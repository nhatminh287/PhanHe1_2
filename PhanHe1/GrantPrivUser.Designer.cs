namespace PhanHe1
{
    partial class GrantPrivUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrantPrivUser));
            this.manageUserlabel = new System.Windows.Forms.Label();
            this.listUserCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.grantBtn = new System.Windows.Forms.Button();
            this.listPriCbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.withAdminOption = new System.Windows.Forms.CheckBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbPrivType = new System.Windows.Forms.ComboBox();
            this.objectLabel = new System.Windows.Forms.Label();
            this.cbbObjectDB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // manageUserlabel
            // 
            this.manageUserlabel.AutoSize = true;
            this.manageUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageUserlabel.Location = new System.Drawing.Point(43, 17);
            this.manageUserlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageUserlabel.Name = "manageUserlabel";
            this.manageUserlabel.Size = new System.Drawing.Size(464, 36);
            this.manageUserlabel.TabIndex = 2;
            this.manageUserlabel.Text = "CẤP QUYỀN CHO NGƯỜI DÙNG";
            this.manageUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listUserCbb
            // 
            this.listUserCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUserCbb.FormattingEnabled = true;
            this.listUserCbb.Location = new System.Drawing.Point(254, 65);
            this.listUserCbb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listUserCbb.Name = "listUserCbb";
            this.listUserCbb.Size = new System.Drawing.Size(171, 21);
            this.listUserCbb.Sorted = true;
            this.listUserCbb.TabIndex = 37;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chooseUsernameLb.Location = new System.Drawing.Point(95, 64);
            this.chooseUsernameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(150, 20);
            this.chooseUsernameLb.TabIndex = 36;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grantBtn.Location = new System.Drawing.Point(221, 257);
            this.grantBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(123, 32);
            this.grantBtn.TabIndex = 39;
            this.grantBtn.Text = "GRANT";
            this.grantBtn.UseVisualStyleBackColor = false;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // listPriCbb
            // 
            this.listPriCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPriCbb.FormattingEnabled = true;
            this.listPriCbb.Location = new System.Drawing.Point(254, 155);
            this.listPriCbb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listPriCbb.Name = "listPriCbb";
            this.listPriCbb.Size = new System.Drawing.Size(171, 21);
            this.listPriCbb.Sorted = true;
            this.listPriCbb.TabIndex = 37;
            this.listPriCbb.SelectedIndexChanged += new System.EventHandler(this.listPriCbb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(63, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Các quyền có thể cấp:";
            // 
            // withAdminOption
            // 
            this.withAdminOption.AutoSize = true;
            this.withAdminOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withAdminOption.Location = new System.Drawing.Point(444, 160);
            this.withAdminOption.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.withAdminOption.Name = "withAdminOption";
            this.withAdminOption.Size = new System.Drawing.Size(15, 14);
            this.withAdminOption.TabIndex = 40;
            this.withAdminOption.UseVisualStyleBackColor = true;
            this.withAdminOption.CheckedChanged += new System.EventHandler(this.withAdminOption_CheckedChanged);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adminLabel.Location = new System.Drawing.Point(463, 156);
            this.adminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(122, 20);
            this.adminLabel.TabIndex = 36;
            this.adminLabel.Text = "Admin Option:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(144, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Loại quyền:";
            // 
            // cbbPrivType
            // 
            this.cbbPrivType.FormattingEnabled = true;
            this.cbbPrivType.Location = new System.Drawing.Point(254, 112);
            this.cbbPrivType.Name = "cbbPrivType";
            this.cbbPrivType.Size = new System.Drawing.Size(171, 21);
            this.cbbPrivType.TabIndex = 42;
            this.cbbPrivType.SelectedIndexChanged += new System.EventHandler(this.privTypeChange);
            // 
            // objectLabel
            // 
            this.objectLabel.AutoSize = true;
            this.objectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.objectLabel.Location = new System.Drawing.Point(158, 203);
            this.objectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.objectLabel.Name = "objectLabel";
            this.objectLabel.Size = new System.Drawing.Size(87, 20);
            this.objectLabel.TabIndex = 43;
            this.objectLabel.Text = "Đối tượng";
            // 
            // cbbObjectDB
            // 
            this.cbbObjectDB.FormattingEnabled = true;
            this.cbbObjectDB.Location = new System.Drawing.Point(254, 203);
            this.cbbObjectDB.Name = "cbbObjectDB";
            this.cbbObjectDB.Size = new System.Drawing.Size(171, 21);
            this.cbbObjectDB.TabIndex = 44;
            this.cbbObjectDB.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbbObjectFormat);
            // 
            // GrantPrivUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 309);
            this.Controls.Add(this.cbbObjectDB);
            this.Controls.Add(this.objectLabel);
            this.Controls.Add(this.cbbPrivType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.withAdminOption);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.listPriCbb);
            this.Controls.Add(this.listUserCbb);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.manageUserlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "GrantPrivUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp quyền cho người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manageUserlabel;
        private System.Windows.Forms.ComboBox listUserCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox listPriCbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox withAdminOption;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbPrivType;
        private System.Windows.Forms.Label objectLabel;
        private System.Windows.Forms.ComboBox cbbObjectDB;
    }
}