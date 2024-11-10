using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace StudentManagementSystem
{
	  public partial class Form1 : Form
	  {
		    // The DataHandler being used for student data
		    private readonly DataHandler studentDataHandler = new DataHandler();

		    public Form1()
		    {
			      InitializeComponent(); // Form component Initialization 
			      InitializeDataGridView(); // DataGridView to display student data
		    }

		    private void InitializeDataGridView()
		    {
			      // Clear existing columns if there are any
			      dataGridView1.Columns.Clear();

			      // Defines the number of columns and their full names in the DataGridView
			      dataGridView1.ColumnCount = 4;
			      dataGridView1.Columns[0].Name = "Student ID";
			      dataGridView1.Columns[1].Name = "Name";
			      dataGridView1.Columns[2].Name = "Age";
			      dataGridView1.Columns[3].Name = "Course";
		    }

		private void AddStudent_Click(object sender, EventArgs e)
        {

        }


        private void ViewAllStudents_Click(object sender, EventArgs e)
        {
     
            }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
         
        }

        private void ClearFields()
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
