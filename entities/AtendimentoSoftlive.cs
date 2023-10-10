using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.entities
{
    // Classe para representar a fila de atendimento
    public class AtendimentoQueue
    {
        private Queue<string> fila = new Queue<string>();

        public void EnfileirarCliente(string cliente)
        {
            fila.Enqueue(cliente);
        }

        public void DesenfileirarCliente()
        {
            fila.Dequeue();
        }

        public int ContagemFila()
        {
            return fila.Count;
        }
    }

    // Classe para o chat
    public class Chat
    {
        private AtendimentoQueue fila = new AtendimentoQueue();

        public void IniciarAtendimento()
        {
            Console.WriteLine("Olá, como posso ajudar?");

            while (true)
            {
                Console.WriteLine($"Há {fila.ContagemFila()} cliente(s) na fila.");

                string mensagem = Console.ReadLine();

                if (mensagem.ToLower() == "encerrar")
                {
                    break;
                }

                fila.EnfileirarCliente(mensagem);

                // Processar a mensagem e fornecer uma resposta ao cliente
                Console.WriteLine("Aguarde um momento...");
                // Simule aqui o processamento da mensagem

                fila.DesenfileirarCliente();
            }
        }
    }

}


