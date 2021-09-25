using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion.POO
{
    class Product
    {
        
        //Definir los miembros de la clase
        //propiedades

        private int _productId;
        private string _nombre;
        private string _descripcion;
        
        // propiedades autoimplementadas 
        public string _precio { get; set; }

        //Metodo constructor
        public Product() //metodo vacio
        { }



        //metodo de propiedad
        //get -- permite obtener el codigo de producto

        public int getproductId()
        {
            return _productId;
        }


        //set -- permite asignar un codigo a producto

        public void setProductId(int productId)
        {
            _productId = productId;
        }

        // nombre del producto
        public string getProductnombre()
        {
            return _nombre;
        }

        public void setproductnombre(string nombre)
        {
            _nombre = nombre;
        }

        public string getproductdescripcion()
        {
            return _descripcion;
        }

        public void setProductdescripcion(string descripcion)
        {
            _descripcion = descripcion;
        }

        //metodo para mostrar la informacion del producto

        public string getBookInfo()
        {
            return "ID: " + _productId + "\tNombre:"  + _nombre +
                "\tDescripcion: " + _descripcion + "\tPrecio: " +
                _precio;
        }

    }

}

    

