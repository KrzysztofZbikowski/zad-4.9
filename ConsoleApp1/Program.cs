class zad
{
    static void Main(string[] args)
    {
        int liczba;
        Console.WriteLine("Podaj łancuch znaków: ");
        string znaki = Console.ReadLine();
        string[] wyrazy = znaki.Split(' ');
        liczba = wyrazy.Length;
        Console.WriteLine("Liczba wyrazów w twoim ciągu znaków wynosi: " + liczba);
        Console.ReadKey();
    }
}