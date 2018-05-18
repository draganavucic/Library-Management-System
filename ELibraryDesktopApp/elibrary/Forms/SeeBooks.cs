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
    public partial class SeeBooks : Form
    {
        public SeeBooks()
        {
            InitializeComponent();
            ShowAllBooks();
        }

        public void ShowAllBooks()
        {
            List<Book> List = Program.librarian.ReturnAllBooks();

            var source = new BindingSource();
            source.DataSource = List;
            booksList.DataSource = source;
            booksList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in booksList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        public void ShowAllAvailableBooks()
        {
            List<Book> List = Program.librarian.ReturnAllAvailableBooks();

            var source = new BindingSource();
            source.DataSource = List;
            booksList.DataSource = source;
            booksList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in booksList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        public void ShowAllBusyBooks()
        {
            List<Book> List = Program.librarian.ReturnAllBusyBooks();

            var source = new BindingSource();
            source.DataSource = List;
            booksList.DataSource = source;
            booksList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in booksList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            ShowAllBooks();
        }

        private void btnAvailableBooks_Click(object sender, EventArgs e)
        {
            ShowAllAvailableBooks();
        }

        private void btnBusyBooks_Click(object sender, EventArgs e)
        {
            ShowAllBusyBooks();
        }
    }
}
