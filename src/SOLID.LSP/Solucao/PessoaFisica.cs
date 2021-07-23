namespace SOLID.LSP.Solucao
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public override bool DocumentoEhValido()
        {
            /*
             * COMO PESSOA FÍSICA CONTINUA SENDO UMA PESSOA ELA TEM UM DOCUMENTO (CPF)
             * LOGO O DOCUMENTO PODE SER VALIDADO.
             * 
             * ALEM DISSO CLASSE BASE (PESSOA) PODE SER SUBSTITUIDA
             * PELA CLASSE FILHA (PESSOA FISICA), POR ISSO O LSP FOI APLICADO CORRETAMENTE
             */
            /*....*/
            return true;
        }
    }
}
