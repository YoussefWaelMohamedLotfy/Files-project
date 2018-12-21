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
            this.Display_but = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveFilee_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Filename_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.OpenFile_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.NotNull_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Default_text = new System.Windows.Forms.TextBox();
            this.Primary_text = new System.Windows.Forms.TextBox();
            this.Condition_text = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.Label();
            this.value_text = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 161);
            this.panel1.TabIndex = 0;
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
            this.Display_but.Location = new System.Drawing.Point(619, 21);
            this.Display_but.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Display_but.Name = "Display_but";
            this.Display_but.Size = new System.Drawing.Size(136, 108);
            this.Display_but.TabIndex = 4;
            this.Display_but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Display_but.Click += new System.EventHandler(this.Display_but_Click);
            // 
            // SaveFilee_txt
            // 
            this.SaveFilee_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.SaveFilee_txt.Location = new System.Drawing.Point(48, 81);
            this.SaveFilee_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveFilee_txt.Name = "SaveFilee_txt";
            this.SaveFilee_txt.ReadOnly = true;
            this.SaveFilee_txt.Size = new System.Drawing.Size(535, 22);
            this.SaveFilee_txt.TabIndex = 3;
            // 
            // Filename_txt
            // 
            this.Filename_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.Filename_txt.Location = new System.Drawing.Point(243, 36);
            this.Filename_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Filename_txt.Name = "Filename_txt";
            this.Filename_txt.ReadOnly = true;
            this.Filename_txt.Size = new System.Drawing.Size(343, 22);
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
            this.OpenFile_btn.ButtonText = "Browse File";
            this.OpenFile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFile_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.IdleBorderThickness = 1;
            this.OpenFile_btn.IdleCornerRadius = 20;
            this.OpenFile_btn.IdleFillColor = System.Drawing.Color.White;
            this.OpenFile_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.Location = new System.Drawing.Point(23, 21);
            this.OpenFile_btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(209, 50);
            this.OpenFile_btn.TabIndex = 1;
            this.OpenFile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(16, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 332);
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
            // save_button
            // 
            this.save_button.ActiveBorderThickness = 1;
            this.save_button.ActiveCornerRadius = 20;
            this.save_button.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.save_button.ActiveForecolor = System.Drawing.Color.White;
            this.save_button.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.save_button.BackColor = System.Drawing.Color.DarkGray;
            this.save_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_button.BackgroundImage")));
            this.save_button.ButtonText = "Save file as XML";
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.SeaGreen;
            this.save_button.IdleBorderThickness = 1;
            this.save_button.IdleCornerRadius = 20;
            this.save_button.IdleFillColor = System.Drawing.Color.White;
            this.save_button.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.save_button.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.save_button.Location = new System.Drawing.Point(15, 564);
            this.save_button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(235, 106);
            this.save_button.TabIndex = 5;
            this.save_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Not Null";
            // 
            // NotNull_text
            // 
            this.NotNull_text.Location = new System.Drawing.Point(802, 215);
            this.NotNull_text.Name = "NotNull_text";
            this.NotNull_text.Size = new System.Drawing.Size(100, 22);
            this.NotNull_text.TabIndex = 12;
            this.NotNull_text.TextChanged += new System.EventHandler(this.NotNull_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Primary Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Condition";
            // 
            // Default_text
            // 
            this.Default_text.Location = new System.Drawing.Point(802, 260);
            this.Default_text.Name = "Default_text";
            this.Default_text.Size = new System.Drawing.Size(100, 22);
            this.Default_text.TabIndex = 16;
            // 
            // Primary_text
            // 
            this.Primary_text.Location = new System.Drawing.Point(802, 304);
            this.Primary_text.Name = "Primary_text";
            this.Primary_text.Size = new System.Drawing.Size(100, 22);
            this.Primary_text.TabIndex = 17;
            // 
            // Condition_text
            // 
            this.Condition_text.Location = new System.Drawing.Point(802, 348);
            this.Condition_text.Name = "Condition_text";
            this.Condition_text.Size = new System.Drawing.Size(100, 22);
            this.Condition_text.TabIndex = 18;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(928, 265);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(42, 17);
            this.Value.TabIndex = 5;
            this.Value.Text = "value";
            // 
            // value_text
            // 
            this.value_text.Location = new System.Drawing.Point(997, 262);
            this.value_text.Name = "value_text";
            this.value_text.Size = new System.Drawing.Size(100, 22);
            this.value_text.TabIndex = 19;
            this.value_text.TextChanged += new System.EventHandler(this.value_text_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 766);
            this.Controls.Add(this.value_text);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Condition_text);
            this.Controls.Add(this.Primary_text);
            this.Controls.Add(this.Default_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NotNull_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Bunifu.Framework.UI.BunifuThinButton2 save_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NotNull_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Default_text;
        private System.Windows.Forms.TextBox Primary_text;
        private System.Windows.Forms.TextBox Condition_text;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.TextBox value_text;
    }
}

