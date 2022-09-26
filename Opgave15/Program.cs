DateTime now = DateTime.Now; 
int year = now.Year;
string input = "";
string countDown;

while (input.ToLower() != "exit") {
    Console.WriteLine("Skriv (0) for at få idags dato og tid");
    Console.WriteLine("Skriv (1) for at finde ud af hvor mange dage der er til jul");
    Console.WriteLine("Skriv (2) for at finde ud af hvor lnag tid til min fødselsdag");
    Console.WriteLine("Skriv (2) for at finde ud af hvor lnag tid til din dato");

    //check which they wanna check or if exit
    input = Console.ReadLine();

    switch (input) {
        case "0":
            //today
            Console.WriteLine(now.ToString());
            break;

        case "1":
            //xmas time
            DateTime xmas = DateTime.Parse($"24/12/{year}");

             //Calculate countdown timer.
             TimeSpan till_xmas = xmas - now;
             countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds to christmas.", till_xmas.Days, till_xmas.Hours, till_xmas.Minutes, till_xmas.Seconds);
             Console.WriteLine(countDown);
             break;
            
        case "2":
              //birthday time
             DateTime bday = DateTime.Parse($"22/11/{year}");

             TimeSpan till_bday = bday - now;
             countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds to birthday.", till_bday.Days, till_bday.Hours, till_bday.Minutes, till_bday.Seconds);
             Console.WriteLine(countDown);
             break;

        case "3":
            //their time
            Console.WriteLine("Skriv med numre dag/måned/årstal");
            DateTime time_input = DateTime.Parse(Console.ReadLine());
            TimeSpan till_x = time_input - now;
            countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds to your time.", till_x.Days, till_x.Hours, till_x.Minutes, till_x.Seconds);
            Console.WriteLine(countDown);
            break;
    }
    Console.WriteLine("\n" +
        "Skriv exit for at forlade progammet");
}