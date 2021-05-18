using System;

namespace LutinhaTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem P1 = new Personagem();
            P1.nome = "Tamaki";
            P1.PontosVida = 68;
            P1.frase =  "Desista, porque eu sou… o Suneater!";
            P1.armadura = true;
            P1.resistenciaArmadura = 10;
            P1.dano = 16;
            P1.defesa = 9;

            Personagem P2 = new Personagem();

            P2.nome = "Kirishima";
            P2.PontosVida = 62;
            P2.frase =  "Eu sou indestrutível!!!";
            P2.armadura = true;
            P2.resistenciaArmadura = 20;
            P2.dano = 14;
            P2.defesa = 10;

            bool personagensVivos = true;

            

                Console.WriteLine(
            $@"A luta vai começar!!!
            {P1.nome} diz: {P1.frase}
            {P2.nome} diz: {P2.frase}
                ");

            P1.PontosVida = P1.PontosVida + P1.resistenciaArmadura;
            P2.PontosVida = P2.PontosVida + P2.resistenciaArmadura;

            do
            {
                Console.WriteLine($@"O que o {P1.nome} irá fazer?
                1 - atacar
                2 - defender");

                int P1Acao = int.Parse(Console.ReadLine());
                
                Console.WriteLine($@"O que o {P2.nome} irá fazer?
                1 - atacar
                2 - defender");

                int P2Acao = int.Parse(Console.ReadLine());

                if (P1Acao == 1 && P2Acao == 1)
                {
                    Console.WriteLine("Os dois atacaram!!");
                    P1.PontosVida = P1.PontosVida - P2.Atacar();
                    P2.PontosVida = P2.PontosVida - P2.Atacar();

                } else if(P1Acao == 1 && P2Acao == 2){
                    Console.WriteLine($"{P1.nome} ataca e {P2.nome} defende");
                    P2.PontosVida = P2.PontosVida - (P1.Atacar() - P2.Defender());

                } else if(P2Acao == 1 && P1Acao == 2){
                    Console.WriteLine($"{P2.nome} ataca e {P1.nome} defende");
                    P2.PontosVida = P1.PontosVida - (P2.Atacar() - P1.Defender());
                } else if(P1Acao == 2 && P2Acao == 2){
                    Console.WriteLine("Os dois ficam se encarando de forma estranha");
                }

            Console.WriteLine(
                $@"Vida dos personagens:
                {P1.nome} tem {P1.PontosVida} pontos de vida
                {P2.nome} tem {P2.PontosVida} pontos de vida
                ");

            if (P1.PontosVida < 0 || P2.PontosVida < 0)
            {
                personagensVivos = false;
            }

            } while (personagensVivos == true);


        }
    }
}
