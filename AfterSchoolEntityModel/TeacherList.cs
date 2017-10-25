using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace AfterSchoolEntityModel
{
    public class TeacherList
    {
        public TeacherList()
        {
            Teachers = new BindingList<teacher>(DBModel.Instance.teachers);
        }

        public virtual BindingList<teacher> Teachers
        {
            get;
            set;
        }

        public IBindingList GetList()
        {
            return Teachers;
        }

        public int GetMaxTeacherId()
        {
            return DBModel.Instance.GetMaxTeacherId();
        }


        public int Update(teacher obj)
        {
            int ret = -1;
            ret = DBModel.Instance.Update(obj);
            Teachers = new BindingList<teacher>(DBModel.Instance.teachers);
            return ret;

        }

        public int Insert(teacher obj)
        {
            int ret = -1;            
            obj.teacherId = GetMaxTeacherId() + 1;
            ret = DBModel.Instance.Insert(obj);
            Teachers = new BindingList<teacher>(DBModel.Instance.teachers);
            return ret;
        }
        public int Delete(teacher obj)
        {
            int ret = -1;
            ret = DBModel.Instance.Delete(obj);
            Teachers = new BindingList<teacher>(DBModel.Instance.teachers);
            return ret;
        }
    }
}
