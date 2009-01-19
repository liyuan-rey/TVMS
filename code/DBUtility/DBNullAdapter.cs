using System;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace TVMS.DBUtility
{
    [TypeConverter(typeof(DBNullAdapterConverter))]
    public class DBNullAdapter
    {
        private static readonly bool defaultBool = false;
        private static readonly int defaultInt = 0;
        private static readonly float defaultFloat = 0;
        private static readonly double defaultDouble = 0;
        private static readonly Decimal defaultDecimal = Decimal.Zero;
        private static readonly DateTime defaultDateTime = DateTime.Today;

        private object data;

        public DBNullAdapter(object data) { this.data = data; }
        //public DBNullAdapter(DateTime data)
        //{
        //    this.data = data;
        //}
        //static public explicit operator DBNullAdapter(object nil) { return new DBNullAdapter(nil); }
        //static public explicit operator DBNullAdapter(DateTime data) { return new DBNullAdapter(data); }
        static public implicit operator bool(DBNullAdapter na) { return DBNull.Value.Equals(na.data) ? defaultBool : (bool)na.data; }
        static public implicit operator int(DBNullAdapter na) { return DBNull.Value.Equals(na.data) ? defaultInt : (int)na.data; }
        static public implicit operator float(DBNullAdapter na) { return DBNull.Value.Equals(na.data) ? defaultFloat : (float)na.data; }
        static public implicit operator double(DBNullAdapter na) { return DBNull.Value.Equals(na.data) ? defaultDouble : (double)na.data; }
        static public implicit operator Decimal(DBNullAdapter na) { return DBNull.Value.Equals(na.data) ? defaultDecimal : (Decimal)na.data; }
        static public implicit operator DateTime(DBNullAdapter na) { return DBNull.Value.Equals(na.data) ? defaultDateTime : (DateTime)na.data; }
    }

    public class DBNullAdapterConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context,
              Type sourceType)
        {

            if (sourceType == typeof(Int32))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }
        // Overrides the ConvertFrom method of TypeConverter.
        public override object ConvertFrom(ITypeDescriptorContext context,
           CultureInfo culture, object value)
        {
            if (value is Int32)
            {
                //string[] v = ((string)value).Split(new char[] { ',' });
                //return new Point(int.Parse(v[0]), int.Parse(v[1]));
                return new DBNullAdapter((int)0);
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(Int32))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }
        // Overrides the ConvertTo method of TypeConverter.
        public override object ConvertTo(ITypeDescriptorContext context,
           CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(Int32))
            {
                return 0;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
