using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntohiStefanaCodrina_1079_proiectPAW
{
    [Serializable]
    public class Adrese:Pizza, ICloneable, IComparable, ITimpLivrare
    {
        private string adresa;
        private int durataLivrare;
        private string data;
        private string numeLivrator;
        public Adrese() : base()
        {
            Adresa = "Anonim";
            DurataLivrare = 20;
            Data = "1.01.2021";
            NumeLivrator = "Anonim";
        }
       
        public Adrese(string numePizza, string blat, string extraTopping, string sos, string adresa)
        {
            this.NumePizza = numePizza;
            this.Blat = blat;
            this.ExtraTopping = extraTopping;
            this.Sos = sos;
            this.Adresa = adresa;
       
        }

        

        public string Adresa { get => adresa; set => adresa = value; }
        public int DurataLivrare { get => durataLivrare; set => durataLivrare = value; }
        public string Data { get => data; set => data = value; }
        public string NumeLivrator { get => numeLivrator; set => numeLivrator = value; }
        public override string ToString()
        {
            return base.ToString() + " Adresa: " + adresa + " se va expedia in: " + durataLivrare +" minute " +  " , pe data: " + data + " de catre " +
                 numeLivrator;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Adrese a = (Adrese)obj;
            if (this.durataLivrare.CompareTo(a.durataLivrare) == 0)
                return string.Compare(this.adresa, a.adresa);
            else
                return this.durataLivrare.CompareTo(a.durataLivrare);
        }

        //operatorul +
        public static Adrese operator +(Adrese a, int x)
        {
            a.durataLivrare += x;
            return a;
        }

        public static Adrese operator +(int x, Adrese a)
        {
            return a + x;
        }

        //operatorul -
        public static Adrese operator -(Adrese a, int x)
        {
            a.durataLivrare -= x;
            return a;
        }

        public static Adrese operator -(int x, Adrese a)
        {
            return a - x;
        }

        public double timpulCalculat()
        {
            double tot = 0;
            for (int i = 0; i < durataLivrare; i++)
                tot = tot + durataLivrare;
            return tot;
        }

    }
}
