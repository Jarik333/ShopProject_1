using System.Linq;
using ShopProject_1.Models;

namespace ShopProject_1
{
    public static class SampleData
    {
        public static void Initialize(GameContext context)
        {
            if (!context.Games.Any())
            {
                context.Games.AddRange(
                    new Game
                    {
                        
                        Name = "Game1",
                        Description = "description1",
                        Price = 100,
                        Category = "Action"
                    },
                    new Game
                    {
                        Name = "Game2",
                        Description = "description2",
                        Price = 200,
                        Category = "Action"
                    },
                    new Game
                    {
                        Name = "Game3",
                        Description = "description3",
                        Price = 300,
                        Category = "Action"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
