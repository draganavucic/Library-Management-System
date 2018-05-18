namespace ELibrary
{
    partial class SeeUsers
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
            this.btnExpUsers = new MonoFlat.MonoFlat_Button();
            this.btnNonExpUsers = new MonoFlat.MonoFlat_Button();
            this.btnAllUsers = new MonoFlat.MonoFlat_Button();
            this.usersList = new MetroFramework.Controls.MetroGrid();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).BeginInit();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnExpUsers);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnNonExpUsers);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnAllUsers);
            this.monoFlat_ThemeContainer1.Controls.Add(this.usersList);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(1179, 550);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "List of all Library members";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(1067, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 9;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // btnExpUsers
            // 
            this.btnExpUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnExpUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExpUsers.Image = null;
            this.btnExpUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpUsers.Location = new System.Drawing.Point(696, 487);
            this.btnExpUsers.Name = "btnExpUsers";
            this.btnExpUsers.Size = new System.Drawing.Size(206, 41);
            this.btnExpUsers.TabIndex = 8;
            this.btnExpUsers.Text = "Show Expired Users";
            this.btnExpUsers.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExpUsers.Click += new System.EventHandler(this.btnExpUsers_Click);
            // 
            // btnNonExpUsers
            // 
            this.btnNonExpUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnNonExpUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNonExpUsers.Image = null;
            this.btnNonExpUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNonExpUsers.Location = new System.Drawing.Point(484, 487);
            this.btnNonExpUsers.Name = "btnNonExpUsers";
            this.btnNonExpUsers.Size = new System.Drawing.Size(206, 41);
            this.btnNonExpUsers.TabIndex = 7;
            this.btnNonExpUsers.Text = "Show Non-expired Users";
            this.btnNonExpUsers.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnNonExpUsers.Click += new System.EventHandler(this.btnNonExpUsers_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnAllUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAllUsers.Image = null;
            this.btnAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllUsers.Location = new System.Drawing.Point(272, 487);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(206, 41);
            this.btnAllUsers.TabIndex = 6;
            this.btnAllUsers.Text = "Show All Users";
            this.btnAllUsers.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // usersList
            // 
            this.usersList.AllowUserToResizeRows = false;
            this.usersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersList.EnableHeadersVisualStyles = false;
            this.usersList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersList.Location = new System.Drawing.Point(12, 73);
            this.usersList.Name = "usersList";
            this.usersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.usersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersList.Size = new System.Drawing.Size(1153, 396);
            this.usersList.Style = MetroFramework.MetroColorStyle.Red;
            this.usersList.TabIndex = 5;
            this.usersList.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SeeUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 550);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeUsers";
            this.Text = "List of all Library members";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MetroFramework.Controls.MetroGrid usersList;
        private MonoFlat.MonoFlat_Button btnExpUsers;
        private MonoFlat.MonoFlat_Button btnNonExpUsers;
        private MonoFlat.MonoFlat_Button btnAllUsers;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
    }
}