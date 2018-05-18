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
    public partial class AddBook : Form
    {
        Author autor = null;

        public AddBook()
        {
            InitializeComponent();
        }

        private void btnRegisterNewBook_Click(object sender, EventArgs e)
        {
            if(autor!=null)
            {

                try
                {
                    Book b = new Book();

                    b.Title = tbTitle.Text;
                    b.Author = autor.Name;
                    b.Available = Int32.Parse(tbQuantity.Text);
                    b.Quantity = Int32.Parse(tbQuantity.Text);
                    b.Description = tbDescription.Text;
                    b.Genre = cbGenre.SelectedItem.ToString();
                    b.Language = cbLanguage.SelectedItem.ToString();
                    b.Pages = Int32.Parse(tbPages.Text);
                    b.Year = Int32.Parse(tbYear.Text);

                    if (Program.librarian.AddBook(b))
                    {
                        MessageBox.Show("Book added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Some error happened. Check again.");
                    }

                }
                catch
                {
                    MessageBox.Show("Fields are not correctly entered or something is empty.");
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to add new author?", "Author of this book is not set.", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var aa = new AddAuthor();
                    aa.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
        }

        private void tbSearchForAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                autor = Program.librarian.ReturnAuthorByName(tbAuthorName.Text.ToString());
                if (autor != null)
                {
                    tbAuthorName.Text = autor.Name;
                    tgAuthorFound.Toggled = true;
                }
            }
            catch
            {
                tbAuthorName.Text = "";
                tgAuthorFound.Toggled = false;
            }
        }
    }
}
