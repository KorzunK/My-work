using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Curse_Work
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;

            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFile.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < FilmGridView.RowCount - 1; i++)
                        {
                            for (int j = 0; j < FilmGridView.ColumnCount - 1; j++)
                            {
                                myWritet.Write(FilmGridView.Rows[i].Cells[j].Value.ToString() + " ");
                            }
                            myWritet.WriteLine();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }

                    myStream.Close();
                }
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {

                if ((myStream = openFile.OpenFile()) != null)
                {
                    StreamReader myReader = new StreamReader(myStream);

                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myReader.ReadToEnd().Split('\n');
                        num = str1.Count();
                        //while ((inpstr = myReader.ReadLine()) != null)
                        //{
                        //    str[num] = new string(inpstr.ToCharArray());
                        //    num++;

                        //}
                        FilmGridView.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split(' ');
                            for (int j = 0; j < FilmGridView.ColumnCount; j++)
                            {
                                FilmGridView.Rows[i].Cells[j].Value = str[j];

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myReader.Close();
                    }
                }

            }
        }
}
