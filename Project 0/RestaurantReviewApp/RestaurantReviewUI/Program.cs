using RestaurantReviewUI;

bool repeat = true;
IMenu menu = new MainMenu();

while(repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch(ans)
    {
        case "SearchRestaurant":
            //call SearchRestaurant method
            Console.WriteLine("SearchRestaurant under implementation...");
            break;

        case "Sing in":
            //call SearchRestaurant method
            Console.WriteLine("Singin under implementation...");
            break;
        case "Sing up":
            //call SearchRestaurant method
            Console.WriteLine("Singup under implementation...");
            break;
        case "MainMenu":
            menu=new MainMenu();
            break;
        case "exit":
            repeat=false;
            break;
        default:
            Console.WriteLine("View dos nor exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}