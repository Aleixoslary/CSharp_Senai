// Criar um objeto de um celular, com as propriedades cor, modelo, tamanho.
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem. Só será
// possível executar tais métodos se o celular estiver ligado.

using System;
using Exe2.Controllers;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController cel = new CelularController();
            Console.Clear();
            
            cel.LigarCel();
            cel.Menu();
        }
    }
}
