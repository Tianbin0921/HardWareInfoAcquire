using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shenhuaBlister.util
{
    /// <summary>
    /// 字节转换公共类
    /// </summary>
    class ByteToAllType
    {
        /// <summary>
        /// byte转int类型
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static int bytes2Int(byte[] bytes)
        {
            int num = bytes[3] & 0xFF;
            num |= ((bytes[2] << 8) & 0xFF00);
            num |= ((bytes[1] << 16) & 0xFF0000);
            num |= ((bytes[0] << 24) & 0xFF0000);
            return num;
        }
        /// <summary>
        /// int 转byte
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static byte[] int2ByteArray(int i)
        {
            byte[] result = new byte[4];
            result[0] = (byte)((i >> 24) & 0xFF);
            result[1] = (byte)((i >> 16) & 0xFF);
            result[2] = (byte)((i >> 8) & 0xFF);
            result[3] = (byte)(i & 0xFF);
            return result;
        }

        /// <summary>
        /// int转二进制
        /// </summary>
        /// <param name="be"></param>
        /// <returns></returns>
        public static String bytes2ErjinZhiString(byte be)
        {
            String erjinzhiCHuan = ""; 
            erjinzhiCHuan= Convert.ToString(be,2).PadLeft(8,'0');  
            return erjinzhiCHuan; 
        }

        public static String byte2HexStr(byte[] bytes, int length)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }

            return returnStr;
        }  
    }
}
