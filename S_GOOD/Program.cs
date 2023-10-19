namespace S_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myUser = new User();
            myUser.Create("Richard", "email@email.com");

            UserDisplay.Display(myUser);
        }
    }
}