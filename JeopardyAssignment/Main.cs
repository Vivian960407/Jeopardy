﻿using System;

namespace JeopardyAssignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //WelcomeMessage.Welcome();

            var game = new Game();
            game.start();

            Console.ReadKey();
           
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

        }

    }
}