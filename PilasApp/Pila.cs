using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasApp
{
    public class Pila : IColeccion
    {
        public List<Object> coleccion;
        private int contador;
        private int capacidad = 10;

        public Pila()
        {
            coleccion = new List<Object>();
            contador = 0;
        }
        public bool estaVacia()
        {
            bool coleccionVacia = false;
            if (coleccion.Count == 0)
               {coleccionVacia = true;}
            else { coleccionVacia = false; }

            return coleccionVacia;
        }

        public object extraer()
        {   
            object primerEle = primero();
            coleccion.Remove(coleccion[0]);
            return primerEle;
        }

        public bool añadir(object obj)
        {
            coleccion.Add(obj);
            return true;
        }


        public object primero()
        {
            object primerEle = coleccion.First();
            return primerEle;
        }
    }
}
