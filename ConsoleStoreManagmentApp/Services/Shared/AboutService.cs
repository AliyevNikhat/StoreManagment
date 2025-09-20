using System.Runtime.CompilerServices;

namespace OnlineStore.Services.Shared
{
    class AboutService
    {
        private readonly string aboutMessage = """
            ************************************************************
            *                                                          *
            *                   ABOUT OUR STORE                        *
            *                                                          *
            ************************************************************

            Welcome to our Online Store! 🛒

            Here you can:

            - Browse and buy a variety of products including Books, Electronics, and more.
            - Create an account to track your orders and receive exclusive offers.
            - Enjoy a user-friendly shopping experience from anywhere.

            Our mission is to provide high-quality products at competitive prices, 
            with excellent customer service.

            Thank you for choosing our store! ❤️

            Press any key to return to the main menu...
            """;
        public void ShowAbout()
        {
            Console.WriteLine(aboutMessage);
        }
    }
}