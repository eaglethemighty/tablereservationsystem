namespace TableReservationSystem.Models
{
    public class TableExtended
    {
        public TableExtended(Table table)
        {
            Table = table;
            Available = true;
        }

        public Table Table { get; set; }
        public bool Available { get; set; }
    }
}