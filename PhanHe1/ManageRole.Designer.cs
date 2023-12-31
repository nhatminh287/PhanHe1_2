﻿namespace PhanHe1
{
    partial class ManageRole
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
            this.manageRolelabel = new System.Windows.Forms.Label();
            this.updateRoleBtn = new System.Windows.Forms.Button();
            this.deleteRoleBtn = new System.Windows.Forms.Button();
            this.createRoleBtn = new System.Windows.Forms.Button();
            this.revokePrivRoleBtn = new System.Windows.Forms.Button();
            this.grantPrivRoleBtn = new System.Windows.Forms.Button();
            this.roleUserBtn = new System.Windows.Forms.Button();
            this.roleInfoBtn = new System.Windows.Forms.Button();
            this.listRoleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageRolelabel
            // 
            this.manageRolelabel.AutoSize = true;
            this.manageRolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageRolelabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageRolelabel.Location = new System.Drawing.Point(229, 22);
            this.manageRolelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageRolelabel.Name = "manageRolelabel";
            this.manageRolelabel.Size = new System.Drawing.Size(236, 36);
            this.manageRolelabel.TabIndex = 2;
            this.manageRolelabel.Text = "QUẢN LÝ ROLE";
            this.manageRolelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateRoleBtn
            // 
            this.updateRoleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updateRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateRoleBtn.Location = new System.Drawing.Point(458, 341);
            this.updateRoleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateRoleBtn.Name = "updateRoleBtn";
            this.updateRoleBtn.Size = new System.Drawing.Size(175, 98);
            this.updateRoleBtn.TabIndex = 19;
            this.updateRoleBtn.Text = "Sửa role";
            this.updateRoleBtn.UseVisualStyleBackColor = false;
            this.updateRoleBtn.Click += new System.EventHandler(this.updateRoleBtn_Click);
            // 
            // deleteRoleBtn
            // 
            this.deleteRoleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteRoleBtn.Location = new System.Drawing.Point(262, 341);
            this.deleteRoleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteRoleBtn.Name = "deleteRoleBtn";
            this.deleteRoleBtn.Size = new System.Drawing.Size(181, 98);
            this.deleteRoleBtn.TabIndex = 18;
            this.deleteRoleBtn.Text = "Xóa role";
            this.deleteRoleBtn.UseVisualStyleBackColor = false;
            this.deleteRoleBtn.Click += new System.EventHandler(this.deleteRoleBtn_Click);
            // 
            // createRoleBtn
            // 
            this.createRoleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.createRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.createRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createRoleBtn.Location = new System.Drawing.Point(65, 341);
            this.createRoleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createRoleBtn.Name = "createRoleBtn";
            this.createRoleBtn.Size = new System.Drawing.Size(175, 98);
            this.createRoleBtn.TabIndex = 17;
            this.createRoleBtn.Text = "Tạo role";
            this.createRoleBtn.UseVisualStyleBackColor = false;
            this.createRoleBtn.Click += new System.EventHandler(this.createRoleBtn_Click);
            // 
            // revokePrivRoleBtn
            // 
            this.revokePrivRoleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.revokePrivRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.revokePrivRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.revokePrivRoleBtn.Location = new System.Drawing.Point(458, 213);
            this.revokePrivRoleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.revokePrivRoleBtn.Name = "revokePrivRoleBtn";
            this.revokePrivRoleBtn.Size = new System.Drawing.Size(175, 98);
            this.revokePrivRoleBtn.TabIndex = 15;
            this.revokePrivRoleBtn.Text = "Thu hồi quyền của role";
            this.revokePrivRoleBtn.UseVisualStyleBackColor = false;
            this.revokePrivRoleBtn.Click += new System.EventHandler(this.revokePrivRoleBtn_Click);
            // 
            // grantPrivRoleBtn
            // 
            this.grantPrivRoleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.grantPrivRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grantPrivRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grantPrivRoleBtn.Location = new System.Drawing.Point(65, 213);
            this.grantPrivRoleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grantPrivRoleBtn.Name = "grantPrivRoleBtn";
            this.grantPrivRoleBtn.Size = new System.Drawing.Size(175, 98);
            this.grantPrivRoleBtn.TabIndex = 14;
            this.grantPrivRoleBtn.Text = "Cấp quyền cho role";
            this.grantPrivRoleBtn.UseVisualStyleBackColor = false;
            this.grantPrivRoleBtn.Click += new System.EventHandler(this.grantPrivRoleBtn_Click);
            // 
            // roleUserBtn
            // 
            this.roleUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.roleUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.roleUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roleUserBtn.Location = new System.Drawing.Point(458, 87);
            this.roleUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleUserBtn.Name = "roleUserBtn";
            this.roleUserBtn.Size = new System.Drawing.Size(175, 98);
            this.roleUserBtn.TabIndex = 13;
            this.roleUserBtn.Text = "Xem thông tin role của người dùng";
            this.roleUserBtn.UseVisualStyleBackColor = false;
            this.roleUserBtn.Click += new System.EventHandler(this.roleUserBtn_Click);
            // 
            // roleInfoBtn
            // 
            this.roleInfoBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.roleInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.roleInfoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roleInfoBtn.Location = new System.Drawing.Point(262, 87);
            this.roleInfoBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleInfoBtn.Name = "roleInfoBtn";
            this.roleInfoBtn.Size = new System.Drawing.Size(175, 98);
            this.roleInfoBtn.TabIndex = 12;
            this.roleInfoBtn.Text = "Xem thông tin quyền của role";
            this.roleInfoBtn.UseVisualStyleBackColor = false;
            this.roleInfoBtn.Click += new System.EventHandler(this.roleInfoBtn_Click);
            // 
            // listRoleBtn
            // 
            this.listRoleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.listRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listRoleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listRoleBtn.Location = new System.Drawing.Point(65, 87);
            this.listRoleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listRoleBtn.Name = "listRoleBtn";
            this.listRoleBtn.Size = new System.Drawing.Size(175, 98);
            this.listRoleBtn.TabIndex = 11;
            this.listRoleBtn.Text = "Xem danh sách role";
            this.listRoleBtn.UseVisualStyleBackColor = false;
            this.listRoleBtn.Click += new System.EventHandler(this.listRoleBtn_Click);
            // 
            // ManageRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 481);
            this.Controls.Add(this.updateRoleBtn);
            this.Controls.Add(this.deleteRoleBtn);
            this.Controls.Add(this.createRoleBtn);
            this.Controls.Add(this.revokePrivRoleBtn);
            this.Controls.Add(this.grantPrivRoleBtn);
            this.Controls.Add(this.roleUserBtn);
            this.Controls.Add(this.roleInfoBtn);
            this.Controls.Add(this.listRoleBtn);
            this.Controls.Add(this.manageRolelabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manageRolelabel;
        private System.Windows.Forms.Button updateRoleBtn;
        private System.Windows.Forms.Button deleteRoleBtn;
        private System.Windows.Forms.Button createRoleBtn;
        private System.Windows.Forms.Button revokePrivRoleBtn;
        private System.Windows.Forms.Button grantPrivRoleBtn;
        private System.Windows.Forms.Button roleUserBtn;
        private System.Windows.Forms.Button roleInfoBtn;
        private System.Windows.Forms.Button listRoleBtn;
    }
}