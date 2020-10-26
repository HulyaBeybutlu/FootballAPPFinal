using FootballAPPFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballAPPFinal.AllForms
{
    public partial class AdminPageForm : Form
    {
        FootballDBEntities db = new FootballDBEntities();
        Worker selectedWorker;
        public AdminPageForm()
        {
            InitializeComponent();
        }

        private void btnCloseAdm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FilldtgReservations()
        {
            dtgReservations.DataSource = db.Reservations.Select(a => new
            {
                First_Name = a.Customer.FirstName,
                Last_Name = a.Customer.LastName,
                Phone = a.Customer.PhoneNumber,
                Stadium_Name = a.Stadium.StName,
                Room_Number = a.Room.RoomNumber,
                Start_Date = a.ResStartDate,
                End_Date = a.ResEndDate,
                Price = a.Amount
            }).ToList();
        }
        
        private void AdminPageForm_Load(object sender, EventArgs e)
        {
            FilldtgReservations();
            FilldtgWorkers();
        }

        public void FilldtgWorkers()
        {
            dtgWorkers.DataSource = db.Workers.Select(w => new
            {
                w.ID,
                w.FullName,
                w.WorkUserName,
                w.WorkPassword
            }).ToList();
            dtgWorkers.Columns[0].Visible = false;
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            pnReservation.Visible = false;
            pnAddWorker.Visible = true;
        }

        private void btnAddWork_Click_1(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string usName = txtUserName.Text;
            string password = txtPassword.Text;
            if (fullName != string.Empty && usName != string.Empty && password != string.Empty)
            {
                Worker wk = null;
                wk = new Worker
                {
                    FullName = fullName,
                    WorkUserName = usName,
                    WorkPassword = password
                };
                db.Workers.Add(wk);
                db.SaveChanges();
                MessageBox.Show("Worker was added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllData();
                FilldtgWorkers();
                
            }
            else
            {
                lblErrorWorker.Text = "You must fill all the field!!!";
                lblErrorWorker.Visible = true;
            }
        }

        #region ClearAllDataMethod
        public void ClearAllData()
        {
            foreach (var con in Controls)
            {
                if (con is TextBox)
                {
                    TextBox txt = (TextBox)con;
                    txt.Text = "";
                }
            }
        }
        #endregion

        #region btnVisibilityMethodWorker
        public void btnVisibility(string txt)
        {
            if (txt == "edit")
            {
                btnAddWork.Visible = false;
                btnEditWorker.Visible = true;
                btnDeleteWorker.Visible = true;
            }
            else
            {
                btnAddWork.Visible = true;
                btnEditWorker.Visible = false;
                btnDeleteWorker.Visible = false;
            }
        }
        #endregion
        private void btnEditWorker_Click(object sender, EventArgs e)
        {
            btnVisibility("add");
            string workerName = txtFullName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (workerName!=string.Empty && userName!=string.Empty && password!=string.Empty)
            {
                selectedWorker.FullName = workerName;
                selectedWorker.WorkUserName = userName;
                selectedWorker.WorkPassword = password;
                db.SaveChanges();
                ClearAllData();
                FilldtgWorkers();
            }
            else
            {
                lblErrorWorker.Text = "You must fill all the field!!!";
                lblErrorWorker.Visible = true;
            }
        }

        
        private void dtgWorkers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnVisibility("edit");
            int workID =(int)dtgWorkers.Rows[e.RowIndex].Cells[0].Value;
            selectedWorker = db.Workers.First(x => x.ID == workID);
            txtFullName.Text = selectedWorker.FullName;
            txtUserName.Text = selectedWorker.WorkUserName;
            txtPassword.Text = selectedWorker.WorkPassword;
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            btnVisibility("del");
            DialogResult res = MessageBox.Show("Are you sure to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes==res)
            {
                db.Workers.Remove(selectedWorker);
                db.SaveChanges();
                ClearAllData();
                FilldtgWorkers();
                
            }
        }

    }
}
