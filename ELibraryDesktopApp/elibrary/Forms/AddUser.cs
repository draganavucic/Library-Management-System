using ELibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELibrary
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User NewUser = new User();
            NewUser.Name = tbName.Text;
            NewUser.Phone = tbPhone.Text;
            NewUser.Address = tbAdress.Text;
            NewUser.RentedBook = null;

            long o;
            if (long.TryParse(tbJMBG.Text, out o) && IsValidEmail(tbEmail.Text))
            {
                NewUser.JMBG = tbJMBG.Text;
                NewUser.Email = tbEmail.Text;

                if (Program.librarian.AddUser(NewUser))
                {
                    MessageBox.Show("Member successfully added: " + NewUser.Name);
                    Close();
                }
                else
                {
                    // Ti nisi covek, ti si greska
                    MessageBox.Show("You re not a man, you are Error!");
                }
            }
            else
            {
                // Ti nisi covek, ti si greska
                MessageBox.Show("You re not a man, you are Error!");
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
