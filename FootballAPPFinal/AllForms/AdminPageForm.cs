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
        private void CusNameCmbFill()
        {
            cmbCusName.Items.AddRange(db.Customers.Select(cs => cs.FirstName).ToArray());
        }
        private void AdminPageForm_Load(object sender, EventArgs e)
        {
            FilldtgReservations();
            CusNameCmbFill();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {

        }
    }
}
