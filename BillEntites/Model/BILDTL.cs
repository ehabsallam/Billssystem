using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillEntity.Model
{
   public class BILDTL
    {
        [Key]
        public Guid DTLCOD { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public Decimal BILPRC { get; set; }

        [Required]
        public int ITMQTY { get; set; }

        [Required]
        [ForeignKey(nameof(BILHDR))]
        public Guid BILCOD { get; set; }
        public BILHDR BILHDR { get; set; }


        [Required]
        [ForeignKey(nameof(ITMDTL))]
        public Guid ITMCOD { get; set; }
        public ITMDTL ITMDTL { get; set; }



    }
}
