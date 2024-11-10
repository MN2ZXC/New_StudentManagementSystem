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
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "Student ID";
                dataGridView1.Columns[1].Name = "Name";
                dataGridView1.Columns[2].Name = "Age";
                dataGridView1.Columns[3].Name = "Course";
            

        }



        private void AddStudent_Click(object sender, EventArgs e)
        {


            
            string studentId = textBox2.Text;
            string name = textBox1.Text;
            int age;
            if (!int.TryParse(textBox3.Text, out age) || string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Invalid input. Please enter a valid Student ID, Name, and Age.");
                return;
            }
            string course = textBox4.Text;

            
            string record = $"{studentId},{name},{age},{course}";
            File.AppendAllText("students.txt", record + Environment.NewLine);

            
            DisplayStudents();

            
            ClearInputFields();
            MessageBox.Show("Student added successfully!");
        }

            private void ClearInputFields()
            {
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

        private void ViewAllStudents_Click(object sender, EventArgs e)
        {
           
                dataGridView1.Rows.Clear(); 
                if (File.Exists("students.txt"))
                {
                    var lines = File.ReadAllLines("students.txt");
                    foreach (var line in lines)
                    {
                        var data = line.Split(',');
                        dataGridView1.Rows.Add(data);
                    }
                }
            }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Student ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Course");

            foreach (var line in File.ReadLines("students.txt"))
            {
                var values = line.Split(',');
                dt.Rows.Add(values);
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("students.txt").ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(textBox2.Text + ","))
                {
                    lines[i] = $"{textBox2.Text},{textBox1.Text},{textBox3.Text},{textBox4.Text}";
                    break;
                }
            }
            File.WriteAllLines("students.txt", lines);
            MessageBox.Show("Student updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("students.txt").ToList();
            lines.RemoveAll(line => line.StartsWith(textBox2.Text + ","));
            File.WriteAllLines("students.txt", lines);
            MessageBox.Show("Student deleted successfully.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                string studentDetails = $"{textBox2.Text}{textBox1.Text},{textBox3.Text},{textBox4.Text}\n";
                File.AppendAllText("students.txt", studentDetails);
                MessageBox.Show("Student added successfully.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var lines = File.ReadAllLines("students.txt");
                if (lines.Length == 0)
                {
                    MessageBox.Show("No students to report.");
                    return;
                }

                int totalStudents = lines.Length;
                double averageAge = lines.Select(line => int.Parse(line.Split(',')[2])).Average();

                File.WriteAllText("summary.txt", $"Total Students: {totalStudents}\nAverage Age: {averageAge}");
                MessageBox.Show($"Total Students: {totalStudents}\nAverage Age: {averageAge}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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
