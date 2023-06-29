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
    public partial class ListUser : Form
    {
        public ListUser()
        {
            InitializeComponent();
            LoadUserDataGridView();
            ColumnsConfigUserDataGridView();
            //LoadListUsers();
        }

        private void LoadUserDataGridView()
        {
            // lấy dữ liệu và đổ vào datagrid view
            BLL bll = new BLL();
            var listUsers = bll.getListUsers();
            dgvListUser.DataSource = new BindingSource(listUsers, null);
        }

        private void ColumnsConfigUserDataGridView()
        {
            // Xác định các cột được hiển thị, tên tiêu đề và độ rộng cột
            dgvListUser.Columns["Username"].HeaderText = "Tên tài khoản";
            dgvListUser.Columns["Username"].Width = 150;

            dgvListUser.Columns["Password"].Visible = false;

            dgvListUser.Columns["Status"].HeaderText = "Trạng thái";
            dgvListUser.Columns["Status"].Width = 150;

            dgvListUser.Columns["CreatedDate"].HeaderText = "Ngày tạo TK";
            dgvListUser.Columns["CreatedDate"].Width = 150;

            dgvListUser.Columns["ExpiryDate"].HeaderText = "Ngày hết hạn";
            dgvListUser.Columns["ExpiryDate"].Width = 150;

            dgvListUser.Columns["LastLogin"].HeaderText = "Lần đăng nhập cuối";
            dgvListUser.Columns["LastLogin"].Width = 150;
        }

        //private void LoadListUsers()
        //{
        //    BLL bll = new BLL();
        //    var listUsers = bll.getListUsers();
        //    ConvertListUsersToListView(ListUserlv, listUsers);
        //}


        //private void ConvertListUsersToListView(ListView listViewUsers, List<User> ListUsers)
        //{
        //    listViewUsers.Items.Clear();
        //    foreach (var l in ListUsers)
        //    {
        //        ListViewItem item = new ListViewItem();
        //        item.Text = l.Username;
        //        listViewUsers.Items.Add(item);
        //    }
        //}



    }
}
