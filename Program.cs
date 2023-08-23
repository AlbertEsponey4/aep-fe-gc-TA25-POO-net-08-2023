class Alumno
{
    private string nombre;
    private int edad;

    public Alumno(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public void Datos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }

    public void VerificarEdad()
    {
        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad.");
        }
        else
        {
            Console.WriteLine("No es mayor de edad.");
        }
    }
}

class Empleado
{
    private string nombre;
    private double sueldo;

    public Empleado(string nombre, double sueldo)
    {
        this.nombre = nombre;
        this.sueldo = sueldo;
    }

    public void ImprimirDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Sueldo: " + sueldo);
    }

    public void CalcularImpuestos()
    {
        if (sueldo > 3000)
        {
            Console.WriteLine("Debe pagar impuestos.");
        }
        else
        {
            Console.WriteLine("No debe pagar impuestos.");
        }
    }
}
