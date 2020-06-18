
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QLNhaSach.Modules
{
    class XLLOAISP:XLBANG
    {
        public XLLOAISP() : base("LOAISP") { }
        public XLLOAISP(string pQuery) : base("LOAISP", pQuery) { }
    }
}