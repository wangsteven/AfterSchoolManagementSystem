using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace AfterSchoolEntityModel
{
    public class CareReservationList 
    {
        public CareReservationList()
        {
            CareReservations = new BindingList<carereservation>(DBModel.Instance.carereservations);
            CurrentStudentId = 0; 
        }

        /*
        private static CareReservationList instance;
        public static CareReservationList Instance
        {
            get
            {
                // Uses "Lazy initialization"
                if (instance == null)
                    instance = new CareReservationList();

                return instance;
            }
        }
        */
        public virtual BindingList<carereservation> CareReservations
        {
            get;
            set;
        }  
    
        public virtual int CurrentStudentId {get;set;}

        public IBindingList GetList()
        {
            if (CurrentStudentId > 0)
            {
                var selectedCareReservations = (from res in CareReservations 
                                                where res.studentId ==CurrentStudentId
                                                select res).ToList();
                return new BindingList<carereservation>(selectedCareReservations);
            }
            else
            {
                return CareReservations;
            }

        }
        public int GetMaxCareReservationId()
        {
            return DBModel.Instance.GetMaxCareReservationId();
        }

        public int Update(carereservation obj)
        {
            int ret = -1;
            ret = DBModel.Instance.Update(obj);
            CareReservations = new BindingList<carereservation>(DBModel.Instance.carereservations);
            return ret;         

        }

        public int Insert(carereservation obj)
        {
            int ret = -1;

            obj.studentId = CurrentStudentId;
            obj.careReservationId = GetMaxCareReservationId() + 1;
            ret = DBModel.Instance.Insert(obj);
            CareReservations = new BindingList<carereservation>(DBModel.Instance.carereservations);
            return ret;
        }
        public int Delete(carereservation obj)
        {
            int ret = -1;
            ret = DBModel.Instance.Delete(obj);
            CareReservations = new BindingList<carereservation>(DBModel.Instance.carereservations);
            return ret;
        }
    }
}
