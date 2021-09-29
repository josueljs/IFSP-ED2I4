using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_09_17
{
    class Evento
    {
        private int id;
        private string descricao;
        private int qtde;
        private int qtdeMaxParticipantes;
        private Participante[] osParticipantes;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int QtdeMaxParticipantes { get => qtdeMaxParticipantes; set => qtdeMaxParticipantes = value; }
        public Participante[] OsParticipantes { get => osParticipantes; }
        public int Qtde { get => qtde;}

        public Evento(int id, string descricao, int qtdeMaxParticipantes)
        {
            this.id = id;
            this.descricao = descricao;
            this.qtdeMaxParticipantes = qtdeMaxParticipantes;
            this.osParticipantes = new Participante[qtdeMaxParticipantes];
            for(int i = 0; i < qtdeMaxParticipantes; ++i)
            {
                this.osParticipantes[i] = new Participante();
            }
        }

        public Evento(int qtdeMaxParticipantes)
            :this(0,"",qtdeMaxParticipantes)
        {
            for (int i = 0; i < qtdeMaxParticipantes; i++)
            {
                this.osParticipantes[i] = new Participante();
            }
        }

        public int InscreverParticipante(Participante p)
        {
            int op=0;

            if (qtde < qtdeMaxParticipantes)
            {
                this.OsParticipantes[qtde].Email = p.Email;
                this.OsParticipantes[qtde].Nome = p.Nome;
                qtde++;
            }
            else
            {
                op = 1;
            }

            return op;
        }

        public int qtdeParticipantes()
        {
            int total = 0;
            foreach(Participante p in this.OsParticipantes)
            {
                if (p.Email != "")
                {
                    total++;
                }
            }
            return total;
        }

        public string listaParticipantes()
        {
            Console.WriteLine("Nome do(s) participante(s) no evento " + this.Descricao + ":");
            foreach(Participante p in this.osParticipantes)
            {
                if (p.Nome != "")
                {
                    Console.WriteLine(p.ToString());
                }
            }
            return "";
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Evento)obj).id);
        }

        public override string ToString()
        {
            return this.id + " - " + this.descricao + " - " + this.qtdeMaxParticipantes + "\n";
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
