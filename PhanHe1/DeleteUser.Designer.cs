namespace PhanHe1
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.userCbb = new System.Windows.Forms.ComboBox();
            this.chooseUsernameLb = new System.Windows.Forms.Label();
            this.deleteUserLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(148, 106);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(123, 32);
            this.deleteBtn.TabIndex = 48;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // userCbb
            // 
            this.userCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCbb.FormattingEnabled = true;
            this.userCbb.Location = new System.Drawing.Point(206, 67);
            this.userCbb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userCbb.Name = "userCbb";
            this.userCbb.Size = new System.Drawing.Size(170, 21);
            this.userCbb.TabIndex = 46;
            // 
            // chooseUsernameLb
            // 
            this.chooseUsernameLb.AutoSize = true;
            this.chooseUsernameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseUsernameLb.Location = new System.Drawing.Point(46, 67);
            this.chooseUsernameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseUsernameLb.Name = "chooseUsernameLb";
            this.chooseUsernameLb.Size = new System.Drawing.Size(150, 20);
            this.chooseUsernameLb.TabIndex = 45;
            this.chooseUsernameLb.Text = "Chọn người dùng:";
            // 
            // deleteUserLb
            // 
            this.deleteUserLb.AutoSize = true;
            this.deleteUserLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteUserLb.ForeColor = System.Drawing.Color.MediumBlue;
            this.deleteUserLb.Location = new System.Drawing.Point(80, 16);
            this.deleteUserLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deleteUserLb.Name = "deleteUserLb";
            this.deleteUserLb.Size = new System.Drawing.Size(280, 36);
            this.deleteUserLb.TabIndex = 44;
            this.deleteUserLb.Text = "XÓA NGƯỜI DÙNG";
            this.deleteUserLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 162);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.userCbb);
            this.Controls.Add(this.chooseUsernameLb);
            this.Controls.Add(this.deleteUserLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa người dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox userCbb;
        private System.Windows.Forms.Label chooseUsernameLb;
        private System.Windows.Forms.Label deleteUserLb;
    }
}