using System;
using System.Linq;

namespace RoboMarte
{
    public static class VisualizacaoDinamica
    {
        public static void MostrarExploracao(Planalto planalto)
        {
            Console.Clear();
            Console.WriteLine("🚀 Missão Marte - Acompanhamento em Tempo Real\n");

            for (int y = planalto.LimiteY; y >= 0; y--)
            {
                Console.Write($"{y,2} ");
                for (int x = 0; x <= planalto.LimiteX; x++)
                {
                    var robo = planalto.Robos.LastOrDefault(r => r.X == x && r.Y == y);
                    Console.Write(robo != null ? ObterIconeRobo(robo) : " . ");
                }
                Console.WriteLine();
            }

            Console.Write("   ");
            for (int x = 0; x <= planalto.LimiteX; x++)
                Console.Write($"{x,3}");

            Console.WriteLine("\n\n📊 Status dos Robôs:");
            foreach (var robo in planalto.Robos)
                Console.WriteLine($"- Posição: ({robo.X}, {robo.Y}) | Direção: {ObterDirecaoCompleta(robo.Direcao)}");
        }

        private static string ObterIconeRobo(Robo robo) => robo.Direcao switch
        {
            'N' => " ▲ ",
            'S' => " ▼ ",
            'L' => " ► ",
            'O' => " ◄ ",
            _ => " ⚙ "
        };

        private static string ObterDirecaoCompleta(char direcao) => direcao switch
        {
            'N' => "Norte ↑",
            'S' => "Sul ↓",
            'L' => "Leste →",
            'O' => "Oeste ←",
            _ => "Desconhecida"
        };
    }
}