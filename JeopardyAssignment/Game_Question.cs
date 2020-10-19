using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace JeopardyAssignment
{

    public class Game_Question
    {
        public List<Question> Questions = new List<Question>();

        //FileReader
        public  void QuestionMaker()
        {
            char tab = Convert.ToChar(9);
            string temp;
            string[] splited_line;

            using (StreamReader file = new StreamReader("questionMaster.txt", true))
            {
                while ((temp = file.ReadLine()) != null)
                {
                    splited_line = temp.Split(tab);
                    if (splited_line[0] == "1" && splited_line.Length == 9)
                    {
                        Questions.Add(new Question
                        {
                            value = splited_line[1],
                            category = splited_line[3],
                            question = splited_line[5],
                            answer = splited_line[6]
                        });
                    }
                    else
                        continue;
                }

                file.Close();
            }
        }

        public void show_One_Question()
        {
            Console.WriteLine("This question is worth " + Questions[5].value + " points");
            Console.WriteLine(Questions[5].question);
            Console.WriteLine("Input what you think the question for this answer is: ");
            string inputQuestion = Console.ReadLine();

            if (Questions[5].answer.Contains(inputQuestion))
            {
                Console.WriteLine(inputQuestion + " is correct!");
                Player.WinQuestion += Questions[5].value;
                
            }
            else
            {
                Console.WriteLine(inputQuestion + " is wrong! The correct answer is " + Questions[5].answer);
            }
        }
        //Dessa metoder ska förklaras senare
        public void Question_Sorter() { }

        public void Random_Q_Generator() { }

       

        //Följande metod är endast till test-körning
        //public void Qprinter()
        //{
        //    foreach (var x in Questions)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}
    }
};
