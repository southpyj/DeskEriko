using System;
using System.Collections.Generic;

namespace DeskEriko.Services.Implements
{
    /// <summary>
    /// 文件转换功能
    /// </summary>
    internal interface IConverterService
    {
        /// <summary>
        /// jpg 文件转icon文件
        /// </summary>
        /// <param name="origin">转换前的文件路径</param>
        /// <param name="converterd">转换后的文件路径</param>
        /// <returns>文件是否转换成功</returns>
        public bool JPGToIcon(string origin, string converterd);
    }
}
