using Intro.Business;
using Intro.Entities;

// A new instance has been obtained by the GameManager object and sets the game's array used by the GameManager constructor.
GameManager gameManager = new GameManager();


Game[] result = gameManager.GetGames();//GameManager.GetGames() returned a game array and assigned the results.

for (int i = 0; i < result.Length; i++) // result object iteration 
{

    // Each game object has been printed name and developer by the result.
    Console.WriteLine(result[i].Name + " has been developed by " + result[i].Developer); 
}
