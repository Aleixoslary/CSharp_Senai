using System;

namespace aula6_3_cnpj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o CNPJ: ");
            string cnpj= Console.ReadLine();

            Console.WriteLine(ValidaCNPJ(cnpj));
        }

        static bool ValidaCNPJ(string cnpj){

            bool resultado=false;
            int[] v1={5,4,3,2,9,8,7,6,5,4,3,2};
            string cnpjCalc="";
            int resto=0;
            string di_v1="";
            string di_v2 ="";
            int calc=0;

            cnpj= cnpj.Replace(" ","");
            cnpj=cnpj.Replace("-","");
            cnpj=cnpj.Replace(".","");
            cnpj=cnpj.Replace("/","");

            cnpjCalc=cnpj.Substring(0,12);

            for (int i=0; i<=11;i++){
                calc += int.Parse(cnpjCalc[i].ToString())*v1[i];
            }

            resto= calc%11;
            calc=11-resto;

            if(resto<2){
                di_v1="0";
            }else{
                di_v1=calc.ToString();
            }

            if(di_v1 ==cnpj[12].ToString()){
                resultado=true;
            }

            int[] v2={6,5,4,3,2,9,8,7,6,5,4,3,2};
            resto=0;
            cnpjCalc= cnpjCalc+calc.ToString();
            calc=0;
            
            for (int i=0; i<=12;i++){
                calc += int.Parse(cnpjCalc[i].ToString())*v2[i];
            }

            resto= calc%11;
            calc=11-resto;

            if(resto<2){
                di_v2="0";
            }else{
                di_v2=calc.ToString();
            }

            if(di_v2 ==cnpj[13].ToString()){
                resultado=true;

            }else{ resultado=false;
            }

            return resultado;
        }
    }
}
