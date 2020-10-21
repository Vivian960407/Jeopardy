using System;
using System.Collections.Generic;
using System.IO;

namespace JeopardyAssignment
{
    public class Game_Question
    {
        public List<Question> Questions = new List<Question>();
        public List<Question> random_question = new List<Question>();

        //FileReader
        public void QuestionMaker()
        {
            char tab = Convert.ToChar(9);
            string temp;
            string[] splited_line;

            using StreamReader file = new StreamReader("questionMaster.txt", true);
            while ((temp = file.ReadLine()) != null)
            {
                splited_line = temp.Split(tab);
                if (splited_line[0] == "1" && splited_line.Length == 9)
                {
                    Questions.Add(new Question
                    {
                        value = splited_line[1],
                        category = splited_line[3],
                        question = splited_line[5].ToLower(),
                        answer = splited_line[6].ToLower()
                    });
                }
                else
                    continue;
            }
            file.Close();
        }

        public int Random_Generator(int count)
        {
            Random rand = new Random();
            int index = rand.Next(0, count);
            return index;
        }

        public int Question_Finder(string category)
        {
            int index = -1;
            for (int i = 0; i < random_question.Count; i++)
            {
                if (random_question[i].category != category)
                    continue;
                else
                {
                    if (random_question[i].accessibility == Q.played)
                        continue;
                    else
                    {
                        index = i;
                        break;
                    }
                }
            }

            if (index == -1)
                Console.WriteLine("There are no more available questions in this category!");
            else
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("You picked {0} category:", random_question[index].category);
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("This question is worth {0} points", random_question[index].value);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Question: {0}", random_question[index].question);
                Console.WriteLine("------------------------------------------------------------------");
                random_question[index].accessibility_controller();
            }
            return index;
        }

        public void List_Categories()
        {
            Console.WriteLine("(1){0}  (2){1}  (3){2}  (4){3}  (5){4}", random_question[0].category, random_question[5].category, random_question[10].category, random_question[15].category, random_question[20].category);
        }

        public string Category(int choice)
        {
            switch (choice)
            {
                case 1:
                    return random_question[0].category;
                case 2:
                    return random_question[5].category;
                case 3:
                    return random_question[10].category;
                case 4:
                    return random_question[15].category;
                default:
                    return random_question[20].category;
            }
        }

        //Probably will get removed
        public void Question_Remover(int index)
        {
            random_question.RemoveAt(index);
        }

        public string Answer_Checker(int index)
        {
            Console.WriteLine("Input what you think the question for this answer is: ");
            //Console.WriteLine(random_question[index].answer); //TEMPORARLY SHOW ANSWER FOR TESTING!!
            string inputQuestion = Console.ReadLine();

            if (random_question[index].answer.Contains(inputQuestion))
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine(inputQuestion + " is correct!");
                Console.WriteLine("----------------------------------");
                return random_question[index].value;
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine(inputQuestion + " is wrong! The correct answer is " + random_question[index].answer);
                Console.WriteLine("---------------------------------------------------------------------");
                int temp = -1 * Int32.Parse(random_question[index].value);
                return Convert.ToString(temp);
            }


        }


        //The following method picks 5 categories randomly fore every new game
        public void Question_Sorter()
        {
            int round_count = 0;
            while (round_count < 5)
            {
                while (true)
                {
                    List<Question> question = new List<Question>();
                    int index_rand = Random_Generator(Questions.Count);
                    for (int i = 0; i < Questions.Count; i++)
                    {
                        if (i != index_rand)
                            continue;
                        else
                        {
                            foreach (var x in Questions)
                            {
                                if (x.category == Questions[index_rand].category)
                                {
                                    question.Add(x);
                                }
                            }
                        }
                    }

                    //Some categories contain less than 5 questions
                    if (question.Count != 5)
                        continue;
                    else
                    {
                        //sort the temporary random list
                        for (int i = 0; i < question.Count; i++)
                        {
                            Question temp;
                            for (int j = 0; j < question.Count; j++)
                            {
                                if ((Convert.ToInt32(question[i].value)) < (Convert.ToInt32(question[j].value)))
                                {
                                    temp = question[i];
                                    question[i] = question[j];
                                    question[j] = temp;
                                }
                            }
                        }

                        //remove the items from the origin list
                        for (int i = 0; i < Questions.Count; i++)
                        {
                            if (Questions[i].category != question[0].category)
                                continue;
                            else
                                Questions.RemoveAt(i);
                        }

                        random_question.AddRange(question);
                        break;
                    }
                }
                round_count++;
            }
        }


        //Följande metod är endast till test-körning
        /*  public void Qprinter()
          {
              foreach (var x in random_question)
              {
                  Console.WriteLine(x);
              }
          }*/
    }
};
