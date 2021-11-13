using System;
using System.Windows.Forms;

namespace LP3_Examen2_Angie
{
    public partial class Form1Login : Form
    {
        ConexionDB conexion = new ConexionDB();

        public Form1Login()
        {
            InitializeComponent();
        }

        private void Form1Login_Load(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            int valido = conexion.ValidarLogin(txtbcorreo.Text, txtbcontrasena.Text);

            if (valido > 0)
            {
                
                this.Hide();
                Menucs menu = new Menucs ();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
