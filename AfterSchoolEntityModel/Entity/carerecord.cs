namespace AfterSchoolEntityModel
{
    using System;
    using System.Collections.Generic;
    using SQLite;

    [Table("carerecord")]
    public partial class carerecord
    {
        [PrimaryKey]
        public int carerecordId { get; set; }

        public int studentId { get; set; }

        //[Column(TypeName = "date")]
        public DateTime carerecordDate { get; set; }

        public bool breakfast { get; set; }

        public bool morningTea { get; set; }

        public bool lunch { get; set; }

        public bool afternoonTea { get; set; }

        public bool supper { get; set; }

        public bool outcare { get; set; }

        [MaxLength(45)]
        public string signoffPerson { get; set; }

        [MaxLength(10)]
        public string checkinTime { get; set; }

        [MaxLength(10)]
        public string checkoutTime { get; set; }

        [MaxLength(45)]
        public string description { get; set; }
    }
}
