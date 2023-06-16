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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDeleteTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBTableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAddTable
            // 
            this.TxtAddTable.Location = new System.Drawing.Point(163, 106);
            this.TxtAddTable.Name = "TxtAddTable";
            this.TxtAddTable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtAddTable.Properties.Appearance.Options.UseFont = true;
            this.TxtAddTable.Size = new System.Drawing.Size(135, 28);
            this.TxtAddTable.TabIndex = 4;
            // 
            // TxtDeleteTable
            // 
            this.TxtDeleteTable.Location = new System.Drawing.Point(163, 196);
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
            this.BtnChooseDB.Location = new System.Drawing.Point(238, 28);
            this.BtnChooseDB.Name = "BtnChooseDB";
            this.BtnChooseDB.Size = new System.Drawing.Size(39, 30);
            this.BtnChooseDB.TabIndex = 8;
            this.BtnChooseDB.Text = "...";
            this.BtnChooseDB.Click += new System.EventHandler(this.BtnChooseDB_Click);
            // 
            // LBTableList
            // 
            this.LBTableList.Location = new System.Drawing.Point(16, 60);
            this.LBTableList.Name = "LBTableList";
            this.LBTableList.Size = new System.Drawing.Size(127, 166);
            this.LBTableList.TabIndex = 10;
            // 
            // Lbl_TableList
            // 
            this.Lbl_TableList.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Lbl_TableList.Appearance.Options.UseFont = true;
            this.Lbl_TableList.Location = new System.Drawing.Point(43, 33);
            this.Lbl_TableList.Name = "Lbl_TableList";
            this.Lbl_TableList.Size = new System.Drawing.Size(72, 21);
            this.Lbl_TableList.TabIndex = 11;
            this.Lbl_TableList.Text = "Table List";
            // 
            // BtnAddTable
            // 
            this.BtnAddTable.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnAddTable.Appearance.Options.UseFont = true;
            this.BtnAddTable.Location = new System.Drawing.Point(163, 60);
            this.BtnAddTable.Name = "BtnAddTable";
            this.BtnAddTable.Size = new System.Drawing.Size(135, 30);
            this.BtnAddTable.TabIndex = 12;
            this.BtnAddTable.Text = "Add Table";
            // 
            // BtnDeleteTable
            // 
            this.BtnDeleteTable.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnDeleteTable.Appearance.Options.UseFont = true;
            this.BtnDeleteTable.Location = new System.Drawing.Point(163, 150);
            this.BtnDeleteTable.Name = "BtnDeleteTable";
            this.BtnDeleteTable.Size = new System.Drawing.Size(135, 30);
            this.BtnDeleteTable.TabIndex = 13;
            this.BtnDeleteTable.Text = "Delete Table";
            // 
            // Lbl_ChoosenDBName
            // 
            this.Lbl_ChoosenDBName.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.Lbl_ChoosenDBName.Appearance.Options.UseFont = true;
            this.Lbl_ChoosenDBName.Location = new System.Drawing.Point(14, 23);
            this.Lbl_ChoosenDBName.Name = "Lbl_ChoosenDBName";
            this.Lbl_ChoosenDBName.Size = new System.Drawing.Size(138, 21);
            this.Lbl_ChoosenDBName.TabIndex = 14;
            this.Lbl_ChoosenDBName.Text = "Choosen DB Name";
            // 
            // LblChoosenDBName
            // 
            this.LblChoosenDBName.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.LblChoosenDBName.Appearance.Options.UseFont = true;
            this.LblChoosenDBName.Location = new System.Drawing.Point(14, 50);
            this.LblChoosenDBName.Name = "LblChoosenDBName";
            this.LblChoosenDBName.Size = new System.Drawing.Size(6, 21);
            this.LblChoosenDBName.TabIndex = 15;
            this.LblChoosenDBName.Text = "-";
            // 
            // BtnExitDB
            // 
            this.BtnExitDB.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnExitDB.Appearance.Options.UseFont = true;
            this.BtnExitDB.Location = new System.Drawing.Point(283, 28);
            this.BtnExitDB.Name = "BtnExitDB";
            this.BtnExitDB.Size = new System.Drawing.Size(74, 30);
            this.BtnExitDB.TabIndex = 16;
            this.BtnExitDB.Text = "Exit DB";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Lbl_TableList);
            this.groupControl1.Controls.Add(this.TxtAddTable);
            this.groupControl1.Controls.Add(this.TxtDeleteTable);
            this.groupControl1.Controls.Add(this.LBTableList);
            this.groupControl1.Controls.Add(this.BtnAddTable);
            this.groupControl1.Controls.Add(this.BtnDeleteTable);
            this.groupControl1.Location = new System.Drawing.Point(384, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(318, 237);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.textEdit1);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.BtnChooseDB);
            this.groupControl2.Controls.Add(this.BtnExitDB);
            this.groupControl2.Location = new System.Drawing.Point(12, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(366, 237);
            this.groupControl2.TabIndex = 19;
            this.groupControl2.Text = "groupControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 21);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "DB Path";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(97, 30);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(135, 28);
            this.textEdit1.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 21);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Situation";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 21);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "-";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.Lbl_ChoosenDBName);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.LblChoosenDBName);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(11, 67);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(343, 159);
            this.groupControl3.TabIndex = 20;
            this.groupControl3.Text = "groupControl3";
            // 
            // frmDBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 260);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDBEdit";
            this.Text = "DB Edit";
            ((System.ComponentModel.ISupportInitialize)(this.TxtAddTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDeleteTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBTableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

