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
            fileDialog.Filter = "txt files (*.txt)|*.txt|Excel Files| *.xls; *.xlsx; *.xlsm";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Filename_txt.Text = fileDialog.SafeFileName;
                SaveFilee_txt.Text = fileDialog.FileName;

            }
        }

        private void Display_but_Click(object sender, EventArgs e)
        {
            string NotNull = NotNull_text.Text;
            string Def = Default_text.Text;
            string Primary_key = Primary_text.Text;
            string Condition = Condition_text.Text;
            string Value = value_text.Text;
            List<string> l1 = new List<string>();
            

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
                if (NotNull == "" && Def == "" && Primary_key == "" && Condition == "")
                {
                    //  D = new Data(id, name, gender, salary);
                    dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                }

                if (NotNull != "")
                {
                    if (NotNull == "Name" || NotNull == "name")
                    {
                        if (arr[1] == "")
                        {
                            MessageBox.Show("Name shouldn't be empty");
                            continue;
                        }
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }
                    else if (NotNull == "ID" || NotNull == "id")
                    {
                        if (arr[0] == "")
                        {
                            MessageBox.Show("ID shouldn't be empty");

                            continue;
                        }
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }

                    else if (NotNull == "Gender" || NotNull == "Gender")
                    {
                        if (arr[2] == "")
                        {
                            MessageBox.Show("Gender shouldn't be empty");
                            continue;
                        }
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);

                    }
                    else if (NotNull == "Salary" || NotNull == "salary")
                    {
                        if (arr[3] == "")
                        {
                            MessageBox.Show("Salary shouldn't be empty");
                            continue;
                        }
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }
                }
                if (Def != "")
                {
                    if (Def == "id" || Def == "ID")
                    {
                        if (arr[0] == "")
                        {
                            arr[0] = Value;
                        }
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }
                    else if (Def == "name" || Def == "Name")
                    {
                        if (arr[1] == "")
                        {
                            arr[1] = Value;
                        }
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }
                    else if (Def == "Gender" || Def == "gender")
                    {
                        if (arr[2] == "")
                        {
                            arr[2] = Value;
                        }
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }
                    else if (Def == "Salary" || Def == "salary")
                    {
                        if (arr[3] == "")
                        {
                            arr[3] = Value;
                        }
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }

                }
                /* if (Primary_key != "")
                 {
                 }
                 dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                 for (int i = 0; i < dataGridView1.Rows.Count; i++)
                 {
                     dataGridView1.Rows[1].Visible = false;
                 }
             }
             */

                if (Primary_key != "")
                {
                    if (Primary_key == "ID" || Primary_key == "id")
                    {
                        if (l1.Contains(arr[0]))
                        {
                            MessageBox.Show("ID should be unique");
                          
                            continue;
                        }
                        l1.Add(arr[0]);

                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }

                    else if (Primary_key == "Name" || Primary_key == "name")
                    {
                        if (l1.Contains(arr[1]))
                        {
                            MessageBox.Show("Name should be unique");
                            continue;
                        }
                        l1.Add(arr[1]);
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }

                  else if (Primary_key == "Gender" || Primary_key == "gender")
                    {
                        if (l1.Contains(arr[2]))
                        {
                            MessageBox.Show("Gender should be unique");
                            continue;
                        }
                        l1.Add(arr[2]);
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }
                    

                    else if (Primary_key == "Salary" || Primary_key == "salary")
                    {
                        if (l1.Contains(arr[3]))
                        {
                            MessageBox.Show("Salary should be unique");
                            continue;
                        }
                        l1.Add(arr[3]);
                        dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                    }

                }

        } // Out of the loop
            //if (Primary_key != "")
            //{
            //    if (Primary_key == "id" || Primary_key == "ID")
            //    {
            //        for (int i = 0; i < dataGridView1.RowCount; i++)
            //        {
            //           for 
            //        }
            //    }
            //}

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

        private void NotNull_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void value_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
