using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Edition
    {
        private string name;
        private string authorsurname;
        private string yearpublication;

        public string Name
        {
            get
            {
                return (name != "") ? name : "Неизвестный";

            }
            set => name = value;
        }

        public string Authorsurname
        {
            get
            {
                return (authorsurname != "") ? authorsurname : "Неизвестный";

            }
            set => authorsurname = value; 
        }

        public string Yearpublication
        {
            get
            {
                return (yearpublication != "") ? yearpublication : "Неизвестный";

            }
            set => name = value;
        }

        public int yearpublication
        {
            get => _godIzdaniya;
            set => _godIzdaniya = (value >= 1990 && value <= 2024) ? value : 1990;
        }

        public Izdanie(string nazvanie, string avtor, int godIzdaniya)
        {
            Nazvanie = nazvanie;
            Avtor = avtor;
            GodIzdaniya = godIzdaniya;
        }

        public void VyvestiInformaciyu()
        {
            Console.WriteLine($"Название: {Nazvanie}\nАвтор: {Avtor}\nГод издания: {GodIzdaniya}");
        }
    }
}
}
    
