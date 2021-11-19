using Microsoft.EntityFrameworkCore;
using TableReservationSystem.Models;

namespace TableReservationSystem.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Table[] seedTables =
            {
                new Table
                {
                    Id = 1,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Id = 2,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = true
                },
                new Table
                {
                    Id = 3,
                    Seats = 5,
                    Size = Size.Medium,
                    Shape = Shape.Entrance,
                    HighChair = false,
                    Window = true
                },
                new Table
                {
                    Id = 4,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Entrance,
                    HighChair = false,
                    Window = true
                },
                new Table
                {
                    Id = 5,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 6,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 7,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 8,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Id = 9,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Id = 10,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Id = 11,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Id = 12,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Id = 14,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 15,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Id = 16,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 17,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 18,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 19,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 20,
                    Seats = 12,
                    Size = Size.Large,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = true
                },
                new Table
                {
                    Id = 21,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 22,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 23,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 24,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 25,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 26,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 27,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 28,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 29,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 30,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 31,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Id = 32,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                }
            };

            modelBuilder.Entity<Table>().HasData(seedTables);
        }
    }
}