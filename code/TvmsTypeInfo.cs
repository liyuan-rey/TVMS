using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TVMS.SmartClient
{
    public sealed class TvmsTypeInfo
    {
        public string typeName;
        public UserControl instance;

        public TvmsTypeInfo(string typeName)
        {
            this.typeName = typeName;
            this.instance = null;
        }
    }
}
