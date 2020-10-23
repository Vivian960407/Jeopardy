namespace JeopardyAssignment
{
    public enum Q
    {
        played,
        available
    }
    public class Question
    {
        public Q accessibility = Q.available;
        public string value { get; set; }
        public string category { get; set; }
        public string question { get; set; }
        public string answer { get; set; }


        public void accessibility_controller()
        {
            accessibility = Q.played;
        }

       /* public override string ToString()
        {
            return string.Format("Category: {0} \n Value: {1} \n Question: {2} \n Answer: {3} \n ", category, value, question, answer);
        }*/
    }
}
