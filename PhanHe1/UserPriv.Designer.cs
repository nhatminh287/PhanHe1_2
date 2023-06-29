namespace PhanHe1
{
    partial class UserPriv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPriv));
            this.listUserCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.privUserlabel = new System.Windows.Forms.Label();
            this.dgvPrivilegesOfUser = new System.Windows.Forms.DataGridView();
            this.dgvObjectPrivOfUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilegesOfUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectPrivOfUser)).BeginInit();
            this.SuspendLayout();
            // 
            // listUserCbb
            // 
            this.listUserCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.listUserCbb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listUserCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUserCbb.FormattingEnabled = true;
            this.listUserCbb.Location = new System.Drawing.Point(249, 78);
            this.listUserCbb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listUserCbb.Name = "listUserCbb";
            this.listUserCbb.Size = new System.Drawing.Size(207, 28);
            this.listUserCbb.Sorted = true;
            this.listUserCbb.TabIndex = 35;
            this.listUserCbb.SelectedIndexChanged += new System.EventHandler(this.listUserCbb_SelectedIndexChanged);
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(80, 81);
            this.chooseUsernameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(150, 20);
            this.chooseUsernameLb.TabIndex = 34;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // privUserlabel
            // 
            this.privUserlabel.AutoSize = true;
            this.privUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.privUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.privUserlabel.Location = new System.Drawing.Point(32, 22);
            this.privUserlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.privUserlabel.Name = "privUserlabel";
            this.privUserlabel.Size = new System.Drawing.Size(492, 36);
            this.privUserlabel.TabIndex = 36;
            this.privUserlabel.Text = "THÔNG TIN QUYỀN NGƯỜI DÙNG";
            this.privUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPrivilegesOfUser
            // 
            this.dgvPrivilegesOfUser.AllowUserToAddRows = false;
            this.dgvPrivilegesOfUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrivilegesOfUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrivilegesOfUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrivilegesOfUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrivilegesOfUser.Location = new System.Drawing.Point(22, 162);
            this.dgvPrivilegesOfUser.Name = "dgvPrivilegesOfUser";
            this.dgvPrivilegesOfUser.Size = new System.Drawing.Size(514, 158);
            this.dgvPrivilegesOfUser.TabIndex = 37;
            // 
            // dgvObjectPrivOfUser
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjectPrivOfUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObjectPrivOfUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjectPrivOfUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObjectPrivOfUser.Location = new System.Drawing.Point(22, 364);
            this.dgvObjectPrivOfUser.Name = "dgvObjectPrivOfUser";
            this.dgvObjectPrivOfUser.Size = new System.Drawing.Size(514, 153);
            this.dgvObjectPrivOfUser.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "1. Quyền hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "2. Quyền thao tác trên đối tượng";
            // 
            // UserPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvObjectPrivOfUser);
            this.Controls.Add(this.dgvPrivilegesOfUser);
            this.Controls.Add(this.privUserlabel);
            this.Controls.Add(this.listUserCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "UserPriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin quyền người dùng";
            this.Load += new System.EventHandler(this.UserPriv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilegesOfUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectPrivOfUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listUserCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label privUserlabel;
        private System.Windows.Forms.DataGridView dgvPrivilegesOfUser;
        private System.Windows.Forms.DataGridView dgvObjectPrivOfUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}