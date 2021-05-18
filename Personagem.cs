namespace LutinhaTerminal
{
    public class Personagem
    {
        public string nome;
        public int PontosVida;

        public string frase;

        public bool armadura = false;

        public int resistenciaArmadura;
        public int dano;
        public int defesa;

        public int Atacar(){
            return dano;
        }

        public int Defender(){
            return defesa;
        }





    }
}