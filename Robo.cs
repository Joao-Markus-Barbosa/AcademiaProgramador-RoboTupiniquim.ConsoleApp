namespace RoboMarte
{
    public class Robo
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Direcao { get; private set; }
        public string Historico { get; private set; } = "";
        private Planalto Planalto { get; }

        public Robo(int x, int y, char direcao, Planalto planalto)
        {
            X = x;
            Y = y;
            Direcao = char.ToUpper(direcao);
            Planalto = planalto;
        }

        public void ExecutarComandos(string comandos)
        {
            foreach (var comando in comandos.ToUpper())
            {
                switch (comando)
                {
                    case 'E': VirarEsquerda(); break;
                    case 'D': VirarDireita(); break;
                    case 'M': Mover(); break;
                }
                Historico += $"{X} {Y} {Direcao} > ";
            }
        }

        private void VirarEsquerda() => Direcao = Direcao switch
        {
            'N' => 'O',
            'O' => 'S',
            'S' => 'L',
            'L' => 'N',
            _ => Direcao
        };

        private void VirarDireita() => Direcao = Direcao switch
        {
            'N' => 'L',
            'L' => 'S',
            'S' => 'O',
            'O' => 'N',
            _ => Direcao
        };

        private void Mover()
        {
            switch (Direcao)
            {
                case 'N' when Y < Planalto.LimiteY: Y++; break;
                case 'S' when Y > 0: Y--; break;
                case 'L' when X < Planalto.LimiteX: X++; break;
                case 'O' when X > 0: X--; break;
            }
        }

        public override string ToString() => $"{X} {Y} {Direcao}";
    }
}