using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade21_09_17
{
    class Eventos
    {
        private Evento[] osEventos;

        public Evento[] OsEventos { get => osEventos;}

        public Eventos(int max, int maxp)
        {
            this.osEventos = new Evento[max];
            for(int i=0; i < max; i++)
            {
                this.osEventos[i] = new Evento(maxp);
            }
        }

        public void adicionarEvento(Evento e, int dia)
        {
            this.osEventos[dia - 1] = e;
        }

        public string pesquisarParticipante(Participante p)
        {
            foreach(Evento e in this.osEventos)
            {
                for(int i = 0; i < e.QtdeMaxParticipantes; i++)
                {
                    if (e.OsParticipantes[i].Email.Equals(p.Email))
                    {
                        return "Participante " + e.OsParticipantes[i].Nome + " está inscrito(a) no evento: '"+e.Descricao+"'.\n";
                    }
                }
            }
            return "";
        }

        public int qtdeParticipantes()
        {
            int total = 0;
            foreach (Evento e in this.osEventos)
            {
                for (int i = 0; i < e.QtdeMaxParticipantes; i++)
                {
                    if (e.OsParticipantes[i].Nome != "")
                    {
                        total++;
                    }
                }
            }
            return total;
        }

        public string listaEventos()
        {
            foreach(Evento e in this.osEventos)
            {
                if (e.Id != 0)
                {
                    Console.WriteLine("Evento: " + e.ToString() + "Total de participantes: " + e.qtdeParticipantes() + ".\n\n");
                }
            }
            return "";
        }
    }
}
