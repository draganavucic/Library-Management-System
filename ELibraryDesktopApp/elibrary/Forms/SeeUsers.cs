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
    public partial class SeeUsers : Form
    {
        public SeeUsers()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ShowAllUsers();
        }

       

        public void ShowAllUsers()
        {
            List<User> ListOfUsers = Program.librarian.ReturnAllUsers();

            var source = new BindingSource();
            source.DataSource = ListOfUsers;
            usersList.DataSource = source;
            usersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in usersList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }


        }

        public void ShowExpiredUsers()
        {
            List<User> ListOfUsers = Program.librarian.ReturnExpiredUsers();

            var source = new BindingSource();
            source.DataSource = ListOfUsers;
            usersList.DataSource = source;
            usersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in usersList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

        }

        public void ShowNonExpiredUsers()
        {
            List<User> ListOfUsers = Program.librarian.ReturnNonExpiredUsers();

            var source = new BindingSource();
            source.DataSource = ListOfUsers;
            usersList.DataSource = source;
            usersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in usersList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnNonExpUsers_Click(object sender, EventArgs e)
        {
            ShowNonExpiredUsers();
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            ShowAllUsers();
        }

        private void btnExpUsers_Click(object sender, EventArgs e)
        {
            ShowExpiredUsers();
        }
    }
}
