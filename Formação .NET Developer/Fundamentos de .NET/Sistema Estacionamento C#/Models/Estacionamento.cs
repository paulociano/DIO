using System.Text.RegularExpressions;
using System;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string novaPlaca = Console.ReadLine();
            bool ok = ValidarPlaca(novaPlaca);
            
            if (!ok)
            {
                Console.WriteLine("A placa informada não é válida");
            }
            else
            {
                veiculos.Add(novaPlaca);
                Console.WriteLine("A placa "+novaPlaca+" foi adicionada!");
            }
            Console.ReadKey();
            
        }

        private static bool ValidarPlaca(string placa) {

            string verificaPlaca = placa.Replace("-", "").Trim();

            /*Verifica se a placa digitada está em branco ou tem o tamanho correto*/
            if(placa == ""){return false;}
            if(placa.Length != 8){return false;}
            
            /*Verifica se a placa está nos formatos BR ou Mercosul*/
            if (char.IsLetter(verificaPlaca, 4))
            {
                /* Verifica se a placa está no formato Mercosul: três letras, um número, uma letra e dois números.*/
                Regex padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}");
                return padraoMercosul.IsMatch(verificaPlaca);
            }
            else
            {
                // Verifica se a placa está no formato BR: 3 letras e 4 números.
                Regex padraoBR = new Regex("[a-zA-Z]{3}[0-9]{4}");
                return padraoBR.IsMatch(verificaPlaca);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = "";
            placa = Console.ReadLine();
            bool ok = ValidarPlaca(placa);

            if (!ok){
                Console.WriteLine("Placa inválida");
                return;
            } else {

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    int horas = 0;
                    decimal valorTotal = 0;

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    horas = Convert.ToInt32(Console.ReadLine());

                    valorTotal = this.precoInicial + (this.precoPorHora * horas);

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R${valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }

                }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
