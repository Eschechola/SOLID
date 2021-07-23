namespace SOLID.DIP.Solucao
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        /*
         * AGORA NOS DEPENDEMOS DA ABSTRAÇAO DO REPOSITORIO 
         * E NAO DA IMPLEMENTAÇAO, AGORA CASO MUDE O CONSTRUTOR 
         * NAO PRECISAREMOS ALTERAR EM CADA MÉTODO.
         * 
         * ALEM DISSO UTILIZAMOS INJEÇAO DE DEPENDENCIA, QUE É
         * DIFERENTE DE INVERSAO DE DEPENDENCIA
         *
         */


        public object CreateBook(object book)
        {
            /* REGRAS DE NEGÓCIO */
            /*...*/
            return _bookRepository.CreateBook(book);
        }
    }
}
