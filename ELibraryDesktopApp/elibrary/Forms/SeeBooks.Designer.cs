namespace ELibrary
{
    partial class SeeBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.btnBusyBooks = new MonoFlat.MonoFlat_Button();
            this.btnAvailableBooks = new MonoFlat.MonoFlat_Button();
            this.btnAllBooks = new MonoFlat.MonoFlat_Button();
            this.booksList = new MetroFramework.Controls.MetroGrid();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksList)).BeginInit();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnBusyBooks);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnAvailableBooks);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnAllBooks);
            this.monoFlat_ThemeContainer1.Controls.Add(this.booksList);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(874, 421);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "List of all Books";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(762, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 12;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // btnBusyBooks
            // 
            this.btnBusyBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnBusyBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBusyBooks.Image = null;
            this.btnBusyBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusyBooks.Location = new System.Drawing.Point(552, 360);
            this.btnBusyBooks.Name = "btnBusyBooks";
            this.btnBusyBooks.Size = new System.Drawing.Size(206, 41);
            this.btnBusyBooks.TabIndex = 11;
            this.btnBusyBooks.Text = "Show Not Available Books";
            this.btnBusyBooks.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBusyBooks.Click += new System.EventHandler(this.btnBusyBooks_Click);
            // 
            // btnAvailableBooks
            // 
            this.btnAvailableBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnAvailableBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAvailableBooks.Image = null;
            this.btnAvailableBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableBooks.Location = new System.Drawing.Point(340, 360);
            this.btnAvailableBooks.Name = "btnAvailableBooks";
            this.btnAvailableBooks.Size = new System.Drawing.Size(206, 41);
            this.btnAvailableBooks.TabIndex = 10;
            this.btnAvailableBooks.Text = "Show Available Books";
            this.btnAvailableBooks.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAvailableBooks.Click += new System.EventHandler(this.btnAvailableBooks_Click);
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnAllBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAllBooks.Image = null;
            this.btnAllBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllBooks.Location = new System.Drawing.Point(128, 360);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(206, 41);
            this.btnAllBooks.TabIndex = 9;
            this.btnAllBooks.Text = "Show All Books";
            this.btnAllBooks.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // booksList
            // 
            this.booksList.AllowUserToOrderColumns = true;
            this.booksList.AllowUserToResizeRows = false;
            this.booksList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.booksList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksList.DefaultCellStyle = dataGridViewCellStyle2;
            this.booksList.EnableHeadersVisualStyles = false;
            this.booksList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.booksList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksList.Location = new System.Drawing.Point(28, 91);
            this.booksList.Name = "booksList";
            this.booksList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.booksList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.booksList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksList.Size = new System.Drawing.Size(816, 252);
            this.booksList.Style = MetroFramework.MetroColorStyle.Red;
            this.booksList.TabIndex = 6;
            this.booksList.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SeeBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 421);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeBooks";
            this.Text = "List of all Books";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MetroFramework.Controls.MetroGrid booksList;
        private MonoFlat.MonoFlat_Button btnBusyBooks;
        private MonoFlat.MonoFlat_Button btnAvailableBooks;
        private MonoFlat.MonoFlat_Button btnAllBooks;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
    }
}