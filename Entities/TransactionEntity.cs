using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class TransactionEntity
    {
        [Key]
        [StringLength(50)]
        public string TransactionId { get; set; }

        public DateTime TransactionDate { get; set; }

        public int Quantity { get; set; }

        public bool IsInput { get; set; }

        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
