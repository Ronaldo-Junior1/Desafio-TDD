using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents.Models
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string _data;
        public Calculadora(string data) 
        {
            listahistorico = new List<string>();
            _data = data;
        }

        public int Somar(int num1,int num2)
        {
            int res = num1 + num2;
            listahistorico.Insert(0, "Res: " + res + "Data:" + _data);
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            listahistorico.Insert(0, "Res: " + res + "Data:" + _data);
            return num1-num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            listahistorico.Insert(0, "Res: " + res + "Data:" + _data);
            return num1*num2;
        }

        public int Dividir(int num1, int num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException();
            }

            int res = num1 / num2;
            listahistorico.Insert(0, "Res: " + res + "Data:" + _data);

            return num1/num2;
        }

        public List<string> Historico()
        {
           
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }

    }
}
