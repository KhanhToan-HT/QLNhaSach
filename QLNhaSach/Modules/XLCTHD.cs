
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaSach.Modules
{
    class XLCTHD:XLBANG
    {
        public XLCTHD() : base ("CTHD") { }
        public XLCTHD(string pQuery) : base("CTHD", pQuery) { }
    }
}