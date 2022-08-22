using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoParentetizacao
{
    public class Parentetizacao
    {
        int open = 0;
        string parentetizacao = "()";

        public bool verificarParentetizacao()
        {
            
            for (var i = 0; i < parentetizacao.Length; i++)
            {
                if (parentetizacao[i] == '(')
                {                
                    open++;
                }
                else
                {
                    open--;
                }
               
            }
            if (open == 0)
            {
                return true;
            }
            return false;

        }

    }
}

