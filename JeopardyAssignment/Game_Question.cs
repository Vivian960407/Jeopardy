﻿using System;
using System.Collections.Generic;
using System.IO;

namespace JeopardyAssignment
{

    public class Game_Question
    {
        public List<Question> Questions = new List<Question>();

        //FileReader
        public void QuestionMaker()
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


        public void show_one_question()
        {
            Console.WriteLine(Questions[5].value);
        }

        //Dessa metoder ska förklaras senare
        public void Question_Sorter() 
        {
            
        }


        public int Random_Generator()
        {
            Random rand = new Random();
            int index = rand.Next(0, Questions.Count);
            return index;
        }

        public int Random_Q_Generator(int value)
        {
            bool control = true;
            int index = 0;
            do
            {
                int j = Random_Generator();
                for (int i = 0; i < Questions.Count; i++)
                {
                    if (i != j)
                        continue;
                    else
                    {
                        if (Questions[i].value == Convert.ToString(value))
                        {
                            index = j;
                            control = false;
                        }
                        else
                            break;
                    }
                }
            } while (control);
            Console.WriteLine("The question you picked is from {0} category. \n {1}", Questions[index].category, Questions[index].question);
            return index;
        }

        public void Question_Remover(int index)
        {
            Questions.RemoveAt(index);
        }


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
