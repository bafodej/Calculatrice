// Calculatrice en C# pemettant d'effectuer les opérations d'addition, de soustraction, de multiplication, de division, de puissance, et de modulo


using System.Numerics;

double? num1;
double? num2;
string? oper;


/*void calculation(double num1, double num2)


{
    double result;

    if (oper == "+")
    {
        Console.WriteLine($"Le resulta de l'opération est{num1 + num2} ");
        
    }
    else if (oper == "-")
    {
        Console.WriteLine($"Le resulta de l'opération est{num1 - num2}");
    }
    else if (oper == "*")
    {
        Console.Write($"Le resulta de l'opération est{num1 * num2}");
    }
    else if (oper == "/")
    {
        Console.WriteLine($"Le resulta de l'opération est{num1 + num2}");
    }
    else if (oper == "%")
    {
        Console.WriteLine($"Le resulta de l'opération est{num1 % num2}");
    }
    else
    {
        Console.WriteLine("Veuillez choissir un opérateur valide + - * / ou %");
    }
    return;
}


Console.WriteLine("Veuillez saisir un nombre ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Veuillez choisir l'opérateur");
oper = Console.ReadLine();

Console.WriteLine("Veuillez saisir le second nombre ");
num2 = double.Parse(Console.ReadLine());*/


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Appuyer sur 1 pour l'addition ");
Console.WriteLine("Appuyer sur 2 pour la soustration ");
Console.WriteLine("Appuyer sur 3 pour la multiplication ");
Console.WriteLine("Appuyer sur 4 pour la division ");
oper = int.Parse(Console.ReadLine());


double addition (double num1, double num2)
{
    double somme = ( num1 + num2);
    return somme;
}

double soustraction (double num1, double num2)
{
    double diference = (num1 - num2);
    return diference;
}

double multiplication (double num1, double num2)
{
    double produit = (num1 * num2);
    return produit;
}

double division (double num1, double num2)
{
    double quotient = (num1 / num2);
    return quotient;
}

Console.WriteLine("Veuillez saisir un nombre ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Veuillez choisir l'opérateur");
oper = Console.ReadLine();

Console.WriteLine("Veuillez saisir le second nombre ");
num2 = double.Parse(Console.ReadLine());



switch(oper)
{
    case 0 : Console.Write($"le resultat est ");
        addition();

        break;
    case 1 : Console.WriteLine($"le resultat est {num1 - num2}");
        break;
    case 2 : Console.WriteLine($"le resultat est {num1 * num2}");
        break;
    case 3 : Console.WriteLine($"le resiltat est de {num1 / num2}");
        break;
    default : Console.WriteLine($"choisir un opérateur ");break;
}



