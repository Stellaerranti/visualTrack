using System;
using System.IO;
using Wisej.Web;
using ClosedXML.Excel;

namespace ExportDGVToExcel
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();

			this.dataGridView1.DataSource = BuildDataSource();
		}

		public object BuildDataSource()
		{
			return new[] {
				new { person = "Albert", score = 100, isStudent = true, fees = 12.0500 },
				new { person = "Bob", score = 57, isStudent = false, fees = 13.4000 },
				new { person = "Carl", score = 84, isStudent = true, fees = 17.2000 },
				new { person = "Dean", score = 82, isStudent = false, fees = 15.7000 },
				new { person = "Edward", score = 76, isStudent = false, fees = 13.5500 },
				new { person = "Fred", score = 65, isStudent = true, fees = 16.4300 },
				new { person = "Greg", score = 43, isStudent = true, fees = 14.7500 },
			};
		}

		private void ExportDataGridView()
		{
			// New workbook
			using (var workbook = new XLWorkbook())
			{
				// New worksheet
				var worksheet = workbook.Worksheets.Add("DGVExport");
				// Log every cell in the DataGridView
				for (int i = 0; i < dataGridView1.Rows.Count; i++)
					for (int x = 0; x < dataGridView1.ColumnCount; x++)
					{
						var currentLetterNumber = x % 26;
						var currentLetter = (char)(currentLetterNumber + 65);
						worksheet.Cell($"{currentLetter}{(i + 1).ToString()}").Value = dataGridView1.Rows[i][x].Value;
					}

				// Saves the file to the project's root directory
				//workbook.SaveAs(Application.MapPath("myFile.xlsx"));

				// Save the file to a memory stream
				using (var fs = new MemoryStream())
				{	
					workbook.SaveAs(fs);

					// Set the position to the beginning of the stream
					fs.Position = 0;
					// Download the stream
					Application.Download(fs, "myFile.xlsx");
				}
			}
		}

		private void dataGridView1_ToolClick(object sender, ToolClickEventArgs e)
		{
			switch (e.Tool.Name)
			{
				case "Export":
					ExportDataGridView();
					break;

			}
		}
	}
}
