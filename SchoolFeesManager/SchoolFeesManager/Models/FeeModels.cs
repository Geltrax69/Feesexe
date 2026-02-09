using SQLite;
using System;

namespace SchoolFeesManager.Models
{
    public class FeeStructure
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FeeName { get; set; } // Tuition, Transport, etc.
        public string ClassName { get; set; } // "X", "All"
        public decimal Amount { get; set; }
        public string Frequency { get; set; } // "Monthly", "Yearly", "OneTime"
        public bool IsOptional { get; set; }
    }

    public class StudentFee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int FeeStructureId { get; set; }
        public string AcademicYear { get; set; }
        public string Month { get; set; } // "April", "May" etc. or null for yearly
        
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        
        [Ignore]
        public decimal DueAmount => TotalAmount - PaidAmount;
        
        [Ignore]
        public string Status => DueAmount <= 0 ? "Paid" : (PaidAmount > 0 ? "Partial" : "Unpaid");
    }

    public class Payment
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMode { get; set; } // Cash, UPI, Cheque
        public string ReferenceNumber { get; set; }
        public string ReceiptNumber { get; set; }
    }
}
