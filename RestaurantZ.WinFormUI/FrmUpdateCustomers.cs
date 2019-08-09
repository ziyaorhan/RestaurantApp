using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmUpdateCustomers : Form
    {
        private ICustomerService _customerService;

        private int updatedCustomerId;

        public List<MessagesAndProperties> allExceptions;

        public FrmUpdateCustomers(int id)
        {
            InitializeComponent();
            this.Icon = new Icon(Global.GetPath("\\Images\\chef.ico"));
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            updatedCustomerId = id;
            allExceptions = new List<MessagesAndProperties>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUpdateCustomers_Load(object sender, EventArgs e)
        {
            var updatedCustomer = _customerService.Get(updatedCustomerId);
            txtCustomerName.Text = updatedCustomer.CustomerName;
            txtCustomerRep.Text = updatedCustomer.CustomerRepresentative;
            txtPhone1.Text = updatedCustomer.Phone1;
            txtPhone1Intercom.Text = updatedCustomer.Phone1Intercom;
            txtPhone2.Text = updatedCustomer.Phone2;
            txtMail.Text = updatedCustomer.Mail;
            txtAddress.Text = updatedCustomer.Address;  
            if (updatedCustomer.BreakfastPrice!=0)
            {
                chkBreakfast.Checked = true;
                txtBreakfast.Enabled = true;
            }
            else
            {
                chkBreakfast.Checked = false;
                txtBreakfast.Enabled = false;
            }
            txtBreakfast.Text = updatedCustomer.BreakfastPrice.ToString();
            if (updatedCustomer.LunchPrice!=0)
            {
                chkLunch.Checked = true;
                txtLunch.Enabled = true;
            }
            else
            {
                chkLunch.Checked = false;
                txtLunch.Enabled = false;
            }
            txtLunch.Text = updatedCustomer.LunchPrice.ToString();
            if (updatedCustomer.DinnerPrice!=0)
            {
                chkDinner.Checked = true;
                txtDinner.Enabled = true;
            }
            else
            {
                chkDinner.Checked = false;
                txtDinner.Enabled = false;
            }
            txtDinner.Text = updatedCustomer.DinnerPrice.ToString();
            if (updatedCustomer.NightMalePrice!=0)
            {
                chkNightMale.Checked = true;
                txtNightMale.Enabled = true;
            }
            else
            {
                chkNightMale.Checked = false;
                txtNightMale.Enabled = false;
            }
            txtNightMale.Text = updatedCustomer.NightMalePrice.ToString();
            txtNotes.Text = updatedCustomer.Notes;
            chkIsActive.Checked = updatedCustomer.IsActive;
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

        private void FillPrices()
        {
            if (txtBreakfast.Text == string.Empty)
            {
                txtBreakfast.Text = "0.00";
            }
            if (txtLunch.Text == string.Empty)
            {
                txtLunch.Text = "0.00";
            }
            if (txtDinner.Text == string.Empty)
            {
                txtDinner.Text = "0.00";
            }
            if (txtNightMale.Text == string.Empty)
            {
                txtNightMale.Text = "0.00";
            }
        }

        private void chkBreakfast_Click(object sender, EventArgs e)
        {
            if (!chkBreakfast.Checked)
            {
                MessageBox.Show("Bu müşteri için kahvaltı hizmetini kaldırıyorsunuz.", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkLunch_Click(object sender, EventArgs e)
        {
            if (!chkLunch.Checked)
            {
                MessageBox.Show("Bu müşteri için öğlen yemeği hizmetini kaldırıyorsunuz.", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkDinner_Click(object sender, EventArgs e)
        {
            if (!chkDinner.Checked)
            {
                MessageBox.Show("Bu müşteri için akşam yemeği hizmetini kaldırıyorsunuz.", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkNightMale_Click(object sender, EventArgs e)
        {
            if (!chkNightMale.Checked)
            {
                MessageBox.Show("Bu müşteri için gece yemeği hizmetini kaldırıyorsunuz.", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkIsActive_Click(object sender, EventArgs e)
        {
            if (!chkIsActive.Checked)
            {
                MessageBox.Show("Müşteriyi pasif yapmanız durumunda, müşteri artık hiç bir hizmet alamayacaktır ve listelerde görünmeyecektir.", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            allExceptions.Clear();
            try
            {
                FillPrices();
                var updatedCustomer = _customerService.Get(updatedCustomerId);
                updatedCustomer.CustomerName = txtCustomerName.Text.Trim();
                updatedCustomer.CustomerRepresentative = txtCustomerRep.Text.Trim();
                updatedCustomer.Phone1 = txtPhone1.Text;
                updatedCustomer.Phone1Intercom = txtPhone1Intercom.Text.Trim();
                updatedCustomer.Phone2 = txtPhone2.Text;
                updatedCustomer.Mail = txtMail.Text.Trim();
                updatedCustomer.Address = txtAddress.Text.Trim();
                updatedCustomer.BreakfastPrice = Convert.ToDecimal(txtBreakfast.Text);
                updatedCustomer.LunchPrice = Convert.ToDecimal(txtLunch.Text);
                updatedCustomer.DinnerPrice = Convert.ToDecimal(txtDinner.Text);
                updatedCustomer.NightMalePrice = Convert.ToDecimal(txtNightMale.Text);
                updatedCustomer.Notes = txtNotes.Text.Trim();
                updatedCustomer.IsActive = chkIsActive.Checked;

                _customerService.Update(updatedCustomer);
                FrmCustomers refreshedFrm = (FrmCustomers)Application.OpenForms["FrmCustomers"];
                refreshedFrm.GetAllCustomer
();
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
                MessageBox.Show("Müşteri güncellenirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
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

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            epMail.Clear();
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
