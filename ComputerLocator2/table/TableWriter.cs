using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerLocator2.filereader; 

namespace ComputerLocator2.table
{
    class TableWriter
    {

        public void WriteTableToConsole(DataGridView table)
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                String valueToWrite = "";

                foreach (DataGridViewCell cell in row.Cells)
                {
                    valueToWrite += cell.Value.ToString();
                }
                
                Console.WriteLine(valueToWrite);
            }
        }

        public void WriteTableToFile(string filePath, string fileName, DataGridView table)
        {


            if (table.Rows.Count > 0)
            {
                FileWriter writer = new FileWriter(filePath, fileName);

                foreach (DataGridViewRow row in table.Rows)
                {
                    String valueToWrite = "";

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        valueToWrite += cell.Value.ToString();
                    }

                    writer.WriteLine(valueToWrite);
                }

                writer.CloseWriter();

                MessageBox.Show("Saved file to following location: " + filePath + fileName);
            }
            else
            {
                MessageBox.Show("Nothing to save");
            }
        }
    }
}
