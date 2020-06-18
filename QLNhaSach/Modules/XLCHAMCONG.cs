using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaSach.Modules
{
    class XLCHAMCONG:XLBANG
    {
        public XLCHAMCONG() : base("CHAMCONG") { }
        public XLCHAMCONG(string pQuery) : base("CHAMCONG", pQuery) { }
    }
}   