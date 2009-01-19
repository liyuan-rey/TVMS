using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace TVMS.DBUtility
{
    class ORMHelper
    {
        public static void RelationalToObject(object p_obj, IDataRecord p_dataReader)
        {
            //--- Get Object Properties
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(p_obj);

            //--- Apply OR-Mapping
            for (int dataIndex = 0; dataIndex < p_dataReader.FieldCount; dataIndex++)
            {
                string fieldName = p_dataReader.GetName(dataIndex).Trim().ToLower();

                for (int propertyIndex = 0; propertyIndex < props.Count; propertyIndex++)
                {
                    PropertyDescriptor prop;
                    try
                    {
                        prop = props[propertyIndex];
                    }
                    catch
                    {
                        continue;
                    }

                    //--- Omit IListTypes (child collections)
                    if (prop.IsReadOnly || prop.PropertyType.GetInterface("IList") != null)
                        continue;

                    if (fieldName == prop.Name.Trim().ToLower())
                    {
                        try
                        {
                            if (!DBNull.Value.Equals(p_dataReader[dataIndex]))
                                prop.SetValue(p_obj, p_dataReader[dataIndex]);
                        }
                        catch (System.ArgumentException e)
                        {
                            StringBuilder s = new StringBuilder();
                            s.AppendFormat("ORM Error: {0} {1}.{2} does not match database type {3} of column {4}",
                                prop.PropertyType.Name, p_obj.GetType().Name, prop.Name,
                                p_dataReader[dataIndex].GetType().Name, p_dataReader.GetName(dataIndex));

                            System.Console.WriteLine(s.ToString());
                            throw e;
                        }
                    }
                }
            }

        }

        public static void RelationalToObject(object p_obj, DataRow p_dataRow)
        {
            //--- Get Object Properties
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(p_obj);

            //--- Apply OR-Mapping

            foreach (DataColumn column in p_dataRow.Table.Columns)
            {


                for (int propertyIndex = 0; propertyIndex < props.Count; propertyIndex++)
                {
                    PropertyDescriptor prop;
                    try
                    {
                        prop = props[propertyIndex];
                    }
                    catch
                    {
                        continue;
                    }


                    //--- Omit IListTypes (childcollections)
                    if (prop.PropertyType.GetInterface("IList") == null && !prop.IsReadOnly)
                    {
                        if (prop.Name.Trim().ToLower() == column.ColumnName.Trim().ToLower())
                        {
                            prop.SetValue(p_obj, p_dataRow[column]);
                        }
                    }
                }
            }

        }

        public static void ObjectToRelational(object p_obj, DataRow p_dataRow)
        {
            //--- Get Object Properties
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(p_obj);

            //--- Loop trough the object properties
            for (int propertyIndex = 0; propertyIndex < props.Count; propertyIndex++)
            {
                //--- Get the Property
                PropertyDescriptor prop = props[propertyIndex];

                //--- Map data to Appropriate Row Column, omiting ChildCollections
                if (prop.PropertyType.GetInterface("IList") == null)
                {
                    try
                    {
                        try
                        {
                            if (prop.Name.Trim().ToLower() == p_dataRow.Table.Columns[prop.Name].ColumnName.Trim().ToLower())
                            {
                                p_dataRow[prop.Name] = prop.GetValue(p_obj);
                            }
                        }
                        catch //--- Ignore non Row Related properties
                        {
                            continue;
                        }


                    }
                    catch (NotImplementedException ex)
                    {
                        throw ex;
                    }
                }

            }


        }

    }
}
