using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP3_Examen2_Angie
{
    public partial class Tickets : Form
    {

        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-E43MVJP\\SQLEXPRESS; Initial Catalog = soporte_db; Integrated Security =True");

        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            getTickets();
        }

        public void getTickets()
        {

            string queryInner = "SELECT tickets.id, tickets.nombre, estados_ticket.nombre, usuarios.email, servicios.nombre FROM tickets";
                    queryInner +="INNER JOIN estados_ticket ON tickets.estado_ticket_id = estados_ticket.id";
                    queryInner +="INNER JOIN usuarios ON tickets.usuario_id = usuarios.id";
                    queryInner +="INNER JOIN servicios ON tickets.servicio_id = servicios.id";

            string query = "SELECT * FROM tickets";
                
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        
    }
}
