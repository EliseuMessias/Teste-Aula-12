using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Aula_12
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Snome /*sobrenome*/ { get; set; }
        public DateTime Nascimento { get; set; }

        public DateTime Data;

        public int Idade()
        {
            var b = DateTime.Now;
            Data = b;
            var i = Convert.ToInt32(Data.Year - Nascimento.Year);
            return i;
        }

        public string nomeCompleto()
        {
            return Nome + " " + Snome;
        }

        public int validarNome()
        {
            int i = 0;
            string n = Nome;
            string s = Snome;

            if (n.Contains(" Ç") || n.Contains(" ç") || s.Contains(" Ç") || s.Contains(" ç"))
            {
                Console.WriteLine("Este nome é não pode ser utilizado. Contém caracter 'Ç' que é inválido no início");
                i = +1;
            }
            if (n.Contains("@") || s.Contains("@"))
            {
                Console.WriteLine("Este nome não podeser utilizado. Contém caracter '@' que é inválido");
                i = +1;
             }
            return i;
        }

        public string erroValidacao(int i)
        {
            string m;
            if (i > 0 && i < 2 || i < 0)
            {
                m = "ERROR";
                return m;
            }


            else if (i == 0 || i > 2)
            {
                m = "NO ERROR";
                return m;
            }

            return "DEFAULT";
        }
    }
}
