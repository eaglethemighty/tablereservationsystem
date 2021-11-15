namespace TableReservationSystem.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Seats { get; set; }
        public Size Size { get; set; }
        public Shape Shape { get; set; }
        public bool HighChair { get; set; }
        public bool Window { get; set; }
    }
}