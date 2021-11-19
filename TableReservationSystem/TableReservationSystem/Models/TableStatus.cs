namespace TableReservationSystem.Models
{
    public class TableStatus
    {
        public TableStatus(Table table)
        {
            Table = table;
            Available = true;
        }

        public Table Table { get; set; }
        public bool Available { get; set; }
    }
}