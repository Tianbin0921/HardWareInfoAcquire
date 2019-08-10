using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardWareInfoAcquire.Model
{
    /// <summary>
    /// 调整参数
    /// </summary>
    class Adjust
    {
        /// <summary>
        /// 类型 cpu gpu 硬盘 主板
        /// </summary>
        public string adjustType
        {
            get;
            set;
        }

        /// <summary>
        /// 风扇加速时间
        /// </summary>
        public int accelerationTime_fan
        {
            get;
            set;
        }

        /// <summary>
        /// 风扇延迟时间
        /// </summary>
        public int accelerationDelay_fan
        {
            get;
            set;
        }

        /// <summary>
        /// uuid
        /// </summary>
        public string uuid
        {
            get;
            set;
        }
    }
}
