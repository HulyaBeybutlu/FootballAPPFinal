using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballAPPFinal.AllForms;
using FootballAPPFinal.Models;

namespace FootballAPPFinal
{
    public partial class Form1 : Form
    {
        FootballDBEntities db = new FootballDBEntities();
        public Form1()
        {
            InitializeComponent();
        }
        #region LoginIsRemember
        public void LoginIsRemember(string username, string password)
        {
            if (chRemember.Checked)
            {
                Properties.Settings.Default.username = username;
                Properties.Settings.Default.password = password;
                Properties.Settings.Default.isRemember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.isRemember = false;
                Properties.Settings.Default.Save();
            }
        }
        #endregion
        #region btnLogin Click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usName = txtUserName.Text;
            string password = txtPassword.Text;
            if (usName!="" && password!="")
            {
                Admin selectedadmin = db.Admins.FirstOrDefault(adm => adm.AdmUserName == usName && adm.AdmUserName==usName);
                if (selectedadmin != null)
                {
                    if (selectedadmin.AdminPassword==password)
                    {
                        LoginIsRemember(usName, password);
                        AdminPageForm admPage = new AdminPageForm();
                        admPage.ShowDialog();
                    }
                };
                Worker selectedworker = db.Workers.FirstOrDefault(wrk => wrk.WorkUserName == usName && wrk.WorkPassword==password);
                if (selectedworker != null)
                {
                    if (selectedworker.WorkPassword==password)
                    {
                        AddCustomerForm addCus = new AddCustomerForm();
                        addCus.ShowDialog();
                    }
                }
                else
                {
                    lblError.Text = "User name or password is not true";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Fill all the field!!!";
                lblError.Visible = true;
            }
           
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region FormLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isRemember)
            {
                txtUserName.Text = Properties.Settings.Default.username;
                txtPassword.Text = Properties.Settings.Default.password;
                chRemember.Checked = true;
            }
        }
        #endregion
    }
}
