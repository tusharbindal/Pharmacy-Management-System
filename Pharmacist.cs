using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();

        }
       
        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uc_P_Dashbord1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uc_p_viewMedic1.Visible = false;
            uc_P_ModifyMedicine1.Visible = false;
            uc_P_ValidityCheck1.Visible = false;
            uc_P_SellMedicines1.Visible = false;
            btnDashboard.PerformClick();
        }
        
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            uc_P_Dashbord1.Visible = true;
            uc_P_Dashbord1.BringToFront();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void uc_P_Dashbord1_Load(object sender, EventArgs e)
        {

        }

        private void uC_P_AddMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void uc_p_viewMedic1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewMedic_Click(object sender, EventArgs e)
        {
            uc_p_viewMedic1.Visible = true;
            uc_p_viewMedic1.BringToFront();
        }

        private void btnModifyMedi_Click(object sender, EventArgs e)
        {
            uc_P_ModifyMedicine1.Visible = true;
            uc_P_ModifyMedicine1.BringToFront();
        }

        private void btnMedicValidity_Click(object sender, EventArgs e)
        {
            uc_P_ValidityCheck1.Visible = true;
            uc_P_ValidityCheck1.BringToFront();
        }

        private void btnsellMedicine_Click(object sender, EventArgs e)
        {
            uc_P_SellMedicines1.Visible = true;
            uc_P_SellMedicines1.BringToFront();
        }
    }
}
