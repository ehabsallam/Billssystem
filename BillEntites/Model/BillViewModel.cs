using BillEntity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillEntites.Model
{
   public class BillViewModel
    {
        public BILDTL BillDetails { get; set; }
        public BILHDR BillHeader { get; set; }
        public ITMDTL ItemDetails { get; set; }
        public VNDDTL VendorDetails { get; set; }
    }
}
