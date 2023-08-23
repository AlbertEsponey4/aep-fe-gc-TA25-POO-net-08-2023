using System.Text;

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

    public void Datos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Sueldo: " + sueldo);
    }

    public void PagaImpuestos()
    {
        if (sueldo > 3000)
        {
            Console.WriteLine("Paga impuestos");
        }
        else
        {
            Console.WriteLine("No paga impuestos");
        }
    }
}

class Operaciones
{
    private int valor1;
    private int valor2;

    public Operaciones(int valor1, int valor2)
    {
        this.valor1 = valor1;
        this.valor2 = valor2;
    }

    public int Sumar()
    {
        return valor1 + valor2;
    }

    public int Restar()
    {
        return valor1 - valor2;
    }

    public int Multiplicar()
    {
        return valor1 * valor2;
    }

    public double Dividir()
    {
        if (valor2 != 0)
        {
            return (double)valor1 / valor2;
        }
        else
        {
            Console.WriteLine("No se puede dividir por zero");
            return 0;
        }
    }
}

class Persona
{
    private string nombre;

    public Persona(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void Saludar()
    {
        Console.WriteLine("Hola, me llamo " + nombre);
    }
}

class Libro
{
    private string autor;
    private string titulo;
    private string ubicacion;

    public Libro(string autor, string titulo, string ubicacion)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.ubicacion = ubicacion;
    }

    public string GetAutor()
    {
        return autor;
    }

    public string GetTitulo()
    {
        return titulo;
        
    }

    public string GetUbicacion()
    {
        return ubicacion;
    }

    public void SetAutor(string autor)
    {
        this.autor = autor;
    }

    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void SetUbicacion(string ubicacion)
    {
        this.ubicacion = ubicacion;
    }
}

class Coche
{
    private string marca;
    private string modelo;
    private int cilindrada;
    private double potencia;

    public Coche(string marca, string modelo, int cilindrada, double potencia)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cilindrada = cilindrada;
        this.potencia = potencia;
    }

    //en lugar de main propio, lo voy a ejecutar en el main principal. En caso de main propio sería lo mismo pero teniendo que especificar primero el objeto coche del cual se quieren mostrar los datos (reviamente creado)
    public void Datos()
    {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Cilindrada: " + cilindrada);
        Console.WriteLine("Potencia: " + potencia);
    }
}

class Persona2
{
    private string nombre;
    private int edad;
    private string DNI;
    private char sexo;
    private double peso;
    private double altura;

    private const char SEXO_DEF = 'H';

    public Persona2()
    {
        nombre = "";
        edad = 0;
        DNI = "49654321J";
        sexo = SEXO_DEF;
        peso = 0.0;
        altura = 0.0;
    }

    public Persona2(string nombre, int edad, char sexo)
    {
        this.nombre = nombre;
        this.edad = edad;
        DNI = "49654321J";
        if (sexo == 'H' || sexo == 'M')
            this.sexo = sexo;
        else 
            this.sexo = SEXO_DEF;
        peso = 0.0;
        altura = 0.0;
    }

    public Persona2(string nombre, int edad, char sexo, string DNI, double peso, double altura)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.DNI = DNI;
        if (sexo == 'H' || sexo == 'M')
            this.sexo = sexo;
        else
            this.sexo = SEXO_DEF;
        this.peso = peso;
        this.altura = altura;
    }
}
class Password
{
    private int longitud;
    private string pass;

    private const int LONG_DEF = 8;
    public Password()
    {
        longitud = LONG_DEF;
        pass = GenerarPassword(LONG_DEF);
    }

    public Password(int longitud)
    {
        this.longitud = longitud;
        pass = GenerarPassword(longitud);
    }

    public string getPassword()
    {
        return pass;
    }

    private string GenerarPassword(int longitud)
    {
        const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890/_@#$%=+";
        string contra = "";
        Random random = new Random();


        for (int i = 0; i < longitud; i++)
        {
            //genero un numero que correspondra a un caracter de l'string caracteres
            int pos = random.Next(caracteres.Length);
            //concateno el caracter corresponent a la posicio random generada abans
            contra = contra + caracteres[pos];
        }

        return contra;
    }
}

class Electrodomestico
{
    protected double precioBase;
    protected string color;
    protected char consumoEnergetico;
    protected double peso;

    protected const string COLOR_DEF = "blanco";
    protected const char CONSUMO_DEF = 'F';
    protected const double PRECIO_DEF = 100;
    protected const double PESO_DEF = 5;

    public Electrodomestico()
    {
        precioBase = PRECIO_DEF;
        color = COLOR_DEF;
        consumoEnergetico = CONSUMO_DEF;
        peso = PESO_DEF;
    }

    public Electrodomestico(double precio, double peso)
    {
        precioBase = precio;
        this.peso = peso;
        color = COLOR_DEF;
        consumoEnergetico = CONSUMO_DEF;
    }

    public Electrodomestico(double precio, string color, char consumoEnergetico, double peso)
    {
        precioBase = precio;

        if (color == "blanco" || color == "BLANCO" || color == "negro" || color == "NEGRO" || color == "rojo" || color == "ROJO" || color == "azul" || color == "AZUL" || color == "gris" || color == "GRIS")
            this.color = color;
        else
            this.color = COLOR_DEF;

        if (consumoEnergetico == 'A' || consumoEnergetico == 'B' || consumoEnergetico == 'C' || consumoEnergetico == 'D' || consumoEnergetico == 'E' || consumoEnergetico == 'F')
            this.consumoEnergetico = consumoEnergetico;
        else
            this.consumoEnergetico = CONSUMO_DEF;

        this.peso = peso;
    }
}

class Serie
{
    private string titulo;
    private int numTemporadas;
    private bool entregado;
    private string genero;
    private string creador;

    private const int NUM_TEMPORADAS_DEF = 3;
    private const bool ENTREGADO_DEF = false;

    public Serie()
    {
        titulo = "";
        numTemporadas = NUM_TEMPORADAS_DEF;
        entregado = ENTREGADO_DEF;
        genero = "";
        creador = "";
    }

    public Serie(string titulo, string creador)
    {
        this.titulo = titulo;
        this.creador = creador;
        numTemporadas = NUM_TEMPORADAS_DEF;
        entregado = ENTREGADO_DEF;
        genero = "";
    }

    public Serie(string titulo, string genero, string creador, int numTemporadas)
    {
        this.titulo = titulo;
        this.genero = genero;
        this.creador = creador;
        this.numTemporadas = numTemporadas;
        this.entregado = ENTREGADO_DEF;
    }
}

class Programa
{
    static void Main(string[] args)
    {
        // EXER 1
        Console.WriteLine("1. Alumno");
        Alumno alumno = new Alumno("Albert", 22);
        alumno.Datos();
        alumno.VerificarEdad();

        Console.WriteLine("\n\n");

        // EXER 2
        Console.WriteLine("2. Empleado");
        Empleado empleado = new Empleado("Albert", 4000);
        empleado.Datos();
        empleado.PagaImpuestos();

        Console.WriteLine("\n\n");

        // EXER 3
        Console.WriteLine("3. Operaciones");

        int valor1 = 3;
        int valor2 = 4;
        Console.WriteLine("valor 1: " + valor1);
        Console.WriteLine("valor 2: " + valor2);

        Operaciones op = new Operaciones(valor1, valor2);

        Console.WriteLine("Suma: " + op.Sumar());
        Console.WriteLine("Resta: " + op.Restar());
        Console.WriteLine("Multiplicacion: " + op.Multiplicar());
        Console.WriteLine("Division: " + op.Dividir());

        Console.WriteLine("\n\n");

        // EXER 4
        Console.WriteLine("4. Persona");
        Persona per1 = new Persona("DEF");
        Persona per2 = new Persona("DEF");

        per1.SetNombre("Albert");
        per2.SetNombre("Raul");

        per1.Saludar();
        per2.Saludar();

        Console.WriteLine("\n\n");

        // EXER 5
        Console.WriteLine("5. Libro");
        Libro libro = new Libro("Albert", "Harry Potter", "Riudoms");

        libro.SetUbicacion("Reus");
        Console.WriteLine($"Autor: {libro.GetAutor()} \nTitulo: {libro.GetTitulo()}  \nUbicacion: {libro.GetUbicacion()}");

        Console.WriteLine("\n\n");

        // EXER 6
        Console.WriteLine("6. Coche");
        Coche coche = new Coche("Honda", "Civic", 1900, 290.3);

        coche.Datos();

        Console.WriteLine("\n\n");

        // EXER 7
        Console.WriteLine("7. Persona 2");

        Persona2 pers = new Persona2();
        Persona2 pers2 = new Persona2("Albert", 22, 'H', "49273478K", 78, 185);

        Console.WriteLine("\n\n");
        // EXER 8
        Console.WriteLine("8. Password");

        Password pass = new Password();
        Console.WriteLine("Contra 1: " + pass.getPassword());

        Password pass2 = new Password(30);
        Console.WriteLine("Contra 2: " + pass2.getPassword());

        Console.WriteLine("\n\n");
        // EXER 9
        Console.WriteLine("9. Electrodomestico");

        Electrodomestico elect = new Electrodomestico();
        Electrodomestico elec2t = new Electrodomestico(300, 150);
        Electrodomestico elect3 = new Electrodomestico(500, "blanco", 'A', 111);


        Console.WriteLine("\n\n");
        // EXER 10
        Console.WriteLine("10. Serie");

        Serie serie = new Serie();
        Serie serie2 = new Serie("Harry Potter", "Albert");
        Serie serie3 = new Serie("Sherlok Holmes", "Raul", "Aventuras", 4);

        Console.WriteLine("\n\n");
    }
}