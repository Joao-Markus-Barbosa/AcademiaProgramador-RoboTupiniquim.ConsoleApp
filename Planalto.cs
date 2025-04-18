using System;
using System.Collections.Generic;

namespace RoboMarte
{
    public class Planalto
    {
        public int LimiteX { get; }
        public int LimiteY { get; }
        public List<Robo> Robos { get; } = new List<Robo>();

        public Planalto(int limiteX, int limiteY)
        {
            if (limiteX <= 0 || limiteY <= 0)
                throw new ArgumentException("Coordenadas devem ser positivas");

            LimiteX = limiteX;
            LimiteY = limiteY;
        }

        public void AdicionarRobo(Robo robo)
        {
            if (robo.X < 0 || robo.Y < 0 || robo.X > LimiteX || robo.Y > LimiteY)
                throw new ArgumentException("Posição inicial inválida");

            Robos.Add(robo);
        }
    }
}