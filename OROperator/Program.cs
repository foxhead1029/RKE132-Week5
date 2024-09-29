//Math >= 90 OR Chemistry >= 90 OR Biology >= 90

//Math && Chemestry || Math && Biology || Chemistry && biology

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90 )||( chemistry >= 90 && biology >= 90 )||( biology >= 90 &&  math <= 90))
{
    Console.WriteLine("Congratulation! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved");
}