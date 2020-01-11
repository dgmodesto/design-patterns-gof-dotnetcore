using System;

namespace Visitor
{
    class Program
    {
        /*
        - INTENÇÃO: representar uma operação a ser executada nos elementos de uma estrutura de objetos. Visitor permite
                    definir uma nova operação sem mudar as classes dos elementos entre os quais opera.
        - Define uma nova operação a uma classe sem alterá-la.
             */
        static void Main(string[] args)
        {
            //Object Structure
            Loja loja = new Loja();

            //Visitor
            PrecoEquipamentoVisitor visitor = new PrecoEquipamentoVisitor();

            //Element
            loja.addEquipamento(new Geladeira("Geladeira Consul", 3500));
            loja.addEquipamento(new Geladeira("Geladeira Brastemp", 5000));
            loja.addEquipamento(new Tv("Tv Lg Smart 55", 3000));
            loja.addEquipamento(new Fogao("Fogão 6 bocas branco Brastemp", 3500));

            //Visita todos os elementos
            loja.getEquipamentoList().ForEach(e =>
            {
                e.accept(visitor);
            });
        }
    }
}
