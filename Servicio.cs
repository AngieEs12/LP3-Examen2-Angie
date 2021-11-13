using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LP3_Examen2_Angie
{
    public partial class Servicio : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-E43MVJP\\SQLEXPRESS; Initial Catalog = soporte_db; Integrated Security=True");

        public Servicio()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            string nombre = cbbservicio.GetItemText(cbbservicio.SelectedItem);

            int servicioId = 0;
           
            if (nombre == "Mantenimiento")
            {
                servicioId = 1;
            }else if( nombre == "Reparacion")
            {
                servicioId = 2;
            }
            
            guardarTicket(nombre, servicioId);

            this.Hide();
            Tickets ticketsForm = new Tickets();
            ticketsForm.Show();
        }

        private void guardarTicket(string nombre, int servicioId)
        {
            conexion.Open();

            string query = "INSERT INTO tickets(nombre, estado_ticket_id, usuario_id, servicio_id) VALUES(@param1, @param2, @param3, @param4)";
            
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.Add(new SqlParameter("@param1", "ANG-" + nombre));
            command.Parameters.Add(new SqlParameter("@param2", 1));
            command.Parameters.Add(new SqlParameter("@param3", 1));
            command.Parameters.Add(new SqlParameter("@param4", servicioId));

            command.ExecuteNonQuery();

            MessageBox.Show("Ticket creado satisfactoriamente");
        }
    }
}
