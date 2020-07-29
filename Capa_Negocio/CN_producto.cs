using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace Capa_Negocio
{
    public class CN_producto
    {
        private CD_Producto productoCD = new CD_Producto();

        public DataTable mostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = productoCD.Mostrar();
            return tabla;
        }
        public void InsertarProd(String nombre,String descripcion,string marca,String precio,String stock)
        {
            productoCD.Insertar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void editar(String nombre,string descripcion, string marca, string precio,string stock,string id)
        {
            productoCD.editar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));

        }
        public void eliminar(String id)
        {
            productoCD.eliminar(Convert.ToInt32(id));
        }
    }
}
