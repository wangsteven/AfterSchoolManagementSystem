using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;


namespace AfterSchoolEntityModel
{
    public class StudentList
    {
        public StudentList()
        {
            Students = new BindingList<student>(DBModel.Instance.students);
        }

        /*
        private static StudentList instance;
        public static StudentList Instance
        {
            get
            {
                // Uses "Lazy initialization"
                if (instance == null)
                    instance = new StudentList();

                return instance;
            }
        }
        
        */
        public virtual BindingList<student> Students
        {
            get;
            set;
        }
        

        public IBindingList GetList()
        {

            return  Students;

        }
        public int GetMaxStudentId()
        {
            return DBModel.Instance.GetMaxStudentId();
        }

        public int Update(student obj)
        {
            int ret = -1;
            ret = DBModel.Instance.Update(obj);
            Students = new BindingList<student>( DBModel.Instance.students);
            return ret;         

        }

        public int Insert(student obj)
        {
            int ret = -1;
            ret = DBModel.Instance.Insert(obj);
            Students = new BindingList<student>(DBModel.Instance.students);
            return ret;
        }
        public int Delete(student obj)
        {
            int ret = -1;
            ret = DBModel.Instance.Delete(obj);
            Students = new BindingList<student>(DBModel.Instance.students);
            return ret;
        }
    }
}
