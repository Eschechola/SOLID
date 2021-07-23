using System;

namespace SOLID.LSP.Solucao
{
    public abstract class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public abstract bool DocumentoEhValido();
    }
}
