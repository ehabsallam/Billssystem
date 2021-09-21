using BillEntites.Model;
using BillEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL
{

    public interface IBillRepository
    {
        void SaveBill(BILDTL bill);
        IEnumerable<BILDTL> GetAllBILDTLs();
        BILDTL GetBILDTL(Guid id);
        void DeleteBILDTL(Guid id);
        void UpdateBILDTL(BILDTL student);
        IEnumerable<BILDTL> GetHeader();
        void SaveBill(BillViewModel bill);
    }
}
