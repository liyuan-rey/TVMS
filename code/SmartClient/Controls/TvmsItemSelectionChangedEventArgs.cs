using System;
using System.Collections.Generic;
using System.Text;

namespace TVMS.SmartClient.Controls
{
    class TvmsItemSelectionChangedEventArgs : EventArgs
    {
        private readonly string dataTypeName;
        private readonly Type dataType;
        private readonly object dataInstance;

        public TvmsItemSelectionChangedEventArgs(string dataTypeName, Type dataType, object dataInstance)
        {
            this.dataTypeName = dataTypeName;
            this.dataType = dataType;
            this.dataInstance = dataInstance;
        }

        public string DataTypeName
        {
            get { return this.DataTypeName; }
        }

        public Type DataType
        {
            get { return this.DataType; }
        }

        public object DataInstance
        {
            get { return this.dataInstance; }
        }
    }

    public delegate void TvmsItemSelectionChangedEventHandler(object sender, TvmsItemSelectionChangedEventArgs e);
}
