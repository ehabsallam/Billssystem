using BillEntites.Model;
using BillEntity;
using BillEntity.Model;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public  class RepositoryBase :IBillRepository
    {
        private RepositoryContext context;
        private DbSet<BILDTL> billEntity;
        private DbSet<BILHDR> hdrEntity;
        public RepositoryBase(RepositoryContext context)
        {
            this.context = context;
            billEntity = context.Set<BILDTL>();
            hdrEntity = context.Set<BILHDR>();
        }

        public void SaveBill(string Date, decimal billprice, string itmName, decimal Itmprice, int itemquantity, string VendorName)
        {
             
            //bill.BILHDR.BILDAT = Date;
            //bill.BILPRC = billprice;

            //context.Entry(bill).State = EntityState.Added;
            //context.SaveChanges();
        }

        //public void DeleteBILDTL(Guid id)
        //{
        //    BILDTL bill = GetBILDTL(id);
        //    billEntity.Remove(bill);
        //    context.SaveChanges(); ;
        //}



        public IEnumerable<BILDTL> GetAllBILDTLs()
        {
            return billEntity.AsEnumerable();
        }

        //public BILDTL GetBILDTL(Guid id)
        //{
        //    return billEntity.SingleOrDefault(s => s.BILCOD == id); ;
        //}

       

        public void UpdateBILDTL(BILDTL bill)
        {
            context.SaveChanges();
        }

       public IEnumerable<BILDTL> GetHeader()
        {
            //IEnumerable<BILHDR> bill = hdrEntity.Include(a=>a.bildtl).Include(a=>a.VNDDTL).ToList();
            IEnumerable<BILDTL> bill = billEntity.Include(a => a.ITMDTL).Include(a => a.BILHDR.VNDDTL).ToList();
      
            return bill;
        }

        public BILDTL GetBILDTL(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteBILDTL(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveBill(BillViewModel bill)
        {
            throw new NotImplementedException();
        }

        public void SaveBill(BILDTL bill)
        {
            throw new NotImplementedException();
        }
    }
}

