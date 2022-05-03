global using Serilog;
using RestaurantReviewUI;

//create and configure logger
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt").MinimumLevel.Information() //local to save the logs
    .CreateLogger();

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case
            "MenuAdmin":
            menu = new AdminMenu();
            break;
        case "Logged":
                        
            menu = new UserMenu();
            break;

        case "SearchRestaurant":
            //call SearchRestaurant method
            Log.Information("Displaying SearchRestaurant menu regardless of being a user");
            menu = new RestaurantSearch();
            break;

        case "Singin":
            //call SearchRestaurant method
            Log.Information("Login with existing user");
            menu = new Signin();

            break;
        case "Singup":
            //call SearchRestaurant method
            Log.Information("Login as a new user");
            menu = new Signup();
            break;
        case "MainMenu":
            Log.Information("Displaying Main Menu to the user");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Information("Exiting the application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
            Console.WriteLine("View dos nor exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}