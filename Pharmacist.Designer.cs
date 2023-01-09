
namespace Pharmacy_Management_System
{
    partial class Pharmacist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModifyMedi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnsellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicValidity = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedic = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uc_P_SellMedicines1 = new Pharmacy_Management_System.PharmancistUC.Uc_P_SellMedicines();
            this.uc_P_ValidityCheck1 = new Pharmacy_Management_System.PharmancistUC.Uc_P_ValidityCheck();
            this.uc_P_ModifyMedicine1 = new Pharmacy_Management_System.PharmancistUC.Uc_P_ModifyMedicine();
            this.uc_p_viewMedic1 = new Pharmacy_Management_System.PharmancistUC.Uc_p_viewMedic();
            this.uC_P_AddMedicine1 = new Pharmacy_Management_System.PharmancistUC.UC_P_AddMedicine();
            this.uc_P_Dashbord1 = new Pharmacy_Management_System.PharmancistUC.Uc_P_Dashbord();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_P_SellMedicines1);
            this.panel2.Controls.Add(this.uc_P_ValidityCheck1);
            this.panel2.Controls.Add(this.uc_P_ModifyMedicine1);
            this.panel2.Controls.Add(this.uc_p_viewMedic1);
            this.panel2.Controls.Add(this.uC_P_AddMedicine1);
            this.panel2.Controls.Add(this.uc_P_Dashbord1);
            this.panel2.Location = new System.Drawing.Point(435, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1486, 1045);
            this.panel2.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnModifyMedi);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.btnsellMedicine);
            this.panel1.Controls.Add(this.btnMedicValidity);
            this.panel1.Controls.Add(this.btnViewMedic);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 1050);
            this.panel1.TabIndex = 3;
            // 
            // btnModifyMedi
            // 
            this.btnModifyMedi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMedi.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModifyMedi.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMedi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMedi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMedi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifyMedi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifyMedi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnModifyMedi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedi.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedi.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedi.Image")));
            this.btnModifyMedi.ImageSize = new System.Drawing.Size(25, 25);
            this.btnModifyMedi.Location = new System.Drawing.Point(88, 588);
            this.btnModifyMedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifyMedi.Name = "btnModifyMedi";
            this.btnModifyMedi.Size = new System.Drawing.Size(346, 69);
            this.btnModifyMedi.TabIndex = 9;
            this.btnModifyMedi.Text = "Modify Medicine";
            this.btnModifyMedi.Click += new System.EventHandler(this.btnModifyMedi_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(74, 820);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(346, 69);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Log Out";
            this.guna2Button1.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnsellMedicine
            // 
            this.btnsellMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnsellMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnsellMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnsellMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsellMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsellMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsellMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsellMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnsellMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnsellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnsellMedicine.Image")));
            this.btnsellMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnsellMedicine.Location = new System.Drawing.Point(90, 741);
            this.btnsellMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsellMedicine.Name = "btnsellMedicine";
            this.btnsellMedicine.Size = new System.Drawing.Size(346, 69);
            this.btnsellMedicine.TabIndex = 6;
            this.btnsellMedicine.Text = "Self Medicine";
            this.btnsellMedicine.Click += new System.EventHandler(this.btnsellMedicine_Click);
            // 
            // btnMedicValidity
            // 
            this.btnMedicValidity.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedicValidity.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMedicValidity.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMedicValidity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicValidity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicValidity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicValidity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicValidity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnMedicValidity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicValidity.ForeColor = System.Drawing.Color.White;
            this.btnMedicValidity.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicValidity.Image")));
            this.btnMedicValidity.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMedicValidity.Location = new System.Drawing.Point(90, 667);
            this.btnMedicValidity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMedicValidity.Name = "btnMedicValidity";
            this.btnMedicValidity.Size = new System.Drawing.Size(346, 69);
            this.btnMedicValidity.TabIndex = 5;
            this.btnMedicValidity.Text = "Medicine Validity Check";
            this.btnMedicValidity.Click += new System.EventHandler(this.btnMedicValidity_Click);
            // 
            // btnViewMedic
            // 
            this.btnViewMedic.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedic.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMedic.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewMedic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewMedic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewMedic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedic.ForeColor = System.Drawing.Color.White;
            this.btnViewMedic.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedic.Image")));
            this.btnViewMedic.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewMedic.Location = new System.Drawing.Point(72, 512);
            this.btnViewMedic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewMedic.Name = "btnViewMedic";
            this.btnViewMedic.Size = new System.Drawing.Size(363, 69);
            this.btnViewMedic.TabIndex = 4;
            this.btnViewMedic.Text = "View Medicine";
            this.btnViewMedic.Click += new System.EventHandler(this.btnViewMedic_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddMedicine.Location = new System.Drawing.Point(72, 434);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(363, 69);
            this.btnAddMedicine.TabIndex = 3;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.Location = new System.Drawing.Point(72, 352);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(363, 69);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // uc_P_SellMedicines1
            // 
            this.uc_P_SellMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uc_P_SellMedicines1.Name = "uc_P_SellMedicines1";
            this.uc_P_SellMedicines1.Size = new System.Drawing.Size(1579, 975);
            this.uc_P_SellMedicines1.TabIndex = 5;
            // 
            // uc_P_ValidityCheck1
            // 
            this.uc_P_ValidityCheck1.Location = new System.Drawing.Point(0, 4);
            this.uc_P_ValidityCheck1.Name = "uc_P_ValidityCheck1";
            this.uc_P_ValidityCheck1.Size = new System.Drawing.Size(1579, 975);
            this.uc_P_ValidityCheck1.TabIndex = 4;
            // 
            // uc_P_ModifyMedicine1
            // 
            this.uc_P_ModifyMedicine1.Location = new System.Drawing.Point(3, 3);
            this.uc_P_ModifyMedicine1.Name = "uc_P_ModifyMedicine1";
            this.uc_P_ModifyMedicine1.Size = new System.Drawing.Size(1579, 975);
            this.uc_P_ModifyMedicine1.TabIndex = 3;
            // 
            // uc_p_viewMedic1
            // 
            this.uc_p_viewMedic1.Location = new System.Drawing.Point(3, 0);
            this.uc_p_viewMedic1.Name = "uc_p_viewMedic1";
            this.uc_p_viewMedic1.Size = new System.Drawing.Size(1579, 975);
            this.uc_p_viewMedic1.TabIndex = 2;
            this.uc_p_viewMedic1.Load += new System.EventHandler(this.uc_p_viewMedic1_Load);
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1579, 975);
            this.uC_P_AddMedicine1.TabIndex = 1;
            this.uC_P_AddMedicine1.Load += new System.EventHandler(this.uC_P_AddMedicine1_Load);
            // 
            // uc_P_Dashbord1
            // 
            this.uc_P_Dashbord1.Location = new System.Drawing.Point(3, 3);
            this.uc_P_Dashbord1.Name = "uc_P_Dashbord1";
            this.uc_P_Dashbord1.Size = new System.Drawing.Size(1579, 1047);
            this.uc_P_Dashbord1.TabIndex = 0;
            this.uc_P_Dashbord1.Load += new System.EventHandler(this.uc_P_Dashbord1_Load);
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.Text = "Pharmacy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmancistUC.Uc_P_Dashbord uc_P_Dashbord1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedi;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnsellMedicine;
        private Guna.UI2.WinForms.Guna2Button btnMedicValidity;
        private Guna.UI2.WinForms.Guna2Button btnViewMedic;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PharmancistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private PharmancistUC.Uc_p_viewMedic uc_p_viewMedic1;
        private PharmancistUC.Uc_P_ModifyMedicine uc_P_ModifyMedicine1;
        private PharmancistUC.Uc_P_ValidityCheck uc_P_ValidityCheck1;
        private PharmancistUC.Uc_P_SellMedicines uc_P_SellMedicines1;
    }
}