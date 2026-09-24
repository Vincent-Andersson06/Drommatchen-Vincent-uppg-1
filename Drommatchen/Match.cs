public class Match
{
    public string Hemmalag { get; private set; }
    public string Bortalag { get; private set; }
    public string Datum { get; private set; }

    public Match(string hemmalag, string bortalag, string datum)
    {
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        Datum = datum;
    }

    public void Presentera()
    {
        Console.WriteLine($"Match: {Hemmalag} - {Bortalag}");
        Console.WriteLine($"Datum: {Datum}");
    }

    public void AnnounceraMålskytt(Spelare spelare)
    {
        Console.WriteLine(
            $"Mål! {spelare.Namn}, nummer {spelare.Nummer}, position {spelare.Position}"
        );
    }
}