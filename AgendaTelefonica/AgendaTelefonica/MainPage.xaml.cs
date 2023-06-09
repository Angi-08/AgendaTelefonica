using AgendaTelefonica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaTelefonica
{
    public partial class MainPage : TabbedPage
    {
        public List<Contacto> lista { get; set; }
        public MainPage()
        {
            InitializeComponent();
            lista = new List<Contacto>();
        }

        private void GuardarContacto(object sender, EventArgs e)
        {
            Contacto c = new Contacto(Name.Text, LastName.Text, Phone.Text, Cellphone.Text, Email.Text);
            lista.Add(c);
            DisplayAlert("Contacto agregado con exito", "", "Aceptar");
            listado.ItemsSource = null;
            listado.ItemsSource = lista;
            Name.Text = string.Empty;
            LastName.Text = string.Empty;
            Phone.Text = string.Empty;
            Cellphone.Text = string.Empty;
            Email.Text = string.Empty;

        }
    }
}
