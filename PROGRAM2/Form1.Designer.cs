namespace ConnectCsharpToMysql
{
    partial class Form1
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
            this.bBackup = new System.Windows.Forms.Button();
            this.bRestore = new System.Windows.Forms.Button();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ciD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // bBackup
            // 
            this.bBackup.Location = new System.Drawing.Point(529, 79);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(75, 23);
            this.bBackup.TabIndex = 5;
            this.bBackup.Text = "Backup";
            this.bBackup.UseVisualStyleBackColor = true;
            this.bBackup.Click += new System.EventHandler(this.bBackup_Click);
            // 
            // bRestore
            // 
            this.bRestore.Location = new System.Drawing.Point(448, 79);
            this.bRestore.Name = "bRestore";
            this.bRestore.Size = new System.Drawing.Size(75, 23);
            this.bRestore.TabIndex = 6;
            this.bRestore.Text = "Restore";
            this.bRestore.UseVisualStyleBackColor = true;
            this.bRestore.Click += new System.EventHandler(this.bRestore_Click);
            // 
            // dgDisplay
            // 
            this.dgDisplay.AllowUserToAddRows = false;
            this.dgDisplay.AllowUserToDeleteRows = false;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciD,
            this.cName,
            this.cAge,
            this.Author_name,
            this.Column2,
            this.Column3});
            this.dgDisplay.Location = new System.Drawing.Point(0, 108);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.ReadOnly = true;
            this.dgDisplay.RowHeadersVisible = false;
            this.dgDisplay.Size = new System.Drawing.Size(604, 230);
            this.dgDisplay.TabIndex = 7;
            this.dgDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplay_CellContentClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 428);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Autor";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 452);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tytu³";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 403);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(364, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 54);
            this.button2.TabIndex = 19;
            this.button2.Text = "DODAJ KSI¥¯KÊ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "SUKAJ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(258, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 54);
            this.button3.TabIndex = 21;
            this.button3.Text = "DODAJ FILM";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(470, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 54);
            this.button4.TabIndex = 22;
            this.button4.Text = "DODAJ MUZE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "SUPER PROGRAIK DLA STARYCH PAÑ BIBLIOTEKAREK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ciD
            // 
            this.ciD.HeaderText = "id_resources";
            this.ciD.Name = "ciD";
            this.ciD.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "Id__Kind";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cAge
            // 
            this.cAge.HeaderText = "Title";
            this.cAge.Name = "cAge";
            this.cAge.ReadOnly = true;
            // 
            // Author_name
            // 
            this.Author_name.HeaderText = "Author_name";
            this.Author_name.Name = "Author_name";
            this.Author_name.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Is_available";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Is_reserve";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(256, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "DODAJ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(603, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dgDisplay);
            this.Controls.Add(this.bRestore);
            this.Controls.Add(this.bBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Csharp To Mysql";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBackup;
        private System.Windows.Forms.Button bRestore;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
    }
}

