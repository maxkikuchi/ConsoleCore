using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        private readonly string _Nome;

        public Jogador1(string nome = "Desconhecido")
        {
            _Nome = nome;
        }

        //Chuta
        public string Chuta()
        {
            return $"{_Nome} está chutando";
        }

        //Corre
        public string Corre()
        {
            return $"{_Nome} está correndo";
        }

        //Passe
        public string Passe()
        {
            return $"{_Nome} está passando";
        }
    }
}