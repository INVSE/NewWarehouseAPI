using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewWarehouseAPI.Models
{
    public class GoodDetail
    {
        [Key]
        public int GoodDetailId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string GoodName { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string GoodQuantity { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GoodUnits { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string GoodImage { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GoodVendor { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GoodContractNum { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GoodContractDate { get; set; }
    }
}
