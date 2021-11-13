using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace LP3_Examen2_Angie
{
    public partial class Ticket : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        private DataGridView dataGridView1 = new DataGridView();

        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            string query = "SELECT tickets.id as id, tickets.nombre as ticket, estados_ticket.nombre as estado, " +
                            "usuarios.email as cliente, servicios.nombre as servicio FROM tickets " +
                            "INNER JOIN estados_ticket ON tickets.estado_ticket_id = estados_ticket.id" +
                            "INNER JOIN usuarios ON tickets.usuario_id = usuarios.id" +
                            "INNER JOIN servicios ON tickets.servicio_id = servicios.id";

            GetTickets(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetTickets(dataAdapter.SelectCommand.CommandText);

        }
        private void GetTickets(string queryTicket)
        {
            try
            {
                string conexion = "Data Source = DESKTOP-E43MVJP\\SQLEXPRESS; Initial Catalog = soporte_db; Integrated Security =True";
               
                dataAdapter = new SqlDataAdapter(queryTicket , conexion);
                
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };

                dataAdapter.Fill(table);

                bindingSource1.DataSource = table;

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            }
            catch (SqlException e)
            {

                MessageBox.Show("ERROR" , e.Message);
            }


        }
    }
}
