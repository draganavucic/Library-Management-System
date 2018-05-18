namespace ELibrary
{
    partial class LibrarianMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.lbName = new MonoFlat.MonoFlat_LinkLabel();
            this.monoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
            this.nbAdminLog = new MonoFlat.MonoFlat_NotificationBox();
            this.panelWorkers = new MonoFlat.MonoFlat_Panel();
            this.btnReturnAllLibrarians = new MonoFlat.MonoFlat_Button();
            this.btnAddLibrarian = new MonoFlat.MonoFlat_Button();
            this.monoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            this.panelBooks = new MonoFlat.MonoFlat_Panel();
            this.btnSearchBooks = new MonoFlat.MonoFlat_Button();
            this.btnAddAuthor = new MonoFlat.MonoFlat_Button();
            this.btnReturnAllBooks = new MonoFlat.MonoFlat_Button();
            this.btnRegisterNewBook = new MonoFlat.MonoFlat_Button();
            this.monoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.panelUsers = new MonoFlat.MonoFlat_Panel();
            this.btnSearchUsers = new MonoFlat.MonoFlat_Button();
            this.btnReturnUnapprovedComments = new MonoFlat.MonoFlat_Button();
            this.btnReturnAllUsers = new MonoFlat.MonoFlat_Button();
            this.btnAddUser = new MonoFlat.MonoFlat_Button();
            this.monoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.panelWorkers.SuspendLayout();
            this.panelBooks.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.lbName);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel4);
            this.monoFlat_ThemeContainer1.Controls.Add(this.nbAdminLog);
            this.monoFlat_ThemeContainer1.Controls.Add(this.panelWorkers);
            this.monoFlat_ThemeContainer1.Controls.Add(this.panelBooks);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.panelUsers);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(908, 492);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Library Managment System - Control Panel";
            // 
            // lbName
            // 
            this.lbName.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbName.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.lbName.Location = new System.Drawing.Point(806, 100);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(88, 15);
            this.lbName.TabIndex = 6;
            this.lbName.TabStop = true;
            this.lbName.Text = "Librarian Name";
            this.toolTip1.SetToolTip(this.lbName, "Press to Log out from LMS.\r\n");
            this.lbName.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.lbName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbName_LinkClicked);
            // 
            // monoFlat_HeaderLabel4
            // 
            this.monoFlat_HeaderLabel4.AutoSize = true;
            this.monoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel4.Image = global::ELibrary.Properties.Resources.worker;
            this.monoFlat_HeaderLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_HeaderLabel4.Location = new System.Drawing.Point(659, 70);
            this.monoFlat_HeaderLabel4.Name = "monoFlat_HeaderLabel4";
            this.monoFlat_HeaderLabel4.Size = new System.Drawing.Size(235, 20);
            this.monoFlat_HeaderLabel4.TabIndex = 5;
            this.monoFlat_HeaderLabel4.Text = "        Librarian logged on system:";
            // 
            // nbAdminLog
            // 
            this.nbAdminLog.BorderCurve = 8;
            this.nbAdminLog.CausesValidation = false;
            this.nbAdminLog.Font = new System.Drawing.Font("Tahoma", 9F);
            this.nbAdminLog.Image = null;
            this.nbAdminLog.Location = new System.Drawing.Point(606, 152);
            this.nbAdminLog.MinimumSize = new System.Drawing.Size(100, 40);
            this.nbAdminLog.Name = "nbAdminLog";
            this.nbAdminLog.NotificationType = MonoFlat.MonoFlat_NotificationBox.Type.Warning;
            this.nbAdminLog.RoundCorners = false;
            this.nbAdminLog.ShowCloseButton = false;
            this.nbAdminLog.Size = new System.Drawing.Size(265, 90);
            this.nbAdminLog.TabIndex = 4;
            this.nbAdminLog.Text = "Only librarian with admin rights can register new workers to system.";
            // 
            // panelWorkers
            // 
            this.panelWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panelWorkers.Controls.Add(this.btnReturnAllLibrarians);
            this.panelWorkers.Controls.Add(this.btnAddLibrarian);
            this.panelWorkers.Controls.Add(this.monoFlat_HeaderLabel3);
            this.panelWorkers.Location = new System.Drawing.Point(606, 248);
            this.panelWorkers.Name = "panelWorkers";
            this.panelWorkers.Padding = new System.Windows.Forms.Padding(5);
            this.panelWorkers.Size = new System.Drawing.Size(265, 194);
            this.panelWorkers.TabIndex = 3;
            // 
            // btnReturnAllLibrarians
            // 
            this.btnReturnAllLibrarians.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnAllLibrarians.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReturnAllLibrarians.Image = global::ELibrary.Properties.Resources.workers;
            this.btnReturnAllLibrarians.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnAllLibrarians.Location = new System.Drawing.Point(24, 111);
            this.btnReturnAllLibrarians.Name = "btnReturnAllLibrarians";
            this.btnReturnAllLibrarians.Size = new System.Drawing.Size(217, 41);
            this.btnReturnAllLibrarians.TabIndex = 2;
            this.btnReturnAllLibrarians.Text = "See Workers";
            this.btnReturnAllLibrarians.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnReturnAllLibrarians.Click += new System.EventHandler(this.btnReturnAllLibrarians_Click);
            // 
            // btnAddLibrarian
            // 
            this.btnAddLibrarian.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLibrarian.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddLibrarian.Image = global::ELibrary.Properties.Resources.librarian;
            this.btnAddLibrarian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLibrarian.Location = new System.Drawing.Point(24, 65);
            this.btnAddLibrarian.Name = "btnAddLibrarian";
            this.btnAddLibrarian.Size = new System.Drawing.Size(217, 41);
            this.btnAddLibrarian.TabIndex = 1;
            this.btnAddLibrarian.Text = "Add new Librarian";
            this.btnAddLibrarian.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddLibrarian.Click += new System.EventHandler(this.btnAddLibrarian_Click);
            // 
            // monoFlat_HeaderLabel3
            // 
            this.monoFlat_HeaderLabel3.AutoSize = true;
            this.monoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel3.Image = global::ELibrary.Properties.Resources.worker;
            this.monoFlat_HeaderLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_HeaderLabel3.Location = new System.Drawing.Point(9, 9);
            this.monoFlat_HeaderLabel3.Name = "monoFlat_HeaderLabel3";
            this.monoFlat_HeaderLabel3.Size = new System.Drawing.Size(147, 20);
            this.monoFlat_HeaderLabel3.TabIndex = 0;
            this.monoFlat_HeaderLabel3.Text = "      Workers Section";
            // 
            // panelBooks
            // 
            this.panelBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panelBooks.Controls.Add(this.btnSearchBooks);
            this.panelBooks.Controls.Add(this.btnAddAuthor);
            this.panelBooks.Controls.Add(this.btnReturnAllBooks);
            this.panelBooks.Controls.Add(this.btnRegisterNewBook);
            this.panelBooks.Controls.Add(this.monoFlat_HeaderLabel2);
            this.panelBooks.Location = new System.Drawing.Point(321, 152);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Padding = new System.Windows.Forms.Padding(5);
            this.panelBooks.Size = new System.Drawing.Size(265, 290);
            this.panelBooks.TabIndex = 2;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearchBooks.Image = global::ELibrary.Properties.Resources.searchbook;
            this.btnSearchBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBooks.Location = new System.Drawing.Point(24, 160);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(217, 41);
            this.btnSearchBooks.TabIndex = 4;
            this.btnSearchBooks.Text = "Search Books";
            this.btnSearchBooks.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAuthor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddAuthor.Image = global::ELibrary.Properties.Resources.author;
            this.btnAddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAuthor.Location = new System.Drawing.Point(24, 207);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(217, 41);
            this.btnAddAuthor.TabIndex = 3;
            this.btnAddAuthor.Text = "Add new Author";
            this.btnAddAuthor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnReturnAllBooks
            // 
            this.btnReturnAllBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnAllBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReturnAllBooks.Image = global::ELibrary.Properties.Resources.allbooks;
            this.btnReturnAllBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnAllBooks.Location = new System.Drawing.Point(24, 112);
            this.btnReturnAllBooks.Name = "btnReturnAllBooks";
            this.btnReturnAllBooks.Size = new System.Drawing.Size(217, 41);
            this.btnReturnAllBooks.TabIndex = 2;
            this.btnReturnAllBooks.Text = "See Books";
            this.btnReturnAllBooks.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnReturnAllBooks.Click += new System.EventHandler(this.btnReturnAllBooks_Click);
            // 
            // btnRegisterNewBook
            // 
            this.btnRegisterNewBook.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisterNewBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegisterNewBook.Image = global::ELibrary.Properties.Resources.book;
            this.btnRegisterNewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterNewBook.Location = new System.Drawing.Point(24, 65);
            this.btnRegisterNewBook.Name = "btnRegisterNewBook";
            this.btnRegisterNewBook.Size = new System.Drawing.Size(217, 41);
            this.btnRegisterNewBook.TabIndex = 1;
            this.btnRegisterNewBook.Text = "Register new Book";
            this.btnRegisterNewBook.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRegisterNewBook.Click += new System.EventHandler(this.btnRegisterNewBook_Click);
            // 
            // monoFlat_HeaderLabel2
            // 
            this.monoFlat_HeaderLabel2.AutoSize = true;
            this.monoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel2.Image = global::ELibrary.Properties.Resources.books;
            this.monoFlat_HeaderLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_HeaderLabel2.Location = new System.Drawing.Point(9, 9);
            this.monoFlat_HeaderLabel2.Name = "monoFlat_HeaderLabel2";
            this.monoFlat_HeaderLabel2.Size = new System.Drawing.Size(128, 20);
            this.monoFlat_HeaderLabel2.TabIndex = 0;
            this.monoFlat_HeaderLabel2.Text = "       Book Section";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(796, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 1;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panelUsers.Controls.Add(this.btnSearchUsers);
            this.panelUsers.Controls.Add(this.btnReturnUnapprovedComments);
            this.panelUsers.Controls.Add(this.btnReturnAllUsers);
            this.panelUsers.Controls.Add(this.btnAddUser);
            this.panelUsers.Controls.Add(this.monoFlat_HeaderLabel1);
            this.panelUsers.Location = new System.Drawing.Point(31, 152);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Padding = new System.Windows.Forms.Padding(5);
            this.panelUsers.Size = new System.Drawing.Size(265, 290);
            this.panelUsers.TabIndex = 0;
            // 
            // btnSearchUsers
            // 
            this.btnSearchUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearchUsers.Image = global::ELibrary.Properties.Resources.searchuser;
            this.btnSearchUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUsers.Location = new System.Drawing.Point(24, 207);
            this.btnSearchUsers.Name = "btnSearchUsers";
            this.btnSearchUsers.Size = new System.Drawing.Size(217, 41);
            this.btnSearchUsers.TabIndex = 4;
            this.btnSearchUsers.Text = "Search Members";
            this.btnSearchUsers.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearchUsers.Click += new System.EventHandler(this.btnSearchUsers_Click);
            // 
            // btnReturnUnapprovedComments
            // 
            this.btnReturnUnapprovedComments.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnUnapprovedComments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReturnUnapprovedComments.Image = global::ELibrary.Properties.Resources.comments;
            this.btnReturnUnapprovedComments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnUnapprovedComments.Location = new System.Drawing.Point(24, 160);
            this.btnReturnUnapprovedComments.Name = "btnReturnUnapprovedComments";
            this.btnReturnUnapprovedComments.Size = new System.Drawing.Size(217, 41);
            this.btnReturnUnapprovedComments.TabIndex = 3;
            this.btnReturnUnapprovedComments.Text = "Comment Requests";
            this.btnReturnUnapprovedComments.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnReturnUnapprovedComments.Click += new System.EventHandler(this.btnReturnUnapprovedComments_Click);
            // 
            // btnReturnAllUsers
            // 
            this.btnReturnAllUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnAllUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReturnAllUsers.Image = global::ELibrary.Properties.Resources.allusers;
            this.btnReturnAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnAllUsers.Location = new System.Drawing.Point(24, 112);
            this.btnReturnAllUsers.Name = "btnReturnAllUsers";
            this.btnReturnAllUsers.Size = new System.Drawing.Size(217, 41);
            this.btnReturnAllUsers.TabIndex = 2;
            this.btnReturnAllUsers.Text = "See Members";
            this.btnReturnAllUsers.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnReturnAllUsers.Click += new System.EventHandler(this.btnReturnAllUsers_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddUser.Image = global::ELibrary.Properties.Resources.adduser;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(24, 65);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(217, 41);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Register new Member";
            this.btnAddUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Image = global::ELibrary.Properties.Resources.User;
            this.monoFlat_HeaderLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(9, 9);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(120, 20);
            this.monoFlat_HeaderLabel1.TabIndex = 0;
            this.monoFlat_HeaderLabel1.Text = "      User Section";
            // 
            // LibrarianMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 492);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibrarianMain";
            this.Text = "Library Managment System - Control Panel";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.panelWorkers.ResumeLayout(false);
            this.panelWorkers.PerformLayout();
            this.panelBooks.ResumeLayout(false);
            this.panelBooks.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_Panel panelUsers;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_Button btnAddUser;
        private MonoFlat.MonoFlat_Button btnReturnAllUsers;
        private MonoFlat.MonoFlat_Button btnReturnUnapprovedComments;
        private MonoFlat.MonoFlat_Button btnSearchUsers;
        private MonoFlat.MonoFlat_Panel panelBooks;
        private MonoFlat.MonoFlat_Button btnSearchBooks;
        private MonoFlat.MonoFlat_Button btnAddAuthor;
        private MonoFlat.MonoFlat_Button btnReturnAllBooks;
        private MonoFlat.MonoFlat_Button btnRegisterNewBook;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel2;
        private MonoFlat.MonoFlat_Panel panelWorkers;
        private MonoFlat.MonoFlat_Button btnReturnAllLibrarians;
        private MonoFlat.MonoFlat_Button btnAddLibrarian;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel3;
        private MonoFlat.MonoFlat_NotificationBox nbAdminLog;
        private MonoFlat.MonoFlat_LinkLabel lbName;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}