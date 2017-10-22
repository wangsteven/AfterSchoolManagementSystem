namespace AfterSchoolEntityModel
{
    using System;
    using System.Collections.Generic;
    using SQLite;

    [Table("teacher")]
    public partial class teacher
    {
        [PrimaryKey]
        public int teacherId { get; set; }

        [MaxLength(64)]
        public string name { get; set; }

        //[Column(TypeName = "enum")]
        [MaxLength(10)]
        public string gender { get; set; }

        public DateTime? birthday { get; set; }

        [MaxLength(64)]
        public string phoneNumber { get; set; }

        [MaxLength(64)]
        public string email { get; set; }

        [MaxLength(128)]
        public string address { get; set; }

        [MaxLength(64)]
        public string profession { get; set; }

        public DateTime? regDate { get; set; }

        [MaxLength(256)]
        public string description { get; set; }

        public bool active { get; set; }
    }
}
