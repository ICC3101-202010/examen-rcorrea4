using System;

namespace ExamenRcorrea4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Player[] players= new Player[15];
            Player[] playing = new Player[12];
            while (cont < 15)
            {
                Player player = new Player("a", "v", 12,12,12,12,false,100,"chilean");

                players[cont] = player;
                if (cont < 12)
                {
                    playing[cont] = player;
                }
                cont += 1;
                Console.WriteLine(player.CompleteName+cont);

            }
            Doctor doctor = new Doctor("name", "122", 12, 12);
            Coach coach = new Coach("raimundo", "11", 18, 12);
            Team team = new Team("a", true, players, playing, coach, doctor, "chile");

            team.info();
        }
    }
}
