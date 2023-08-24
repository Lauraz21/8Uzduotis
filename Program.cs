Console.WriteLine("Iveskite du skaicius: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());


if (number > 0 && number2 > 0)
{
    Console.WriteLine("Abu skaiciai yra teigiami");
}
else if ((number < 0 && number2 > 0) || (number > 0 && number2 < 0))
{ 
    Console.WriteLine("Tik vienas skaicius yra teigiamas");
}
else
{
    Console.WriteLine("Ne vienas skaicius nera teigiamas");
}