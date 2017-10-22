using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace AfterSchoolEntityModel
{

    /// <summary>
    /// There are no comments for Entity.careReservation in the schema.
    /// </summary>
    [Table("currentCareReservation")]
    public partial class currentcarereservation
    {
  
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for careReservation constructor in the schema.
        /// </summary>
        public currentcarereservation()
        {
            reservationDate = DateTime.Now;
            startTime = "15:30:00"; //new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 30, 0);
            endTime = "18:30:00"; //new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 30, 0);

            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for reservationSeqId in the schema.
        /// </summary>
        public virtual int reservationSeqId
        {
            get;
            set;
        }

        public int weekday { get; set; }

        /// <summary>
        /// There are no comments for reservationSeqId in the schema.
        /// </summary>
        public virtual DateTime reservationDate
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for studentId in the schema.
        /// </summary>
        public virtual int studentId
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for name in the schema.
        /// </summary>
        [MaxLength(64)]
        public virtual string name
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for grade in the schema.
        /// </summary>
        public virtual int grade
        {
            get;
            set;
        }

        /// <summary>
        /// There are no comments for classGroup in the schema.
        /// </summary>
        public virtual int classGroup
        {
            get;
            set;
        }

        /// <summary>
        /// There are no comments for school in the schema.
        /// </summary>
        [MaxLength(64)]
        public virtual string school
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for schoolTeacher in the schema.
        /// </summary>
        [MaxLength(128)]
        public virtual string schoolTeacher
        {
            get;
            set;
        }

        /// <summary>
        /// There are no comments for guardian in the schema.
        /// </summary>
        [MaxLength(128)]
        public virtual string guardian
        {
            get;
            set;
        }

        /// <summary>
        /// There are no comments for location in the schema.
        /// </summary>
        [MaxLength(64)]
        public virtual string startLocation
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for startTime in the schema.
        /// </summary>
        [MaxLength(10)]
        public virtual string startTime
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for endTime in the schema.
        /// </summary>
        [MaxLength(10)]
        public virtual string endTime
        {
            get;
            set;
        }

        /// <summary>
        /// There are no comments for breakfast in the schema.
        /// </summary>
        public virtual bool breakfast { get; set; }

        /// <summary>
        /// There are no comments for morningTea in the schema.
        /// </summary>
        public virtual bool morningTea { get; set; }

        /// <summary>
        /// There are no comments for lunch in the schema.
        /// </summary>
        public virtual bool lunch { get; set; }
    
        /// <summary>
        /// There are no comments for afternoonTea in the schema.
        /// </summary>
        public virtual bool afternoonTea
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for supper in the schema.
        /// </summary>
        public virtual bool supper
        {
            get;
            set;
        }

        public virtual bool outcare { get; set; }


        /// <summary>
        /// There are no comments for description in the schema.
        /// </summary>
        [MaxLength(128)]
        public virtual string description
        {
            get;
            set;
        }


    }

}
