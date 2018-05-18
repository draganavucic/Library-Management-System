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
    public partial class SeeComments : Form
    {
        public SeeComments()
        {
            InitializeComponent();
            ShowAllComments();
            commentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public void ShowAllComments()
        {
            List<Comment> ListOfComments = Program.librarian.ReturnAllUnApprovedComments();

            var source = new BindingSource();
            source.DataSource = ListOfComments;
            commentGrid.DataSource = source;
            commentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in commentGrid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void btnAppCom_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(commentGrid.SelectedRows[0].Cells[0].Value.ToString());
            foreach (DataGridViewRow r in commentGrid.SelectedRows)
            {
                Comment comment = new Comment();
                comment.CommentedBook = r.Cells[0].Value.ToString();
                comment.UserCommented = r.Cells[1].Value.ToString();
                comment.Rate = int.Parse(r.Cells[2].Value.ToString());
                comment.IsApproved = Convert.ToBoolean(r.Cells[3].Value);
                comment.Text = r.Cells[4].Value.ToString();
                //MessageBox.Show(comment.CommentedBook + comment.UserCommented + comment.Rate+ comment.IsApproved+ comment.Text);
                Program.librarian.ApproveComment(comment);

            }
            ShowAllComments();
        }

        private void btnDelCom_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in commentGrid.SelectedRows)
            {
                Comment comment = new Comment();
                comment.CommentedBook = r.Cells[0].Value.ToString();
                comment.UserCommented = r.Cells[1].Value.ToString();
                comment.Rate = int.Parse(r.Cells[2].Value.ToString());
                comment.IsApproved = Convert.ToBoolean(r.Cells[3].Value);
                comment.Text = r.Cells[4].Value.ToString();
                //MessageBox.Show(comment.CommentedBook + comment.UserCommented + comment.Rate+ comment.IsApproved+ comment.Text);
                Program.librarian.DiscardComment(comment);

            }
            ShowAllComments();
        }
    }
}
