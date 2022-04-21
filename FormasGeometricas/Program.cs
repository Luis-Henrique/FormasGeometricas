Console.WriteLine("-------------------------");

Quadrado q1 = new Quadrado(4.0);
Console.WriteLine(q1.Lado);
q1.Lado = 5.0;
Console.WriteLine("------Quadrados------\nLado:{0} ", q1.Lado);
Console.WriteLine("Area:{0}", q1.Area);
Console.WriteLine("Perimetro:{0}", q1.Perimetro);

Console.WriteLine("=====================");

Quadrado q2 = new Quadrado(10.0);
Console.WriteLine("Lado:{0} ", q2.Lado);
Console.WriteLine("Area:{0}", q2.Area);
Console.WriteLine("Perimetro:{0}", q2.Perimetro);

Console.WriteLine("\n-------------------------");

Retangulo r1 = new Retangulo(2.0, 5.0);
Console.WriteLine("-----Retangulo-----\nBase:{0} ", r1.Base);
Console.WriteLine("Altura:{0}", r1.Altura);
Console.WriteLine("Area:{0}", r1.Area);
Console.WriteLine("Perimetro:{0}", r1.Perimetro);

Console.WriteLine("\n-------------------------");
Console.WriteLine("-----Trapézio-----");

    Console.WriteLine("Entre com a base maior do trapezio");
    double BaseMaior = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Entre com a base menor do trapezio");
    double BaseMenor = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Entre com o Lado 1 do trapezio");
    double Lado1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Entre com o Lado2 do trapezio");
    double Lado2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Entre com a altura do trapezio");
    double Altura = Convert.ToDouble(Console.ReadLine());

        Trapezio t1 = new Trapezio(BaseMaior, BaseMenor, Lado1, Lado2, Altura);
        Console.WriteLine("Trapézio: área:{0}, perimetro:{1}", t1.Area, t1.Perimetro);