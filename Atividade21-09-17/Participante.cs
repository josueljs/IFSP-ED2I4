using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_09_17
{
    class Participante
    {
        private string email;
        private string nome;

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }

        public Participante(string email, string nome)
        {
            this.email = email;
            this.nome = nome;
        }

        public Participante() : this("", "") { }

        public bool PodeInscrever(Eventos e)
        {
            bool podeInscrever = true;
            int xpart = 0;
            foreach(Evento i in e.OsEventos)
            {
                foreach(Participante p in i.OsParticipantes)
                {
                    if(this.email == p.email)
                    {
                        xpart++;
                    }
                }
            }
            if (xpart>1)
            {
                podeInscrever = false;
            }

            return podeInscrever;
        }

        public override bool Equals(object obj)
        {
            return this.email.Equals(((Participante)obj).email);
        }

        public override string ToString()
        {
            return this.email + " - " + this.nome + "\n";
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
