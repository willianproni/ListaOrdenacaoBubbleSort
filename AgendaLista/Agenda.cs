using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLista
{
    internal class Agenda
    {
        //public Contato Anterior { get; set; }
        //public Contato Registro { get; set; }
        //public Contato Proximo { get; set; }
        public Contato Head { get; set; }
        public Contato Tail { get; set; }

        public Agenda()
        {
            //Anterior = null;
            //Registro = null;
            //Proximo = null;
            Head = null;
            Tail = null;
        }

        //remover
        //edit
        //imprimir
        //buscar
        //ordenar
        //acharPosicao

        public void Push(Contato novoContato)
        {
            if (Vazio())
            {
                Head = novoContato;
                Tail = novoContato;
            }
            else
            {
                novoContato.Anterior = Tail;
                Tail.Proximo = novoContato;
                Tail = novoContato;
                OrdenarAgenda();
            }
        }

        public void Print()
        {
            if (Vazio())
            {
                Console.WriteLine("Lista Vazia!!");
            }
            else
            {
                Contato aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
            }

            Console.ReadKey();
        }

        public void OrdenarAgenda()
        {
            for (Contato referencia = Head; referencia != null; referencia = referencia.Proximo)
            {
                for (Contato comparacao = referencia.Proximo; comparacao != null; comparacao = comparacao.Proximo)
                {
                    if (String.Compare(referencia.Nome, comparacao.Nome) > 0)
                    {
                        if (referencia.Anterior != null && referencia.Anterior != comparacao)
                            referencia.Anterior.Proximo = comparacao;

                        if (referencia.Anterior == null && comparacao.Proximo == null && referencia.Proximo == comparacao)
                        {
                            referencia.Proximo = comparacao.Proximo;
                        }
                        else if (referencia.Proximo != comparacao)
                        {
                            comparacao.Anterior.Proximo = comparacao.Proximo;
                            Tail = comparacao.Anterior;
                        }
                        else
                        {
                            referencia.Proximo = comparacao.Proximo;
                        }

                        comparacao.Anterior = referencia.Anterior;
                        comparacao.Proximo = referencia;

                        referencia.Anterior = comparacao;


                        if (referencia.Anterior == null)
                            Head = referencia;

                        if (comparacao.Proximo == null)
                            Tail = comparacao;

                        if (referencia.Proximo == null)
                            Tail = referencia;

                        if (comparacao.Anterior == null)
                            Head = comparacao;

                    }
                }
            }
        }

        public bool Vazio()
        {
            if ((Head == null) && (Tail == null))
                return true;
            else
                return false;
        }

    }
}