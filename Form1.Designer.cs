﻿using System.Windows.Forms;

namespace StudentManagementSystem
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.studentName = new System.Windows.Forms.Label();
			this.StudentID = new System.Windows.Forms.Label();
			this.Age = new System.Windows.Forms.Label();
			this.Course = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.AddStudent = new System.Windows.Forms.Button();
			this.UpdateStudent = new System.Windows.Forms.Button();
			this.DeleteStudent = new System.Windows.Forms.Button();
			this.ViewAllStudents = new System.Windows.Forms.Button();
			this.GenerateReport = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// studentName
			// 
			this.studentName.AutoSize = true;
			this.studentName.Location = new System.Drawing.Point(51, 29);
			this.studentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.studentName.Name = "studentName";
			this.studentName.Size = new System.Drawing.Size(54, 13);
			this.studentName.TabIndex = 0;
			this.studentName.Text = "Full Name";
			// 
			// StudentID
			// 
			this.StudentID.AutoSize = true;
			this.StudentID.Location = new System.Drawing.Point(50, 67);
			this.StudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.StudentID.Name = "StudentID";
			this.StudentID.Size = new System.Drawing.Size(55, 13);
			this.StudentID.TabIndex = 1;
			this.StudentID.Text = "StudentID";
			// 
			// Age
			// 
			this.Age.AutoSize = true;
			this.Age.Location = new System.Drawing.Point(53, 98);
			this.Age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Age.Name = "Age";
			this.Age.Size = new System.Drawing.Size(26, 13);
			this.Age.TabIndex = 2;
			this.Age.Text = "Age";
			// 
			// Course
			// 
			this.Course.Location = new System.Drawing.Point(53, 134);
			this.Course.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Course.Name = "Course";
			this.Course.Size = new System.Drawing.Size(52, 20);
			this.Course.TabIndex = 3;
			this.Course.Text = "Course";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(109, 29);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(114, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(109, 64);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(114, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(109, 98);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(114, 20);
			this.textBox3.TabIndex = 6;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(109, 134);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(114, 20);
			this.textBox4.TabIndex = 7;
			// 
			// AddStudent
			// 
			this.AddStudent.Location = new System.Drawing.Point(245, 329);
			this.AddStudent.Margin = new System.Windows.Forms.Padding(2);
			this.AddStudent.Name = "AddStudent";
			this.AddStudent.Size = new System.Drawing.Size(69, 19);
			this.AddStudent.TabIndex = 8;
			this.AddStudent.Text = "Add Student";
			this.AddStudent.UseVisualStyleBackColor = true;
			this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
			// 
			// UpdateStudent
			// 
			this.UpdateStudent.Location = new System.Drawing.Point(318, 329);
			this.UpdateStudent.Margin = new System.Windows.Forms.Padding(2);
			this.UpdateStudent.Name = "UpdateStudent";
			this.UpdateStudent.Size = new System.Drawing.Size(84, 19);
			this.UpdateStudent.TabIndex = 9;
			this.UpdateStudent.Text = "Update Student";
			this.UpdateStudent.UseVisualStyleBackColor = true;
			this.UpdateStudent.Click += new System.EventHandler(this.UpdateStudent_Click);
			// 
			// DeleteStudent
			// 
			this.DeleteStudent.Location = new System.Drawing.Point(498, 329);
			this.DeleteStudent.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteStudent.Name = "DeleteStudent";
			this.DeleteStudent.Size = new System.Drawing.Size(80, 19);
			this.DeleteStudent.TabIndex = 10;
			this.DeleteStudent.Text = "Delete Student";
			this.DeleteStudent.UseVisualStyleBackColor = true;
			this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
			// 
			// ViewAllStudents
			// 
			this.ViewAllStudents.Location = new System.Drawing.Point(406, 329);
			this.ViewAllStudents.Margin = new System.Windows.Forms.Padding(2);
			this.ViewAllStudents.Name = "ViewAllStudents";
			this.ViewAllStudents.Size = new System.Drawing.Size(88, 19);
			this.ViewAllStudents.TabIndex = 11;
			this.ViewAllStudents.Text = "View All Students";
			this.ViewAllStudents.UseVisualStyleBackColor = true;
			this.ViewAllStudents.Click += new System.EventHandler(this.ViewAllStudents_Click);
			// 
			// GenerateReport
			// 
			this.GenerateReport.Location = new System.Drawing.Point(582, 329);
			this.GenerateReport.Margin = new System.Windows.Forms.Padding(2);
			this.GenerateReport.Name = "GenerateReport";
			this.GenerateReport.Size = new System.Drawing.Size(90, 19);
			this.GenerateReport.TabIndex = 12;
			this.GenerateReport.Text = "Generate Report";
			this.GenerateReport.UseVisualStyleBackColor = true;
			this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(245, 46);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(439, 254);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 455);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.GenerateReport);
			this.Controls.Add(this.ViewAllStudents);
			this.Controls.Add(this.DeleteStudent);
			this.Controls.Add(this.UpdateStudent);
			this.Controls.Add(this.AddStudent);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Course);
			this.Controls.Add(this.Age);
			this.Controls.Add(this.StudentID);
			this.Controls.Add(this.studentName);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label studentName;
		private System.Windows.Forms.Label StudentID;
		private System.Windows.Forms.Label Age;
		private System.Windows.Forms.Label Course;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button AddStudent;
		private System.Windows.Forms.Button UpdateStudent;
		private System.Windows.Forms.Button DeleteStudent;
		private System.Windows.Forms.Button ViewAllStudents;
		private System.Windows.Forms.Button GenerateReport;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}