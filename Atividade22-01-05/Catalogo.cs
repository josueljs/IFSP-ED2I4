using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atividade22_01_05
{
    public class Catalogo
    {
        private List<Equipamentos> lote;

        public List<Equipamentos> Lote { get => lote; set => lote = value; }

        public Catalogo()
        {
            lote = new List<Equipamentos>();
        }

        public void InserirTipoEquipamento(Equipamentos tipoequipamento)
        {
            lote.Add(tipoequipamento);
        }
    }
}