using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    // Object strucuture
    public class Loja
    {
        private List<Equipamento> eqList = new List<Equipamento>();

        public void addEquipamento(Equipamento eq)
        {
            this.eqList.Add(eq);
        }

        public List<Equipamento> getEquipamentoList()
        {
            return eqList;
        }
    }
}
