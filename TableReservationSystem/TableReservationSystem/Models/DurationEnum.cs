using System.ComponentModel;

namespace TableReservationSystem.Models
{
    public enum Duration
    {
        [Description("60")]
        dur60,
        [Description("90")]
        dur90,
        [Description("120")]
        dur120,
        [Description("180")]
        dur180,
    }
}