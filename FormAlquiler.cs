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
        List<Mostrar> resumen = new List<Mostrar>();
        public FormAlquiler()
        {
            InitializeComponent();
        }

        private void CargarVehiculos()
        {
            FileStream stream = new FileStream("Vehiculos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() >-1)
            {
                //en el orden que estan en el archivo asi se tienen que agregar a la lista para evitar errores
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.placa = reader.ReadLine();
                vehiculo.marca = reader.ReadLine();
                vehiculo.modelo = Convert.ToInt16(reader.ReadLine());
                vehiculo.color = reader.ReadLine();
                vehiculo.precioKilometro = Convert.ToDecimal(reader.ReadLine());

                vehiculos.Add(vehiculo);
            }
            reader.Close();
        }

        private void CargarClientes()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //en el orden que estan en el archivo asi se tienen que agregar a la lista para evitar errores
                Cliente cliente = new Cliente();
                cliente.nit = reader.ReadLine();
                cliente.nombre = reader.ReadLine();
                cliente.direccion = reader.ReadLine();

                clientes.Add(cliente);
            }
            reader.Close();
        }

        private void CargarAlquiler()
        {
            FileStream stream = new FileStream("Alquiler.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                //en el orden que estan en el archivo asi se tienen que agregar a la lista para evitar errores
                Alquiler alquiler = new Alquiler();
                alquiler.nit = reader.ReadLine();
                alquiler.placa = reader.ReadLine();
                alquiler.fechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                alquiler.fechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                alquiler.kilometrosRecorridos = Convert.ToInt16(reader.ReadLine());

                alquileres.Add(alquiler);
            }
            reader.Close();
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
                Mostrar dato = new Mostrar();
                for (int j = 0; j< clientes.Count; j++) //buscara dentro de la lista de clientes si esta el nit que esta en la lista alquileres
                {
                    if (alquileres[i].nit == clientes[j].nit)  //revisa si el nit que esta en la lista alquileres y clientes son iguales y si es asi los muestra
                    {
                        dato.nombre = clientes[j].nombre;
                        dato.devolucion = alquileres[i].fechaDevolucion;
                    }
                }
                for (int k = 0; k < vehiculos.Count; k++) //buscara dentro de la lista de vehiculos si esta la placa que esta en la lista de alquileres
                {
                    if (alquileres[i].placa == vehiculos[k].placa) //revisa si la placa que esta en la lista alquileres y vehiculos son iguales y si es asi los muestra
                    {
                        dato.placa = vehiculos[k].placa;
                        dato.marca = vehiculos[k].marca;
                        dato.totalpagar = vehiculos[k].precioKilometro * alquileres[i].kilometrosRecorridos;
                    }
                }
                resumen.Add(dato);

                dataGridViewResumen.DataSource = null;
                dataGridViewResumen.Refresh();

                dataGridViewResumen.DataSource = resumen;
                dataGridViewResumen.Refresh();
            }
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarVehiculos();
            dataGridViewAutomoviles.DataSource = vehiculos;
            dataGridViewAutomoviles.Refresh();

            CargarAlquiler();
            dataGridViewAlquileres.DataSource = alquileres;
            dataGridViewAlquileres.Refresh();
        }
    }
}
