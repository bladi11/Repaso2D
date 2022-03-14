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
    public partial class FormAlquiler : Form
    {
        //se usaran las 4 listas porque en este form se relacionaran todos los datos
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Cliente> clientes = new List<Cliente>();           
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Mostrar> mostrar = new List<Mostrar>();
        public FormAlquiler()
        {
            InitializeComponent();
        }

        private void GuardarAlquileres()
        {
            FileStream stream = new FileStream("Alquiler.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var alquiler in alquileres)
            {
                //foreach funciona empieza en vehiculos toma la lista de vehculos y lo copia a la variable vehiculo y esta se usa para guardarla en el archivo 
                //el orden para guardar debe ser el orden de la escritura en el form para evitar errores cuando se carguen los datos
                writer.WriteLine(alquiler.nit);
                writer.WriteLine(alquiler.placa);
                writer.WriteLine(alquiler.fechaAlquiler);
                writer.WriteLine(alquiler.fechaDevolucion);
                writer.WriteLine(alquiler.kilometrosRecorridos);

            }
            writer.Close();
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.nit = textBoxnit.Text;
            alquiler.placa = textBoxplaca.Text;
            alquiler.fechaAlquiler = dateTimePickerfechaPrestamo.Value;
            alquiler.fechaDevolucion = dateTimePickerDevolucion.Value;
            alquiler.kilometrosRecorridos = Convert.ToInt16(textBoxkilometros.Text);

            alquileres.Add(alquiler);
            GuardarAlquileres();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< alquileres.Count; i++)  //buscara dentro de la lista de alquileres, alquiler por alquiler
            {
                Mostrar mostrarTem = new Mostrar();
                for (int j = 0; j< clientes.Count; j++) //buscara dentro de la lista de clientes si esta el nit que esta en la lista alquileres
                {
                    if (alquileres[i].nit == clientes[j].nit)  //revisa si el nit que esta en la lista alquileres y clientes son iguales y si es asi los muestra
                    {
                        mostrarTem.nombre = clientes[j].nombre;
                    }
                }
                for (int k = 0; k < vehiculos.Count; k++) //buscara dentro de la lista de vehiculos si esta la placa que esta en la lista de alquileres
                {
                    if (alquileres[i].placa == vehiculos[k].placa) //revisa si la placa que esta en la lista alquileres y vehiculos son iguales y si es asi los muestra
                    {
                        mostrarTem.placa = vehiculos[k].placa;
                        mostrarTem.color = vehiculos[k].color;
                        mostrarTem.totalpagar = vehiculos[k].precioKilometro * alquileres[i].kilometrosRecorridos;
                    }
                }
                mostrar.Add(mostrarTem);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                dataGridView1.DataSource = mostrar;
                dataGridView1.Refresh();
            }
        }
    }
}
