using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardWareInfoAcquire.Dto
{
    /// <summary>
    /// 信息采集类
    /// </summary>
    class HardwareInfo
    {
        /// <summary>
        /// cpu温度
        /// </summary>
        public float cpuTemperature
        {
            get;
            set;
        }

        /// <summary>
        /// cpu占用率
        /// </summary>
        public float cpuLoad
        {
            get;
            set;
        }

        /// <summary>
        /// cpu风扇
        /// </summary>
        public ushort cpuFan
        {
            get;
            set;
        }

        /// <summary>
        /// gpu温度
        /// </summary>
        public float gpuTemperature
        {
            get;
            set;
        }

        /// <summary>
        /// gpu占用
        /// </summary>
        public float gpuLoad
        {
            get;
            set;
        }

        /// <summary>
        /// gpu风扇
        /// </summary>
        public ushort gpuFan
        {
            get;
            set;
        }

        /// <summary>
        /// 硬盘温度
        /// </summary>
        public float hddTemperature
        {
            get;
            set;
        }

        /// <summary>
        /// 主板温度
        /// </summary>
        public float mainBoardTemperature
        {
            get;
            set;
        }

        /// <summary>
        /// 内存占用率
        /// </summary>
        public float memoryLoad
        {
            get;
            set;
        }

        /// <summary>
        /// 已使用内存
        /// </summary>
        public float memoryUsed
        {
            get;
            set;
        }

        /// <summary>
        /// 可用内存
        /// </summary>
        public float memoryAvailable
        {
            get;
            set;
        }
    }
}
