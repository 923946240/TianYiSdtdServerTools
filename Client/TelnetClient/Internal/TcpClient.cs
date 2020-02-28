﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceCoffee.Common.LogManager;
using IceCoffee.Network.Sockets.MulitThreadTcpClient;

namespace TianYiSdtdServerTools.Client.TelnetClient.Internal
{
    internal class TcpClient : BaseClient<TcpSession>
    {
        public TcpClient()
        {

        }

        protected override void OnReconnectDefeated()
        {
            Log.Info("自动重连失败，已尝试次数：" + AutoReconnectMaxCount.ToString());
            base.OnReconnectDefeated();
        }
    }
}
