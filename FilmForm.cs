using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace CWork
{
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();

            FilmGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FilmGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void SaveFile()
        {
            FileStream fs = new FileStream("Film.xml", FileMode.Create);
            XmlTextWriter xmlOut = new XmlTextWriter(fs, Encoding.Unicode);
            xmlOut.Formatting = Formatting.Indented;

            xmlOut.WriteStartDocument();


            for (int i = 0; i < FilmGridView.RowCount; i++)
            {
                xmlOut.WriteStartElement("Film");
                xmlOut.WriteStartElement("FilmName");
                xmlOut.WriteAttributeString("Value", (string)FilmGridView.Rows[i].Cells[0].Value);
                xmlOut.WriteEndElement();
                xmlOut.WriteStartElement("ReleaseYear");
                xmlOut.WriteAttributeString("Value", (string)FilmGridView.Rows[i].Cells[1].Value);
                xmlOut.WriteEndElement();
                xmlOut.WriteStartElement("Genre");
                xmlOut.WriteAttributeString("Value", (string)FilmGridView.Rows[i].Cells[2].Value);
                xmlOut.WriteEndElement();
                xmlOut.WriteStartElement("Director");
                xmlOut.WriteAttributeString("Value", (string)FilmGridView.Rows[i].Cells[3].Value);
                xmlOut.WriteEndElement();
                xmlOut.WriteStartElement("Company");
                xmlOut.WriteAttributeString("Value", (string)FilmGridView.Rows[i].Cells[4].Value);
                xmlOut.WriteEndElement();
                xmlOut.WriteStartElement("Format");
                xmlOut.WriteAttributeString("Value", (string)FilmGridView.Rows[i].Cells[5].Value);
                xmlOut.WriteEndElement();
                xmlOut.WriteStartElement("Quality");
                xmlOut.WriteAttributeString("Value", (string)FilmGridView.Rows[i].Cells[6].Value);
                xmlOut.WriteEndElement();
                xmlOut.WriteEndElement();
            }

            xmlOut.Close();
            fs.Close();
        }

       
        private void LoadFile()
        {
            int index = -1;

            FilmGridView.Rows.Clear();

            DataTable dt = new DataTable();
            FileStream fs = new FileStream("Film.xml", FileMode.Open);
            XmlTextReader xmlIn = new XmlTextReader(fs);

            while (xmlIn.Read())
            {
                if (xmlIn.NodeType == XmlNodeType.EndElement) { continue; }

                if (xmlIn.Name == "Film")
                {
                    FilmGridView.Rows.Add();
                    index++;
                }

                if (xmlIn.Name == "FilmName")
                {
                    FilmGridView.Rows[index].Cells[0].Value = xmlIn.GetAttribute("Value");
                }

                if (xmlIn.Name == "ReleaseYear")
                {
                    FilmGridView.Rows[index].Cells[1].Value = xmlIn.GetAttribute("Value");
                }

                if (xmlIn.Name == "Genre")
                {
                    FilmGridView.Rows[index].Cells[2].Value = xmlIn.GetAttribute("Value");
                }

                if (xmlIn.Name == "Director")
                {
                    FilmGridView.Rows[index].Cells[3].Value = xmlIn.GetAttribute("Value");
                }

                if (xmlIn.Name == "Company")
                {
                    FilmGridView.Rows[index].Cells[4].Value = xmlIn.GetAttribute("Value");
                }

                if (xmlIn.Name == "Format")
                {
                    FilmGridView.Rows[index].Cells[5].Value = xmlIn.GetAttribute("Value");
                }

                if (xmlIn.Name == "Quality")
                {
                    FilmGridView.Rows[index].Cells[6].Value = xmlIn.GetAttribute("Value");
                }

            }

            xmlIn.Close();
            fs.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            FilmGridView.Rows.Add();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int index = FilmGridView.CurrentRow.Index;
            FilmGridView.Rows.RemoveAt(index);
            string[] data = new string[FilmGridView.Rows.Count];
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Xml_save_button_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Xml_load_button_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
        
        private void search_button_Click(object sender, EventArgs e)
        {
            if (Search_textBox.Text == String.Empty)
            {
                MessageBox.Show("Input something");
            }

            for (int i = 0; i < FilmGridView.RowCount; i++)
            {
                FilmGridView.Rows[i].Selected = false;
                for (int j = 0; j < FilmGridView.ColumnCount; j++)
                    if (FilmGridView.Rows[i].Cells[j].Value != null)

                            if (FilmGridView.Rows[i].Cells[j].Value.ToString().Contains(Search_textBox.Text))
                            {
                                FilmGridView.Rows[i].Selected = true;
                                break;
                            }
                        
            }
        }
    }
