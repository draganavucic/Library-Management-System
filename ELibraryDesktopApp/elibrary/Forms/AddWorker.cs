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
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            if(tbName.Text=="" || tbPassword.Text=="" || tbUsername.Text=="")
            {
                MessageBox.Show("You must fill all fields!");
            }
            else
            {
                Librarian newL = new Librarian();
                newL.Username = tbUsername.Text;
                newL.Password = tbPassword.Text;
                newL.Birthday = dtBirthday.Value;
                newL.Name = tbName.Text;

                if (cbAdmin.Checked == true)
                    newL.IsAdmin = true;

                if (Program.librarian.AddLibrarian(newL))
                {
                    MessageBox.Show("New librarian worker added: " + newL.Name);
                    Close();
                }
                else
                {
                    MessageBox.Show("There was some error during saving worker!");
                }
            }
            
        }
    }
}
