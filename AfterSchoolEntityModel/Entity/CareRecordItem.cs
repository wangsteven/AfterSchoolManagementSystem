using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSchoolEntityModel
{
    public class CareRecordItem
    {
        public CareRecordItem() { }
        public CareRecordItem(string stname, carerecord record)
        {
            name = stname;
            studentId = record.studentId;
            carerecordId = record.carerecordId;
            carerecordDate = record.carerecordDate;
            breakfast = record.breakfast;
            morningTea = record.morningTea;
            lunch = record.lunch;
            afternoonTea = record.afternoonTea;
            supper = record.supper;
            outcare = record.outcare;
            checkinTime = record.checkinTime;
            checkoutTime = record.checkoutTime; 
        }

        public CareRecordItem(string stname,  currentcarereservation reservation)
        {
            name = stname;
            studentId = reservation.studentId;
            carerecordDate = DateTime.Now;
            carerecordId = -1;
            breakfast = reservation.breakfast;
            morningTea = reservation.morningTea;
            lunch = reservation.lunch;
            afternoonTea = reservation.afternoonTea;
            supper = reservation.supper;
            outcare = reservation.outcare;
            checkinTime = reservation.startTime;
            checkoutTime = reservation.endTime;
        }

        public carerecord GetCarerecord( )
        {
            carerecord record = new carerecord();
            record.studentId = studentId;
            record.carerecordId = carerecordId;
            record.carerecordDate = carerecordDate;
            record.breakfast = breakfast;
            record.morningTea = morningTea;
            record.lunch = lunch;
            record.afternoonTea = afternoonTea;
            record.supper = supper;
            record.outcare = outcare;
            record.checkinTime = checkinTime;
            record.checkoutTime = checkoutTime;
            return record;
        }

        public virtual int studentId { get; set; }
        public string name { get; set; }

        public int carerecordId { get; set; }

        public DateTime carerecordDate { get; set; }

        public bool breakfast { get; set; }

        public bool morningTea { get; set; }

        public bool lunch { get; set; }

        public bool afternoonTea { get; set; }

        public bool supper { get; set; }

        public bool outcare { get; set; }

        public string signature { get; set; }

        public string checkinTime { get; set; }

        public string checkoutTime { get; set; }

        public string description { get; set; }
    }
}
