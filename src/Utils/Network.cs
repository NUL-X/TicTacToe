using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using TicTacToe.Entities;
using TicTacToe.Forms;

namespace TicTacToe.Utils
{
    public class Network
    {
        #region Variables 
         
        		
        		// Reference for the TicTacToe main screen
        
        		Main objTicTacToe=null;
        					
        		
        		// Thread for client and server
        
        		public Thread thread_receive_client;
        		public Thread thread_receive_server;
        
        		
        		// Server IP and port
        
        		private string serverIP;
        		const int SERVERPORT=12790;
        
        		
        		// Loop control variables for client and server threads
        
        		bool wReceivingServer=true;
        		bool wReceivingClient=true;
        
        		
        		// TCP e NetworkStream objects for client and server
        
        		NetworkStream clientSockStream;
        		NetworkStream serverSockStream; 
        
        		TcpClient tcpClient;
        		TcpListener tcpListener;
        		Socket soTcpServer;
        		
        		#endregion
        
        		#region Constructor 
        
        		public Network(frmTicTacToe pThis)
        		{
        			
        			
        			// References screen game
        
        		   	objTicTacToe=pThis;
        			 
        		}
        
        		#endregion
        
        		#region Client 
        
        		public void ConnectServer(string pIP)
        		{
        
        			
        			// Connect to a game server
        
        			serverIP=pIP;
        			byte[] buf = new byte[1];
        			
        			thread_receive_client = new Thread(new ThreadStart(ThreadReceivingClient));
        			thread_receive_client.Start();
        			
        		}
        
        
        		private void ThreadReceivingClient()
        		{
        			
        			// Thread for receiving packets from server
        
        			try
        			{
        
        				byte[] buf = new byte[512];
        				int bytesReceived=0;
        
        				tcpClient = new TcpClient(serverIP,SERVERPORT);
        				clientSockStream = tcpClient.GetStream();
        
        				objTicTacToe.RestartGame();
        				objTicTacToe.SetStatusMessage("Connected!");
        
        				wReceivingClient=true;
        
        				while (wReceivingClient)
        				{
        				
        					
        					// Thread is blocked until receives data
        			
        					try
        					{
        						bytesReceived = clientSockStream.Read(buf, 0, 2);
        					}
        					catch
        					{
        						return;
        					}
        									
        					
        					// Processes network packet
        				
        					if (bytesReceived>0) 
        					{
        						
        						// Control packet for game restart
        
        						if (buf[0]==byte.Parse(Asc("R").ToString()))
        						{
        							objTicTacToe.RestartGame();
        							continue;
        						}
        
        						
        						// Packet indicating a game move
        			
        						int wRow=int.Parse(Convert.ToChar(buf[0]).ToString());
        						int wColumn=int.Parse(Convert.ToChar(buf[1]).ToString());
        
        						if ((wRow>0 && wRow<4) && (wColumn>0 && wColumn<4))
        						{
        							objTicTacToe.wNetworkPlay=true;
        							objTicTacToe.MakeMove(wRow,wColumn);
        						}
        
        					} //if (bytesReceived>0) 
        			
        				} //while (wReceivingClient)
        
        			}
        			catch (ThreadAbortException ) {}
        			catch (Exception ex)
        			{
        				MessageBox.Show("An error ocurred: " + ex.Message + "\n" + ex.StackTrace);
        				objTicTacToe.mnDisconnect_Click(null,null);
        				return;
        			}
        		}
        
        		#endregion
        
        		#region Server 
         
        		public void StartServer()
        		{
        			
        			
        			// Starts game server
        			
        			thread_receive_server = new Thread(new ThreadStart(ThreadReceivingServer));
        			thread_receive_server.Start();
        		}
        
        	
        		private void ThreadReceivingServer()
        		{
        			
        			// Thread for receiving packets from client
        
        			try 
        			{
        				byte[] buf = new byte[512];
        				IPHostEntry localHostEntry = Dns.GetHostByName(Dns.GetHostName());
        				int bytesReceived=0;
        
        				tcpListener = new TcpListener(localHostEntry.AddressList[0],SERVERPORT);
        
        				tcpListener.Start();
        			
        				
        				// Thread is blocked until it gets a connection from client
        
        				soTcpServer = tcpListener.AcceptSocket();
        
        				serverSockStream = new NetworkStream(soTcpServer);
        
        				objTicTacToe.RestartGame();
        				objTicTacToe.SetStatusMessage("Connected!");
        
        				wReceivingServer=true;
        
        				while (wReceivingServer)
        				{
        
        					
        					// Thread is blocked until receives data
        
        					try 
        					{
        						bytesReceived=serverSockStream.Read(buf,0,2);
        					}
        					catch
        					{
        						return;
        					}
        				
        					
        					// Processes network packet
        
        					if (bytesReceived>0) 
        					{
        
        						
        						// Control packet for game restart
        
        						if (buf[0]==byte.Parse(Asc("R").ToString()))
        						{
        							objTicTacToe.RestartGame();
        							continue;
        						}
        		
        						
        						// Packet indicating a game move
        		
        						int wRow=int.Parse(Convert.ToChar(buf[0]).ToString());
        						int wColumn=int.Parse(Convert.ToChar(buf[1]).ToString());
        
        						if ((wRow>0 && wRow<4) && (wColumn>0 && wColumn<4))
        						{
        							objTicTacToe.wNetworkPlay=true;
        							objTicTacToe.MakeMove(wRow,wColumn);
        						}
        
        					}	//if (bytesReceived>0) 
        			
        				}	//while (wReceivingServer)
        			}
        			catch (ThreadAbortException) {}
        			catch (Exception ex)
        			{
        				MessageBox.Show("An error ocurred: " + ex.Message + "\n" + ex.StackTrace);
        				objTicTacToe.mnDisconnect_Click(null,null);
        				return;
        			}
        		}
        
        		#endregion
        
        		#region Functions for sending packets/disconnect 
         
        		public void SendPacketTCP(Byte[] pDados)
        		{
        			
        			// Sends a packet via TCP
        
        			try
        			{
        				if (objTicTacToe.wClient==true)
        				{
        					if (clientSockStream==null)
        						return;
        
        					if (clientSockStream.CanWrite)
        					{
        						clientSockStream.Write(pDados, 0, 2);
        						clientSockStream.Flush();
        					}
        				}
        				else
        				{
        					if (serverSockStream==null)
        						return;
        
        					if (serverSockStream.CanWrite)
        					{
        						serverSockStream.Write(pDados,0, 2);
        						serverSockStream.Flush();
        					}
        				}
        			}
        			catch (Exception ex)
        			{
        				MessageBox.Show("An error ocurred: " + ex.Message + "\n" + ex.StackTrace);
        				objTicTacToe.mnDisconnect_Click(null,null);
        				return;
        			}
        			
        		}
        
        		public void SendMove(int wRow,int wColumn)
        		{
        			
        			// Sends packet that shows move position
        
        			byte[] buf = new byte[2];
        			buf[0]=byte.Parse(Asc(wRow.ToString()).ToString());
        			buf[1]=byte.Parse(Asc(wColumn.ToString()).ToString());
        
        			SendPacketTCP(buf);
        			
        		}
        
        		public void SendsRestartPacket()
        		{
        			
        			// Sends packet for the other game restart
        
        			byte[] buf = new byte[2];
        			buf[0]=byte.Parse(Asc("R").ToString());
        			buf[1]=0;
        
        			SendPacketTCP(buf);
        
        		}
        
        		public void Disconnect()
        		{
        			
        			// Disconnect client and server
        			
        			if (objTicTacToe.wClient==true)
        			{
        				thread_receive_client.Abort();
        
        				wReceivingClient=false;
        
        				if (clientSockStream!=null)
        					clientSockStream.Close();
        
        				if (tcpClient!=null)
        					tcpClient.Close();
        		
        			}
        
        			if (objTicTacToe.wServer==true)
        			{
        				thread_receive_server.Abort();	
        
        				wReceivingServer=false;
        
        				if (serverSockStream!=null)
        					serverSockStream.Close();
        				
        				if (tcpListener!=null)
        					tcpListener.Stop();
        
        				if (soTcpServer!=null)
        					soTcpServer.Shutdown(SocketShutdown.Both);
        					
        			}
        
        		}
        
        		private static int Asc(string character)
        		{
        			
        			// VB.NET ASC function
        
        			if (character.Length == 1)
        			{
        				System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
        				int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];
        				return (intAsciiCode);
        			}
        			else
        			{
        				throw new ApplicationException("Character is not valid.");
        			}
        
        		}	//private static int Asc(string character)
        
        		#endregion
    }
}