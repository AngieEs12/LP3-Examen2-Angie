using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LP3_Examen2_Angie
{
    public partial class Ticket : Form
    {

        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-E43MVJP\\SQLEXPRESS; Initial Catalog = soporte_db; Integrated Security =True");

        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, System.EventArgs e)
        {
            string query = "SELECT tickets.id as id, tickets.nombre as ticket, estados_ticket.nombre as estado, " +
                            "usuarios.email as cliente, servicios.nombre as servicio FROM tickets " +
                            "INNER JOIN estados_ticket ON tickets.estado_ticket_id = estados_ticket.id" +
                            "INNER JOIN usuarios ON tickets.usuario_id = usuarios.id" +
                            "INNER JOIN servicios ON tickets.servicio_id = servicios.id";

            GetTickets(query);
        }

        private void GetTickets(string queryTicket)
        {
            try
            {
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryTicket , conexion);
                
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable dataTable = new DataTable();
                
                dataAdapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;

            }
            catch (SqlException e)
            {

                MessageBox.Show("ERROR" , e.Message);
            }
        }

    }
}
