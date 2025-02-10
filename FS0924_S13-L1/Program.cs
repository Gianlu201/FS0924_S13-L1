using FS0924_S13_L1;

var athlete1 = new Athlete();
athlete1.FirstName = "Simone";
athlete1.LastName = "Giannelli";
athlete1.Age = 20;
athlete1.Sport = "volleyball";
athlete1.CompetitionsWinned = 3;

Console.WriteLine(athlete1.Presentation());
