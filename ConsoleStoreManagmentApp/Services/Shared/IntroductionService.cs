namespace OnlineStore.Services.Shared
{
    public class IntroductionService
    {
        private readonly string introMessage = """
            ************************************************************
            *                                                          *
            *              WELCOME TO OUR ONLINE STORE!                *
            *                                                          *
            ************************************************************

            Please choose an option:

            1 --- Sign Up      : Create a new account
            2 --- Log In       : Access your account
            3 --- About        : Learn more about our store
            4 --- Exit
            Enter your choice (1, 2, or 3):
            """;

        public void ShowIntro()
        {
            Console.WriteLine(introMessage);
        }
    }
}