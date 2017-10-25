using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace AfterSchoolEntityModel
{
 

    public class DBModel
    {
        public DBModel()
        {

        }

        private static DBModel instance;
        public static DBModel Instance
        {
            get
            {
                // Uses "Lazy initialization"
                if (instance == null)
                    instance = new DBModel();

                return instance;
            }
        }		

        public virtual List<carerecord> carerecords
        {
            get
            {
                return SQLiteHelper.Instance.Query<carerecord>("select * from carerecord");
            }
        }
        public virtual List<carereservation> carereservations
        {
            get
            {
                return SQLiteHelper.Instance.Query<carereservation>("select * from carereservation");
            }
        }

        public virtual List<currentcarereservation> currentcarereservations
        {
            get
            {
                return SQLiteHelper.Instance.Query<currentcarereservation>("select * from currentcarereservation");
            }
        }
        public virtual List<course> courses
        {
            get
            {
                return SQLiteHelper.Instance.Query<course>("select * from course");
            }
        }
        public virtual List<coursepayment> coursepayments
        {
            get
            {
                return SQLiteHelper.Instance.Query<coursepayment>("select * from coursepayment");
            }
        }
        public virtual List<coursestudentattendance> coursestudentattendances
        {
            get
            {
                return SQLiteHelper.Instance.Query<coursestudentattendance>("select * from coursestudentattendance");
            }
        }
        public virtual List<student> students
        {
            get
            {
                return SQLiteHelper.Instance.Query<student>("select * from student");
            }            
        }
        public virtual List<teacher> teachers
        {
            get
            {
                return SQLiteHelper.Instance.Query<teacher>("select * from teacher");
            }
        }
        public virtual List<teacherattendace> teacherattendaces
        {
            get
            {
                return SQLiteHelper.Instance.Query<teacherattendace>("select * from teacherattendace");
            }
        }

        public virtual List<carereservation> GetCareRecordListFromDB(string condition)
        {
            var result = SQLiteHelper.Instance.Query<carereservation>("select * from carereservation  " + condition);
            return result;
            
        }

        public virtual List<currentcarereservation> GetCurrentCareReservationsFrom(string table)
        {
            return SQLiteHelper.Instance.Query<currentcarereservation>("select * from "+ table + " order by school, grade, classgroup");
        }

        public virtual int DeleteAllCurrentCareReservations()
        {
            return SQLiteHelper.Instance.DeleteAll<currentcarereservation>();
        }

        public virtual int InsertAllCurrentCareReservations(List<currentcarereservation> new_currentcarereservations)
        {
            return SQLiteHelper.Instance.InsertAll(new_currentcarereservations);
        }

        public int Update(object obj)
        {
            return SQLiteHelper.Instance.Update(obj);
        }

        public int UpdateAll(System.Collections.IEnumerable list)
        {
            return SQLiteHelper.Instance.UpdateAll(list);
        }

        public int Insert(object obj)
        {
            return SQLiteHelper.Instance.Insert(obj);
        }

        public int InsertAll(System.Collections.IEnumerable list)
        {
            return SQLiteHelper.Instance.InsertAll(list);
        }
        public int Delete(object obj)
        {
            return SQLiteHelper.Instance.Delete(obj);
        }       

        public int GetMaxStudentId()
        {
            return SQLiteHelper.Instance.CreateCommand("select max(studentid) from student").ExecuteScalar<int>();
        }

        public int GetMaxCareReservationId()
        {
            int maxid = 0;
            try
            {
                maxid  =SQLiteHelper.Instance.CreateCommand("select max(carereservationid) from carereservation").ExecuteScalar<int>();
            }
            catch { }
            return maxid;
        }

        public int GetMaxCareRecordId()
        {
            int maxid = 0;
            try
            {
                maxid = SQLiteHelper.Instance.CreateCommand("select max(carerecordId) from carerecord").ExecuteScalar<int>();
            }
            catch { }

            return maxid;
        }

        public int GetMaxTeacherId()
        {
            int maxid = 0;
            try
            {
                maxid = SQLiteHelper.Instance.CreateCommand("select max(teacherId) from teacher").ExecuteScalar<int>();
            }
            catch { }
            return maxid;
        }

        public string GetStudentName(int studentId)
        {
            var st = (from stu in students
                      where stu.studentId == studentId
                      select stu).ToList();
                          ;
            if(st != null && st.Count> 0)
            {
                return st[0].name;
            }
            else
            {
                return "";
            }
        }
        
    }
}
