namespace AfterSchoolEntityModel
{
    using System;
    using System.Collections.Generic;
    using SQLite;
    [Table("coursepayments")]
    public partial class coursepayment
    {
        [PrimaryKey]
        //[PrimaryKey]
        public int paymentId { get; set; }

        [MaxLength(45)]
        public string receiptId { get; set; }

        public int? studentId { get; set; }

        //[Column(TypeName = "date")]
        public DateTime? payDate { get; set; }

        [MaxLength(45)]
        public string paymentMethodName { get; set; }

        [MaxLength(45)]
        public string customerNameOnPayment { get; set; }

        public decimal? amount { get; set; }

        //[Column(TypeName = "blob")]
        //public byte[] paymentImg { get; set; }
    }
}
