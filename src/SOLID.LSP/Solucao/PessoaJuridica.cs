namespace SOLID.LSP.Solucao
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public override bool DocumentoEhValido()
        {
            /*
             * COMO PESSOA FÍSICA CONTINUA SENDO UMA PESSOA ELA TEM UM DOCUMENTO (CNPJ)
             * LOGO O DOCUMENTO PODE SER VALIDADO.
             * 
             * ALEM DISSO CLASSE BASE (PESSOA) PODE SER SUBSTITUIDA
             * PELA CLASSE FILHA (PESSOA JURIDICA), POR ISSO O LSP FOI APLICADO CORRETAMENTE
             */
            /*....*/
            return true;
        }
    }
}
