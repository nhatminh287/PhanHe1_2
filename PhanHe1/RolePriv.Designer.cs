namespace PhanHe1
{
    partial class RolePriv
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
            this.privUserlabel = new System.Windows.Forms.Label();
            this.listRoleCbb = new System.Windows.Forms.ComboBox();
            this.chooseRoleLb = new System.Windows.Forms.Label();
            this.dgvSysPrivs = new System.Windows.Forms.DataGridView();
            this.dgvObjectPrivs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysPrivs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectPrivs)).BeginInit();
            this.SuspendLayout();
            // 
            // privUserlabel
            // 
            this.privUserlabel.AutoSize = true;
            this.privUserlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.privUserlabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.privUserlabel.Location = new System.Drawing.Point(105, 18);
            this.privUserlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.privUserlabel.Name = "privUserlabel";
            this.privUserlabel.Size = new System.Drawing.Size(452, 36);
            this.privUserlabel.TabIndex = 40;
            this.privUserlabel.Text = "THÔNG TIN QUYỀN CỦA ROLE";
            this.privUserlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listRoleCbb
            // 
            this.listRoleCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRoleCbb.FormattingEnabled = true;
            this.listRoleCbb.Location = new System.Drawing.Point(309, 64);
            this.listRoleCbb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listRoleCbb.Name = "listRoleCbb";
            this.listRoleCbb.Size = new System.Drawing.Size(171, 21);
            this.listRoleCbb.Sorted = true;
            this.listRoleCbb.TabIndex = 39;
            this.listRoleCbb.SelectedIndexChanged += new System.EventHandler(this.listRoleCbb_SelectedIndexChanged);
            // 
            // chooseRoleLb
            // 
            this.chooseRoleLb.AutoSize = true;
            this.chooseRoleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseRoleLb.Location = new System.Drawing.Point(202, 63);
            this.chooseRoleLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseRoleLb.Name = "chooseRoleLb";
            this.chooseRoleLb.Size = new System.Drawing.Size(91, 20);
            this.chooseRoleLb.TabIndex = 38;
            this.chooseRoleLb.Text = "Chọn role:";
            // 
            // dgvSysPrivs
            // 
            this.dgvSysPrivs.AllowUserToAddRows = false;
            this.dgvSysPrivs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSysPrivs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSysPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSysPrivs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSysPrivs.Location = new System.Drawing.Point(20, 138);
            this.dgvSysPrivs.Name = "dgvSysPrivs";
            this.dgvSysPrivs.ReadOnly = true;
            this.dgvSysPrivs.Size = new System.Drawing.Size(624, 149);
            this.dgvSysPrivs.TabIndex = 42;
            // 
            // dgvObjectPrivs
            // 
            this.dgvObjectPrivs.AllowUserToAddRows = false;
            this.dgvObjectPrivs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjectPrivs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObjectPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjectPrivs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObjectPrivs.Location = new System.Drawing.Point(20, 342);
            this.dgvObjectPrivs.Name = "dgvObjectPrivs";
            this.dgvObjectPrivs.ReadOnly = true;
            this.dgvObjectPrivs.Size = new System.Drawing.Size(624, 161);
            this.dgvObjectPrivs.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "1. Quyền hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "2. Quyền thao tác trên đối tượng";
            // 
            // RolePriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvObjectPrivs);
            this.Controls.Add(this.dgvSysPrivs);
            this.Controls.Add(this.privUserlabel);
            this.Controls.Add(this.listRoleCbb);
            this.Controls.Add(this.chooseRoleLb);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "RolePriv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin quyền của role";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysPrivs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectPrivs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label privUserlabel;
        private System.Windows.Forms.ComboBox listRoleCbb;
        private System.Windows.Forms.Label chooseRoleLb;
        private System.Windows.Forms.DataGridView dgvSysPrivs;
        private System.Windows.Forms.DataGridView dgvObjectPrivs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}