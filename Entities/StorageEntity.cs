using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {

        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        public DateTime LastUpdate { get; set; }

        [DefaultValue(0)]
        public int PartialQuantity { get; set; }

        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        public string WareHouseId { get; set; }
        public WareHouseEntity WareHouse { get; set; }

        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
