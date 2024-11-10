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

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
						// Clear existing rows in the DataGridView
						dataGridView1.Rows.Clear();

						// Retrieve all students from the DataHandler
						var students = studentDataHandler.GetAllStudents();

						// Add each student to the DataGridView
							foreach (var student in students)
							{
									dataGridView1.Rows.Add(student); // Add student data as a new row
							}
				}

				private void UpdateStudent_Click(object sender, EventArgs e)
				{
						// Check if a row is selected
						if (dataGridView1.SelectedRows.Count > 0)
						{
								// Get the selected row
								var selectedRow = dataGridView1.SelectedRows[0];

								// Retrieve the Student ID from the selected row
								string studentId = selectedRow.Cells[0].Value.ToString();

								// Get updated values from the text boxes
								string name = textBox2.Text;
								int age;

								// Validate age input
								if (!int.TryParse(textBox3.Text, out age))
								{
										MessageBox.Show("Please enter a valid age.");
										return; // Exit if validation fails
								}

								string course = textBox4.Text; // Retrieve course

								// Call the UpdateStudent method to update the student's information
								studentDataHandler.UpdateStudent(studentId, name, age, course);

								// Refresh the DataGrid View to show updated data
								ViewAllStudents_Click(sender, e); // Re-fetch and display students
						}
						else
						{
								MessageBox.Show("Please select a student to update."); // Message that diplays if no student is selected
						}
				}

				private void DeleteStudent_Click(object sender, EventArgs e)
						{
							// Check if a row is selected
							if (dataGridView1.SelectedRows.Count > 0)
							{
									// Get the selected row
									var selectedRow = dataGridView1.SelectedRows[0];

									// Retrieve the Student ID from the selected row
									string studentId = selectedRow.Cells[0].Value.ToString();

									// Confirm deletion with the user
									DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo);
									if (dialogResult == DialogResult.Yes)
									{
											// Call the DeleteStudent method to delete the student's information
											studentDataHandler.DeleteStudent(studentId);

											// Refresh the DataGridView to show updated data
											ViewAllStudents_Click(sender, e); // Re-fetch and display students
									}
							}
							else
							{
								MessageBox.Show("Please select a student to delete."); // Message shown if no student is selected
							}
				}

    

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
         
        }

				private void ClearInputFields()
				{	
						// Clear all input fields in the form
						textBox2.Clear();
						textBox1.Clear();
						textBox3.Clear();
						textBox4.Clear();
				}

				private void Form1_Load(object sender, EventArgs e)
				{

				}
		}
}
