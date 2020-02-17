﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IceCoffee.Wpf.MvvmFrame;
using IceCoffee.Wpf.MvvmFrame.NotifyPropertyChanged;
using TianYiSdtdServerTools.Client.Models.SdtdServerInfo;

namespace TianYiSdtdServerTools.Client.Models.ObservableClasses
{
    /// <summary>
    /// 服务器首选项
    /// </summary>
    [NPCA_Class]
    public class SdtdServerPrefModel : ObservableObject
    {
        /// <summary>
        /// 服务器IP地址
        /// </summary>
        public string ServerIP { get; set; }

        /// <summary>
        /// telnet端口
        /// </summary>
        public ushort? TelnetPort { get; set; }

        /// <summary>
        /// telnet密码
        /// </summary>
        public string TelnetPassword { get; set; }

        /// <summary>
        /// GPS端口
        /// </summary>
        public ushort? GPSPort { get; set; }

        /// <summary>
        /// 服务器部分首选项 Preference
        /// </summary>
        public ServerPartialPref ServerPartialPref { get; set; } = new ServerPartialPref();

    }
}
