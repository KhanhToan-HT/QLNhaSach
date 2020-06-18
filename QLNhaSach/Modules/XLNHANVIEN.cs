using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QLNhaSach.Modules
{
    class XLNHANVIEN:XLBANG
    {
        public XLNHANVIEN() : base("NHANVIEN") { }
        public XLNHANVIEN(string pQuery) : base("NHANVIEN", pQuery) { }
    }
}