using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntohiStefanaCodrina_1079_proiectPAW
{
    [Serializable]
    public class Pizza: ICloneable, IComparable
    {
        private string numePizza;
        private string blat;
        private string sos;
        private string extraTopping;
        private string adresaLivrare;

        public Pizza()
        {
            NumePizza = "Clasic";
            Blat = "subtire";
            Sos = "dulce";
            ExtraTopping = "fara";
            adresaLivrare = "fara adresa";
        }
        public Pizza(string numePizza, string blat, string sos, string extraTopping,string adresaLivrare)
        {
            this.NumePizza = numePizza;
            this.Blat= blat;
            this.Sos = sos;
            this.ExtraTopping = extraTopping;
            this.AdresaLivrare = adresaLivrare;
        }

        public string NumePizza { get => numePizza; set => numePizza = value; }
        public string Blat { get => blat; set => blat = value; }
        public string Sos { get => sos; set => sos = value; }
        public string ExtraTopping { get => extraTopping; set => extraTopping = value; }
        public string AdresaLivrare { get => adresaLivrare; set => adresaLivrare = value; }

        public object Clone()
        {
            return this.MemberwiseClone();//creeaza o copie superficiala a obiectului
        }

        public int CompareTo(object obj)
        {
            Pizza d = (Pizza)obj;
            if (this.ExtraTopping.CompareTo(d.ExtraTopping) == 0)
                return string.Compare(this.NumePizza, d.NumePizza);
            else
                return this.ExtraTopping.CompareTo(d.ExtraTopping);

        }

        public override string ToString()
        {
            return "NumePizza: " + NumePizza + " are blatul: " + Blat 
                +  " cu sosul: "+Sos+" si extraTopping: "+ExtraTopping+" si cu timpul de coacere: "
                +AdresaLivrare+".";

        }
        ////operatorul +
        //public static Pizza operator +(Pizza a, int x)
        //{
        //    a.DurataCoacere += x;
        //    return a;
        //}

        //public static Pizza operator +(int x, Pizza a)
        //{
        //    return a + x;
        //}

        ////operatorul -
        //public static Pizza operator -(Pizza a, int x)
        //{
        //    a.DurataCoacere -= x;
        //    return a;
        //}

        //public static Pizza operator -(int x, Pizza a)
        //{
        //    return a - x;
        //}

    }

}
