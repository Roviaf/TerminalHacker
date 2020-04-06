using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game Configuration Data
    string[] diflevel1Password = { "table", "books", "shelf", "aisle", "borrow" };
    string[] diflevel1Password2 = { "computer", "librarian", "collection", "silence", "geography" };
    string[] diflevel1Password3 = { "authentication", "bibliography", "vocabulary", "documentation", "encyclopedia" };
    string[] diflevel2Password = { "arrest", "thief", "safety", "bail", "cell" };
    string[] diflevel2Password2 = { "criminal", "custody", "detective", "escape", "felony" };
    string[] diflevel2Password3 = { "fingerprints", "handcuffs", "misdemeamar", "pickpocket", "interrogation" };
    string[] diflevel3Password = { "space", "earth", "moon", "alien", "comets" };
    string[] diflevel3Password2 = { "astronaut", "galaxy", "beacon", "density", "eclipse" };
    string[] diflevel3Password3 = { "acceleration", "eccentricity", "exoplanet", "gravitation", "satellite" };
    //Game State
    int difficulty;
    int level;
    string password;
    const string MenuHint = "You may type menu at any time.";
    enum Screen { MainMenu, Inventory, Difficulty, Password, Win }
    Screen currentScreen;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu(/*"Pedro"*/);
        
    }

    /*
    void Update()
    {
        int index = Random.Range(0, difficulty1Password.Length);
        print(index);
    }
    */

    void ShowMainMenu(/*string greeting*/)
    {
        currentScreen = Screen.MainMenu;
        //Terminal.ClearScreen();
        // var greeting = "Hello Pedro";
        // Terminal.WriteLine(greeting);
        // print("Hello my name is " + greeting);
        Terminal.WriteLine("Welcome to Hacker3000");
        //Terminal.WriteLine("");
        Terminal.WriteLine("What would you like to hack today?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }
    void OnUserInput(string Input)
    {
        if (Input == "menu")
        {
            Terminal.ClearScreen();

            ShowMainMenu();


        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(Input);
        }
        else if (currentScreen == Screen.Difficulty)
        {
            ChooseDifficulty(Input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(Input);
        }

        //print("The user typed " + Input);
        //print(Input == "1"); //bolean = true or false
    }


    void ShowInventory(string Input)
    {
        currentScreen = Screen.Inventory;
    }

    void RunMainMenu(string Input)
    {
        bool isValidLevelNumber = (Input == "1" || Input == "2" || Input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(Input);
            ChooseDifficulty(Input);
            
        }
        else if (Input == "999")
        {
            ShowInventory(Input);
            Terminal.ClearScreen();
            Terminal.WriteLine(@"
 _____________________________
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|_____________________________|
");
        }
        else if (Input == "4")
        {
            Terminal.WriteLine("There is no level 4, sorry");
        }
        else if (Input == "007")
        {
            Terminal.WriteLine("Please select a level Mr Bond");
        }
        else if (Input == "42")
        {
            Terminal.WriteLine("Huh? That's the meaning of life");
        }
        else if (Input == "release")
        {
            Terminal.WriteLine("This game was released on 13/01/2020");
        }
        else if (Input == "Release")
        {
            Terminal.WriteLine("This game was released on 13/01/2020");
        }
        else if (Input == "hello")
        {
            Terminal.WriteLine("hello back at you!");
        }
        else if (Input == "Hello")
        {
            Terminal.WriteLine("Hello back at you!");
        }
        else if (Input == "22")
        {
            Terminal.WriteLine("That's the developer's age!");
        }
        else if (Input == "3.14")
        {
            Terminal.WriteLine("First 3 numbers of PI!");
        }
        else
        {
            Terminal.WriteLine("Please select a valid level");
        }
    }


    void ChooseDifficulty(string Input)
    {
        currentScreen = Screen.Difficulty;
        Terminal.ClearScreen();
        switch (level) 
        { 
            case 1:
                Terminal.WriteLine("You have chosen the Local Library");
                Terminal.WriteLine("");
                Terminal.WriteLine("Please Select a difficulty level:");
                Terminal.WriteLine("01 - Easy");
                Terminal.WriteLine("02 - Medium");
                Terminal.WriteLine("03 - Hard");
                Terminal.WriteLine("");
                CheckDifficulty();
                break;
        }
        switch (level)
        {
            case 2:
                Terminal.WriteLine("You have chosen the Police Station");
                Terminal.WriteLine("");
                Terminal.WriteLine("Please Select a difficulty level:");
                Terminal.WriteLine("01 - Easy");
                Terminal.WriteLine("02 - Medium");
                Terminal.WriteLine("03 - Hard");
                Terminal.WriteLine("");
                CheckDifficulty();
                break;
        }
        switch (level)
        {
            case 3:
                Terminal.WriteLine("You have chosen NASA");
                Terminal.WriteLine("");
                Terminal.WriteLine("Please Select a difficulty level:");
                Terminal.WriteLine("01 - Easy");
                Terminal.WriteLine("02 - Medium");
                Terminal.WriteLine("03 - Hard");
                Terminal.WriteLine("");
                CheckDifficulty();
                break;
        }

        void CheckDifficulty()
        {

            bool isValidDifficultyNumber = (Input == "01" || Input == "02" || Input == "03");
            if (isValidDifficultyNumber)
            {
                difficulty = int.Parse(Input);
                StartGame();
            }

        }
        }


    void StartGame()
    {
        //int index1 = Random.Range(0, difficulty1Password.Length);
        //print(difficulty1Password.Length);
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                switch (difficulty)
                {
                    case 1:
                        password = diflevel1Password[Random.Range(0, diflevel1Password.Length)];
                        break;
                    case 2:
                        password = diflevel1Password2[Random.Range(0, diflevel1Password2.Length)];
                        break;
                    case 3:
                        password = diflevel1Password3[Random.Range(0, diflevel1Password3.Length)];
                        break;
                    default:
                        Debug.LogError("Invalid difficulty number");
                        break;
                }
                break;
            case 2:
                switch (difficulty)
                {
                    case 1:
                        password = diflevel2Password[Random.Range(0, diflevel2Password.Length)];
                        break;
                    case 2:
                        password = diflevel2Password2[Random.Range(0, diflevel2Password2.Length)];
                        break;
                    case 3:
                        password = diflevel2Password3[Random.Range(0, diflevel2Password3.Length)];
                        break;
                    default:
                        Debug.LogError("Invalid difficulty number");
                        break;
                }
                break;
            case 3:
                switch (difficulty)
                {
                    case 1:
                        password = diflevel3Password[Random.Range(0, diflevel3Password.Length)];
                        break;
                    case 2:
                        password = diflevel3Password2[Random.Range(0, diflevel3Password2.Length)];
                        break;
                    case 3:
                        password = diflevel3Password3[Random.Range(0, diflevel3Password3.Length)];
                        break;
                    default:
                        Debug.LogError("Invalid difficulty number");
                        break;
                }
                break;
        }
        
        Terminal.WriteLine("Enter the Password");
        Terminal.WriteLine("Hint: " + password.Anagram());
        Terminal.WriteLine(MenuHint);
    }
    void CheckPassword(string Input)
    {
        if (Input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            StartGame();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowDifficultyReward();
    }

    void ShowDifficultyReward()
    {
        switch (level)
        {
            case 1:
                switch (difficulty)
                {
                    case 1:
                        Terminal.WriteLine("");
                        Terminal.WriteLine("        You have guessed the word!");
                        Terminal.WriteLine(@"
                  _________
                 /       //
                /       // 
               /_______// 
              (_______(/
");
                        Terminal.WriteLine("             Have a book...");
                        Terminal.WriteLine("");
                        Terminal.WriteLine("    Check out the other dificulties.");
                        break;
                    case 2:
                        Terminal.WriteLine("");
                        Terminal.WriteLine(" Woah! You guessed the word, congratz!");
                        Terminal.WriteLine(@"
                  _________
                 / The   //
                /Witcher// 
               /_______// 
              (_______(/
");
                        Terminal.WriteLine("    You obtained the Witcher book!");
                        break;
                    case 3:
                        Terminal.WriteLine("");
                        Terminal.WriteLine("    You guessed it! Marvelously done!");
                        Terminal.WriteLine(@"
                  _________
                 /HackerX//
                / Book  // 
               /_______// 
              (_______(/
");
                        Terminal.WriteLine("     You obtain the hackerX book!");
                        break;
                }
                break;
            case 2:
                switch (difficulty)
                {
                    case 1:
                        Terminal.WriteLine("");
                        Terminal.WriteLine("        The key to... the word!");
                        Terminal.WriteLine(@"
              __
             /0 \_______
             \__/-=' = '
");
                        Terminal.WriteLine("      I wonder what it unlocks...");
                        Terminal.WriteLine("");
                        Terminal.WriteLine("    Check out the other dificulties.");
                        break;
                    case 2:
                        Terminal.WriteLine("      You're a dangerous fellow...");
                        Terminal.WriteLine(@"
         _____            _____
        /     \          /     \
       |       |000YY000|       |
       |       |000YY000|       |
        \_____/          \_____/
");
                        Terminal.WriteLine("");
                        Terminal.WriteLine("         Have some handcuffs...");
                        Terminal.WriteLine("");
                        break;
                    case 3:
                        Terminal.WriteLine("       Hands up! You're a hacker!");
                        Terminal.WriteLine(@"
            ___________
            |GUN_______\~~~~~
            |  |o)/
            |  |/
            |__|
");
                        Terminal.WriteLine("       A pistol is thrown at you.");
                        Terminal.WriteLine("");
                        break;
                }
                break;
            case 3:
                switch (difficulty)
                {
                    case 1:
                        Terminal.WriteLine(" They're beautiful and...");
                        Terminal.WriteLine(@"
    *      *           *          *
  *        *    *           *        *      *
   *         *     *         *     *  
   *        *        *        *        *
");
                        Terminal.WriteLine("              ...only seen at night");

                        break;
                    case 2:
                        Terminal.WriteLine("              Congratz!");
                        Terminal.WriteLine("");
                        Terminal.WriteLine(@"
                  /\
                 | o|
                 |__|
                 /88\
                  88
");
                        Terminal.WriteLine("         We're ready to take off");
                        break;
                    case 3:
                        Terminal.WriteLine("    You saw nothing...");
                        Terminal.WriteLine("");
                        Terminal.WriteLine(@"
                       ___  
         /\   |    |  |     |\  |
        /--\  |    |  |__   | \ |
       /    \ |___ |  |___  |  \|
");
                        Terminal.WriteLine("");
                        Terminal.WriteLine("              ...they are real");
                        Terminal.WriteLine("");
                        break;
                }
                break;
        }
        
        
    }
}
