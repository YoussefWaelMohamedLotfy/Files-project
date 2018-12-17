using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OpenFileDialog File = new OpenFileDialog();
        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            File.Filter = "txt files (*.txt)|*.txt";;
            if(File.ShowDialog()==DialogResult.OK)
            {
                Filename_txt.Text = File.SafeFileName;
                SaveFilee_txt.Text = File.FileName;

            }
        }
    }
}
