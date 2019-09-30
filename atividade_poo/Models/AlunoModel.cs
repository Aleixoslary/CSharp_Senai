using System;

namespace atividade_poo.obj.Models
{

    //Atributos
    public class AlunoModel
    {
        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
         public string Nome{get;set;}

         /// <summary>
        /// Nome de Curso
        /// </summary>
        /// <value>string</value>
        public string Curso{get;set;}

        /// <summary>
        /// R.A
        /// </summary>
        /// <value>string</value>
        public string Ra{get;set;}

        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value>int</value>
        public int Idade{get;set;}
    }

}