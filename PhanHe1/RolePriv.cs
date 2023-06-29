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
    public partial class RolePriv : Form
    {
        public RolePriv()
        {
            InitializeComponent();
            LoadListRoles();
        }

        private void LoadListRoles()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();
            listRoleCbb.DataSource = listRoles;
            listRoleCbb.DisplayMember = "Rolename";
        }

        private void listRoleCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rolename = listRoleCbb.Text;
            if (rolename != null)
            {
                BLL bll = new BLL();
                // lấy danh sách quyền hệ thống
                List<Privilege> sysPrivs = bll.getListPrivilegesByUserNameOrRoleName(rolename);
                dgvSysPrivs.DataSource = sysPrivs;

                // lấy danh sách quyền thao tác trên đối tượng
                List<Priv> objectPrivs = bll.getListPrivs(rolename, "DBA_TAB_PRIVS", "GRANTEE");
                dgvObjectPrivs.DataSource = objectPrivs;


            }
        }



        private void privUserLv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
