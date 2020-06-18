using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QLNhaSach.Modules
{
    class XLDONHANG:XLBANG
    {
        public XLDONHANG() : base("DONHANG") { }
        public XLDONHANG(string pQuery) : base("DONHANG", pQuery) { }
    }
}