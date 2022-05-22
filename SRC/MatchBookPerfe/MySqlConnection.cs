namespace Control_Empresa
{
    internal class MySqlConnection
    {
        private string connectionstring;

        public MySqlConnection(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
    }
}