namespace JeopardyAssignment
{
    public class Question
    {
        public string value { get; set; }
        public string category { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

        public override string ToString()
        {
            return string.Format("Category: {0} \n Value: {1} \n Question: {2} \n Answer: {3} \n ", category, value, question, answer);
        }
    }
}
