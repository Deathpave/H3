using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebServer
{
    public class Server
    {
        // bool to check if server is alive
        public bool running = false;

        // encoder to encode messages
        private Encoding _encoder = Encoding.UTF8;
        // the servers net socket
        private Socket _serverSocket;
        // path of content
        private string _contentPath;

        public bool Start(IPAddress ipAddress, int port, string contentPath)
        {
            // checks if server is running, to prevent multiple starts
            if (running)
                return false;

            try
            {
                // creates the socket for the server
                _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // binds the socket, to given IPAddress and port ( where to listen)
                _serverSocket.Bind(new IPEndPoint(ipAddress, port));
                // tells the socket to listen (int max connections qued)
                _serverSocket.Listen();
                // sets the amount of time to wait before timing out
                _serverSocket.ReceiveTimeout = 10;
                _serverSocket.SendTimeout = 10;
                // sets the server to active
                running = true;
                // sets the content path
                _contentPath = contentPath;
            }
            catch (Exception)
            {
                return false;
            }

            // starts a thread to listen for requests for the server
            Thread listener = new Thread(() =>
            {
                // runs thread while server is running
                while (running)
                {
                    // empty client socket
                    Socket clientsocket;
                    try
                    {
                        // creates a connection to any recieved request
                        // on the server socket
                        clientsocket = _serverSocket.Accept();
                        // creates a thread to handle the connection
                        Thread connectionHandler = new Thread(() =>
                        {
                            // sets clients time outs
                            clientsocket.ReceiveTimeout = 10;
                            clientsocket.SendTimeout = 10;
                            try
                            {
                                // attempt to handle the connection
                                ConnectionHandler(clientsocket);
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    // attempt to close the connection
                                    clientsocket.Close();
                                }
                                catch (Exception)
                                {
                                }
                            }
                        });
                        // starts the connectionhandler thread
                        connectionHandler.Start();
                    }
                    catch (Exception)
                    {
                    }
                }
            });
            // starts the listener thread
            listener.Start();
            return true;
        }

        public void Stop()
        {
            if (running)
            {
                running = false;
                try
                {
                    // closes the server socket
                    _serverSocket.Close();
                }
                catch (Exception)
                {
                }
                // nulls the socket, to remove any leftover data
                _serverSocket = null;
            }
        }

        private void ConnectionHandler(Socket clientSocket)
        {
            // creates a buffer for the message
            byte[] buffer = new byte[10240];
            // received bytes from the client socket
            int receivedBytes = clientSocket.Receive(buffer);
            // transform bytes to string via encoding
            string receivedMsg = _encoder.GetString(buffer, 0, receivedBytes);
            string method = receivedMsg.Substring(0, receivedMsg.IndexOf(" "));
            // finds the start of message
            int start = receivedMsg.IndexOf(method) + method.Length + 1;
            // finds length of message
            int length = receivedMsg.LastIndexOf("HTTP") - start - 1;
            // gets the request message (url)
            string url = receivedMsg.Substring(start, length);

            // if request method is GET
            string? file = null;
            if (method == "GET")
            {
                file = url.Split('?')[0];
            }
            else
            {
                // sends a response to the client
                sendResponse(clientSocket, new byte[0], "", "404");
                return;
            }

            if (file != null)
            {
                // ensures filepath is in correct format
                file = file.Replace("/", @"\").Replace("\\..", "");
                // find where the extension starts
                start = file.LastIndexOf('.') + 1;
                if (start > 0)
                {
                    // length of file without extension
                    length = file.Length - start;
                    // extension name
                    string extension = file.Substring(start, length);
                    // if the extension is supported 
                    if (extensions.ContainsKey(extension))
                    {
                        // if the file exists in the content folder
                        if (File.Exists(_contentPath + file))
                        {
                            // responds the client  with the file as byte[]
                            sendResponse(clientSocket, File.ReadAllBytes(_contentPath + file), extension);
                        }
                        else
                        {
                        }
                    }
                }
            }
        }


        private void sendResponse(Socket client, byte[] byteContent, string contenttype, string code = "200")
        {
            try
            {
                // creates a header byte[]
                byte[] header = _encoder.GetBytes(
                    "HTTP/1.1 " + code + "\r\n"
                    + "Server: H3MM\r\n"
                    + "Content-Length: " + byteContent.Length.ToString() + "\r\n"
                    + "Connection: close\r\n"
                    + "Content-Type: " + contenttype + "\r\n\r\n");
                // sends the header byte[]
                client.Send(header);
                // sends the content of the file
                client.Send(byteContent);
                client.Close();
            }
            catch (Exception)
            {
            }
        }

        private Dictionary<string, string> extensions = new Dictionary<string, string>()
        {
            // extensions / file types
            { "html","text/html"},
            {"xml","text/xml" },
            {"txt","text/plain" }
        };
    }
}
