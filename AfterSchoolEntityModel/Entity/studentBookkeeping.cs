using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
namespace AfterSchoolEntityModel
{
    public class studentBookkeeping : transaction
    {
        [PrimaryKey]
        public virtual int studentBookkeepingId { get; set; }


        public virtual decimal blanceDebit { get; set; }

        public virtual decimal blanceCredit { get; set; }

    }
}
