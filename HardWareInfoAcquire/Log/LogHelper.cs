using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HardWareInfoAcquire.Log
{
    class LogHelper
    {
        string logFile = "";
        /// <summary>
        /// 不带参数构造函数
        /// </summary>
        public LogHelper()
        {
        }

        /// <summary>
        /// 带参数构造函数
        /// </summary>
        /// <param name="logFile"></param>
        public LogHelper(string logFile)
        {
            this.logFile = logFile;
            CreateDirectory(this.logFile);
        }

        /// <summary>
        /// 追加一条信息
        /// </summary>
        /// <param name="text"></param>
        public void Write(string text)
        {
            using (StreamWriter sw = new StreamWriter(this.logFile, true, Encoding.UTF8))
            {
                sw.Write(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + text);
            }
        }

        /// <summary>
        /// 追加一条信息
        /// </summary>
        /// <param name="logFile"></param>
        /// <param name="text"></param>
        public void Write(string logFile, string text)
        {
            using (StreamWriter sw = new StreamWriter(logFile, true, Encoding.UTF8))
            {
                sw.Write(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + text);
            }
        }

        /// <summary>
        /// 追加一行信息
        /// </summary>
        /// <param name="text"></param>
        public void WriteLine(string text)
        {
            text += "\r\n";
            using (StreamWriter sw = new StreamWriter(this.logFile, true, Encoding.UTF8))
            {
                sw.Write(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + text);
            }
        }

        /// <summary>
        /// 追加一行信息
        /// </summary>
        /// <param name="logFile"></param>
        /// <param name="text"></param>
        public void WriteLine(string logFile, string text)
        {
            text += "\r\n";
            using (StreamWriter sw = new StreamWriter(logFile, true, Encoding.UTF8))
            {
                sw.Write(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + text);
            }
        }

        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="infoPath"></param>
        public void CreateDirectory(string infoPath)
        {
            DirectoryInfo directoryInfo = Directory.GetParent(infoPath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

    }
}
