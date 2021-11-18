using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TableReservationSystem.Data;
using System;
using System.Linq;

namespace TableReservationSystem.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new TableReservationSystemContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TableReservationSystemContext>>());
            if (context.Table.Any())
            {
                return;
            }

            context.Table.AddRange(
                new Table
                {
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = true
                },
                new Table
                {
                    Seats = 5,
                    Size = Size.Medium,
                    Shape = Shape.Entrance,
                    HighChair = false,
                    Window = true
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Entrance,
                    HighChair = false,
                    Window = true
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 12,
                    Size = Size.Large,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = true
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                }

            );
            context.SaveChanges();
        }
    }
}