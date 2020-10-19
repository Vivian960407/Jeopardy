using System;

namespace JeopardyAssignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WelcomeMessage.Welcome();

            var game = new Game_Question();
            game.QuestionMaker();

            game.show_one_question();

            //Följande rad är endast för test-körning av koden
            //game.Qprinter();

            Console.ReadKey();
            /* DataTable datatable = new DataTable();
             Console.Write("What season do you want to play? ");
             string Choosen_Season = Console.ReadLine().ToLower();

             string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName);
             StreamReader streamreader = new StreamReader(startupPath + @"\jeopardy_clue_dataset\" + Choosen_Season + ".tsv");

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

             var randomRowIndex = 5;
             var randomRow = datatable.Rows[randomRowIndex];
             for (int i = 0; i < datatable.Columns.Count; i++)
             {
                 if (datatable.Columns[i].ToString() == "answer")
                     Console.WriteLine(datatable.Columns[i].ToString() + ": " + randomRow[i]);

                 if (datatable.Columns[i].ToString() == "question")
                     Console.WriteLine(datatable.Columns[i].ToString() + ": " + randomRow[i]);
             }
             //------------------------------------------------------------------------------------------------------
             //var filePath = startupPath + @"\jeopardy_clue_dataset\" + Choosen_Season + ".tsv";
             //var question_input = File.ReadAllLines(filePath);

             Console.WriteLine("What´s the question to this answer?");
             var inputQuestion = Console.ReadLine();

             for (int i = 0; i < datatable.Columns.Count; i++)
             {
                 if (datatable.Columns[i].ToString() == "question")
                 {
                     //if (inputQuestion.Equals(Convert.ToString(datatable.Columns[i].ToString() + ": " + randomRow[i]), StringComparison.OrdinalIgnoreCase))
                     if (inputQuestion.Equals(randomRow[i].ToString(), StringComparison.OrdinalIgnoreCase))
                     {

                         Console.WriteLine("Correct");
                     }
                     else
                     {
                         Console.WriteLine("Wrong");
                     }
                     break;
                 }

             }



             //------------------------------------------------------------------------------------------------------

             //------------------------------------------------------------------------------------------------------
             //string[] words = input_question.Split();
             //char delimiter_question = '\t';
             //IEnumerable<string> matchingLines = File.ReadLines(startupPath + @"\jeopardy_clue_dataset\" + Choosen_Season + ".tsv")
             //    .Where(line => words.Intersect(line.Split(delimiter_question)).Any())
             //    .ToList();


             //foreach (DataRow row in datatable.Rows) 
             //{
             //    Console.WriteLine();

             //    foreach (DataColumn column in datatable.Columns)
             //    {
             //        if (column.ColumnName == "value" ||
             //            column.ColumnName == "category" ||
             //            column.ColumnName == "question" ||
             //            column.ColumnName == "answer" ||
             //            column.ColumnName == "air_date")
             //        {
             //            Console.Write(column.ColumnName);
             //            Console.Write(" ");
             //            Console.WriteLine(row[column]);
             //        }
             //    }
             //}
             //------------------------------------------------------------------------------------------------------

             Console.ReadLine();

             Console.WriteLine("Testing");
             Console.WriteLine("Pull");
             Console.WriteLine("Function");*/
        }

    }
}