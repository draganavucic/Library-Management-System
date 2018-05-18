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
    public partial class SearchBooks : Form
    {
        public SearchBooks()
        {
            InitializeComponent();
        }

        Book book = new Book();
        Author autor = new Author();
        Book[] BookArray;
        Author[] AuthorArray;
        int CurrentIndex = 0;

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            BookArray = Program.librarian.ReturnBooksByTitle(tbTitle.Text.ToString()).ToArray();

            if (BookArray.Count() != 0)
            {
                nbStatus.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Success;
                nbStatus.Text = "Found " + BookArray.Count().ToString() + " books.";

                AuthorArray = new Author[BookArray.Count()];

                for (int i = 0; i < BookArray.Count(); i++)
                {
                    AuthorArray[i] = Program.librarian.ReturnAuthorByName(BookArray[i].Author.ToString());
                }

                DisplayBook(0);
            }
            else
            {
                nbStatus.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Error;
                nbStatus.Text = "No books found under this name.";
            }
        }

        private void DisplayBook(int index)
        {
            book = BookArray[index];
            lbTitle.Text = book.Title;
            lbLanguage.Text = book.Language;
            lbGenre.Text = book.Genre;
            lbQuantity.Text = book.Quantity.ToString();
            lbAvailable.Text = book.Available.ToString();
            lbYear.Text = book.Year.ToString();
            lbPages.Text = book.Pages.ToString();
            tbDescription.Text = book.Description;

            autor = AuthorArray[index];
            lbFullName.Text = autor.Name;
            lbBirthYear.Text = autor.Year.ToString();
            tbBiography.Text = autor.Bio;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
                DisplayBook(--CurrentIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < BookArray.Count() - 1)
                DisplayBook(++CurrentIndex);
        }
    }
}
