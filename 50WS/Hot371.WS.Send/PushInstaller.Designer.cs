using System.ServiceProcess;

namespace Hot371.WS.Send
{

    /// <summary>
    /// 用于PushJob的安装程序
    /// </summary>
    partial class PushInstaller
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            this.PushProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.PushsInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            PushProcessInstaller.Account = ServiceAccount.LocalSystem;
            // 
            this.PushProcessInstaller.Password = null;
            this.PushProcessInstaller.Username = null;
            //注册services 的注册名字必须和Window Service 名字一致  
            this.PushsInstaller.ServiceName = "PushJobServices";
            this.PushsInstaller.DisplayName = "PushJobServices";
            this.PushsInstaller.Description = "This is a services for push message to  tongcheng app";
            // this.PushInstaller.StartType = ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.PushProcessInstaller,
            this.PushsInstaller});
        }

        private System.ServiceProcess.ServiceProcessInstaller PushProcessInstaller;
        private System.ServiceProcess.ServiceInstaller PushsInstaller;
        #endregion
    }
}