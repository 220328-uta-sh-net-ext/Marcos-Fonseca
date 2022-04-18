using PokemonUi;

bool repeat = true
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchPokemon":
            //call SearchPokemon method
            Console.WriteLine("SearchPokemon() Method implementation is in progress...");
            break;
        case "AddPokemon":
            //call AddPokemon method
            Console.WriteLine("AddPokemon() Method implementation is in progress...");
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}