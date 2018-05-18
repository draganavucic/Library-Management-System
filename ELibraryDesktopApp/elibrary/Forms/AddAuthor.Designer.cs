namespace ELibrary
{
    partial class AddAuthor
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
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.tbYear = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Separator1 = new MonoFlat.MonoFlat_Separator();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.btnAddAuthor = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label4 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.tbBiography = new MonoFlat.MonoFlat_TextBox();
            this.tbName = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.tbYear);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Separator1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnAddAuthor);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label4);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label3);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.tbBiography);
            this.monoFlat_ThemeContainer1.Controls.Add(this.tbName);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(546, 408);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Add New Author";
            // 
            // tbYear
            // 
            this.tbYear.BackColor = System.Drawing.Color.Transparent;
            this.tbYear.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.tbYear.Image = null;
            this.tbYear.Location = new System.Drawing.Point(284, 111);
            this.tbYear.MaxLength = 32767;
            this.tbYear.Multiline = false;
            this.tbYear.Name = "tbYear";
            this.tbYear.ReadOnly = false;
            this.tbYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbYear.Size = new System.Drawing.Size(205, 41);
            this.tbYear.TabIndex = 22;
            this.tbYear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbYear.UseSystemPasswordChar = false;
            // 
            // monoFlat_Separator1
            // 
            this.monoFlat_Separator1.Location = new System.Drawing.Point(13, 284);
            this.monoFlat_Separator1.Name = "monoFlat_Separator1";
            this.monoFlat_Separator1.Size = new System.Drawing.Size(521, 14);
            this.monoFlat_Separator1.TabIndex = 21;
            this.monoFlat_Separator1.Text = "monoFlat_Separator1";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(434, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 20;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAuthor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddAuthor.Image = global::ELibrary.Properties.Resources.author;
            this.btnAddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAuthor.Location = new System.Drawing.Point(152, 328);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(217, 41);
            this.btnAddAuthor.TabIndex = 19;
            this.btnAddAuthor.Text = "Save New Author";
            this.btnAddAuthor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // monoFlat_Label4
            // 
            this.monoFlat_Label4.AutoSize = true;
            this.monoFlat_Label4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label4.Location = new System.Drawing.Point(284, 90);
            this.monoFlat_Label4.Name = "monoFlat_Label4";
            this.monoFlat_Label4.Size = new System.Drawing.Size(60, 15);
            this.monoFlat_Label4.TabIndex = 17;
            this.monoFlat_Label4.Text = "Birth Year:";
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label3.Location = new System.Drawing.Point(52, 168);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(64, 15);
            this.monoFlat_Label3.TabIndex = 15;
            this.monoFlat_Label3.Text = "Biography:";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(52, 90);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(64, 15);
            this.monoFlat_Label1.TabIndex = 13;
            this.monoFlat_Label1.Text = "Full Name:";
            // 
            // tbBiography
            // 
            this.tbBiography.BackColor = System.Drawing.Color.Transparent;
            this.tbBiography.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbBiography.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.tbBiography.Image = null;
            this.tbBiography.Location = new System.Drawing.Point(55, 186);
            this.tbBiography.MaxLength = 32767;
            this.tbBiography.Multiline = true;
            this.tbBiography.Name = "tbBiography";
            this.tbBiography.ReadOnly = false;
            this.tbBiography.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBiography.Size = new System.Drawing.Size(434, 71);
            this.tbBiography.TabIndex = 11;
            this.tbBiography.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbBiography.UseSystemPasswordChar = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.tbName.Image = null;
            this.tbName.Location = new System.Drawing.Point(52, 111);
            this.tbName.MaxLength = 32767;
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = false;
            this.tbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbName.Size = new System.Drawing.Size(205, 41);
            this.tbName.TabIndex = 10;
            this.tbName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.UseSystemPasswordChar = false;
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 408);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAuthor";
            this.Text = "Add New Author";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_Label monoFlat_Label4;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_TextBox tbBiography;
        private MonoFlat.MonoFlat_TextBox tbName;
        private MonoFlat.MonoFlat_Button btnAddAuthor;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_Separator monoFlat_Separator1;
        private MonoFlat.MonoFlat_TextBox tbYear;
    }
}