﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;

namespace BUS
{
    public class cPhongKhamBUS
    {
        public static List<cPhongKhamDO> Getdsphongkham()
        {
            return DA.cPhongKhamDA.Getdsphongkham();
        }

        public static void Insertphongkham(string MAPHONGKHAM, string TENPHONG, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cPhongKhamDA.Insertphongkham(MAPHONGKHAM,TENPHONG,NGAYTAO,TRANGTHAI);
        }

        public static void Updatephongkham(string MAPHONGKHAM, string TENPHONG, DateTime NGAYTAO, Boolean TRANGTHAI)
        {
            DA.cPhongKhamDA.Updatephongkham(MAPHONGKHAM, TENPHONG, NGAYTAO, TRANGTHAI);
        }

        public static bool Checkphongkham (string PHONGKHAM)
        {
            return DA.cPhongKhamDA.Checkphongkham(PHONGKHAM);
        }

        public static string Getmaphongkham()
        {
            return DA.cPhongKhamDA.Getmaphongkham();
        }
    }
}
