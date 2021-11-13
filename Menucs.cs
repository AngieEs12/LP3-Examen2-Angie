using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP3_Examen2_Angie
{
    public partial class Menucs : Form
    {
        public Menucs()
        {
            InitializeComponent();
        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tickets  ticketform = new Tickets();
            ticketform.Show();
        }

        private void btnservicio_Click(object sender, EventArgs e)
        {
            this.Hide();

            Servicio servicioForm = new Servicio();
            servicioForm.Show();
        }
    }
}
