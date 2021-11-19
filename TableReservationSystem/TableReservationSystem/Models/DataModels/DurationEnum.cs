using System.ComponentModel;

namespace TableReservationSystem.Models
{
    public enum Duration
    {
        [Description("60")]
        dur60 = 1,
        [Description("90")]
        dur90 = 2,
        [Description("120")]
        dur120 = 3,
        [Description("180")]
        dur180 = 4,
    }
}