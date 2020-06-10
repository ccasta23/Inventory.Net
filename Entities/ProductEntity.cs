﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(600)]
        public string ProductDescription { get; set; }

        [DefaultValue(0)]
        public int TotalQuantity { get; set; }

        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
