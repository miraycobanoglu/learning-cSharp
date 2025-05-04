using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama1
{ 
    public class calisan
    {
        private int id;
        private string soyad;
        private protected string isim;

        public calisan(int id, string soyad, string isim)
        {
           this.id = id;
           this.soyad = soyad;
           this.isim = isim;
        }
        


        public string getSoyad()
        {
            return this.soyad;
        }
        public void setSoyad(string soyad)
        {
            this.soyad = soyad;
        }


        public string ISIM
        {
            get { return isim; }
            set { isim = value; }
        }


        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }


        public void bilgileriGoster()
        {
            Console.WriteLine("id :"+id);
            Console.WriteLine("soyad : "+soyad);
            Console.WriteLine("isim : "+isim);
        }
        
    }
}

