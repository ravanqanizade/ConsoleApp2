using System;

class Heyvan
{
    public Heyvan(string ləqəb, int yaş, string cins, DateTime enerji, double qiymət, double yemMiqdarı)
    {
        Ləqəb = ləqəb;
        Yaş = yaş;
        Cins = cins;
        Enerji = enerji;
        Qiymət = qiymət;
        YemMiqdarı = yemMiqdarı;
    }

    public string Ləqəb { get; set; }
    public int Yaş { get; set; }
    public string Cins { get; set; }
    public DateTime Enerji { get; set; }
    public double Qiymət { get; set; }
    public double YemMiqdarı { get; set; }

    public virtual void YeməkYe()
    {
        Console.WriteLine($"{Ləqəb} yemək yedi.");
    }

    public virtual void Yat()
    {
        Console.WriteLine($"{Ləqəb} yatdı.");
    }

    public virtual void Oyna()
    {
        Console.WriteLine($"{Ləqəb} oynadı.");
    }
}

class İt : Heyvan
{
    public İt(string ləqəb, int yaş, string cins, DateTime enerji, double qiymət, double yemMiqdarı)
        : base(ləqəb, yaş, cins, enerji, qiymət, yemMiqdarı) { }

    public override void YeməkYe()
    {
        Console.WriteLine($"{Ləqəb} it yeməyi yedi.");
    }

    public override void Oyna()
    {
        Console.WriteLine($"{Ləqəb} top oynadı.");
    }
}

class Pişik : Heyvan
{
    public Pişik(string ləqəb, int yaş, string cins, DateTime enerji, double qiymət, double yemMiqdarı)
        : base(ləqəb, yaş, cins, enerji, qiymət, yemMiqdarı) { }

    public override void YeməkYe()
    {
        Console.WriteLine($"{Ləqəb} pişik yeməyi yedi.");
    }

    public override void Oyna()
    {
        Console.WriteLine($"{Ləqəb} oyuncaq siçanla oynadı.");
    }
}

class Layihə
{
    static void Main(string[] args)
    {
        İt mənimItim = new İt("Rex", 5, "Erkək", DateTime.Now, 500.0, 1.0);
        Pişik mənimPişiyim = new Pişik("Whiskers", 3, "Dişi", DateTime.Now, 300.0, 0.5);

        mənimItim.YeməkYe();
        mənimItim.Yat();
        mənimItim.Oyna();

        mənimPişiyim.YeməkYe();
        mənimPişiyim.Yat();
        mənimPişiyim.Oyna();

        Console.ReadLine();
    }
}
