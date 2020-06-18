
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QLNhaSach.Modules
{
    class XLKHACHHANG:XLBANG
    {
        public XLKHACHHANG() : base("KHACHHANG") { }
        public XLKHACHHANG(string pQuery) : base("KHACHHANG", pQuery) { }
    }
}