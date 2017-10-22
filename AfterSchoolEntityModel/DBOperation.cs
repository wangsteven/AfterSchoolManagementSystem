using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterSchoolEntityModel
{
    public class DBOperation
    {
        public virtual int Update(object obj)
        {
           return  DBModel.Instance.Update(obj);          

        }

        public virtual int Insert(object obj)
        {

            return DBModel.Instance.Insert(obj);            
        }
        public virtual int Delete(object obj)
        {

            return DBModel.Instance.Delete(obj);
        }
    }
}
