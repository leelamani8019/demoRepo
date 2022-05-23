public class tleft
{
    public static void Main()
    {
        filereding.Detials det = new filereding.Detials();
        det.readfile();
        filereding.Retrive ret=new filereding.Retrive();
        Console.WriteLine("Id\tsource \t destination \t date \t  time \t\t network \tstatus");
        ret.Success();
       // ret.missed();
       // ret.failed();
       // ret.dialled();
       

       
    }
}