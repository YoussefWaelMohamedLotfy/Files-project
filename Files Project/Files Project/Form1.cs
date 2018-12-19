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
using System.Xml;

namespace Files_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OpenFileDialog fileDialog = new OpenFileDialog();
        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            fileDialog.Filter = "txt files (*.txt)|*.txt|Excel Files| *.xls; *.xlsx; *.xlsm" ;
            if(fileDialog.ShowDialog()==DialogResult.OK)
            {
                Filename_txt.Text = fileDialog.SafeFileName;
                SaveFilee_txt.Text = fileDialog.FileName;

            }
        }

        private void Display_but_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            FileStream FS = new FileStream(fileDialog.FileName, FileMode.Open);
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

        private void save_button_Click(object sender, EventArgs e)
        {

            XmlWriter writer = XmlWriter.Create("NewFile1.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("Records");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                writer.WriteStartElement("Person");
                writer.WriteStartAttribute("ID");
                writer.WriteValue(dataGridView1.Rows[i].Cells[0].Value.ToString());
                writer.WriteEndAttribute();
                writer.WriteEndElement();

                writer.WriteStartElement("Person");
                writer.WriteStartAttribute("Name");
                writer.WriteValue(dataGridView1.Rows[i].Cells[1].Value.ToString());
                writer.WriteEndAttribute();
                writer.WriteEndElement();

                writer.WriteStartElement("Person");
                writer.WriteStartAttribute("Gender");
                writer.WriteValue(dataGridView1.Rows[i].Cells[2].Value.ToString());
                writer.WriteEndAttribute();
                writer.WriteEndElement();

                writer.WriteStartElement("Person");
                writer.WriteStartAttribute("Salary");
                writer.WriteValue(dataGridView1.Rows[i].Cells[3].Value.ToString());
                writer.WriteEndAttribute();
                writer.WriteEndElement();


              
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            //if (!File.Exists("NewFile1.xml"))
            //{
            //    XmlWriterSettings settings = new XmlWriterSettings { ConformanceLevel = ConformanceLevel.Document };
            //    XmlWriter writer = XmlWriter.Create("NewFile1.xml");

            //    writer.WriteStartDocument();
            //    writer.WriteStartElement("RecordBig");
            //    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            //    {
            //        writer.WriteStartElement("Record"); // Record open tag

            //        writer.WriteStartElement("ID");
            //        MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //        writer.WriteString(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //        writer.WriteEndElement();

            //        writer.WriteStartElement("Name");
            //        MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        writer.WriteString(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //        writer.WriteEndElement();

            //        writer.WriteStartElement("Gender");
            //        MessageBox.Show(dataGridView1.Rows[i].Cells[2].Value.ToString());
            //        writer.WriteString(dataGridView1.Rows[i].Cells[2].Value.ToString());
            //        writer.WriteEndElement();

            //        writer.WriteStartElement("Salary");
            //        MessageBox.Show(dataGridView1.Rows[i].Cells[3].Value.ToString());
            //        writer.WriteString(dataGridView1.Rows[i].Cells[3].Value.ToString());
            //        writer.WriteEndElement();

            //         ================================ Errors are caused here ===================================
            //         writer.WriteEndElement(); ; // Record closing tag
            //    }

            //    writer.WriteEndDocument();
            //    writer.Close();

            //else // For overwriting
            {
                //XmlWriterSettings settings = new XmlWriterSettings { ConformanceLevel = ConformanceLevel.Document };
                //XmlWriter writer = XmlWriter.Create("NewFile1.xml");

                //writer.WriteStartDocument();

                //for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                //{
                //    writer.WriteStartElement("Record"); // Record open tag

                //    writer.WriteStartElement("ID");
                //    MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
                //    writer.WriteString(dataGridView1.Rows[i].Cells[0].Value.ToString());
                //    writer.WriteEndElement();

                //    writer.WriteStartElement("Name");
                //    writer.WriteString(dataGridView1.Rows[i].Cells[1].Value.ToString());
                //    writer.WriteEndElement();

                //    writer.WriteStartElement("Gender");
                //    writer.WriteString(dataGridView1.Rows[i].Cells[2].Value.ToString());
                //    writer.WriteEndElement();

                //    writer.WriteStartElement("Salary");
                //    writer.WriteString(dataGridView1.Rows[i].Cells[3].Value.ToString());
                //    writer.WriteEndElement();

                //    writer.WriteEndElement(); // Record closing tag
                //}

                //writer.WriteEndDocument();
                //writer.Close();
            }


            MessageBox.Show("Saved successfully!");
        }
    }
}
