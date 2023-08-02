String nombreProducto;
int cantidadxProducto, cantidadDeProductos = 10;
double precio, total, totalAcumulado = 0;

for (int i = 1; i <= cantidadDeProductos; i++)
{
    Console.WriteLine("Nombre de producto " + i + ":");
    nombreProducto = Console.ReadLine();

    Console.WriteLine("Cantidad de productos" + i + ":");
    cantidadxProducto = int.Parse(Console.ReadLine());

    Console.WriteLine("Precio por producto " + i + ":");
    precio = double.Parse(Console.ReadLine());

    total = (cantidadxProducto * precio) * 1.13;
    totalAcumulado = totalAcumulado + total;
    Console.Clear();

}

Console.WriteLine("El precio total a pagar es: $" + double.Round(totalAcumulado, 2));