using System;

namespace RoboMarte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("🌌 Bem-vindo ao Controle da Missão Marte!");
                Console.WriteLine("Digite as coordenadas do canto superior direito (ex: 5 5):");
                var dimensoes = Console.ReadLine().Split(' ');
                var planalto = new Planalto(int.Parse(dimensoes[0]), int.Parse(dimensoes[1]));

                while (true)
                {
                    Console.WriteLine("\n🛰️ Adicionar novo robô (X Y Direção) ou ENTER para finalizar:");
                    var posicao = Console.ReadLine();
                    if (string.IsNullOrEmpty(posicao)) break;

                    var dados = posicao.Split(' ');
                    var robo = new Robo(int.Parse(dados[0]), int.Parse(dados[1]), dados[2][0], planalto);

                    Console.WriteLine("📡 Comandos para o robô (E/D/M):");
                    robo.ExecutarComandos(Console.ReadLine());
                    planalto.AdicionarRobo(robo);

                    VisualizacaoDinamica.MostrarExploracao(planalto);
                }

                Console.WriteLine("\n🎯 Relatório Final da Missão:");
                foreach (var robo in planalto.Robos)
                    Console.WriteLine(robo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ ERRO: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}