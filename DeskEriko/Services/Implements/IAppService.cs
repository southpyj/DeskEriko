
namespace DeskEriko.Services.Implements
{
    /// <summary>
    /// 应用管理类
    /// </summary>
    internal interface IAppService
    {
        /// <summary>
        /// 按名称搜索app
        /// </summary>
        /// <param name="name">要搜索的名称</param>
        public void SearchApp(string name);

        /// <summary>
        /// 打开指定的app
        /// </summary>
        /// <param name="name">app名称</param>
        public void OpenApp(string name);
    }
}
