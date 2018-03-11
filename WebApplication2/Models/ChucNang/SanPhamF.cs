using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.CSDL;

namespace WebApplication2.Models.CSDL

{
    public class SanPhamF
    {
        private csdl context;
        public SanPhamF()
        {
            context = new csdl();
        }

        // Trả về toàn bộ bảng
        public IQueryable<Tour> DSSanPham
        {
            get { return context.Tours; }
        }

        // Trả về một đối tượng, khi biết Khóa
        public Tour FindEntity(string MaSP)
        {
            Tour dbEntry = context.Tours.Find(MaSP);
            return dbEntry;
        }

        // Thêm một đối tượng
        public string Insert(Tour model)
        {
            Tour dbEntry = context.Tours.Find(model.MaTour);

            if (dbEntry != null)
            {
                return null;

            }
            context.Tours.Add(model);
            context.SaveChanges();
            return model.MaTour;
        }

        // Sửa một đối tượng theo khóa
        public string Update(Tour model)
        {
            Tour dbEntry = context.Tours.Find(model.MaTour);
            //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
            //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.TenTour = model.TenTour;
            dbEntry.DiaChiTour = model.DiaChiTour;
            dbEntry.NgayKhoiHanh = model.NgayKhoiHanh;
            dbEntry.Gia = model.Gia;
            // Sửa các trường khác cũng như vậy
            context.SaveChanges();

            return model.MaTour;
        }

        // Xóa một đối tượng theo Key
        public string Delete(string MaSP)
        {
            Tour dbEntry = context.Tours.Find(MaSP);
            if (dbEntry == null)
            {
                return null;
            }
            context.Tours.Remove(dbEntry);
            context.SaveChanges();
            return MaSP;
        }
    }
}