namespace AfterSchoolEntityModel
{
    using System;
    using System.Collections.Generic;
    using SQLite;

    [Table("coursestudentattendance")]
    public partial class coursestudentattendance
    {
        
        [PrimaryKey]
        public int courseAttendanceId { get; set; }

        //[Column(TypeName = "date")]
        public DateTime courseAttendanceDate { get; set; }

        public int courseId { get; set; }

        public int studentId { get; set; }

        [MaxLength(64)]
        public string description { get; set; }
    }
}
