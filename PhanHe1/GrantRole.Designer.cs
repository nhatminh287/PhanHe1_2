namespace PhanHe1
{
    partial class GrantRole
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
            this.grantBtn = new System.Windows.Forms.Button();
            this.listRoleCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listPriCbb = new System.Windows.Forms.ComboBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.withAdminOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPrivType = new System.Windows.Forms.ComboBox();
            this.objectLabel = new System.Windows.Forms.Label();
            this.cbbObjectDB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grantBtn.Location = new System.Drawing.Point(237, 279);
            this.grantBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(123, 32);
            this.grantBtn.TabIndex = 44;
            this.grantBtn.Text = "GRANT";
            this.grantBtn.UseVisualStyleBackColor = false;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // listRoleCbb
            // 
            this.listRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRoleCbb.FormattingEnabled = true;
            this.listRoleCbb.Location = new System.Drawing.Point(223, 69);
            this.listRoleCbb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listRoleCbb.Name = "listRoleCbb";
            this.listRoleCbb.Size = new System.Drawing.Size(171, 21);
            this.listRoleCbb.Sorted = true;
            this.listRoleCbb.TabIndex = 42;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseUsernameLb.Location = new System.Drawing.Point(121, 69);
            this.chooseUsernameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(91, 20);
            this.chooseUsernameLb.TabIndex = 41;
            this.chooseUsernameLb.Text = "Chọn role:";
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(87, 21);
            this.manageUserlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(352, 36);
            this.manageUserlabel.TabIndex = 40;
            this.manageUserlabel.Text = "CẤP QUYỀN CHO ROLE";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(27, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Các quyền có thể cấp: ";
            // 
            // listPriCbb
            // 
            this.listPriCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPriCbb.FormattingEnabled = true;
            this.listPriCbb.Location = new System.Drawing.Point(223, 166);
            this.listPriCbb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listPriCbb.Name = "listPriCbb";
            this.listPriCbb.Size = new System.Drawing.Size(171, 21);
            this.listPriCbb.Sorted = true;
            this.listPriCbb.TabIndex = 42;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminLabel.Location = new System.Drawing.Point(432, 166);
            this.adminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(122, 20);
            this.adminLabel.TabIndex = 41;
            this.adminLabel.Text = "Admin Option:";
            // 
            // withAdminOption
            // 
            this.withAdminOption.AutoSize = true;
            this.withAdminOption.Location = new System.Drawing.Point(413, 169);
            this.withAdminOption.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.withAdminOption.Name = "withAdminOption";
            this.withAdminOption.Size = new System.Drawing.Size(15, 14);
            this.withAdminOption.TabIndex = 45;
            this.withAdminOption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(111, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Loại quyền:";
            // 
            // cbbPrivType
            // 
            this.cbbPrivType.FormattingEnabled = true;
            this.cbbPrivType.Location = new System.Drawing.Point(223, 120);
            this.cbbPrivType.Name = "cbbPrivType";
            this.cbbPrivType.Size = new System.Drawing.Size(171, 21);
            this.cbbPrivType.TabIndex = 47;
            this.cbbPrivType.SelectedIndexChanged += new System.EventHandler(this.privTypeChange);
            // 
            // objectLabel
            // 
            this.objectLabel.AutoSize = true;
            this.objectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.objectLabel.Location = new System.Drawing.Point(120, 218);
            this.objectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.objectLabel.Name = "objectLabel";
            this.objectLabel.Size = new System.Drawing.Size(92, 20);
            this.objectLabel.TabIndex = 48;
            this.objectLabel.Text = "Đối tượng:";
            // 
            // cbbObjectDB
            // 
            this.cbbObjectDB.FormattingEnabled = true;
            this.cbbObjectDB.Location = new System.Drawing.Point(223, 217);
            this.cbbObjectDB.Name = "cbbObjectDB";
            this.cbbObjectDB.Size = new System.Drawing.Size(171, 21);
            this.cbbObjectDB.TabIndex = 49;
            this.cbbObjectDB.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbbObjectFormat);
            // 
            // GrantRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 343);
            this.Controls.Add(this.cbbObjectDB);
            this.Controls.Add(this.objectLabel);
            this.Controls.Add(this.cbbPrivType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withAdminOption);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.listPriCbb);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRoleCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.manageUserlabel);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "GrantRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp quyền cho Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox listRoleCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listPriCbb;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.CheckBox withAdminOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPrivType;
        private System.Windows.Forms.Label objectLabel;
        private System.Windows.Forms.ComboBox cbbObjectDB;
    }
}