namespace AfterSchoolEntityModel
{
    using System;
    using System.Collections.Generic;
    using SQLite;

    [Table("carereservation")]
    public partial class carereservation
    {
        [PrimaryKey]
        public int careReservationId { get; set; }

        public int studentId { get; set; }

        public int weekday { get; set; }

        [MaxLength(10)]
        public string startTime { get; set; }

        [MaxLength(10)]
        public string endTime { get; set; }

        [MaxLength(45)]
        public string startLocation { get; set; }

        public bool recuring { get; set; }

        public bool breakfast { get; set; }

        public bool morningTea { get; set; }

        public bool lunch { get; set; }

        public bool afternoonTea { get; set; }

        public bool supper { get; set; }

        public bool outcare { get; set; }

        [MaxLength(45)]
        public string description { get; set; }
    }
}
