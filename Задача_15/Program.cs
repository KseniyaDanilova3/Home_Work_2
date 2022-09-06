// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да, 7 -> да, 1 -> нет

Console.WriteLine("Название какого по счету дня недели вывести на экране?");

Console.WriteLine("Введите цифру");

string day = Console.ReadLine();

int number = int.Parse(day);

if (number == 6 || number == 7) {

    Console.WriteLine("Ура, это выходной! :)");
    
}

else if (7 < number || number < 1) {

    Console.WriteLine("Такого дня нет .. ");
    
}

else 
{

  Console.WriteLine("Увы, это не выходной! :(");
    
}


