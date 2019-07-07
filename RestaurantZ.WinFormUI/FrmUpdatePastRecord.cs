using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Entities.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmUpdatePastRecord : Form
    {
        private string ServiceName;
        private int Id;
        private IBreakfastService _breakfastService;
        private ILunchService _lunchService;
        private IDinnerService _dinnerService;
        private INightMaleService _nightMaleService;
        private ICustomerService _customerService;
        private IService updatedService;
        public FrmUpdatePastRecord(string serviceName,int id)
        {
            InitializeComponent();
            ServiceName = serviceName;
            Id = id;
            _breakfastService = InstanceFactory.GetInstance<IBreakfastService>();
            _lunchService = InstanceFactory.GetInstance<ILunchService>();
            _dinnerService = InstanceFactory.GetInstance<IDinnerService>();
            _nightMaleService = InstanceFactory.GetInstance<INightMaleService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void FrmUpdatePastRecord_Load(object sender, EventArgs e)
        {
            if (ServiceName=="breakfast")
            {
                updatedService = _breakfastService.Get(Id);
                lblServiceName.Text = "KAHVALTI GEÇMİŞ KAYIT GÜNCELLE";
            }
            else if (ServiceName == "lunch")
            {
                updatedService = _lunchService.Get(Id);
                lblServiceName.Text = "ÖĞLEN YEMEĞİ GEÇMİŞ KAYIT GÜNCELLE";
            }
            else if (ServiceName == "dinner")
            {
                updatedService = _dinnerService.Get(Id);
                lblServiceName.Text = "AKŞAM YEMEĞİ GEÇMİŞ KAYIT GÜNCELLE";
            }
            else
            {
                updatedService = _nightMaleService.Get(Id);
                lblServiceName.Text = "GECE YEMEĞİ GEÇMİŞ KAYIT GÜNCELLE";
            }
            txtCustomer.Text = _customerService.Get(updatedService.CustomerId).CustomerName;
            nudNumberOfPerson.Value = updatedService.NumberOfPerson;
            txtExtraPrice.Text = updatedService.ExtraPrice.ToString();
            rTxtDescription.Text = updatedService.Description;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatedService.NumberOfPerson = Convert.ToUInt16(nudNumberOfPerson.Value);
            updatedService.ExtraPrice = Convert.ToDecimal(txtExtraPrice.Text);
            updatedService.Description = rTxtDescription.Text;
            if (ServiceName == "breakfast")
            {
                _breakfastService.Update(updatedService as Breakfast);
            }
            else if (ServiceName == "lunch")
            {
                _lunchService.Update(updatedService as Lunch);
            }
            else if (ServiceName == "dinner")
            {
                _dinnerService.Update(updatedService as Dinner);
            }
            else
            {
                _nightMaleService.Update(updatedService as NightMale);
            }
            FrmPastRecords frmPastRecords = (FrmPastRecords)Application.OpenForms["FrmPastRecords"];
            frmPastRecords.FillDgvPastRecord();
            this.Close();
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
