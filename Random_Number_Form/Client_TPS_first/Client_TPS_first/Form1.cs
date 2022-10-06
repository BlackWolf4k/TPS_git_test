using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_TPS_first
{
    public partial class Form1 : Form
    {
        private static Socket socket;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            early_main();
        }

        private void early_main()
        {
            activities_lv.Columns.Add( "Type", 120 );
            activities_lv.Columns.Add( "Message", 656 );
        }

        private void connect( object sender, EventArgs e )
        {
            IPEndPoint ip = new IPEndPoint( IPAddress.Parse( ip_tb.Text ), ( int )( Convert.ToDouble( port_tb.Text ) ) );
            socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );

            socket.Connect( ip );
        }

        private void disconnect( object sender, EventArgs e )
        {
            socket.Shutdown( SocketShutdown.Both );
            socket.Close();
        }

        private void send( object sender, EventArgs e )
        {
            byte[] message = Encoding.ASCII.GetBytes( message_tb.Text );
            socket.Send( message );

            string[] description_ = { "Sended", message_tb.Text };

            ListViewItem description = new ListViewItem( description_ );
            activities_lv.Items.Add( description );

            Thread response = new Thread( new ThreadStart( wait_response ) );
            response.Start();
        }

        private void wait_response()
        {
            byte[] buffer = new byte[1024];
            string recived_data = "";

            send_b.Enabled = false;

            while ( true )
            {
                int bytes_recived = socket.Receive( buffer );
                recived_data += Encoding.ASCII.GetString( buffer, 0, bytes_recived );

                if ( bytes_recived == 0 )
                    break;
            }
            string[] description_ = { "Recived", recived_data };

            ListViewItem description = new ListViewItem( description_ );
            activities_lv.Items.Add( description );

            send_b.Enabled = true;
        }
    }
}