using System.Diagnostics.Eventing.Reader;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Blanco");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Rosa");
        }

        private void cboColorFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNac.Value;

            //Operador Ternario
            string choco = cbkChocolate.Checked == true ? "Le Gusta el Chocolate" : "No le gusta el chocolate";
            string estadoCivil;
            if (rbtCasado.Checked)

                estadoCivil = "Casado";
            else if (rbtDivorciado.Checked)
                estadoCivil = "Divorciado";
            else
                estadoCivil = "Soltero";

            string colorfavortito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = (choco + ", Estado civil:" + estadoCivil + ". Su color favorito es: " + colorfavortito + " y su numero favorito es; " + numeroFavorito);
            MessageBox.Show("Los datos de: " + nombre +" Son:  Fecha de Nacimiento" + fecha + mensaje);

        }     

      
    }
}
