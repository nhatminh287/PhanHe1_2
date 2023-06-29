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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanHe1
{
    public partial class GrantRole : Form
    {

        List<TypePriv> listTypePrivs;

        public GrantRole()
        {
            InitializeComponent();
            listTypePrivs = new List<TypePriv>() {
                new TypePriv() { Description = "Quyền hệ thống", TableName = "DBA_SYS_PRIVS" },
                new TypePriv() { Description = "Quyền đối tượng", TableName = "DBA_TAB_PRIVS" },
            };
            LoadListRoles();
            LoadListTypePrivs();
            LoadListPrivilegeSYS();
            LoadListObjectDb();
        }

        private void LoadListRoles()
        {
            BLL bll = new BLL();
            var listRoles = bll.getListRoles();
            listRoleCbb.DataSource = listRoles;
            listRoleCbb.DisplayMember = "Rolename";
        }

        private void LoadListTypePrivs()
        {
            BLL bll = new BLL();

            cbbPrivType.DataSource = listTypePrivs;
            cbbPrivType.DisplayMember = "Description";
        }

        private void LoadListPrivilegeSYS()
        {
            BLL bll = new BLL();
            if (cbbPrivType.SelectedIndex == 0)
            {
                var listPri = bll.getListPrivilegeSYS();
                listPriCbb.DataSource = listPri;
                listPriCbb.DisplayMember = "Rolename";
            }
            else
            {

                List<string> listObjectPriv = new List<string>()
                { "SELECT", "INSERT", "UPDATE", "DELETE", "EXCEUTE" };
                listPriCbb.DataSource = listObjectPriv;
            }
        }

        private void LoadListObjectDb()
        {
            BLL bll = new BLL();
            var listObjects = bll.getListObject();
            cbbObjectDB.DataSource = listObjects;
            cbbObjectDB.ValueMember = "ObjectName";
        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            string rolename = listRoleCbb.Text;
            string priname = listPriCbb.Text;
            string query = "";
            if (cbbPrivType.SelectedIndex == 0) // gán quyền hệ thống
            {
                string adminOption = withAdminOption.CheckState == CheckState.Checked ? "WITH ADMIN OPTION" : "";
                query = "grant " + priname + " to " + rolename + " " + adminOption;
            }
            else // gán quyền trên đối tượng
            {
                string objectDB = ((string)cbbObjectDB.SelectedValue);
                query = $"GRANT {priname} ON {objectDB} TO {rolename}";
            }
            //MessageBox.Show(query);

            BLL bll = new BLL();
            bll.grantUserToRole(query);
            MessageBox.Show("Cấp quyền cho role " + rolename + " thành công!");
        }

        private void cbbObjectFormat(object sender, ListControlConvertEventArgs e)
        {
            string Name = ((ObjectDB)e.ListItem).ObjectName;
            string Type = ((ObjectDB)e.ListItem).ObjectType;
            e.Value = "(" + Type + ")  " + Name;
        }

        private void privTypeChange(object sender, EventArgs e)
        {
            LoadListPrivilegeSYS();
            if (cbbPrivType.SelectedIndex == 0)
            {
                adminLabel.Visible = true;
                withAdminOption.Visible = true;
                objectLabel.Visible = false;
                cbbObjectDB.Visible = false;
            }
            else
            {
                adminLabel.Visible = false;
                withAdminOption.Visible = false;
                objectLabel.Visible = true;
                cbbObjectDB.Visible = true;
            }
        }
    }
}
