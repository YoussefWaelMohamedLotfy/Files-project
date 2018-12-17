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
            this.OpenFile_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Filename_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SaveFilee_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SaveFilee_txt);
            this.panel1.Controls.Add(this.Filename_txt);
            this.panel1.Controls.Add(this.OpenFile_btn);
            this.panel1.Location = new System.Drawing.Point(49, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 131);
            this.panel1.TabIndex = 0;
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.ActiveBorderThickness = 1;
            this.OpenFile_btn.ActiveCornerRadius = 20;
            this.OpenFile_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.ActiveForecolor = System.Drawing.Color.White;
            this.OpenFile_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.OpenFile_btn.BackColor = System.Drawing.Color.Transparent;
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
            // Filename_txt
            // 
            this.Filename_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.Filename_txt.Location = new System.Drawing.Point(182, 29);
            this.Filename_txt.Name = "Filename_txt";
            this.Filename_txt.ReadOnly = true;
            this.Filename_txt.Size = new System.Drawing.Size(258, 20);
            this.Filename_txt.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 232);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 OpenFile_btn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox SaveFilee_txt;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Filename_txt;
    }
}

