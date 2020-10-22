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
    public partial class AddCustomerForm : Form
    {
        FootballDBEntities db = new FootballDBEntities();
        decimal totalPrice;
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            FillcmbStName();
            FillcmbStNumber();
            FillcmbRoom();
        }
        private void FillcmbStName()
        {
            cmbStName.Items.AddRange(db.Stadiums.Select(sna => sna.StName).ToArray());
        }
        private void FillcmbStNumber()
        {
            cmbStNumber.Items.AddRange(db.Stadiums.Select(snu => snu.StNumber.ToString()).ToArray());
        }
        private void FillcmbRoom()
        {
            cmbRoomNumber.Items.AddRange(db.Rooms.Select(r => r.RoomNumber.ToString()).ToArray());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phone = txtPhone.Text;
            string stName = cmbStName.Text;
            string stNumber = cmbStNumber.Text;
            string roomNumber = cmbRoomNumber.Text;
            DateTime startTime = dtStarttime.Value;
            DateTime endTime = dtEndtime.Value;

            int phoneNumber;
            if (Extensions.isNotEmpty(new string[]{
                firstName,lastName,phone,stName,stNumber,roomNumber
            },string.Empty))
            {
                if (db.Rooms.Any(m => m.Capacity <= 12))
                {
                    if (int.TryParse(phone,out phoneNumber))
                    {
                        Room selectedRoom = db.Rooms.FirstOrDefault(r => r.RoomNumber.ToString() == roomNumber);
                        Stadium selectedSt = db.Stadiums.FirstOrDefault(s => s.StName == stName);
                        totalPrice = selectedSt.Price;

                        int cusId = 0;

                        Reservation rv = db.Reservations.Add(new Reservation
                        {
                            ResStartDate = startTime,
                            ResEndDate=endTime,
                            CustomerID=cusId,
                            StadiumID=selectedSt.ID,
                            RoomID=selectedRoom.ID,
                            Amount=(int)totalPrice
                        });
                        db.SaveChanges();
                        MessageBox.Show("Reservation was added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lblError.Text = "Please enter correct phone number";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "This room if full";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Fill all the field!!!";
                lblError.Visible = true;
            }
        }
    }
}
