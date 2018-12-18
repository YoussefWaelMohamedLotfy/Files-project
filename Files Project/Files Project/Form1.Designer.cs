namespace Files_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveFilee_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Filename_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.OpenFile_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Display_but = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Display_but);
            this.panel1.Controls.Add(this.SaveFilee_txt);
            this.panel1.Controls.Add(this.Filename_txt);
            this.panel1.Controls.Add(this.OpenFile_btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 131);
            this.panel1.TabIndex = 0;
            // 
            // SaveFilee_txt
            // 
            this.SaveFilee_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.SaveFilee_txt.Location = new System.Drawing.Point(36, 66);
            this.SaveFilee_txt.Name = "SaveFilee_txt";
            this.SaveFilee_txt.ReadOnly = true;
            this.SaveFilee_txt.Size = new System.Drawing.Size(402, 20);
            this.SaveFilee_txt.TabIndex = 3;
            // 
            // Filename_txt
            // 
            this.Filename_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.Filename_txt.Location = new System.Drawing.Point(182, 29);
            this.Filename_txt.Name = "Filename_txt";
            this.Filename_txt.ReadOnly = true;
            this.Filename_txt.Size = new System.Drawing.Size(258, 20);
            this.Filename_txt.TabIndex = 2;
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.ActiveBorderThickness = 1;
            this.OpenFile_btn.ActiveCornerRadius = 20;
            this.OpenFile_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.ActiveForecolor = System.Drawing.Color.White;
            this.OpenFile_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.BackColor = System.Drawing.Color.Transparent;
            this.OpenFile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFile_btn.BackgroundImage")));
            this.OpenFile_btn.ButtonText = "Open File";
            this.OpenFile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFile_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.IdleBorderThickness = 1;
            this.OpenFile_btn.IdleCornerRadius = 20;
            this.OpenFile_btn.IdleFillColor = System.Drawing.Color.White;
            this.OpenFile_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.Location = new System.Drawing.Point(17, 17);
            this.OpenFile_btn.Margin = new System.Windows.Forms.Padding(5);
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(157, 41);
            this.OpenFile_btn.TabIndex = 1;
            this.OpenFile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // Display_but
            // 
            this.Display_but.ActiveBorderThickness = 1;
            this.Display_but.ActiveCornerRadius = 20;
            this.Display_but.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Display_but.ActiveForecolor = System.Drawing.Color.White;
            this.Display_but.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Display_but.BackColor = System.Drawing.Color.Transparent;
            this.Display_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Display_but.BackgroundImage")));
            this.Display_but.ButtonText = "Open File";
            this.Display_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Display_but.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_but.ForeColor = System.Drawing.Color.SeaGreen;
            this.Display_but.IdleBorderThickness = 1;
            this.Display_but.IdleCornerRadius = 20;
            this.Display_but.IdleFillColor = System.Drawing.Color.White;
            this.Display_but.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Display_but.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Display_but.Location = new System.Drawing.Point(464, 17);
            this.Display_but.Margin = new System.Windows.Forms.Padding(5);
            this.Display_but.Name = "Display_but";
            this.Display_but.Size = new System.Drawing.Size(102, 88);
            this.Display_but.TabIndex = 4;
            this.Display_but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Display_but.Click += new System.EventHandler(this.Display_but_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 270);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Salary";
            this.Column4.Name = "Column4";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Open File";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(496, 362);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(102, 88);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 464);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 OpenFile_btn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SaveFilee_txt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Filename_txt;
        private Bunifu.Framework.UI.BunifuThinButton2 Display_but;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}

