using System.Runtime.InteropServices;

namespace DeskEriko.Common
{
    internal static  class ExternManager
    {
        /// <summary>
        /// 注册热键
        /// </summary>
        /// <param name="hwnd">窗口句柄，用于接收热键消息的窗口</param>
        /// <param name="id">热键 ID</param>
        /// <param name="fsModifiers">修饰键（见下表）。</param>
        /// <param name="vk">虚拟键码（Virtual-Key Code）</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hwnd, int id, uint fsModifiers, uint vk);

        /// <summary>
        /// 注销热键
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="id">热键id</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hwnd, int id);
    }
}
