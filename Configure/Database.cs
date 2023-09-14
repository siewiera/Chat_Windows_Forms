using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Configure
{
    internal class Database : Form
    {

        private string server;
        private string database;
        private bool trusted_conn;
        private bool trusted_cert;

        public Database() {
      
            this.server = "DESKTOP-MQ5HJ99";
            this.database = "Chat";
            this.trusted_conn = true;
            this.trusted_cert = true;           
        }

        public SqlConnection connection() {

            SqlConnection conn = new SqlConnection($"Server={this.server};" +
                $"Database={this.database};" +
                $"Trusted_Connection={this.trusted_conn};" +
                $"TrustServerCertificate={this.trusted_cert};");
            return conn;
        }

        public SqlCommand cmd(string query, string error) {

            SqlConnection conn = this.connection();
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open) {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    r.Close();
                }
                else {
                    MessageBox.Show($"{error}");
                }
            }
            else {
                MessageBox.Show($"Error! Connection problem");    
            }
            conn.Close();
            return null;
        }
    }
}
