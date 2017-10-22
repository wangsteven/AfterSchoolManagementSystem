namespace AfterSchoolEntityModel
{
    using System;
    using System.Collections.Generic;
    using SQLite;

    [Table("teacherattendace")]
    public partial class teacherattendace
    {
        [PrimaryKey]
        public int teacherattendaceId { get; set; }

        public DateTime? checkintime { get; set; }

        public DateTime? checkouttime { get; set; }

        [MaxLength(45)]
        public string description { get; set; }
    }
}
