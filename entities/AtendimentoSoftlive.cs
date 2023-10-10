using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                Console.WriteLine();
                Console.WriteLine($"Há {fila.ContagemFila()} cliente(s) na fila.");
                Console.WriteLine();

                string mensagem = Console.ReadLine();

                if (mensagem.ToLower() == "encerrar")
                {
                    break;
                }

                fila.EnfileirarCliente(mensagem);

                // Processar a mensagem e fornecer uma resposta ao cliente
                Console.WriteLine();
                Console.WriteLine("Aguarde um momento...");
                string resposta = ResponderCliente(mensagem);
                SimularDigitacao();
                Console.WriteLine("Digitando...");
                SimularDigitacao();
                Console.WriteLine(resposta);
                Console.WriteLine();
                // Simule aqui o processamento da mensagem

                fila.DesenfileirarCliente();
            }
        }

        public string ResponderCliente(string pergunta)
        {
            // Aqui você pode implementar a lógica para responder ao cliente com base em sua pergunta.
            // Por enquanto, estamos fornecendo uma resposta simples.
            return "Obrigado por sua pergunta. Em breve, um atendente irá ajudá-lo.";
        }

        private void SimularDigitacao()
        {
            // Simula o atendente digitando durante 2 segundos (2000 milissegundos)
            Thread.Sleep(1500);
        }
    }


}


