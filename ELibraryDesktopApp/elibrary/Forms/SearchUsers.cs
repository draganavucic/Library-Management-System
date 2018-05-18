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
    public partial class SearchUsers : Form
    {

        User user = new User();
        User[] UserArray;
        int CurrentUserIndex = 0;

        public SearchUsers()
        {
            InitializeComponent();
            tgHasBook.Enabled = false;
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            Clear();

            long ParsedJMBG;
            if (long.TryParse(tbSearch.Text, out ParsedJMBG))
            {
                // text is a number, meaning it's a JMBG
                UserArray = Program.librarian.ReturnUsersByJMBG(ParsedJMBG.ToString()).ToArray();
                if (UserArray.Count() != 0)
                {
                    nbUserStatus.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Success;
                    nbUserStatus.Text = "Found " + UserArray.Count().ToString() + " users.";
                    DisplayUser(0);
                }
            }
            else
            {
                // text is a text, meaning it's a Name
                UserArray = Program.librarian.ReturnUsersByName(tbSearch.Text).ToArray();
                if (UserArray.Count() != 0)
                {
                    nbUserStatus.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Success;
                    nbUserStatus.Text = "Found " + UserArray.Count().ToString() + " users.";
                    DisplayUser(0);
                }
            }
        }

        public void DisplayUser(int index)
        {
            tgHasBook.Toggled = false;
            lbBookYear.Text = "n/a";
            lbBookName.Text = "n/a";
            btnBookReturn.Enabled = false;
            btnBookReturn.ForeColor = Color.Gray;
            btnBookSearch.Enabled = true;
            btnBookSearch.ForeColor = Color.White;
            btnExtendMembership.Enabled = true;
            btnExtendMembership.ForeColor = Color.White;

            user = UserArray[index];

            lbJMBG.Text = user.JMBG;
            lbName.Text = user.Name;
            lbAdress.Text = user.Address;
            lbPhone.Text = user.Phone;
            lbEmail.Text = user.Email;
            lbExpDate.Text = user.ExpirationDate.ToString("d");
            if (user.RentedBook != "" && user.RentedBook != null)
            {
                btnBookReturn.Enabled = true;
                btnBookReturn.ForeColor = Color.White;

                btnBookSearch.Enabled = false;
                btnBookSearch.ForeColor = Color.Gray;

                tgHasBook.Toggled = true;

                lbBookName.Text = user.RentedBook;
                lbBookYear.Text = Program.librarian.ReturnBookByTitle(user.RentedBook).Year.ToString();
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentUserIndex > 0)
                DisplayUser(--CurrentUserIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentUserIndex < UserArray.Count() - 1)
                DisplayUser(++CurrentUserIndex);
        }

        public void Clear()
        {
            CurrentUserIndex = 0;
            lbJMBG.Text = "n/a";
            lbName.Text = "n/a";
            lbPhone.Text = "n/a";
            lbAdress.Text = "n/a";
            lbEmail.Text = "n/a";
            lbBookYear.Text = "n/a";
            lbBookYear.Text = "n/a";
            lbExpDate.Text = "n/a";
            nbUserStatus.Text = "No users found.";
            nbUserStatus.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Error;
            tgHasBook.Toggled = false;
            btnBookSearch.Enabled = false;
            btnBookSearch.ForeColor = Color.Gray;
            btnBookReturn.Enabled = false;
            btnBookReturn.ForeColor = Color.Gray;
            btnExtendMembership.Enabled = false;
            btnExtendMembership.ForeColor = Color.Gray;
            btnConfirmRent.Enabled = false;
            btnConfirmRent.ForeColor = Color.Gray;
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            user = UserArray[CurrentUserIndex];
            Program.librarian.ReturnBook(user, user.RentedBook);
            DisplayUser(CurrentUserIndex);
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            user = UserArray[CurrentUserIndex];
            if (Program.librarian.IsBookAvailable(tbBookSearch.Text))
            {
                nbAddBook.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Notice;
                nbAddBook.Text = "Book is found and available!";
                btnConfirmRent.Enabled = true;
                btnConfirmRent.ForeColor = Color.White;
            }
            else
            {
                nbAddBook.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Error;
                nbAddBook.Text = "Book is not found or not available!";
                btnConfirmRent.Enabled = false;
                btnConfirmRent.ForeColor = Color.Gray;
            }
            //DisplayUser(CurrentUserIndex);
        }

        private void btnConfirmRent_Click_1(object sender, EventArgs e)
        {
            user = UserArray[CurrentUserIndex];
            Program.librarian.RentBook(user, tbBookSearch.Text);
            nbAddBook.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Success;
            nbAddBook.Text = "Book is rent!";
            DisplayUser(CurrentUserIndex);
            btnConfirmRent.Enabled = false;
            btnConfirmRent.ForeColor = Color.Gray;
        }

        private void btnExtendMembership_Click_1(object sender, EventArgs e)
        {
            user = UserArray[CurrentUserIndex];
            Program.librarian.ExtendMembership(user);
            DisplayUser(CurrentUserIndex);
        }
    }
}
