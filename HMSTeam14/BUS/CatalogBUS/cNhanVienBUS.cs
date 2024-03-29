﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;

namespace BUS
{
    public class cNhanVienBUS
    {
        public static List<cNhanVienDO> GetStaffList()
        {
            return DA.cNhanVienDA.GetStaffList();
        }
        public static void InsertNewStaff(string Manhanvien, string Maphongkham, string Manhomnhanvien, string Hoten, string Gioitinh, string Tendangnhap, string Matkhau, string Chucdanh, bool Tinhtrang, DateTime Ngaytao)
        {
            DA.cNhanVienDA.InsertNewStaff(Manhanvien, Maphongkham, Manhomnhanvien, Hoten, Gioitinh, Tendangnhap, Matkhau, Chucdanh, Tinhtrang, Ngaytao);
        }
        public static void UpdateStaffInfor(string Manhanvien, string Maphongkham, string Manhomnhanvien, string Hoten, string Gioitinh, string Chucdanh, bool Tinhtrang)
        {
            DA.cNhanVienDA.UpdateStaffInfor(Manhanvien, Maphongkham, Manhomnhanvien, Hoten, Gioitinh, Chucdanh, Tinhtrang);
        }
        public static string GetIDByGroupName(string Name)
        {
            return DA.cNhomNhanVienDA.GetIDByGroupName(Name);
        }
        public static string GetIDByClinicName(string Name)
        {
            return DA.cPhongKhamDA.GetIDByClinicName(Name);
        }
        public static string GetStaffID()
        {
            return DA.cNhanVienDA.GetStaffID();
        }
        public static void UpdatePassword(string Manhanvien, string Matkhau)
        {
            DA.cNhanVienDA.UpdatePassword(Manhanvien, Matkhau);
        }
        public static bool CheckUser(string username, string password)
        {
            return  DA.cNhanVienDA.CheckUser(username, password);
        }
        public static cNhanVienDO GetStaffInforByID(string ID)
        {
            return DA.cNhanVienDA.GetStaffByID(ID);
        }
        public static string ToMD5(string password)
        {
            return DA.cNhanVienDA.ToMD5(password);
        }
    }
}
