using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskEriko.Common
{
    /// <summary>
    /// 托盘图标管理类
    /// </summary>
    internal class TrayIconManager
    {
        /// <summary>
        /// 图标通知类
        /// </summary>
        private readonly NotifyIcon _notifyIcon;

        /// <summary>
        /// 图标显示图片
        /// </summary>
        private const string _iconFile = "pack://application:,,,/Resources/Icon/eriko_app.ico";

        /// <summary>
        /// 图标显示的文本
        /// </summary>
        private const string _iconText = "eriko";

        /// <summary>
        /// 图标被双击时的事件
        /// </summary>
        public event EventHandler? DoubleClick;

        public TrayIconManager()
        {
            _notifyIcon = new()
            {
                Icon = new(_iconFile), 
                Text = _iconText,
                Visible = true
            };
            _notifyIcon.DoubleClick += DoubleClick;
        }
    }
}
