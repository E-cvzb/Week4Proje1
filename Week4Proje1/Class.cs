using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Proje1
{
     public class Class
    {
        private string name;
        private string surname;
        private String birthday;// bir işlem yapmayacaım için string türünde tanımlayacam

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        
        public void Person ()  // isimleri yazdırabileceğim bir metot tanımlıyorum.
        {
            Console.WriteLine($"İsmim {name} soyadım {surname} {birthday} tarihinde doğdum");
        }
    }

}
