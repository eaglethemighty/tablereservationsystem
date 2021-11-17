using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TableReservationSystem.Data;

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
                    //1,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    //2,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = true
                },
                new Table
                {
                    //3,
                    Seats = 5,
                    Size = Size.Medium,
                    Shape = Shape.Entrance,
                    HighChair = false,
                    Window = true
                },
                new Table
                {
                    //4,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Entrance,
                    HighChair = false,
                    Window = true
                },
                new Table
                {
                    //5,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //6,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //7,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //8,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    //9,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    //10,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    //11,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    //12,
                    Seats = 4,
                    Size = Size.Medium,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    //14,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //15,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = true,
                    Window = false
                },
                new Table
                {
                    //16,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //17,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //18,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //19,
                    Seats = 2,
                    Size = Size.Small,
                    Shape = Shape.Middle,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //20,
                    Seats = 12,
                    Size = Size.Large,
                    Shape = Shape.Wall,
                    HighChair = true,
                    Window = true
                },
                new Table
                {
                    //21,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //22,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //23,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //24,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //25,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //26,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //27,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //28,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //29,
                    Seats = 1,
                    Size = Size.Small,
                    Shape = Shape.Bar,
                    HighChair = false,
                    Window = false
                },
                new Table
                {
                    //30,
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