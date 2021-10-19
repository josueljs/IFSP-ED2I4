using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_10_01
{
    class Contatos
    {
        private readonly List<Contato> agenda;

        public Contatos()
        {
            agenda=new List<Contato>();
        }

        public List<Contato> Agenda => agenda;

        public bool adicionar(Contato c)
        {
            bool add = true;
            Agenda.Add(c);
            return add;
        }

        public Contato pesquisar(Contato c)
        {
            Contato contatoencontrado = new Contato();
            
            foreach(Contato s in Agenda)
            {
                if (s.Email.Equals(c.Email))
                {
                    contatoencontrado=s;
                }
            }

            return contatoencontrado;
        }

        public bool alterar(Contato c)
        {
            bool alterar = false;
            foreach(Contato s in Agenda)
            {
                if (s.Email.Equals(c.Email))
                {
                    s.Nome = c.Nome;
                    s.Telefone = c.Telefone;
                    s.DtNasc = c.DtNasc;
                    alterar = true;
                }
            }
            return alterar;
        }

        public bool remover(Contato c)
        {
            bool remove = false;
            foreach(Contato s in Agenda.ToList())
            {
                if (s.Email.Equals(c.Email))
                {
                    agenda.Remove(s);
                    remove = true;
                }
            }
            return remove;
        }

        public void mostraLista()
        {
            foreach (Contato c in Agenda)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public override bool Equals(object obj)
        {
            return this.Agenda.Equals(((Contatos)obj).Agenda);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
