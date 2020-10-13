using System;
using System.Collections.Generic;
using System.Text;
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
                while ((temp = file.ReadLine()) != null )
                {
                    splited_line = temp.Split(tab);
                    if (splited_line[0] == "1" && splited_line.Length == 9)
                    {
                        Questions.Add(new Question{
                            value = splited_line[1],
                            category = splited_line[3],
                            question = splited_line[5],
                            answer = splited_line[6]});
                    }
                    else
                        continue;
                }

                file.Close();
            }
        }

        //Dessa metoder ska förklaras senare
        public void Question_Sorter() { }

        public void Random_Q_Generator() { }


        //Följande metod är endast till test-körning
      /*  public void Qprinter()
        {
            foreach(var x in Questions)
            {
                Console.WriteLine(x);
            }
        }*/
    }
};
