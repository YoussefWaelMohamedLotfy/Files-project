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
        List<string> mylist;
        string record;
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
            string Delemiter = Del_txt.Text;

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            FileStream FS = new FileStream(fileDialog.FileName, FileMode.Open);
            string[] arr;
            mylist = new List<string>();
            StreamReader SR = new StreamReader(FS);

            int counter = 0;

            while (SR.Peek() != -1)
            {
                record = SR.ReadLine();
                arr = record.Split(Delemiter[0]);

                string id = arr[0];
                string name = arr[1];
                string gender = arr[2];
                string salary = arr[3];

                mylist.Add(id);
                mylist.Add(name);
                mylist.Add(gender);
                mylist.Add(salary);

                if (counter == 0)
                {
                    dataGridView1.Columns.Add(arr[0], arr[0]);
                    dataGridView1.Columns.Add(arr[1], arr[1]);
                    dataGridView1.Columns.Add(arr[2], arr[2]);
                    dataGridView1.Columns.Add(arr[3], arr[3]);

                    counter = counter + 1;
                }
                else
                {
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


                    if (Primary_key != "")
                    {
                        if (Primary_key == "ID" || Primary_key == "id")
                        {
                            if (l1.Contains(arr[0]))
                            {
                                MessageBox.Show("ID should be unique");

                                break;
                            }
                            l1.Add(arr[0]);

                            dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                        }

                        else if (Primary_key == "Name" || Primary_key == "name")
                        {
                            if (l1.Contains(arr[1]))
                            {
                                MessageBox.Show("Name should be unique");
                                break;
                            }
                            l1.Add(arr[1]);
                            dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                        }

                        else if (Primary_key == "Gender" || Primary_key == "gender")
                        {
                            if (l1.Contains(arr[2]))
                            {
                                MessageBox.Show("Gender should be unique");
                                break;
                            }
                            l1.Add(arr[2]);
                            dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                        }


                        else if (Primary_key == "Salary" || Primary_key == "salary")
                        {
                            if (l1.Contains(arr[3]))
                            {
                                MessageBox.Show("Salary should be unique");
                                break;
                            }
                            l1.Add(arr[3]);
                            dataGridView1.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                        }

                    }
                }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
           
        }

        private void null_but_Click(object sender, EventArgs e)
        {
            if(Null_combo.SelectedItem.ToString()=="ID")
            {
                for(int i=0;i<dataGridView1.Rows.Count-1; i++)
                {
                 
                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Id column has a Null value ");
                        break;
                    }
                }
            }
            else if(Null_combo.SelectedItem.ToString() == "Name")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("Name column has a Null value ");
                        break;
                    }
                }
            }
            else if(Null_combo.SelectedItem.ToString() == "Gender")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                    {
                        MessageBox.Show("Gender column has a Null value ");
                        break;
                    }
                }
            }
            else if(Null_combo.SelectedItem.ToString() == "Salary")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                    {
                        MessageBox.Show("Salary column has a Null value ");
                        break;
                    }
                }
            }
           
        }

        private void default_but_Click(object sender, EventArgs e)
        {
            String default_valu=Default_txt.Text;
            if (Default_combo.SelectedItem.ToString() == "ID")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                    {
                        dataGridView1.Rows[i].Cells[0].Value = default_valu;
                        mylist[i+0+dataGridView1.Columns.Count] = default_valu;
                    }
                }
            }
            else if (Default_combo.SelectedItem.ToString() == "Name")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                    {
                        dataGridView1.Rows[i].Cells[1].Value = default_valu;
                        
                    }
                }
            }
            else if (Default_combo.SelectedItem.ToString() == "Gender")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                    {
                        dataGridView1.Rows[i].Cells[2].Value = default_valu;
                        
                    }
                }
            }
            else if (Default_combo.SelectedItem.ToString() == "Salary")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    if (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                    {
                        dataGridView1.Rows[i].Cells[3].Value = default_valu;
                        
                    }
                }
            }
        }

        private void check_but_Click(object sender, EventArgs e)
        {
            int Checkvalue = Convert.ToInt32( Check_txt.Text);

          if(Check_combo.SelectedItem.ToString()== "Data Greater than Value")
          {
                for (int i = 1; i < dataGridView1.Rows.Count-1;i++)
                {
                    int  temp = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    if ( Checkvalue > temp)
                    {
                        MessageBox.Show("Error1 ");
                        break;
                    }

                }
          }
          else if(Check_combo.SelectedItem.ToString() == " Data Smaller than Value")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int temp = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    if (Checkvalue < temp)
                    {
                        MessageBox.Show("Error2 ");
                        break;
                    }

                }
            }
          else if(Check_combo.SelectedItem.ToString() == " Data Equale  Value")
          {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int temp = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    if (Checkvalue != temp)
                    {
                        MessageBox.Show("Error3 ");
                        break;
                    }

                }
            }
        }

        private void Primary_but_Click(object sender, EventArgs e)
        {
            if (Primary_combo.SelectedItem.ToString() == "ID")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = i + 1; j < dataGridView1.Rows.Count - 1; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView1.Rows[j].Cells[0].Value.ToString())
                        {

                            MessageBox.Show("Dupplicated");
                            break;
                        }
                    }
                }
            }

            if (Primary_combo.SelectedItem.ToString() == "Salary")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = i + 1; j < dataGridView1.Rows.Count - 1; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[3].Value.ToString() == dataGridView1.Rows[j].Cells[3].Value.ToString())
                        {

                            MessageBox.Show("Dupplicated");
                            break;
                        }
                    }
                }
            }

            if (Primary_combo.SelectedItem.ToString() == "Gender")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = i + 1; j < dataGridView1.Rows.Count - 1; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == dataGridView1.Rows[j].Cells[2].Value.ToString())
                        {

                            MessageBox.Show("Dupplicated");
                            break;
                        }
                    }
                }
            }
            else if(Primary_combo.SelectedItem.ToString() == "Name")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = i + 1; j < dataGridView1.Rows.Count - 1; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == dataGridView1.Rows[j].Cells[1].Value.ToString())
                        {

                            MessageBox.Show("Dupplicated");
                            break;
                        }
                    }
                }

            }
        }

        private void Check_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
