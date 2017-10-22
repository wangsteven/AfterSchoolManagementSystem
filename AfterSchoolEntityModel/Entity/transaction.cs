using System;
using System.Collections.Generic;
using SQLite;

namespace AfterSchoolEntityModel
{
    //for bookkeeping
    public class transaction
    {
        [PrimaryKey]
        public virtual int transactionId { get; set; }
     
        public virtual DateTime transactionTimeStamp { get; set; }

        public virtual TransactionType transType { get; set; }

        public virtual decimal transactionAmount { get; set; }

        [MaxLength(128)]
        public virtual string customer { get; set; }

        [MaxLength(128)]
        public virtual string cashier { get; set; }

        [MaxLength(256)]
        public virtual string description { get; set; }
    }

    public enum TransactionType
    {
        Debit = 0,
        Credit = 1
    }
}
