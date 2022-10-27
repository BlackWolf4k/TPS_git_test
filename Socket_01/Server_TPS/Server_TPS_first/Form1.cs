using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Text;

namespace Server_TPS_first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            early_main();

            Debug.WriteLine("cuai");
            Thread server_start_thread = new Thread( new ThreadStart( start_server ) );
            server_start_thread.Start();
            //start_server();
        }

        private void early_main()
        {
            // Create the list view of the requestes
            activities_lv.Columns.Add( "From", 120 );
            activities_lv.Columns.Add( "Request", 656 );
        }

        private void start_server()
        {
            // Start server
            IPEndPoint ip = new IPEndPoint( IPAddress.Parse( "127.0.0.1" ), 1024 );
            Socket socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            
            socket.Bind( ip );

            socket.Listen( 100 );

            while ( true )
            {

                Socket client = socket.Accept();

                Thread server = new Thread( () => handle_client( client ) );
                server.Start();
            }
        }

        private void handle_client( Socket client_socket )
        {
            byte[] buffer = new byte[1024];
            string recived_data = "";

            string[] description_ = { ( ( IPEndPoint )client_socket.RemoteEndPoint ).Address.ToString(), "Connected" };

            ListViewItem description = new ListViewItem( description_ );
            activities_lv.Items.Add( description );
            while ( true )
            {
                /*while ( true )
                {*/
                    int bytes_recived = client_socket.Receive( buffer );
                    recived_data += Encoding.ASCII.GetString( buffer, 0, bytes_recived );

                    /*if ( bytes_recived == 0 )
                        break;*/
                //}
                description_[1] = recived_data;
                activities_lv.Items.Add( new ListViewItem( description_ ) );
                string message = "";

                //if ( recived_data == "random_number" )
                //{
                    Random random = new Random();
                    message = random.Next( 0, 10 ).ToString();
                    byte[] message_ = Encoding.ASCII.GetBytes( message );
                    client_socket.Send( message_ );
                //}
                description_[1] = message;
                activities_lv.Items.Add( new ListViewItem( description_ ) );
            }
            client_socket.Close();
        }
    }
}