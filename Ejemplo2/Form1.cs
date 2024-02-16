using System.DirectoryServices.ActiveDirectory;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {

            DateTime fecha1;
            fecha1 = dtpFecha2.Value;
            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("dddd dd/MM/yyyy"));
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            DateTime fecha2, fecha3;
            fecha2 = calFecha.SelectionStart;
            fecha3 = calFecha.SelectionEnd;
            MessageBox.Show("Ha elegido desde : " + fecha2.ToString("dd/MM/yyyy") +
                " hasta " + fecha3.ToString("dd/MM/yyyy") + " para sus vacaciones");
        }
    }
}
