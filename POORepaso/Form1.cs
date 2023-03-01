using POORepaso.productos;
using productos;



namespace POORepaso
{
    public partial class Form1 : Form
    {
        Telefono Movistar = new Telefono(); //object  //productos.telefono forma de llamar desde otro archivo con namespace diferente
        Telefono Claro = new Telefono("Huawei","blanco","4G+");
        Telefono Digitel = new Telefono("Apple", "Negro", "5G");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Movistar.llamar();
              Claro.llamar();
              Digitel.llamar();*/
            //Metodo que retorna datos
            //  MessageBox.Show(Movistar.MandarMensaje("Robert", "Hola a todos"));

            //Metodo estatico que suma dos numeros
          // MessageBox.Show(Operaciones.Suma(50, 100).ToString());
            
        }
    }
}