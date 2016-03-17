﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using NewLife.Net;

namespace NewLife.MessageQueue
{
    /// <summary>MQ客户端</summary>
    public class MQClient : DisposeBase
    {
        #region 属性
        /// <summary>名称</summary>
        public String Name { get; set; }

        /// <summary>远程地址</summary>
        public NetUri Remote { get; set; }

        /// <summary>网络客户端</summary>
        public ISocketClient Client { get; set; }
        #endregion

        #region 构造函数
        /// <summary>实例化</summary>
        public MQClient()
        {
            Remote = new NetUri(ProtocolType.Tcp, NetHelper.MyIP(), 2234);
            // 还未上消息格式，暂时用Udp替代Tcp，避免粘包问题
            //Remote = new NetUri(ProtocolType.Udp, NetHelper.MyIP(), 2234);
        }
        #endregion

        #region 启动方法
        public void Open()
        {
            if (Client == null || Client.Disposed)
            {
                Client = Remote.CreateRemote();
                Client.Received += Client_Received;
                Client.Open();

                Client.Send("Name " + Name);
            }
        }
        #endregion

        #region 发布订阅
        /// <summary>发布主题</summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        public Boolean Public(String topic)
        {
            Open();

            Client.Send("Public " + topic);

            return true;
        }

        /// <summary>订阅主题</summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        public Boolean Subscribe(String topic)
        {
            Open();

            Client.Send("Subscribe " + topic);

            return true;
        }
        #endregion

        #region 收发消息
        /// <summary>发布消息</summary>
        /// <param name="topic"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public Boolean Send(String topic, Object msg)
        {
            Open();

            Client.Send("Message " + topic);

            return true;
        }

        public EventHandler<EventArgs<Object>> Received;

        void Client_Received(object sender, ReceivedEventArgs e)
        {
            if (Received != null) Received(this, new EventArgs<object>(e.Data.ReadBytes(e.Length)));
        }
        #endregion
    }
}