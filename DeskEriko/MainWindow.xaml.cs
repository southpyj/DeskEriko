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
        private readonly NotifyIcon _notifyIcon;

        public MainWindow()
        {
            InitializeComponent();

            _notifyIcon = new()
            {
                Icon = new("pack://application:,,,/Resources/Icon/eriko_app.ico"),
                Text = "eriko",
                Visible = true
            };
            _notifyIcon.DoubleClick += IconDoubleClick;
        }

        /// <summary>
        /// 小图标双击时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconDoubleClick(object? sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
            this.Activate();
        }
    }
}