using System.Windows;
using System.Windows.Forms;

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
        private NotifyIcon _notifyIcon;

        public MainWindow()
        {
            InitializeComponent();

            _notifyIcon = new();
            _notifyIcon.Icon = new("pack://application:,,,/Resources/Icon/eriko_app.ico");
            _notifyIcon.Text = "eriko";
            _notifyIcon.Visible = true;
            _notifyIcon.DoubleClick += IconDoubleClick;
        }


        private void IconDoubleClick(object? sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
            this.Activate();
        }
    }
}