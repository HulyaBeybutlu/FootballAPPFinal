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
        Stadium selectedSt;
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
            FillcmbRoom();
        }
        private void FillcmbStName()
        {
            cmbStName.Items.AddRange(db.Stadiums.Select(sna => sna.StName).ToArray());
        }
        private void FillcmbRoom()
        {
            cmbRoomNumber.Items.AddRange(db.Rooms.Select(r => r.RoomNumber.ToString()).ToArray());
        }

        #region btnConfirmClick
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phone = txtPhone.Text;
            string stName = cmbStName.Text;
            string roomNumber = cmbRoomNumber.Text;
            DateTime startTime = dtStarttime.Value;
            DateTime endTime = dtEndtime.Value;

            int phoneNumber;
            if (Extensions.isNotEmpty(new string[]{
                firstName,lastName,phone,stName,roomNumber
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
                        Customer newCus = new Customer()
                        {
                            FirstName=firstName,
                            LastName=lastName,
                            PhoneNumber=Convert.ToString(phoneNumber)
                        };
                        db.Customers.Add(newCus);
                        db.SaveChanges();

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
                        //To select multiple items in ComboBoxAdv
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
        #endregion

        #region cmbStNameSelectIndexChange
        private void cmbStName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stadiumName = cmbStName.Text; ;
            if (stadiumName!=string.Empty)
            {
                selectedSt = db.Stadiums.First(s => s.StName == stadiumName);
                lblAmount.Text = selectedSt.Price + "AZN";
                lblAmount.Visible = true;
            }
        }
        #endregion
    }
}
