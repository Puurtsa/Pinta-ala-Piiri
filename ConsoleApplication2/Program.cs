using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Ikkuna
    {
        public float Leveys { get; set; }
        public float Korkeus { get; set; }
        public float Pintaala
        
        {
          get { return 2 * (Leveys * Korkeus); }
        }
        public float Piiri
        {
            get { return 2 * (Leveys + Korkeus);  }
        }
        public Ikkuna ()
        {
            //tämä on oletus constructor
        }
        public Ikkuna (float leveys, float korkeus)
        {
            Korkeus = korkeus;
            Leveys = leveys;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOIkkunaDemo();
        }


        static void OOIkkunaDemo()
        {
            //ohjelma laskee ikkunan pinta-alan ja piirin
            float Leveys = 0;
            float Korkeus = 0;
            float Ala, Piiri = 0;
            //kysytään käyttäjältä mitat
            Console.WriteLine("Lasken ikkunan pinta-alan ja piirin, syötä ikkunan leveys millimetreinä");
            Leveys = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna korkeus millimetreinä");
            Korkeus = float.Parse(Console.ReadLine());
            Ala = Leveys * Korkeus;
            Piiri = 2 * (Leveys + Korkeus);
            Console.WriteLine("ikkunan ala {0} ja piiri {1}", Ala, Piiri);
            Ikkuna ikkuna = new Demot.Ikkuna();
            ikkuna.Leveys = Leveys;
            ikkuna.Korkeus = Korkeus;
            //Ala = ikkuna.LaskePintaala();
            Ikkuna ikkuna2 = new Demot.Ikkuna(Leveys / 2, Korkeus / 2);
            Console.WriteLine("ikkunan ala laskettu olion avulla {0} ja piiri {1}", ikkuna.Pintaala, ikkuna.Piiri);
        }
    }
}
