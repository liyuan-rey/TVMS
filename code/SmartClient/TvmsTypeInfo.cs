using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TVMS.SmartClient
{
    public sealed class TvmsTypeInfo
    {
        public string listTypeName;
        public Type listType;
        public ListView listInstance;
        public string pageTypeName;
        public Type pageType;
        public TabPage pageInstance;

        public TvmsTypeInfo(string listTypeName, string pageTypeName)
        {
            InitializeData(listTypeName, null, null, pageTypeName, null, null);
        }

        public TvmsTypeInfo(string listTypeName, Type listType, ListView listInstance, string pageTypeName, Type pageType, TabPage pageInstance)
        {
            InitializeData(listTypeName, listType, listInstance, pageTypeName, pageType, pageInstance);
        }

        private void InitializeData(string listTypeName, Type listType, ListView listInstance, string pageTypeName, Type pageType, TabPage pageInstance)
        {
            this.listTypeName = listTypeName;
            this.listType = listType;
            this.listInstance = listInstance;
            this.pageTypeName = pageTypeName;
            this.pageType = pageType;
            this.pageInstance = pageInstance;
        }
    }
}
