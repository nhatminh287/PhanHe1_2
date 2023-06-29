using Business_Logic_Layer;
using Data_Access_Layer;
using Object;
using Oracle.ManagedDataAccess.Client;
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
    public partial class UserPriv : Form
    {
        private BLL bll;
        public UserPriv()
        {
            InitializeComponent();
            bll = new BLL();

        }

        private void UserPriv_Load(object sender, EventArgs e)
        {
            LoadUserComboBox();

            // Set header text for dgvPrivilegesOfUser
            dgvPrivilegesOfUser.Columns[0].HeaderText = "Privileges";
            dgvPrivilegesOfUser.Columns[0].Width = 300;
            dgvPrivilegesOfUser.Columns[1].Visible = false; // Hide username column
            dgvPrivilegesOfUser.Columns[2].HeaderText = "Admin Option";
            dgvPrivilegesOfUser.Columns[2].Width = 150;

            // Set header text for dgvObjectPrivOfUser
            dgvObjectPrivOfUser.Columns[0].Visible = false;
            dgvObjectPrivOfUser.Columns[1].HeaderText = "Privileges";
            dgvObjectPrivOfUser.Columns[1].Width = 300;
            dgvObjectPrivOfUser.Columns[2].Visible = false;
            dgvObjectPrivOfUser.Columns[3].HeaderText = "Object";
            dgvObjectPrivOfUser.Columns[3].Width = 150;
            dgvObjectPrivOfUser.Columns[4].Visible = false;

        }

        private void LoadUserComboBox()
        {
            // Lấy danh sách user đưa vào omboBox
            var listUsers = bll.getListUsers();
            listUserCbb.DataSource = listUsers;
            listUserCbb.DisplayMember = "Username";
            listUserCbb.ValueMember = "Username";
        }


        private void listUserCbb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listUserCbb.SelectedIndex < 0)
            {
                return;
            }

            var listSysPrivs = bll.getListPrivilegesByUserNameOrRoleName(listUserCbb.Text);
            var listObjectPrivs = bll.getListPrivs(listUserCbb.Text, "DBA_TAB_PRIVS", "GRANTEE");

            //dgvPrivilegesOfUser.Refresh();
            dgvPrivilegesOfUser.DataSource = listSysPrivs;
            dgvObjectPrivOfUser.DataSource = listObjectPrivs;


            if (listSysPrivs.Count == 0 && listObjectPrivs.Count == 0)
            {
                MessageBox.Show("Người dùng chưa được gán quyền nào hết.");
                return;
            }

        }

    }
}