using System.Runtime.Intrinsics.Arm;

namespace ExIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
                if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
                else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}

// Leia a hora inicial e a hora final de um jogo.
// A seguir calcule a duração do jogo, sabendo que ele pode começar em um dia e terminar em outro,
// tendo uma duração mínima de 1 hora e máxima de 24 horas.