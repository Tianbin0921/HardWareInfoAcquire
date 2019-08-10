using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HardWareInfoAcquire.DataHelper
{
    /// <summary>
    /// dataset 转成model的方法
    /// </summary>
    class DataSetToList
    {
        /// <summary>         、
        /// DataSet装换为泛型集合         
        /// </summary>         
        /// <typeparam name="T"></typeparam>         
        /// <param name="ds">DataSet</param>         
        /// <param name="tableIndex">待转换数据表索引</param>         
        /// <returns></returns>         
        public static IList<T> DataSetToIList<T>(DataSet ds, int tableIndex)
        {
            if (ds == null || ds.Tables.Count < 0)
                return null;
            if (tableIndex > ds.Tables.Count - 1)
                return null;
            if (tableIndex < 0)
                tableIndex = 0;
            DataTable dt = ds.Tables[tableIndex];

            IList<T> result = new List<T>();
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                T _t = (T)Activator.CreateInstance(typeof(T));
                PropertyInfo[] propertys = _t.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (pi.Name.Equals(dt.Columns[i].ColumnName))
                        {
                            if (dt.Rows[j][i] != DBNull.Value)
                                pi.SetValue(_t, dt.Rows[j][i], null);
                            else
                                pi.SetValue(_t, null, null);
                            break;
                        }
                    }
                } result.Add(_t);
            } return result;
        }


        /// <summary>         
        /// DataSet装换为泛型集合        
        ///  </summary>     
        /// <typeparam name="T"></typeparam>   
        ///<param name="ds">DataSet</param>      
        /// <param name="tableName">待转换数据表名称</param>         
        /// <returns></returns>         
        /// 2008-08-01 22:47 HPDV2806         
        public static IList<T> DataSetToIList<T>(DataSet ds, string tableName)
        {
            int _TableIndex = 0; if (ds == null || ds.Tables.Count < 0)
                return null; if (string.IsNullOrEmpty(tableName))
                return null;
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                if (ds.Tables[i].TableName.Equals(tableName))
                {
                    _TableIndex = i;
                    break;
                }
            }
            return DataSetToIList<T>(ds, _TableIndex);
        }
        public static List<T> GetModelFromDB<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        /// <summary>
        /// 将DataRow转换成实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        private static T GetItem<T>(DataRow dr)
        {
            try
            {
                Type temp = typeof(T);
                T obj = Activator.CreateInstance<T>();
                foreach (DataColumn column in dr.Table.Columns)
                {
                    foreach (PropertyInfo pro in temp.GetProperties())
                    {
                        if (pro.Name.ToLower() == column.ColumnName.ToLower())
                        {
                            if (dr[column.ColumnName] == DBNull.Value)
                            {
                                pro.SetValue(obj, " ", null);
                                break;
                            }
                            else
                            {
                                pro.SetValue(obj, dr[column.ColumnName], null);
                                break;
                            }
                        }
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
