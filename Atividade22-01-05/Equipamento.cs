using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atividade22_01_05
{
    public class Equipamento
    {
        private int id;
        private bool avaria;

        public int Id { get => id; set => id = value; }
        public bool Avaria { get => avaria; set => avaria = value; }

        public Equipamento()
        {
            this.id = 0;
            this.avaria = false;
        }

        public Equipamento(int id)
        {
            this.id = id;
            this.avaria = false;
        }
    }
}