using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.interfaces
{
    public interface ICalculadora
    {
        //interfaces
        int Somar(int num1, int num2);

        int Subtrair(int num1, int num2);

        int Multiplicar(int num1, int num2);

        int Dividir(int num1, int num2);
    }
}
