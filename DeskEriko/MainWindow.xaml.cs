using DeskEriko.Common;
using System.Windows;

namespace DeskEriko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// 收入隐藏栏的小图标配置
        /// </summary>
        private TrayIconManager _trayManager = new();

        public MainWindow()
        {
            InitializeComponent();
            InitTrayManager();
        }

        private void InitTrayManager()
        {
            _trayManager.DoubleClick += ActiveWindow;
        }

        /// <summary>
        /// 打开并激活主窗口
        /// </summary>
        /// <param name="sender">触发事件的组件</param>
        /// <param name="e">事件参数</param>
        private void ActiveWindow(object? sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
            this.Activate();
        }
    }
}