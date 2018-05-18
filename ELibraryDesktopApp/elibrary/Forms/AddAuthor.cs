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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if(tbName.Text=="" || tbBiography.Text=="")
            {
                MessageBox.Show("Fields cant be empty.");
            }
            else
            {
                Author newA = new Author();

                newA.Name = tbName.Text;
                newA.Bio = tbBiography.Text;

                int y;
                if (Int32.TryParse(tbYear.Text, out y))
                {
                    newA.Year = y;

                    if (Program.librarian.AddAuthor(newA))
                    {
                        MessageBox.Show("Author added successfuly.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("There was some error during saving author!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid year.");
                    tbYear.Text = "";
                }
            }
        }
    }
}
