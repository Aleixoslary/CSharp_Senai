using Aula12_Poo.Models;

namespace Aula12_Poo.Controllers
{
    public class CarroEletricoController : CarroController
    {
        CarroEletricoModel carroEletrico = new CarroEletricoModel();
    
        MotorModel motor = new MotorModel();

        public void CarregaBateria(float carga){
            if (carroEletrico.Bateria <100){
                carroEletrico.Bateria+= carga; // É O MESMO QUE: carroEletrico.Bateria = carroEletrico.Bateria + carga;
            } else{
                System.Console.WriteLine("A bateria está completa! Vooaa");
            }
        }

        public float StatusBateria(){

            return carroEletrico.Bateria;
        }
    }
}