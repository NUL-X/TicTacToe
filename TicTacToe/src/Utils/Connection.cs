using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using TicTacToe;
using TicTacToe.Forms;

namespace TicTacToe.Utils
{
    public class Connection
    {
        #region Variables

        // Reference for the TicTacToe main screen
        private GridForm _gameForm = null;
        
        // Thread for client and server
        private Thread _clientThread;
        private Thread _serverThread;

        // Server IP and port
        private string _serverHostname;
        const int SERVERPORT = 20413;

        // Loop control variables for client and server threads
        private bool _onlineServer = true;
        private bool _connectedAsClient = true;

        // TCP & NetworkStream objects for client and server
        private NetworkStream _socketStream;
        private TcpClient _tcpClient;
        private TcpListener _tcpListener;
        private Socket _serverSocket;

        #endregion

        #region Constructor

        public Connection(GridForm gameFrom)
        {
            _gameForm = gameFrom; // References screen game
        }

        #endregion

        #region Client

        public void ConnectServer(string hostname)
        {
            // Connect to a game server
            _serverHostname = hostname;
            _clientThread = new Thread(ClientThread);
            _clientThread.Start();
        }
        
        private void ClientThread()
        {
            // Thread for receiving packets from server
            try
            {
                var data = new byte[512];
                var receivedData = 0;

                _tcpClient = new TcpClient(_serverHostname, SERVERPORT);
                _socketStream = _tcpClient.GetStream();

                _gameForm.RestartGame();
                _gameForm.SetStatusMessage("Connected!");
                _connectedAsClient = true;

                while (_connectedAsClient)
                {
                    // Thread is blocked until receives data
                    try {
                        receivedData = _socketStream.Read(data, 0, 2);
                    } catch {
                        return;
                    }

                    // Processes network packet
                    if (receivedData <= 0) continue;
                    
                    // Control packet for game restart
                    if (data[0] == byte.Parse(StringUtils.Asc("R").ToString()))
                    {
                        _gameForm.RestartGame(); // Receive R & RESTART game
                        continue;
                    }

                    // Packet indicating a game move
                    var x = int.Parse(Convert.ToChar(data[0]).ToString());
                    var y = int.Parse(Convert.ToChar(data[1]).ToString());
                    if ((x <= 0 || x >= 3) || (y <= 0 || y >= 3)) continue;
                    _gameForm.isConnected = true;
                    _gameForm.MakeMove(x, y);
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred: " + ex.Message + '\n' + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _gameForm.DisconnectButton_Click(null, null);
                return;
            }
        }

        #endregion

        #region Server

        public void StartServer()
        {
            // Starts game server
            _serverThread = new Thread(ServerThread);
            _serverThread.Start();
        }
        
        private void ServerThread()
        {
            // Thread for receiving packets from client
            try
            {
                var receivedData = new byte[512];
                var localHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                var bytesReceived = 0;

                _tcpListener = new TcpListener(localHostEntry.AddressList[0], SERVERPORT);
                _tcpListener.Start();
                
                // Thread is blocked until it gets a connection from client
                _serverSocket = _tcpListener.AcceptSocket();
                _socketStream = new NetworkStream(_serverSocket);

                _gameForm.RestartGame();
                _gameForm.SetStatusMessage("Connected!");
                _onlineServer = true;
                Console.WriteLine("Server up");

                while (_onlineServer)
                {
                    // Thread is blocked until receives data
                    try {
                        bytesReceived = _socketStream.Read(receivedData, 0, 2);
                        Console.WriteLine("Receiving data");
                    } catch {
                        return;
                    }

                    // Processes network packet
                    if (bytesReceived <= 0) continue;
                    
                    // Control packet for game restart
                    if (receivedData[0] == byte.Parse(StringUtils.Asc("R").ToString()))
                    {
                        _gameForm.RestartGame();
                        continue;
                    }
                    
                    // Packet indicating a game move
                    var x = int.Parse(Convert.ToChar(receivedData[0]).ToString());
                    var y = int.Parse(Convert.ToChar(receivedData[1]).ToString());
                    if ((x <= 0 || x >= 3) || (y <= 0 || y >= 3)) continue;
                    _gameForm.isConnected = true;
                    _gameForm.MakeMove(x, y);
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred: " + ex.Message + '\n' + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _gameForm.DisconnectButton_Click(null, null);
                return;
            }
        }

        #endregion

        #region Packet Funtions

        public void SendPacketTCP(byte[] data)
        {
            // Sends a packet via TCP
            try
            {
                if (_socketStream == null || !_socketStream.CanWrite) return;
                _socketStream.Write(data, 0, 2);
                _socketStream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred: " + ex.Message + '\n' + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _gameForm.DisconnectButton_Click(null, null);
                return;
            }
        }

        public void SendMove(int x, int y)
        {
            // Sends packet that shows move position
            var data = new byte[2];
            data[0] = byte.Parse(StringUtils.Asc(x.ToString()).ToString());
            data[1] = byte.Parse(StringUtils.Asc(y.ToString()).ToString());
            SendPacketTCP(data);
        }

        public void SendsRestartPacket()
        {
            // Sends packet for the other game restart
            var data = new byte[2];
            data[0] = byte.Parse(StringUtils.Asc("R").ToString());
            data[1] = 0;
            SendPacketTCP(data);
        }

        public void Disconnect()
        {
            // Disconnect client and server
            // TODO : Check if connected in the first place
            _socketStream?.Close();
            if (_gameForm.isClient){
                _clientThread.Abort();
                _connectedAsClient = false;
                _tcpClient?.Close();
            } else {
                _serverThread.Abort();
                _onlineServer = false;
                _tcpListener?.Stop();
                _serverSocket?.Shutdown(SocketShutdown.Both);
            }
        }

        #endregion
    }
}