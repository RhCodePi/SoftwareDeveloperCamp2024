using Intro.Entities;

namespace Intro.Business
{
    public class GameManager
    {
        // set global array for hold games
        Game[] games = new Game[3];

        // set constructor
        public GameManager()
        {
            // set first game information
            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Baldur's Gate 3";
            game1.Developer = "Larian Studios";
            game1.Reviews = "Overwhelmingly positive";
            game1.Type = "CRPG";

            // set second game information
            Game game2 = new Game();
            game2.Id = 2;
            game2.Name = "Elden Ring";
            game2.Developer = "FromSoftware";
            game2.Reviews = "Very Positive";
            game2.Type = "Souls-like";

            // set third game information
            Game game3 = new Game();
            game3.Id = 3;
            game3.Name = "Red Dead Redemption 2 ";
            game3.Developer = "Rockstar Games";
            game3.Reviews = "Veri Positive";
            game3.Type = "Open World";

            games[0] = game1;
            games[1] = game2;
            games[2] = game3;
        }

        // get games
        public Game[] GetGames()
        {
            return games;
        }

    }
}
