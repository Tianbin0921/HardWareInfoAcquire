using HardWareInfoAcquire.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using HardWareInfoAcquire.Util;
using HardWareInfoAcquire.DataHelper;

namespace HardWareInfoAcquire.Model.impl
{
    class TemperatureAdjustImpl : InterfaceTemperatureAdjust
    {
        public void add(Adjust adjust)
        {
            string sql = "insert into temperature_adjust (adjustType,accelerationTime_fan,accelerationDelay_fan,uuid,enable) ";
            sql += "values(@adjustType,@accelerationTime_fan,@accelerationDelay_fan,@uuid) ";

            SQLiteParameter[] parameters = {
            new SQLiteParameter("@adjustType",DbType.Int32),
            new SQLiteParameter("@accelerationTime_fan",DbType.Int32),
            new SQLiteParameter("@accelerationDelay_fan",DbType.Int32),
            new SQLiteParameter("@uuid",DbType.String),
            new SQLiteParameter("@enable",DbType.Int32)};

            parameters[0].Value = adjust.adjustType;
            parameters[1].Value = adjust.accelerationTime_fan;
            parameters[2].Value = adjust.accelerationDelay_fan;
            parameters[3].Value = StringUtil.getUUid();
            parameters[4].Value = 1;

            SQLiteHelper.ExecuteSql(sql, parameters);
        }

        public void delete(string uuid)
        {
            String sql = "delete from temperature_adjust where uuid= @uuid ";
            SQLiteParameter[] parameters = { new SQLiteParameter("@uuid", DbType.String) };
            parameters[0].Value = uuid;
            SQLiteHelper.ExecuteSql(sql, parameters);
        }

        public DataTable getAllData(Adjust adjust)
        {
            string sql = "select uuid,adjustType,accelerationTime_fan,accelerationDelay_fan from temperature_adjust where enable = 1 ";
            if (StringUtil.checkStringIsNotNull(adjust.adjustType))
            {
                sql += " and adjustType = " + adjust.adjustType;
            }

            DataSet ds = SQLiteHelper.Query(sql);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public void update(Adjust adjust)
        {
            string sql = "update temperature_adjust set adjustType=@adjustType,accelerationTime_fan=@accelerationTime_fan,accelerationDelay_fan=@accelerationDelay_fan where uuid=@uuid";

            SQLiteParameter[] parameters = {
                new SQLiteParameter("@adjustType",DbType.Int32),
                new SQLiteParameter("@accelerationTime_fan",DbType.Int32),
                new SQLiteParameter("@accelerationDelay_fan",DbType.Int32),
                new SQLiteParameter("@uuid", DbType.String)
            };
            parameters[0].Value = adjust.adjustType;
            parameters[1].Value = adjust.accelerationTime_fan;
            parameters[2].Value = adjust.accelerationDelay_fan;
            parameters[3].Value = adjust.uuid;

            SQLiteHelper.ExecuteSql(sql, parameters);
        }

        public Adjust getByUUid(string uuid)
        {
            string sql = "select uuid,adjustType,accelerationTime_fan,accelerationDelay_fan from temperature_adjust where enable = 1 and uuid='" + uuid + "' ";
            DataSet ds = SQLiteHelper.Query(sql);
            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable db = ds.Tables[0];
                if (db.Rows.Count > 0)
                {
                    Adjust adjust = new Adjust();
                    adjust.uuid = db.Rows[0]["uuid"].ToString();
                    adjust.adjustType = db.Rows[0]["adjustType"].ToString();
                    adjust.accelerationTime_fan = Convert.ToInt32(db.Rows[0]["accelerationTime_fan"].ToString());
                    adjust.accelerationDelay_fan = Convert.ToInt32(db.Rows[0]["accelerationDelay_fan"].ToString());

                    return adjust;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
