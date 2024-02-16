namespace LinqProject
{
    class GamaManager
    {
        List<Game> _games = new List<Game>();

        public GamaManager()
        {
            Game game = new Game()
            {
                Id = 1,
                Name = "Baldur's Gate 3",
                Coast = 34.5m,
                Developer = "Larian Studios"
            };


            Game game2 = new Game()
            {
                Id = 2,
                Name = "Elden Ring",
                Coast = 40.99m,
                Developer = "FromSoftware"
            };

            Game game3 = new Game()
            {
                Id = 3,
                Name = "Cyberpunk 2077",
                Coast = 44.99m,
                Developer= "CD Project Red",
            };

            Game game4 = new Game()
            {
                Id = 4,
                Name = "Dark Souls 3",
                Coast = 39.99m,
                Developer = "FromSoftware"
            };

            _games.AddRange(new List<Game>() { game, game2, game3, game4 });
        }

        public List<Game> FilterByCoast(decimal Coast)
        {

            return _games.Where(g => g.Coast > Coast).ToList();
        }

        public List<Game> FilterByDeveloper(string Developer)
        {
            return _games.Where(g=> g.Developer == Developer).ToList();
        }

    }
}
