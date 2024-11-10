using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataHandler
{

		// Define the file path where student data will be stored
		private const string FilePath = "students.txt";
	
	// Method to add a new student
		public void AddStudent(string studentId, string name, int age, string course)
		{
				// Create a comma-separated record string for the student
				string record = $"{studentId},{name},{age},{course}";

				// Append the new record to the file, with a new line
				File.AppendAllText(FilePath, record + Environment.NewLine);
		}
	
		// Method to retrieve all student records from file
		public List<string[]> GetAllStudents()
		{
			// Initialize a list to hold student data arrays
			var students = new List<string[]>();

		// Check if the file exists before attempting to read
				if (File.Exists(FilePath))
						{
						// Read all lines from file
						var lines = File.ReadAllLines(FilePath);

							// Process each line and split it into an array of strings
								foreach (var line in lines)
								{
										var data = line.Split(','); // Split the line into components
										students.Add(data); // Add the array to the list of students
								}
				}

				// Return the list of student data arrays
				return students;
		}

		// Method to update existing student's record
		public void UpdateStudent(string studentId, string name, int age, string course)
		{
				// Read all lines from the file into a list
				var lines = File.ReadAllLines(FilePath).ToList();

				// Loop through each line to find the student record that needs to be updated
				for (int i = 0; i < lines.Count; i++)
				{
							// Check if the current line starts with the specified student ID
							if (lines[i].StartsWith(studentId + ","))
							{
									// Update the line with the new student information
									lines[i] = $"{studentId},{name},{age},{course}";
									break; // Exit the loop after update
							}
				}

				// Write the updated lines back to the file
				File.WriteAllLines(FilePath, lines);
		}

			// Method to delete a student record from the file
			public void DeleteStudent(string studentId)
			{
					// Read all lines from file into list
					var lines = File.ReadAllLines(FilePath).ToList();

					// Remove all lines that start with the specified student ID
					lines.RemoveAll(line => line.StartsWith(studentId + ","));

					// Write the remaining lines back to file
					File.WriteAllLines(FilePath, lines);
			}

			// Method to generate a report of total students and average age
			public (int totalStudents, double averageAge) GenerateReport()
			{
					// Check if the file exists; if not, return zero students and average age
					if (!File.Exists(FilePath))
					{
							return (0, 0);
					}

					// Read all lines from the file
					var lines = File.ReadAllLines(FilePath);

					// Calculate the total number of students
					int totalStudents = lines.Length;

					// Calculate the average age by parsing the age from each record
					double averageAge = lines.Select(line => int.Parse(line.Split(',')[2])).Average();

					// Return the total number of students and the average age
					return (totalStudents, averageAge);
			}
}
