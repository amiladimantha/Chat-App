using ChatClient.MVVM.Core;
using ChatClient.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.MVVM.ViewModel
{
    class MainViewModel
    {
        public RelayCmd ConnectToServerCommand { get; set; }

        public Server _server;
        public MainViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new RelayCmd(o => _server.ConnectToServer());
        }
    }
}
