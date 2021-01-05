using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        private readonly string _Nome;

        public Jogador2()
        {
            _Nome = "Brenner";
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando";
        }

        public string Corre()
        {
            return $"{_Nome} está correndo";
        }

        public string Passe()
        {
            return $"{_Nome} está passando";
        }
    }
}