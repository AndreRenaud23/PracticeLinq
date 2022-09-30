using System.Linq;

List<string> videoGames = new()
{
    "Splatoon 3",
    "Zelda",
    "Minecraft",
    "Fifa 2023",
    "Rocket League",
    "League of Legends",
    "Starcraft II",
    "Fall Guys",
    "Jedi Fallen Order",
    "Cluster Truck",
    "Super Mario Bros",
    "Call of Duty",
    "Fortnite",
    "Roblox",
    "Destiny 2",
    "Rayman's Adventures",
    "Madden 22",
    "Rec room",
    "NBA 2K22",
    "Super Smash Bros Ultimate",
    "Super Mario Odyssey",
    "Overwatch"
};

videoGames.OrderBy(x => x.Length)
    .ThenBy(x => x)
    .ToList()
    .ForEach(x => Console.WriteLine(x));
