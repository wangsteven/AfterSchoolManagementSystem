using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using System.Collections;

namespace AfterSchoolEntityModel
{
    public class CareRecordList 
    {
        /*
        private static CareRecordList instance;

        public static CareRecordList Instance
        {
            get
            {
                // Uses "Lazy initialization"
                if (instance == null)
                {
                    instance = new CareRecordList();
                    instance.SelStudentId = 0;
                }

                return instance;
            }
        }
        */

        public CareRecordList()
        {
            SelStudentId = 0;
        }

        public DateTime SelStartDate
        {
            get;
            set;
        }

        public DateTime SelEndDate
        {
            get;
            set;
        }

        public int SelStudentId
        {
            get;
            set;
        }

        public BindingList<CareRecordItem> CareRecordItems
        {
            get;
            set;
        }

        public IBindingList GetList()
        {
            return CareRecordItems;
        }

        public IBindingList GetSelStudentList()
        {
            var studentlist = DBModel.Instance.students;
            var selstudents = (from rec in CareRecordItems
                               from st in studentlist
                               where st.studentId == rec.studentId
                               select st).ToList();
            
            return new BindingList<student>(selstudents);
            
        }

        public IBindingList GetAllUnSelectedStudents()
        {
            List<student> studentlist = DBModel.Instance.students;
            List<student> selstudents = (GetSelStudentList() as BindingList<student> ).ToList();

            var unselstudents = studentlist.Except(selstudents, new StudentComparer()).ToList();


            return new BindingList<student>(unselstudents);
        }
        public void InitCareRecordItems(List<carerecord> recordlist )
        {
            CareRecordItems.Clear();
            foreach (carerecord record in recordlist)
            {
                string name = DBModel.Instance.GetStudentName(record.studentId);
                CareRecordItem item = new CareRecordItem(name, record);
                CareRecordItems.Add(item);
            }
        }

        public void InitCareRecordItems(List<currentcarereservation> reservationlist)
        {
            CareRecordItems.Clear();
            foreach (currentcarereservation reservation in reservationlist)
            {
                string name = DBModel.Instance.GetStudentName(reservation.studentId);
                CareRecordItem item = new CareRecordItem(name, reservation);
                CareRecordItems.Add(item);
            }
        }

        public void InitFromDB_CareRecord()
        {
            if(CareRecordItems != null && CareRecordItems.Count >0)
            {
                CareRecordItems.Clear();
            }
            else
            {
                CareRecordItems = new BindingList<CareRecordItem>();
            }
            DateTime dtstart = DateTime.Parse(SelStartDate.ToShortDateString());
            DateTime dtend = DateTime.Parse(SelEndDate.ToShortDateString());

            if (dtstart == dtend)
            {
                dtend = dtend.AddDays(1);
            }



            if (SelStudentId >= 0)
            {
          

                var selectedCareRecords = (from rec in DBModel.Instance.carerecords
                                                where (rec.studentId == SelStudentId &&
                                                        rec.carerecordDate > dtstart &&
                                                        rec.carerecordDate < dtend)
                                                select rec).ToList();
                
                InitCareRecordItems(selectedCareRecords);
            }
            else
            {
                var selectedCareRecords = (from rec in DBModel.Instance.carerecords
                                           where ( rec.carerecordDate > dtstart &&
                                                   rec.carerecordDate < dtend)
                                           select rec).ToList();
                InitCareRecordItems(selectedCareRecords);                
            }
        }

        public void InitFromDB_CurrentCareReservation()
        {
            if (CareRecordItems != null && CareRecordItems.Count > 0)
            {
                CareRecordItems.Clear();
            }
            else
            {
                CareRecordItems = new BindingList<CareRecordItem>();
            }

            if (SelStudentId >= 0)
            {
                var selectedCarReservation = (from rec in DBModel.Instance.currentcarereservations
                                           where (rec.studentId == SelStudentId)
                                           select rec).ToList();

                InitCareRecordItems(selectedCarReservation);
            }
            else
            {
                InitCareRecordItems(DBModel.Instance.currentcarereservations);
            }
        }

        public void SetDate()
        {
            foreach (CareRecordItem record in CareRecordItems)
            {
                //record.carerecordDate = SelDate;
            }
        }

        public int SaveCareRecordList(bool addnew)
        {
            if (addnew)
            {
                int maxcarerecordid
                    = DBModel.Instance.GetMaxCareRecordId();
                List<carerecord> _recordlist = new List<carerecord>();
                foreach (CareRecordItem record in CareRecordItems)
                {
                    carerecord rec = record.GetCarerecord();
                    maxcarerecordid++;
                    rec.carerecordId = maxcarerecordid;
                    rec.carerecordDate = SelStartDate;
                    record.carerecordId = maxcarerecordid;
                    record.carerecordDate = SelStartDate;
                    _recordlist.Add(rec);
                    
                }
                DBModel.Instance.InsertAll(_recordlist);
            }
            else
            {
                List<carerecord> _recordlist = new List<carerecord>();
                foreach (CareRecordItem record in CareRecordItems)
                {
                    carerecord rec = record.GetCarerecord();
                  
                    _recordlist.Add(rec);

                }
                DBModel.Instance.UpdateAll(_recordlist);
            }
            return 1;
        }
    }
}