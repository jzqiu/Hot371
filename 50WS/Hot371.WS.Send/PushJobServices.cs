using System;
using System.Configuration;
using System.ServiceProcess;
using System.Threading;
using QJZ.Framework.Utility;

namespace Hot371.WS.Send
{
    /// <summary>
    /// 用于定时推送的Job
    /// </summary>
    public partial class PushJobServices : ServiceBase
    {

        #region Property
        /// <summary>
        /// 全局定时器对象,在Dispose中释放
        /// </summary>
        private Timer PushTimer { get; set; }

        /// <summary>
        /// 推送回调的逻辑
        /// </summary>
        private TimerCallback Callback
        {
            //{
            //return new PushProcessing().PushData;
            //}
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region Methods
        public PushJobServices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Services开启时执行的动作
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            //执行推送任务
            try
            {
                log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(@"~\App_Data\log4net.config"));
                //初始化定时器
                InitializationTimer();
            }
            catch (Exception ex)
            {
                //释放定时器
                PushTimer.Dispose();
                Log4Helper.Write("推送过程中发生异常：" + ex.Message, LogMessageType.Error);
            }
        }

        /// <summary>
        /// Services结束执行的动作
        /// </summary>
        protected override void OnStop()
        {
            try
            {
                PushTimer.Dispose();
            }
            catch (Exception ex)
            {
                Log4Helper.Write("推送停止发生异常：" + ex.Message, LogMessageType.Error);
            }
        }


        /// <summary>
        /// 初始化定时器
        /// </summary>
        private void InitializationTimer()
        {
            var interval = ConfigurationManager.AppSettings["IntervalTime"];
            if (string.IsNullOrWhiteSpace(interval))
            {
                interval = "3";
            }

            //设置间隔时间默认3分钟,如果有设置取设置值
            var intervalTimer = TimeSpan.FromSeconds(int.Parse(interval)*60);

            //初始化定时器
            PushTimer = new Timer(Callback, null, TimeSpan.FromSeconds(0), intervalTimer);
        }

        #endregion
    }
}
