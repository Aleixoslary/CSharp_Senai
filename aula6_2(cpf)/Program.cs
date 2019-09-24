using System;

namespace aula6_2_cpf_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CPF: ");
            string cpf= Console.ReadLine();

            Console.WriteLine(ValidaCPF(cpf));
        }

        static bool ValidaCPF(string cpfUsuario){

            bool resultado = false;
            int[] v1 ={10,9,8,7,6,5,4,3,2};
            string cpfCalculo ="";
            int resto=0;
            string digito_v1="";
            string digito_v2="";
            int calculo=0;

            cpfCalculo = cpfUsuario.Substring(0,9);

            for(int i=0; i<=8;i++){
                calculo+= int.Parse(cpfCalculo[i].ToString()) * v1[i];
            }

           resto=calculo%11;
           calculo=11-resto;

            if(calculo>9){
                digito_v1="0";
            } else{
                digito_v1=calculo.ToString();
            }

            if(digito_v1 ==cpfUsuario[9].ToString()){
                resultado=true;
            }

            int[] v2={11,10,9,8,7,6,5,4,3,2};
            resto=0;

            cpfCalculo= cpfCalculo+calculo.ToString();
            calculo=0;

            for(int i=0; i<=9;i++){
                calculo+= int.Parse(cpfCalculo[i].ToString()) * v2[i];
            }

           resto=calculo%11;
           calculo=11-resto;

            if(calculo>9){
                digito_v2="0";
            } else{
                digito_v2=calculo.ToString();
            }

            if(digito_v2==cpfUsuario[10].ToString()){
                resultado=true;
            }

            return resultado;
        }
    }
}


//TRIM -- Tira os caracteres indesejados


//Distribua os 9 primeiros dígitos do CPF na primeira linha de uma tabela, e na linha abaixo distribua os pesos 10, 9, 8, 7, 6, 5, 4, 3,2;
//2) Multiplique os valores de cada coluna;
//3) Calcule a somatória dos resultados (10+18+…+24+18) = 210
//4) O resultado obtido (210) será divido por 11. Considere como quociente apenas o valor inteiro obtido na divisão, o resto da divisão será responsável pelo cálculo do primeiro dígito verificador