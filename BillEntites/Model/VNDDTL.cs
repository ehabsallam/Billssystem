using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillEntity.Model
{
   public class VNDDTL
    {
        [Key]
        public Guid VNDCOD { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 60 characters")]
        public string VNDNAM { get; set; }


        public ICollection<BILHDR> bilhdr { get; set; }
    }
}
