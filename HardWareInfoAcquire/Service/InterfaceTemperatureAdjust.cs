using HardWareInfoAcquire.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HardWareInfoAcquire.Service
{
    /// <summary>
    /// 温度控制解决方案
    /// </summary>
    interface InterfaceTemperatureAdjust
    {
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="adjust"></param>
        /// <returns></returns>
        DataTable getAllData(Adjust adjust);

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="adjust"></param>
        void add(Adjust adjust);

        /// <summary>
        /// 删除UUID对应数据
        /// </summary>
        /// <param name="uuid"></param>
        void delete(string uuid);

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="adjust"></param>
        void update(Adjust adjust);

        /// <summary>
        /// 根据uuid获取记录
        /// </summary>
        /// <param name="uuid"></param>
        /// <returns></returns>
        Adjust getByUUid(string uuid);
    }
}
