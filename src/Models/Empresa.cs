using System;

namespace ISS.Models
{
    public class Empresa
    {
        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }

        public string Ativa { get; set; }

        public string Cidade { get; set; }

        public string Provedor { get; set; }



        public Empresa(Empresa empresa)
        {
            this.CNPJ = empresa.CNPJ;
            this.RazaoSocial = empresa.RazaoSocial;
            this.Ativa = empresa.Ativa;
            this.Cidade = empresa.Cidade;
            this.Provedor = empresa.Provedor;
        }

        public Empresa(string cnpj, string razaoSocial, string ativa, string cidade, string provedor)
        {
            this.CNPJ = cnpj;
            this.RazaoSocial = razaoSocial;
            this.Ativa = ativa;
            this.Cidade = cidade;
            this.Provedor = provedor;
        }

    }
}