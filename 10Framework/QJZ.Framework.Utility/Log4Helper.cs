using System;
using log4net;

namespace QJZ.Framework.Utility
{
    /// <summary>
    /// log4net工具类
    /// </summary>
    public class Log4Helper
    {
        /// <summary>
        /// 初始化日志系统
        /// 在系统运行开始初始化
        /// Global.asax Application_Start内
        /// </summary>
        public static void Init(string configFilePath)
        {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(configFilePath));
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">信息类型</param>
        public static void Write(string message, LogMessageType messageType)
        {
            DoLog(message, messageType, null, Type.GetType("System.Object"));
        }

        /// <summary>
        /// 根据预制日志分类,写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">信息类型</param>
        /// <param name="logType">日志类型</param>
        /// <remarks>
        /// added by 王纪虎 at 2011-11-10
        /// </remarks>
        public static void Write(string message, LogMessageType messageType, LogType logType)
        {
            Write(message, messageType, logType, null);
        }

        /// <summary>
        /// 根据预制日志分类,写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">信息类型</param>
        /// <param name="logType">日志类型</param>
        /// <param name="ex">Exception</param>
        /// <remarks>
        /// added by 王纪虎 at 2011-11-10
        /// </remarks>
        public static void Write(string message, LogMessageType messageType, LogType logType, Exception ex)
        {
            DoLog(message, messageType, ex, logType);
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="type"></param>
        public static void Write(string message, LogMessageType messageType, Type type)
        {
            DoLog(message, messageType, null, type);
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="ex">异常</param>
        public static void Write(string message, LogMessageType messageType, Exception ex)
        {
            DoLog(message, messageType, ex, Type.GetType("System.Object"));
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="ex">异常</param>
        /// <param name="type"></param>
        public static void Write(string message, LogMessageType messageType, Exception ex, Type type)
        {
            DoLog(message, messageType, ex, type);
        }

        /// <summary>
        /// 断言
        /// </summary>
        /// <param name="condition">条件</param>
        /// <param name="message">日志信息</param>
        public static void Assert(bool condition, string message)
        {
            Assert(condition, message, Type.GetType("System.Object"));
        }

        /// <summary>
        /// 断言
        /// </summary>
        /// <param name="condition">条件</param>
        /// <param name="message">日志信息</param>
        /// <param name="type">日志类型</param>
        public static void Assert(bool condition, string message, Type type)
        {
            if (condition == false)
                Write(message, LogMessageType.Info);
        }

        /// <summary>
        /// 保存日志
        /// </summary>
        /// <param name="message">日志信息</param>
        /// <param name="messageType">日志类型</param>
        /// <param name="ex">异常</param>
        /// <param name="type">日志类型</param>
        private static void DoLog(string message, LogMessageType messageType, Exception ex, Type type)
        {
            DoLog(message, messageType, ex, LogManager.GetLogger(type));
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="messageType"></param>
        /// <param name="ex"></param>
        /// <param name="logType"></param>
        private static void DoLog(string message, LogMessageType messageType, Exception ex, LogType logType)
        {
            DoLog(message, messageType, ex, LogManager.GetLogger(logType.ToString() + "_logger"));
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="messageType"></param>
        /// <param name="ex"></param>
        /// <param name="logger"></param>
        private static void DoLog(string message, LogMessageType messageType, Exception ex, ILog logger)
        {
            switch (messageType)
            {
                case LogMessageType.Debug:
                    {
                        if (ex != null)
                            logger.Debug(message, ex);
                        else
                            logger.Debug(message);
                    }
                    break;
                case LogMessageType.Info:
                    {
                        if (ex != null)
                            logger.Info(message, ex);
                        else
                            logger.Info(message);
                    }
                    break;
                case LogMessageType.Warn:
                    {
                        if (ex != null)
                            logger.Warn(message, ex);
                        else
                            logger.Warn(message);
                    }
                    break;
                case LogMessageType.Error:
                    {
                        if (ex != null)
                            logger.Error(message, ex);
                        else
                            logger.Error(message);
                    }
                    break;
                case LogMessageType.Fatal:
                    {
                        if (ex != null)
                            logger.Fatal(message, ex);
                        else
                            logger.Fatal(message);
                    }
                    break;
            }
        }
    }

    #region 消息类型

    /// <summary>
    /// 消息类型
    /// </summary>
    public enum LogMessageType
    {
        /// <summary>
        /// 调试
        /// </summary>
        Debug,
        /// <summary>
        /// 信息
        /// </summary>
        Info,
        /// <summary>
        /// 警告
        /// </summary>
        Warn,
        /// <summary>
        /// 错误
        /// </summary>
        Error,
        /// <summary>
        /// 致命错误
        /// </summary>
        Fatal
    }

    #endregion
    #region 日志分类

    /// <summary>
    /// 日志记录分类
    /// </summary>
    /// <remarks>
    /// added by 王纪虎 at 2011-11-10
    /// </remarks>
    public enum LogType
    {
        /// <summary>
        /// 请求时间监控
        /// </summary>
        RequestingTimeInfo
    }

    #endregion
}
