using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            File.Filter = "txt files (*.txt)|*.txt|Excel Files| *.xls; *.xlsx; *.xlsm" ;
            if(File.ShowDialog()==DialogResult.OK)
            {
                Filename_txt.Text = File.SafeFileName;
                SaveFilee_txt.Text = File.FileName;

            }
        }

        private void Display_but_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            FileStream FS = new FileStream(File.FileName, FileMode.Open);
            string[] arr;

            StreamReader SR = new StreamReader(FS);
            List<Data> L = new List<Data>();
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("gender", "Gender");
            dataGridView1.Columns.Add("salary", "Salary");
            while (SR.Peek() != -1)
            {
                string record = SR.ReadLine();
                arr = record.Split('@');
                string id = arr[0];
                string name = arr[1];
                string gender = arr[2];
                string salary = arr[3];
                if (string.IsNullOrWhiteSpace(arr[0]))
                    arr[0] = "default:1";

                //  D = new Data(id, name, gender, salary);
                dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
            }
            SR.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
