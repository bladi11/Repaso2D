using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2D
{
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>(); //ir guardando los datos 

        public Form1()
        {
            InitializeComponent();
        }
        private void GuardarVehiculo()
        {
            FileStream stream = new FileStream("Vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var vehiculo in vehiculos)
            {
                //foreach funciona empieza en vehiculos toma la lista de vehculos y lo copia a la variable vehiculo y esta se usa para guardarla en el archivo 
                //el orden para guardar debe ser el orden de la escritura en el form para evitar errores cuando se carguen los datos
                writer.WriteLine(vehiculo.placa);
                writer.WriteLine(vehiculo.marca);
                writer.WriteLine(vehiculo.modelo);
                writer.WriteLine(vehiculo.color);
                writer.WriteLine(vehiculo.precioKilometro);
            }
            writer.Close();
        }
        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.placa = textBoxplaca.Text;
            vehiculo.marca = textBoxmarca.Text;
            vehiculo.color = textBoxcolor.Text;
            vehiculo.modelo = Convert.ToInt16(textBoxmodelo.Text);
            vehiculo.precioKilometro = Convert.ToDecimal(textBoxprecioxkm.Text);

            int posicion = vehiculos.FindIndex(x => x.placa == vehiculo.placa); //busca en la lista de vehiculos la placa que se ha ingresado en 
            //en un nuevo vehiculo, sino la encuentra con findindex devolvera un -1 y la agregara a la lista de lo contrario aparecera el mensaje
            if (posicion == -1)
            {
                vehiculos.Add(vehiculo); //se agrega a la lista el nuevo vehiculo
                GuardarVehiculo();
            }
            else
            {
                MessageBox.Show("Placa repetida");
            }

        }

        private void buttonAlquiler_Click(object sender, EventArgs e)
        {
            FormAlquiler formAlquiler = new FormAlquiler();
            formAlquiler.Show();
        }
    }
}
