using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanHe2_QLNV;

namespace PhanHe1
{
    public partial class MHchonphanhe : Form
    {
        public MHchonphanhe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form form = new FormRoot();
            form.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form form = new DangNhap();
            form.ShowDialog();
            Show();
        }
    }
}
