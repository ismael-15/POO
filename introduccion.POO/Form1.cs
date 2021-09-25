using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduccion.POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creamos la instancia de la clase product
            //product es una instancia de la clase product()
            //la cual permite crear objetos 
            Product product = new Product();

            // creamos un objeto

            //asignar valores a las variables de propiedad 
            // a travez de los metodos propiedad
            product.setProductId(1);
            product.setproductnombre("Iphone Xs Max");
            product.setProductdescripcion("Color golden,64GB y 4GB de RAM con doble camara");
            product._precio = "$800";

            //mostrar los datos de producto
            //MessageBox.Show(
            //  "ID: " + product.getproductId() +
            // "Nombre del producto: " + product.getProductnombre() +
            //"Descripcion: " + product.getproductdescripcion() +
            //"precio: " + product._precio
            //);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //instancia de la clase utilizando constructores

            //utilizando el constructor que inicialixa todas las propiedades 
            Product product = new Product();
            product.setProductId(Convert.ToInt32(textId.Text));
            product.setproductnombre(textName.Text);
            product.setProductdescripcion(textDes.Text);
            product._precio = textPrecio.Text;

            //agregar los datos al lisbox
            lstBookInfo.Items.Add( product.getBookInfo());
            
        }

        private void lstBookInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }   }