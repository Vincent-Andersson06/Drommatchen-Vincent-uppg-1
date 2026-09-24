Spelare spelare1 = new Spelare("Lukas", 10, "Anfallare");
Spelare spelare2 = new Spelare("Erik", 7, "Mittfältare");

Match match = new Match("IFK Göteborg", "AIK", "2026-04-20");

match.Presentera();

match.AnnounceraMålskytt(spelare1);
match.AnnounceraMålskytt(spelare2);




