using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmNewCustomer : Form
    {
        private ICustomerService _customerService;

        public List<MessagesAndProperties> allExceptions;

        public FrmNewCustomer()
        {
            InitializeComponent();
            this.Icon = new Icon(Global.GetPath("\\Images\\chef.ico"));
            try
            {
                _customerService = InstanceFactory.GetInstance<ICustomerService>();
            }
            catch
            {
                MessageBox.Show("Form açılırken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
            }
            allExceptions = new List<MessagesAndProperties>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            allExceptions.Clear();
            try
            {
                FillPrices();
                Customer customer = new Customer()
                {
                    CustomerName = txtCustomerName.Text.Trim(),
                    CustomerRepresentative = txtCustomerRep.Text.Trim(),
                    Phone1 = txtPhone1.Text.Trim(),
                    Phone1Intercom = txtPhone1Intercom.Text.Trim(),
                    Phone2 = txtPhone2.Text.Trim(),
                    Mail = txtMail.Text,
                    Address = txtAddress.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                    BreakfastPrice = Convert.ToDecimal(txtBreakfast.Text),
                    LunchPrice = Convert.ToDecimal(txtLunch.Text),
                    DinnerPrice = Convert.ToDecimal(txtDinner.Text),
                    NightMalePrice = Convert.ToDecimal(txtNightMale.Text),
                    IsActive = chkIsActive.Checked == true ? true : false,
                    IsVisible = true,
                    UserId = Variables.CurrentUser.UserId
                };
                _customerService.Add(customer);
                FrmCustomers refreshedFrm = (FrmCustomers)Application.OpenForms["FrmCustomers"];
                refreshedFrm.GetAllCustomer();
                Cursor.Current = Cursors.Default;
                this.Close();
            }
            catch (CustomExceptionForValidation ex)
            {
                Cursor.Current = Cursors.Default;
                allExceptions = ex.ExceptionDetails;//hataları listeye at.
                RunErrorProviders();
            }
            catch
            {
                MessageBox.Show("Yeni müşteri eklerken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
            }
        }

        private void FillPrices()
        {
            if (txtBreakfast.Text == string.Empty || txtBreakfast.Text == ".")
            {
                txtBreakfast.Text = "0.00";
            }
            if (txtLunch.Text == string.Empty || txtLunch.Text == ".")
            {
                txtLunch.Text = "0.00";
            }
            if (txtDinner.Text == string.Empty || txtDinner.Text == ".")
            {
                txtDinner.Text = "0.00";
            }
            if (txtNightMale.Text == string.Empty || txtNightMale.Text == ".")
            {
                txtNightMale.Text = "0.00";
            }
        }

        private void RunErrorProviders()
        {
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "CustomerName"))
            {
                epCustomerName.SetError(txtCustomerName, ValidationTool.GetExceptionsByProperty(allExceptions, "CustomerName"));
            }
            else
            {
                epCustomerName.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "CustomerRepresentative"))
            {
                epCustomerRep.SetError(txtCustomerRep, ValidationTool.GetExceptionsByProperty(allExceptions, "CustomerRepresentative"));
            }
            else
            {
                epCustomerRep.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "Phone1"))
            {
                epPhone1.SetError(txtPhone1, ValidationTool.GetExceptionsByProperty(allExceptions, "Phone1"));
            }
            else
            {
                epPhone1.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "Mail"))
            {
                epMail.SetError(txtMail, ValidationTool.GetExceptionsByProperty(allExceptions, "Mail"));
            }
            else
            {
                epMail.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "BreakfastPrice"))
            {
                epBreakfast.SetError(txtBreakfast, ValidationTool.GetExceptionsByProperty(allExceptions, "BreakfastPrice"));
            }
            else
            {
                epBreakfast.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "LunchPrice"))
            {
                epLunch.SetError(txtLunch, ValidationTool.GetExceptionsByProperty(allExceptions, "LunchPrice"));
            }
            else
            {
                epLunch.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "DinnerPrice"))
            {
                epDinner.SetError(txtDinner, ValidationTool.GetExceptionsByProperty(allExceptions, "DinnerPrice"));
            }
            else
            {
                epDinner.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "NightMalePrice"))
            {
                epNightMale.SetError(txtNightMale, ValidationTool.GetExceptionsByProperty(allExceptions, "NightMalePrice"));
            }
            else
            {
                epNightMale.Clear();
            }
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            txtBreakfast.Enabled = false;
            txtLunch.Enabled = false;
            txtDinner.Enabled = false;
            txtNightMale.Enabled = false;
        }

        private void chkBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBreakfast.Checked == false)
            {
                txtBreakfast.Enabled = false;
                txtBreakfast.Text = "0.00";
            }
            else
            {
                txtBreakfast.Enabled = true;
                txtBreakfast.Text = "";
                txtBreakfast.Focus();
            }
        }

        private void chkLunch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLunch.Checked == false)
            {
                txtLunch.Enabled = false;
                txtLunch.Text = "0.00";
            }
            else
            {
                txtLunch.Enabled = true;
                txtLunch.Text = "";
                txtLunch.Focus();
            }
        }

        private void chkDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDinner.Checked == false)
            {
                txtDinner.Enabled = false;
                txtDinner.Text = "0.00";
            }
            else
            {
                txtDinner.Enabled = true;
                txtDinner.Text = "";
                txtDinner.Focus();
            }
        }

        private void chkNightMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNightMale.Checked == false)
            {
                txtNightMale.Enabled = false;
                txtNightMale.Text = "0.00";
            }
            else
            {
                txtNightMale.Enabled = true;
                txtNightMale.Text = "";
                txtNightMale.Focus();
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            epCustomerName.Clear();
        }

        private void txtCustomerRep_TextChanged(object sender, EventArgs e)
        {
            epCustomerRep.Clear();
        }

        private void txtPhone1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            epPhone1.Clear();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            epMail.Clear();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                pnlTop.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
    }
}
