using System;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace Jeopardy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i;
            DataTable datatable = new DataTable();
            Console.Write("What season do you want to play?");
            string Choosen_Season = Console.ReadLine().ToLower();
            StreamReader streamreader = new StreamReader(@"C:\Users\marcu\source\repos\JeopardyAssignment\jeopardy_clue_dataset-master\" + Choosen_Season + ".tsv");
            char[] delimiter = new char[] { '\t' };
            string[] columnheaders = streamreader.ReadLine().Split(delimiter);
            foreach (string columnheader in columnheaders)
            {
                datatable.Columns.Add(columnheader);
            }

            while (streamreader.Peek() > 0)
            {
                DataRow datarow = datatable.NewRow();
                datarow.ItemArray = streamreader.ReadLine().Split(delimiter);
                datatable.Rows.Add(datarow);
            }

            foreach (DataRow row in datatable.Rows) 
            {
                Console.WriteLine();

                foreach (DataColumn column in datatable.Columns)
                {
                    if (column.ColumnName == "value" ||
                        column.ColumnName == "category" ||
                        column.ColumnName == "question" ||
                        column.ColumnName == "answer" ||
                        column.ColumnName == "air_date")
                    {
                        Console.Write(column.ColumnName);
                        Console.Write(" ");
                        Console.WriteLine(row[column]);
                    }
                }
            }

            
            Console.ReadLine();

            Console.WriteLine("Testing");
            Console.WriteLine("Pull");
            Console.WriteLine("Function");
        }

    }
}