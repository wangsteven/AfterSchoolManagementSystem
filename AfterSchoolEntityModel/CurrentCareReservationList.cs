using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.ComponentModel;

namespace AfterSchoolEntityModel
{
    public class CurrentCareReservationList
    {
        /*
        private static CurrentCareReservationList instance;
        public static CurrentCareReservationList Instance
        {
            get
            {
                // Uses "Lazy initialization"
                if (instance == null)
                    instance = new CurrentCareReservationList();

                return instance;
            }
        }
        */
        public virtual BindingList<currentcarereservation> CurrentCareReservations
        {
            get;
            set;
        }

        public IBindingList GetList( )
        {

            return CurrentCareReservations;

        }

        public virtual int SelectedWeekday { get; set; }

        public CurrentCareReservationList()
        {
            SelectedWeekday =( int)(DateTime.Now.DayOfWeek);
            GetTodayCareReservationList();
            
        }

        public void GetTodayCareReservationList()
        {
            ////Getfrom the database table
            CurrentCareReservations = new BindingList<currentcarereservation>(DBModel.Instance.GetCurrentCareReservationsFrom("currentCareReservation"));
        }

        public void CreateTodayCareReservationList()
        {
            //Getfrom the database View
            CurrentCareReservations = new BindingList<currentcarereservation>(DBModel.Instance.GetCurrentCareReservationsFrom("reservationView where weekday = " + SelectedWeekday));
        }

        public void Refresh()
        {
            CreateTodayCareReservationList();

        }

        public BindingList<student> GetAllSelectedStudents()
        {
            var studentlist = DBModel.Instance.students;
            var selstudents = (from rev in CurrentCareReservations
                               from st in studentlist
                               where st.studentId == rev.studentId
                               select st).ToList();
            return new BindingList<student>(selstudents);

        }

        public BindingList<student> GetAllUnSelectedStudents()
        {          
            List<student> studentlist = DBModel.Instance.students;
            List<student> selstudents = GetAllSelectedStudents().ToList();

            var unselstudents = studentlist.Except(selstudents, new StudentComparer()).ToList();

          
            return new BindingList<student>(unselstudents);
        }

        public void InsertReservation(currentcarereservation new_reservation)
        {
            CurrentCareReservations.Add(new_reservation);
        }

        public void RemoveReservation(currentcarereservation reservation)
        {
            CurrentCareReservations.Remove(reservation);
        }


        private   int DeleteAllCurrentCareReservations()
        {
            return DBModel.Instance.DeleteAllCurrentCareReservations();
        }

        public virtual int SaveCurrentCareReservations()
        {

            DeleteAllCurrentCareReservations();

            return DBModel.Instance.InsertAllCurrentCareReservations(CurrentCareReservations.ToList());

        }

        public int Update(currentcarereservation obj)
        {
            return 1;

        }

        public int Insert(currentcarereservation obj)
        {
            InsertReservation(obj);
            return 1;

        }
        public int Delete(currentcarereservation obj)
        {
            RemoveReservation(obj);
            return 1;
        }
    }


    class StudentComparer : IEqualityComparer<student>
    {
        public bool Equals(student s1, student s2)
        {
            if (s1 == null)
                return s2 == null;
            return s1.studentId == s2.studentId;
        }

        public int GetHashCode(student s)
        {
            if (s == null)
                return 0;
            return s.studentId.GetHashCode();
        }
    }


}
