using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QLNhaSach.Modules
{
    class XLNSX:XLBANG
    {
        public XLNSX() : base("NSX") { }
        public XLNSX(string pQuery) : base("NSX", pQuery) { }
    }
}