namespace ConnectCsharpToMysql
{
    partial class KONTO_USERS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ążkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.płytyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.cAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ążkiToolStripMenuItem,
            this.filmyToolStripMenuItem,
            this.płytyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ążkiToolStripMenuItem
            // 
            this.ążkiToolStripMenuItem.Name = "ążkiToolStripMenuItem";
            this.ążkiToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ążkiToolStripMenuItem.Text = "Książki";
            this.ążkiToolStripMenuItem.Click += new System.EventHandler(this.ążkiToolStripMenuItem_Click);
            // 
            // filmyToolStripMenuItem
            // 
            this.filmyToolStripMenuItem.Name = "filmyToolStripMenuItem";
            this.filmyToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.filmyToolStripMenuItem.Text = "Filmy";
            this.filmyToolStripMenuItem.Click += new System.EventHandler(this.filmyToolStripMenuItem_Click);
            // 
            // płytyToolStripMenuItem
            // 
            this.płytyToolStripMenuItem.Name = "płytyToolStripMenuItem";
            this.płytyToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.płytyToolStripMenuItem.Text = "Płyty";
            this.płytyToolStripMenuItem.Click += new System.EventHandler(this.płytyToolStripMenuItem_Click);
            // 
            // dgDisplay
            // 
            this.dgDisplay.AllowUserToAddRows = false;
            this.dgDisplay.AllowUserToDeleteRows = false;
            this.dgDisplay.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAge,
            this.Author_name});
            this.dgDisplay.Location = new System.Drawing.Point(0, 36);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.ReadOnly = true;
            this.dgDisplay.RowHeadersVisible = false;
            this.dgDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDisplay.Size = new System.Drawing.Size(405, 138);
            this.dgDisplay.TabIndex = 28;
            this.dgDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplay_CellContentClick);
            // 
            // cAge
            // 
            this.cAge.HeaderText = "TYTUL";
            this.cAge.Name = "cAge";
            this.cAge.ReadOnly = true;
            this.cAge.Width = 200;
            // 
            // Author_name
            // 
            this.Author_name.HeaderText = "AUTOR";
            this.Author_name.Name = "Author_name";
            this.Author_name.ReadOnly = true;
            this.Author_name.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Wyjdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KONTO_USERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KONTO_USERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.KONTO_USERS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ążkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem płytyToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_name;
        private System.Windows.Forms.Button button1;
    }
}