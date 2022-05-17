class animal
{
    public static void Main(String []args)
    {
        Classobject.dog dogb=new Classobject.dog();
        dogb.breed = "bull dog";
        Console.WriteLine(dogb.breed);
        dogb.bark();
        Console.ReadLine();
    }
}