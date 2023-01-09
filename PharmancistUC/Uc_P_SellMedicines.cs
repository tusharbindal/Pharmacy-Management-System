using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmancistUC
{
    public partial class Uc_P_SellMedicines : UserControl
    {
        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;
        int valueAmount;
        String valueId;
        protected Int64 noofunits;
        public Uc_P_SellMedicines()
        {
            InitializeComponent();
        }

        private void Uc_P_ShellMedicines_Load(object sender, EventArgs e)
        {
            listBoxMedic.Items.Clear();
            DataSet ds = Connection.GetData("Select mname from mst_medic where eDate >= NOW() and quantity > '0' ");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedic.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }



        private void btnSync_Click(object sender, EventArgs e)
        {
            Uc_P_ShellMedicines_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedic.Items.Clear();
            DataSet ds = Connection.GetData("Select mname from mst_medic where mname like '" + txtSearch.Text + "%' and eDate >= NOW() and quantity > '0'");
            for (int i=0; i<ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedic.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedic_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoofUnits.Clear();
            String name = listBoxMedic.GetItemText(listBoxMedic.SelectedItem);
            txtMedicinName.Text = name;
            DataSet ds = Connection.GetData("Select mid, eDate, perunit from mst_medic where mname ='" + name + "' ");
            txtMedicineId.Text = ds.Tables[0].Rows[0][0].ToString();
            dtpExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPriceperUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoofUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtNoofUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPriceperUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoofUnits.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalAmount.ToString();

            }
            else
            {
                txtNoofUnits.Clear();
            }
        }


       

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "")
            {
                DataSet ds = Connection.GetData("Select quantity from mst_medic where mid = '" + txtMedicineId.Text + "' ");
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoofUnits.Text);
                if (newQuantity >= 0)
                {
                    n = DGVView.Rows.Add();
                    DGVView.Rows[n].Cells[0].Value = txtMedicineId.Text;
                    DGVView.Rows[n].Cells[1].Value = txtMedicinName.Text;
                    DGVView.Rows[n].Cells[2].Value = dtpExpireDate.Text;
                    DGVView.Rows[n].Cells[3].Value = txtPriceperUnit.Text;
                    DGVView.Rows[n].Cells[4].Value = txtNoofUnits.Text;
                    DGVView.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    TotalLabel.Text = "Rs. " + totalAmount.ToString();
                    String error = Connection.SetData("Update mst_medic set quantity = '" + newQuantity + "' where mid = '" + txtMedicineId + "' ");
                    if (error == "")
                    {
                        MessageBox.Show("Medicine Added");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("Medicine is Out Of Stock. \n Only " + quantity + " Left ", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                Uc_P_ShellMedicines_Load(this, null);

            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
        //    DGVPrinter print = new DGVPrinter();
        //    print.Title = "Medicine Bill";
        //    print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
        //    print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
        //    print.PageNumbers = true;
        //    print.PageNumberInHeader = false;
        //    print.PorportionalColums = true;
        //    print.HeaderCellAligment = StringAlignment.Near;
        //    print.Footer = "Total Payable Amount :" + TotalLabel.Text;
        //    print.FooterSpacing = 15;
        //    print.PrintDataGridView(DGVView);
        //    totalAmount = 0;
        //    TotalLabel.Text = "Rs. 00";
        //    DGVView.DataSource = 0;

        }

        private void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicinName.Clear();
            dtpExpireDate.ResetText();
            txtPriceperUnit.Clear();
            txtNoofUnits.Clear();
        }

        private void DGVView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(DGVView.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = DGVView.Rows[e.RowIndex].Cells[0].Value.ToString();
                noofunits = Int64.Parse(DGVView.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    DGVView.Rows.RemoveAt(this.DGVView.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    DataSet ds = Connection.GetData("Select quantity from mst_medic where mid = '" + valueId + "' ");
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noofunits;
                    String error = Connection.SetData("Update mst_medic set quantity = '" + newQuantity + "' where mid = '" + valueId + "' ");
                    if (error == "")
                    {
                        MessageBox.Show("Medicine Removed from Cart.");
                        totalAmount = totalAmount - valueAmount;
                        TotalLabel.Text = "Rs. " + totalAmount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    Uc_P_ShellMedicines_Load(this, null);

                }
            }
        }
    }
}
