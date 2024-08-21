// See https://aka.ms/new-console-template for more information
using PilasApp;

Pila pila = new Pila(); 
bool booleano = false;
//test de estaVacia();
booleano = pila.estaVacia();
Console.WriteLine("La pila esta vacìa?: " + booleano);

//test de añadir(Object obj)
int numero = 1;
int num = 3;
string nombre = "Adrian";
booleano = pila.añadir(numero);
if (booleano) { Console.WriteLine("Elemento agregado con èxito."); }
else { Console.WriteLine("No pudo agregarse el objeto."); }

//test de primero()
object primero = pila.primero();
Console.WriteLine("El primer elemento de la colecciòn es: " + primero);

//test de extraer()
object elementoEliminado = pila.extraer();
Console.WriteLine("El elemento que fue eliminado es: " + elementoEliminado);

pila.añadir(num); pila.añadir(nombre);
//Para ver los elementos de la lista
Console.WriteLine("Elementos de la lista: ");
foreach (object item in pila.coleccion)
{
    Console.WriteLine("Elemento: " + item);
}


