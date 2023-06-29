using Business_Logic_Layer;
using Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1
{
    public partial class DeleteUser : Form
    {
        //string activeUser;

        public DeleteUser()
        {
            InitializeComponent();
            LoadListUsers();
        }
        private void LoadListUsers()
        {
            BLL bll = new BLL();
            var listUsers = bll.getListUsers();

            userCbb.DataSource = listUsers;
            userCbb.DisplayMember = "Username";
            userCbb.ValueMember = "Username";
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var username = userCbb.SelectedValue.ToString();
            if (userCbb.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool result = bll.deleteUserBLL(username);

            if (result == true)
            {
                MessageBox.Show(username + " đã được xóa thành công khỏi hệ thống", "Thành công",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Không thể xóa người dùng {username} do lỗi bên hệ thống", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadListUsers();
        }

    }
}
