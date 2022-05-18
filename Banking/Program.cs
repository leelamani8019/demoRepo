public class sbi_bank : Banking.Account, Banking.manager, Banking.accountholder
{

    public override string create()
    {
        return "name";

    }
    public override string Read()
    {
        return "detials";

    }
    public override string update()
    {
        return "detials";
    }
    public override string delete()
    {
        return "account";
    }
    public static void Main(String[] args)
    {
        sbi_bank si = new sbi_bank();
        Banking.savings_account save = new Banking.savings_account();
        si.create();
        si.update();
        si.delete();
        si.Read();
        save.transaction(90000);
    }
}
    
    

