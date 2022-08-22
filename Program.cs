void Zadacha1(){    
//     Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    RecursionKrat3(m, n);
    Console.Write("\b\b.");
}
void RecursionKrat3(int m, int n){
    if(m > n){
        return;
    }
    if(m % 3 == 0){
        Console.Write(m + ", ");
    }
    m++;
    RecursionKrat3(m, n);
}

void Zadacha2(){
    // Задайте значения M и N. Напишите программу, 
    // которая найдёт сумму натуральных элементов в промежутке от M до N.
    Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    RecursionSum(m, n);
}

void Zadacha3(){
    //  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    //  Даны два неотрицательных числа m и n.
    Console.Write("Введите число M: ");
    int numberM = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.Write("Введите число N: ");
    int numberN = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine($"A({numberM}, {numberN}) = {AattackOnTitan(numberM, numberN)}");
}


void RecursionSum(int m, int n, int sum = 0){
    if(m > n){
        Console.Write(sum);
        return;
    }
    sum += m;
    m++;
    RecursionSum(m, n, sum);
}

int AattackOnTitan(int m, int n){
    if(m == 0){
        return n + 1;
    }
    else{
        if((m != 0) && (n == 0)){
            return AattackOnTitan(m - 1, 1);
        }
        else{
            return AattackOnTitan(m - 1, AattackOnTitan(m, n - 1));
        }
    }
}
// Zadacha1();
// Zadacha2();
Zadacha3();