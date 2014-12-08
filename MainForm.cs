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
 
            DataGridViewTextBoxColumn firstColumn =
                new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn secondColumn =
                new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn thirdColumn =
                new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn fourthColumn =
                new DataGridViewTextBoxColumn();
           
            DataGridViewTextBoxColumn fifthColumn =
                new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn sixColumn =
                new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn seventhColumn =
                new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn eightColumn =
                new DataGridViewTextBoxColumn();


            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Genre", "Genre");
            dataGridView.Columns.Add("Release date", "Release date");
            dataGridView.Columns.Add("Director", "Director");
            dataGridView.Columns.Add("Company", "Company");
            dataGridView.Columns.Add("Duration", "Duration");
            dataGridView.Columns.Add("Format", "Format");
            dataGridView.Columns.Add("Quality", "Quality");
            

            DataGridViewCell firstCell =
                new DataGridViewTextBoxCell();

            DataGridViewCell secondCell =
                new DataGridViewTextBoxCell();

            DataGridViewCell thirdCell =
                new DataGridViewTextBoxCell();

            DataGridViewCell fourthCell =
                new DataGridViewTextBoxCell();

            DataGridViewCell fifthCell =
                new DataGridViewTextBoxCell();

            DataGridViewTextBoxCell sixCell =
                new DataGridViewTextBoxCell();

            DataGridViewTextBoxCell seventhCell =
                new DataGridViewTextBoxCell();

            DataGridViewTextBoxCell eightCell =
                new DataGridViewTextBoxCell();


            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(firstCell, secondCell, thirdCell, fourthCell, fifthCell, sixCell, seventhCell, eightCell);
            this.dataGridView.Rows.Add(row);
            
            firstCell = new DataGridViewTextBoxCell();
            secondCell = new DataGridViewTextBoxCell();
            thirdCell = new DataGridViewTextBoxCell();
            fourthCell = new DataGridViewTextBoxCell();
            fifthCell = new DataGridViewTextBoxCell();
            sixCell = new DataGridViewTextBoxCell();
            seventhCell = new DataGridViewTextBoxCell();
            eightCell = new DataGridViewTextBoxCell();
        }
    }
}
