using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web11
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string hoTen = Request.Form["txtHoTen"]; // lấy thông tin từ form điền 
            string sNamSinh = Request.Form["txtNamSinh"];

            if (hoTen == null || sNamSinh == null)
            {
                ArrayList lsNV = (ArrayList)Session["danhsach"];
                string str = "";
                int i = 1;
                foreach (Nhanvien nv in lsNV)
                {
                    str += "<tr><td class='auto-style1'>" + (i++) + "</td><td>" + nv.HoTen.ToString() + "</td><td>" + nv.NamSinh.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) + "</td></tr>";
                }
                tblNhanvien.InnerHtml = str;
                
            }
            else
            {
               
                Nhanvien nhanvien = new Nhanvien(hoTen, DateTime.Parse(sNamSinh, new CultureInfo("vi-VN")));
                ArrayList lsNV = (ArrayList)Session["danhsach"];
                lsNV.Add(nhanvien);
                String str = "";
                int i = 1;
                foreach (Nhanvien nv in lsNV) 
                {
                    str += "<tr><td class='auto-style1'>" + (i++)+"</td><td>"+ nv.HoTen.ToString() + "</td><td>" + nv.NamSinh.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + "</td></tr>";
                }
                tblNhanvien.InnerHtml = str; 
            }
        }

       
    }
}