namespace SOLID.DIP.Violacao
{
    public class BookService
    {
        /*
         * A VIOLAÇAO AQUI OCORRE POIS INSTANCIAMOS O REPOSITORIO
         * AO INVES DE USARMOS UMA INTERFACE INJETADA
         * 
         * CASO O CONSTRUTOR DO REPOSITORIO MUDE, VOCE TERA QUE MUDAR SUA IMPLEMENTAÇAO
         * AGORA IMAGINE O TRABALHO QUE VOCE TERIA SE 100, 1000, 2000 METODOS USASSEM
         * ESSE REPOSITORIO
         *
         * USAR IMPLEMENTAÇOES CONCRETAS TIRA A FLEXIBILIDADE DA APLICACAO!
         *
         */
        public object CreateBook(object book)
        {
            /* REGRAS DE NEGÓCIO */
            /*...*/
            return new BookRepository().CreateBook(book);
        }
    }
}
