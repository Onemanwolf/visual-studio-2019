namespace VisualStudio2019_Whats_New
{
    public class Teacher : Person
    {
        public override string FirstName { get; set ; }
        public override string LastName { get; set ; }
        public override string Email { get ; set; }

        public override string SendMessage(string message)
        {


            System.Console.WriteLine();

            return "String";
        }
    }
}