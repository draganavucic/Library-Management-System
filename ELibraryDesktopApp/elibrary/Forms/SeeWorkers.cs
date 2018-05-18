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
    public partial class SeeWorkers : Form
    {
        public SeeWorkers()
        {
            InitializeComponent();

            ShowAllWorkers();
        }

        public void ShowAllWorkers()
        {
            List<Librarian> List = Program.librarian.ReturnAllLibrarians();

            var source = new BindingSource();
            source.DataSource = List;
            workersList.DataSource = source;
            workersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in workersList.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }


        }

        private void btnUpdateWorker_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in workersList.SelectedRows)
            {
                Librarian l = new Librarian();
                l.Username = r.Cells[0].Value.ToString();
                l.Password = r.Cells[1].Value.ToString();
                l.IsAdmin = Convert.ToBoolean(r.Cells[2].Value);
                l.Name = r.Cells[3].Value.ToString();

                Program.librarian.UpdateLibrarian(l);

            }
            ShowAllWorkers();
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in workersList.SelectedRows)
            {
                Librarian l = new Librarian();
                l.Username = r.Cells[0].Value.ToString();
                l.Password = r.Cells[1].Value.ToString();
                l.IsAdmin = Convert.ToBoolean(r.Cells[2].Value);
                l.Name = r.Cells[3].Value.ToString();
                
                Program.librarian.DeleteLibrarian(l);

            }
            ShowAllWorkers();
        }
    }
}
