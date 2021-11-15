using System.ComponentModel;

namespace TableReservationSystem.Models
{
    public enum Size
    {
        [Description("1")]
        one,
        [Description("2")]
        two,
        [Description("4")]
        four,
        [Description("5")]
        five,
        [Description("6")]
        six,
        [Description("12")]
        twelve
    }
}
