namespace AfterSchoolEntityModel
{
    using System;
    using System.Collections.Generic;
    using SQLite;
    
    [Table("student")]
    public   partial class student
    {
        public override string ToString()
        {
            return name.ToString() +" ("+ school.ToString() +  " grade:" + grade + " class:" + classGroup + ")";
        }

        //[PrimaryKey]
        [PrimaryKey]
        public virtual  int studentId { get; set; }

       [MaxLength(16)]
        public virtual  string contactId { get; set; }

        [MaxLength(64)]
        public virtual  string name { get; set; }

        //[Column(TypeName = "enum")]
        [MaxLength(10)]
        public virtual  string gender { get; set; }

        [MaxLength(64)]
        public virtual  string school { get; set; }

        public virtual  int grade { get; set; }

        public virtual  int classGroup { get; set; }

        [MaxLength(128)]
        public virtual  string schoolTeacher { get; set; }

        [MaxLength(128)]
        public virtual  string guardian { get; set; }

        public virtual  DateTime birthday { get; set; }

        [MaxLength(256)]
        public virtual  string allergies { get; set; }

        [MaxLength(256)]
        public virtual  string favorite { get; set; }

        public virtual  DateTime regDate { get; set; }

        [MaxLength(256)]
        public virtual  string description { get; set; }

        [MaxLength(256)]
        public virtual  string picture { get; set; }

        public virtual  bool active { get; set; }
    }
}
