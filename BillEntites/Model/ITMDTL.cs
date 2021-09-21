using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillEntity.Model
{
    public class ITMDTL
    {

        [Key] 
        public Guid ITMCOD { get; set; }

        [Required(ErrorMessage = "itemName is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 60 characters")]
        public string ITMNAM { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public Decimal ITMPRC { get; set; }


        public ICollection<BILDTL> bildtl { get; set; }
    }
}
