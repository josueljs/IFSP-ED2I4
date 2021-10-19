using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_10_01
{
    class Contato
    {
        private string email;
        private string nome;
        private string telefone;
        private Data dtNasc;

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        internal Data DtNasc { get => dtNasc; set => dtNasc = value; }

        public Contato()
        {
            email = "";
            nome = "";
            telefone = "";
           dtNasc = new Data();
        }

        public Contato(string email, string nome, string telefone, Data dtNasc)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dtNasc=dtNasc;
        }

        public int getIdade()
        {
            return 2021 - dtNasc.Ano;
        }

        public override string ToString()
        {
            return email+" - "+nome+" - "+telefone+" - "+ dtNasc.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.email.Equals(((Contato)obj).Email);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
