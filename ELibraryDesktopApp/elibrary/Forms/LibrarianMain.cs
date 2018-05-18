using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELibrary.Models;

namespace ELibrary
{
    public partial class LibrarianMain : Form
    {
      
        public LibrarianMain()
        {
            InitializeComponent();
            lbName.Text = Program.librarian.Name;
            if (Program.librarian.IsAdmin)
            {
                nbAdminLog.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Success;
                nbAdminLog.Text = "You are administrator.";
            }
            else
            {
                nbAdminLog.Text += "\r You are not administrator.";
                panelWorkers.Enabled = false;
            }
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
                var aw = new AddWorker();
                aw.Show();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var aa = new AddAuthor();
            aa.Show();
        }

        private void btnRegisterNewBook_Click(object sender, EventArgs e)
        {
            var ab = new AddBook();
            ab.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var au = new AddUser();
            au.Show();
        }

        private void btnReturnUnapprovedComments_Click(object sender, EventArgs e)
        {
            var sc = new SeeComments();
            sc.Show();
        }

        private void btnReturnAllLibrarians_Click(object sender, EventArgs e)
        {
            var sw = new SeeWorkers();
            sw.Show();
        }

        private void btnReturnAllUsers_Click(object sender, EventArgs e)
        {
            var su = new SeeUsers();
            su.Show();
        }

        private void btnReturnAllBooks_Click(object sender, EventArgs e)
        {
            var sb = new SeeBooks();
            sb.Show();
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            var sb = new SearchBooks();
            sb.Show();
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            var su = new SearchUsers();
            su.Show();
        }

        private void lbName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.librarian = null;
            Hide();
            var lm = new Login();
            lm.ShowDialog();
            Close();
        }
    }
}
