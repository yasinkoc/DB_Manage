namespace DB_Manage
{
    partial class frmDBEdit
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
            this.TxtAddTable = new DevExpress.XtraEditors.TextEdit();
            this.TxtDeleteTable = new DevExpress.XtraEditors.TextEdit();
            this.BtnChooseDB = new DevExpress.XtraEditors.SimpleButton();
            this.LBTableList = new DevExpress.XtraEditors.ListBoxControl();
            this.Lbl_TableList = new DevExpress.XtraEditors.LabelControl();
            this.BtnAddTable = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDeleteTable = new DevExpress.XtraEditors.SimpleButton();
            this.Lbl_ChoosenDBName = new DevExpress.XtraEditors.LabelControl();
            this.LblChoosenDBName = new DevExpress.XtraEditors.LabelControl();
            this.BtnExitDB = new DevExpress.XtraEditors.SimpleButton();
            this.Lbl_FormName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDeleteTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBTableList)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAddTable
            // 
            this.TxtAddTable.Location = new System.Drawing.Point(439, 85);
            this.TxtAddTable.Name = "TxtAddTable";
            this.TxtAddTable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtAddTable.Properties.Appearance.Options.UseFont = true;
            this.TxtAddTable.Size = new System.Drawing.Size(135, 28);
            this.TxtAddTable.TabIndex = 4;
            // 
            // TxtDeleteTable
            // 
            this.TxtDeleteTable.Location = new System.Drawing.Point(439, 175);
            this.TxtDeleteTable.Name = "TxtDeleteTable";
            this.TxtDeleteTable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtDeleteTable.Properties.Appearance.Options.UseFont = true;
            this.TxtDeleteTable.Size = new System.Drawing.Size(135, 28);
            this.TxtDeleteTable.TabIndex = 5;
            // 
            // BtnChooseDB
            // 
            this.BtnChooseDB.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnChooseDB.Appearance.Options.UseFont = true;
            this.BtnChooseDB.Location = new System.Drawing.Point(26, 88);
            this.BtnChooseDB.Name = "BtnChooseDB";
            this.BtnChooseDB.Size = new System.Drawing.Size(120, 30);
            this.BtnChooseDB.TabIndex = 8;
            this.BtnChooseDB.Text = "Choose DB";
            // 
            // LBTableList
            // 
            this.LBTableList.Location = new System.Drawing.Point(292, 39);
            this.LBTableList.Name = "LBTableList";
            this.LBTableList.Size = new System.Drawing.Size(127, 166);
            this.LBTableList.TabIndex = 10;
            // 
            // Lbl_TableList
            // 
            this.Lbl_TableList.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Lbl_TableList.Appearance.Options.UseFont = true;
            this.Lbl_TableList.Location = new System.Drawing.Point(319, 12);
            this.Lbl_TableList.Name = "Lbl_TableList";
            this.Lbl_TableList.Size = new System.Drawing.Size(72, 21);
            this.Lbl_TableList.TabIndex = 11;
            this.Lbl_TableList.Text = "Table List";
            // 
            // BtnAddTable
            // 
            this.BtnAddTable.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnAddTable.Appearance.Options.UseFont = true;
            this.BtnAddTable.Location = new System.Drawing.Point(439, 39);
            this.BtnAddTable.Name = "BtnAddTable";
            this.BtnAddTable.Size = new System.Drawing.Size(135, 30);
            this.BtnAddTable.TabIndex = 12;
            this.BtnAddTable.Text = "Add Table";
            // 
            // BtnDeleteTable
            // 
            this.BtnDeleteTable.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnDeleteTable.Appearance.Options.UseFont = true;
            this.BtnDeleteTable.Location = new System.Drawing.Point(439, 129);
            this.BtnDeleteTable.Name = "BtnDeleteTable";
            this.BtnDeleteTable.Size = new System.Drawing.Size(135, 30);
            this.BtnDeleteTable.TabIndex = 13;
            this.BtnDeleteTable.Text = "Delete Table";
            // 
            // Lbl_ChoosenDBName
            // 
            this.Lbl_ChoosenDBName.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Lbl_ChoosenDBName.Appearance.Options.UseFont = true;
            this.Lbl_ChoosenDBName.Location = new System.Drawing.Point(26, 139);
            this.Lbl_ChoosenDBName.Name = "Lbl_ChoosenDBName";
            this.Lbl_ChoosenDBName.Size = new System.Drawing.Size(138, 21);
            this.Lbl_ChoosenDBName.TabIndex = 14;
            this.Lbl_ChoosenDBName.Text = "Choosen DB Name";
            // 
            // LblChoosenDBName
            // 
            this.LblChoosenDBName.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.LblChoosenDBName.Appearance.Options.UseFont = true;
            this.LblChoosenDBName.Location = new System.Drawing.Point(26, 166);
            this.LblChoosenDBName.Name = "LblChoosenDBName";
            this.LblChoosenDBName.Size = new System.Drawing.Size(6, 21);
            this.LblChoosenDBName.TabIndex = 15;
            this.LblChoosenDBName.Text = "-";
            // 
            // BtnExitDB
            // 
            this.BtnExitDB.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnExitDB.Appearance.Options.UseFont = true;
            this.BtnExitDB.Location = new System.Drawing.Point(152, 88);
            this.BtnExitDB.Name = "BtnExitDB";
            this.BtnExitDB.Size = new System.Drawing.Size(120, 30);
            this.BtnExitDB.TabIndex = 16;
            this.BtnExitDB.Text = "Exit DB";
            // 
            // Lbl_FormName
            // 
            this.Lbl_FormName.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.Lbl_FormName.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Lbl_FormName.Appearance.Options.UseFont = true;
            this.Lbl_FormName.Appearance.Options.UseForeColor = true;
            this.Lbl_FormName.Location = new System.Drawing.Point(78, 28);
            this.Lbl_FormName.Name = "Lbl_FormName";
            this.Lbl_FormName.Size = new System.Drawing.Size(140, 29);
            this.Lbl_FormName.TabIndex = 17;
            this.Lbl_FormName.Text = "DB Edit Form";
            // 
            // frmDBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 216);
            this.Controls.Add(this.Lbl_FormName);
            this.Controls.Add(this.BtnExitDB);
            this.Controls.Add(this.LblChoosenDBName);
            this.Controls.Add(this.Lbl_ChoosenDBName);
            this.Controls.Add(this.BtnDeleteTable);
            this.Controls.Add(this.BtnAddTable);
            this.Controls.Add(this.Lbl_TableList);
            this.Controls.Add(this.LBTableList);
            this.Controls.Add(this.BtnChooseDB);
            this.Controls.Add(this.TxtDeleteTable);
            this.Controls.Add(this.TxtAddTable);
            this.Name = "frmDBEdit";
            this.Text = "DB Edit";
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDeleteTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBTableList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TxtAddTable;
        private DevExpress.XtraEditors.TextEdit TxtDeleteTable;
        private DevExpress.XtraEditors.SimpleButton BtnChooseDB;
        private DevExpress.XtraEditors.ListBoxControl LBTableList;
        private DevExpress.XtraEditors.LabelControl Lbl_TableList;
        private DevExpress.XtraEditors.SimpleButton BtnAddTable;
        private DevExpress.XtraEditors.SimpleButton BtnDeleteTable;
        private DevExpress.XtraEditors.LabelControl Lbl_ChoosenDBName;
        private DevExpress.XtraEditors.LabelControl LblChoosenDBName;
        private DevExpress.XtraEditors.SimpleButton BtnExitDB;
        private DevExpress.XtraEditors.LabelControl Lbl_FormName;
    }
}

