using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntohiStefanaCodrina_1079_proiectPAW
{
    [Serializable]
    public abstract class Clienti
    {
        private string nume;
        private string parola;
        private string email;

        protected string Nume { get => nume; set => nume = value; }
        protected string Parola { get => parola; set => parola = value; }
        protected string Email { get => email; set => email = value; }

        protected Clienti(string nume, string parola, string email)
        {
            this.Nume = nume;
            this.Parola = parola;
            this.Email = email;
        }
    }

}
