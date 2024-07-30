using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CtorPractice
{
    internal class BabyClass
    {

        private int _birthDate;
        private string _name;
        private string _surName;

        public string Name
        {

            get { return _name; }

            set
            {
                _name = value;
            }

        }

        public string surName
        {

            get { return _surName; }

            set
            {
                _surName = value;
            }

        }

        public int birthDate
        {

            get
            {
                return _birthDate;
            }
            set
            {
                if (value >= 2023)

                { _birthDate = value; }

            }
        }




        public DateTime CreatedDateTime { get; private set; }

        //1.si Default Constructor tarzında parametre almayan bir metot.
        public BabyClass()
        {
            Console.WriteLine("Ingaaaa");
            CreatedDateTime = DateTime.Now;
            Console.WriteLine($"Bebeğin Doğum saati: {CreatedDateTime}");
        }


       


        //2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.
        public BabyClass(string name,string surname)
        {
            _name = name;
            _surName = surname;
            Console.WriteLine("Ingaaaa");
            //2 Constructor içinde ortak olarak bebek nesnesi
            //oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.
            CreatedDateTime = DateTime.Now;
            Console.WriteLine($"Bebeğin Adı:{name}, Soyadı : {surname}");
            Console.WriteLine($"Bebeğin Doğum saati: {CreatedDateTime}");


        }










    }
}
