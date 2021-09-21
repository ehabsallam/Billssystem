using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillEntity.Model
{
  public  class BILHDR
    {
        [Key]
        public Guid BILCOD { get; set; }
        [Required]
        public DateTime BILDAT { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public Decimal BILPRC { get; set; }


        [StringLength(250, ErrorMessage = "Name can't be longer than 60 characters")]
        public string BILIMG { get; set; }


        [ForeignKey(nameof(VNDDTL))]
        public Guid VNDCOD { get; set; }
        public VNDDTL VNDDTL { get; set; }




        public ICollection<BILDTL> bildtl { get; set; }
    }
}
