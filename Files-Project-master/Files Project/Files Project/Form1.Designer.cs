﻿namespace Files_Project
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 131);
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
            this.Display_but.Location = new System.Drawing.Point(464, 17);
            this.Display_but.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Display_but.Name = "Display_but";
            this.Display_but.Size = new System.Drawing.Size(102, 88);
            this.Display_but.TabIndex = 4;
            this.Display_but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Display_but.Click += new System.EventHandler(this.Display_but_Click);
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
            this.OpenFile_btn.ButtonText = "Browse File";
            this.OpenFile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFile_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.IdleBorderThickness = 1;
            this.OpenFile_btn.IdleCornerRadius = 20;
            this.OpenFile_btn.IdleFillColor = System.Drawing.Color.White;
            this.OpenFile_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.Location = new System.Drawing.Point(17, 17);
            this.OpenFile_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(157, 41);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
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
            this.save_button.Location = new System.Drawing.Point(11, 458);
            this.save_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(176, 86);
            this.save_button.TabIndex = 5;
            this.save_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(497, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Not Null";
            // 
            // NotNull_text
            // 
            this.NotNull_text.Location = new System.Drawing.Point(602, 179);
            this.NotNull_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NotNull_text.Name = "NotNull_text";
            this.NotNull_text.Size = new System.Drawing.Size(76, 20);
            this.NotNull_text.TabIndex = 12;
            this.NotNull_text.TextChanged += new System.EventHandler(this.NotNull_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(497, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Default";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(489, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Primary Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(501, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Condition";
            // 
            // Default_text
            // 
            this.Default_text.Location = new System.Drawing.Point(602, 211);
            this.Default_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Default_text.Name = "Default_text";
            this.Default_text.Size = new System.Drawing.Size(76, 20);
            this.Default_text.TabIndex = 16;
            // 
            // Primary_text
            // 
            this.Primary_text.Location = new System.Drawing.Point(602, 247);
            this.Primary_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Primary_text.Name = "Primary_text";
            this.Primary_text.Size = new System.Drawing.Size(76, 20);
            this.Primary_text.TabIndex = 17;
            // 
            // Condition_text
            // 
            this.Condition_text.Location = new System.Drawing.Point(602, 283);
            this.Condition_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Condition_text.Name = "Condition_text";
            this.Condition_text.Size = new System.Drawing.Size(76, 20);
            this.Condition_text.TabIndex = 18;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.BackColor = System.Drawing.Color.Transparent;
            this.Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Value.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.ForeColor = System.Drawing.Color.White;
            this.Value.Location = new System.Drawing.Point(691, 213);
            this.Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(53, 21);
            this.Value.TabIndex = 5;
            this.Value.Text = "value";
            // 
            // value_text
            // 
            this.value_text.Location = new System.Drawing.Point(748, 213);
            this.value_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.value_text.Name = "value_text";
            this.value_text.Size = new System.Drawing.Size(76, 20);
            this.value_text.TabIndex = 19;
            this.value_text.TextChanged += new System.EventHandler(this.value_text_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 609);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

