using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace productos
{
    public class Telefono
    {
        private string marca;
        private string color;
        private string tipo;
        private string v;

        //Metodo constructor
        public Telefono()
        {
            marca = "Samsung";
            color = "negro";
            tipo = "smartphone";
        }

        public Telefono(string M)
        {
            marca = M;
            color = "negro";
            tipo = "smartphone";
        }



        public Telefono(string M, string C, string T)
        {
            marca = M;
            color = C;
            tipo = T;
        }

        public void llamar()
        {
            System.Windows.Forms.MessageBox.Show("Tu celular es un: "+ marca + " y es de color " + color + ",Del tipo " + tipo);
        }

        public string MandarMensaje(string N, string Msj)
        {
            string Nombre = N;
            string Mensaje = Msj;

            string Enviando = "El mensaje: " + Mensaje + ", enviado por: " + Nombre;

            return Enviando;
        }


    }
}
