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
        Stadium selectedStadium;
        Room selectedRoom;
        public AdminPageForm()
        {
            InitializeComponent();
        }

        #region ToggleInputButtons
        public void ToggleInput(string mode)
        {
            if (mode == "Reservation")
            {
                pnReservation.Visible = true;
                pnAddWorker.Visible = false;
                pnStadiums.Visible = false;
                pnRooms.Visible = false;
            }
            else if (mode == "AddWorker")
            {
                pnAddWorker.Visible = true;
                pnReservation.Visible = false;
                pnStadiums.Visible = false;
                pnRooms.Visible = false;
            }
            else if (mode == "Rooms")
            {
                pnRooms.Visible = true;
                pnStadiums.Visible = false;
                pnReservation.Visible = false;
                pnAddWorker.Visible = false;
            }
            else if (mode == "Stadiums")
            {
                pnStadiums.Visible = true;
                pnReservation.Visible = false;
                pnAddWorker.Visible = false;
                pnRooms.Visible = false;
            }
        }
        #endregion

        private void AdminPageForm_Load(object sender, EventArgs e)
        {
            FilldtgReservations();
        }
        private void btnCloseAdm_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #region DtgReservationMethod
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
        #endregion
        
        #region WorkersForm
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
            ToggleInput("AddWorker");
            FilldtgWorkers();

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
            if (workerName != string.Empty && userName != string.Empty && password != string.Empty)
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
            int workID = (int)dtgWorkers.Rows[e.RowIndex].Cells[0].Value;
            selectedWorker = db.Workers.First(x => x.ID == workID);
            txtFullName.Text = selectedWorker.FullName;
            txtUserName.Text = selectedWorker.WorkUserName;
            txtPassword.Text = selectedWorker.WorkPassword;
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            btnVisibility("del");
            DialogResult res = MessageBox.Show("Are you sure to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == res)
            {
                db.Workers.Remove(selectedWorker);
                db.SaveChanges();
                ClearAllData();
                FilldtgWorkers();

            }
        }
        #endregion

        #region StadiumsForm

        #region FilldtgStadiums
        public void FilldtgStadiums()
        {
            dtgStadiums.DataSource = db.Stadiums.Select(s => new
            {
                s.ID,
                s.StName,
                s.Price,
            }).ToList();
            dtgStadiums.Columns[0].Visible = false;
        }
        #endregion

        private void btnStadiums_Click(object sender, EventArgs e)
        {
            ToggleInput("Stadiums");
            FilldtgStadiums();
        }

        private void btnAddStadium_Click(object sender, EventArgs e)
        {
            string stName = txtStName.Text;
            decimal price = nmStPrice.Value;
            if (stName != string.Empty && price != 0)
            {
                Stadium st = null;
                st = new Stadium
                {
                    StName = stName,
                    Price = price,
                };
                db.Stadiums.Add(st);
                db.SaveChanges();
                MessageBox.Show($"{st.StName} was added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllData();
                FilldtgStadiums();
            }
            else
            {
                lblErrorStadium.Text = "You must fill all the field!!!";
                lblErrorStadium.Visible = true;
            }
        }

        public void btnVisibilityStadium(string txt)
        {
            if (txt == "edit")
            {
                btnAddStadium.Visible = false;
                btnEditSt.Visible = true;
                btnDeleteSt.Visible = true;
            }
            else
            {
                btnAddStadium.Visible = true;
                btnEditSt.Visible = false;
                btnDeleteSt.Visible = false;
            }
        }

        private void btnEditSt_Click(object sender, EventArgs e)
        {
            btnVisibilityStadium("add");
            string stName = txtStName.Text;
            decimal stPrice = nmStPrice.Value;
            string password = txtPassword.Text;
            if (stName != string.Empty && stPrice != 0)
            {
                selectedStadium.StName = stName;
                selectedStadium.Price = stPrice;
                db.SaveChanges();
                ClearAllData();
                FilldtgStadiums();
            }
            else
            {
                lblErrorStadium.Text = "You must fill all the field!!!";
                lblErrorStadium.Visible = true;
            }
        }

        private void btnDeleteSt_Click(object sender, EventArgs e)
        {
            btnVisibilityStadium("del");
            DialogResult res = MessageBox.Show("Are you sure to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == res)
            {
                db.Stadiums.Remove(selectedStadium);
                db.SaveChanges();
                ClearAllData();
                FilldtgStadiums();
            }
        }
        private void dtgStadiums_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnVisibility("edit");
            int stID = (int)dtgStadiums.Rows[e.RowIndex].Cells[0].Value;
            selectedStadium = db.Stadiums.First(x => x.ID == stID);
            txtStName.Text = selectedStadium.StName;
            nmStPrice.Value = selectedStadium.Price;
        }
        #endregion

        #region RoomsForm
        #region FilldtgRooms
        public void FilldtgRooms()
        {
            dtgRooms.DataSource = db.Rooms.Select(s => new
            {
                s.ID,
                s.RoomNumber,
                s.Capacity,
            }).ToList();
            dtgRooms.Columns[0].Visible = false;
        }
        #endregion
        private void btnRooms_Click(object sender, EventArgs e)
        {
            ToggleInput("Rooms");
            FilldtgRooms();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomNum = txtRoomNum.Text;
            string capacity = txtCapacity.Text;
            if (roomNum != string.Empty && capacity != string.Empty)
            {
                Room rm = null;
                rm = new Room
                {
                    RoomNumber = Convert.ToInt32(roomNum),
                    Capacity = Convert.ToInt32(capacity),
                };
                db.Rooms.Add(rm);
                db.SaveChanges();
                MessageBox.Show("Room was added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllData();
                FilldtgRooms();
            }
            else
            {
                lblErrorRoom.Text = "You must fill all the field!!!";
                lblErrorRoom.Visible = true;
            }
        }
        public void btnVisibilityRoom(string txt)
        {
            if (txt == "edit")
            {
                btnAddRoom.Visible = false;
                btnEditRoom.Visible = true;
                btnDeleteRoom.Visible = true;
            }
            else
            {
                btnAddRoom.Visible = true;
                btnEditRoom.Visible = false;
                btnDeleteRoom.Visible = false;
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            btnVisibilityStadium("add");
            string roomNum = txtRoomNum.Text;
            string capacity = txtCapacity.Text;
            string password = txtPassword.Text;
            if (roomNum != string.Empty && capacity != string.Empty)
            {
                selectedRoom.RoomNumber =Convert.ToInt32(roomNum);
                selectedRoom.Capacity = Convert.ToInt32(capacity);
                db.SaveChanges();
                ClearAllData();
                FilldtgRooms();
            }
            else
            {
                lblErrorRoom.Text = "You must fill all the field!!!";
                lblErrorRoom.Visible = true;
            }
        }
       
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            btnVisibilityRoom("del");
            DialogResult res = MessageBox.Show("Are you sure to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == res)
            {
                db.Rooms.Remove(selectedRoom);
                db.SaveChanges();
                ClearAllData();
                FilldtgRooms();
            }
        }

        private void dtgRooms_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnVisibility("edit");
            int roomID = (int)dtgRooms.Rows[e.RowIndex].Cells[0].Value;
            selectedRoom = db.Rooms.First(x => x.ID == roomID);
            txtRoomNum.Text = selectedRoom.RoomNumber.ToString();
            txtCapacity.Text = selectedRoom.Capacity.ToString();
        }
        #endregion
    }
}

