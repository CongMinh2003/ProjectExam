﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLiNhaHang;
using DTO_QuanLiNhaHang;

namespace BUS_QuanLiNhaHang
{
    public class BusThucDon
    {
        Dataprovider td = new Dataprovider();

        public DataTable loadThucDon()
        {
            return td.loadThucDon();
        }
    }
}
