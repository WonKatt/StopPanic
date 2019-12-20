using System;
using SQLite;

namespace StopPanic.Data.Entities
{
    public class PanicCalendarRecord
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime DateTime { get; set; }
        public int Value { get; set; }
        public string PhysicalFeelingComment { get; set; }
        public string EmotionalFeelingComment { get; set; }
        public string AdditionalComment { get; set; }
    }
}
