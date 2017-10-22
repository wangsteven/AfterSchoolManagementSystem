namespace AfterSchoolEntityModel
{
    using System;
    using System.Collections.Generic;
    using SQLite;

    [Table("course")]
    public partial class course
    {
        [PrimaryKey]
        public int courseId { get; set; }

        [MaxLength(45)]
        public string teacherId { get; set; }

        [MaxLength(64)]
        public string name { get; set; }

        public int? courseLength { get; set; }

        public int? weekday { get; set; }

        public DateTime? startTime { get; set; }

        [MaxLength(64)]
        public string location { get; set; }

        public decimal? price { get; set; }

        [MaxLength(256)]
        public string description { get; set; }
    }
}
