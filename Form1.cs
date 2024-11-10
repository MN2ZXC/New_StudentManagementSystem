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
						// Retrieve input values from text boxes
						string studentId = textBox2.Text;
						string name = textBox1.Text;
						int age;

						// Validatinng input values
						if (!int.TryParse(textBox3.Text, out age) || string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(name))
						{
								MessageBox.Show("Invalid input. Please enter a valid Student ID, Name, and Age.");
								return; // Exit if validation fails
						}

						string course = textBox4.Text; // Retrieve course

						// Call the AddStudent method to add the new student
						studentDataHandler.AddStudent(studentId, name, age, course);

						// Clear input fields after adding the student
						ClearInputFields();
						MessageBox.Show("Student added successfully!");
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

				private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
				{
						// Ensure the clicked cell is not a header and there are rows in the DataGridView
						if (e.RowIndex >= 0 && dataGridView1.Rows.Count > 0)
						{
								// Get the selected row
								var selectedRow = dataGridView1.Rows[e.RowIndex];

								// Populate the text boxes with student's details
								textBox1.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
								textBox2.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
								textBox3.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
								textBox4.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
						}
				}

		private void ClearInputFields()
				{	
						// Clear all input fields in the form
						textBox2.Clear();
						textBox1.Clear();
						textBox3.Clear();
						textBox4.Clear();
				}
		}
}
