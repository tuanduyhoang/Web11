using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web11
{
    public class Nhanvien
    {
        string hoTen;
        DateTime namSinh;
        public Nhanvien(string ht, DateTime ns)
        {
            this.hoTen = ht;
            this.namSinh = ns;
        }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
    }
}