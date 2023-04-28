namespace EscolaMVC
{
    public static class Utils
    {
        /// <summary>
        /// Remove traços e pontos de uma string
        /// </summary>
        /// <param name="documento">CPF ou CNPJ</param>
        /// <returns>documento sem máscara</returns>
        public static string RemoverMascaraCPFouCNPJ(string documento) 
        {
            string docSemMascara = documento.Replace("-", "").Replace(".", "");

            return docSemMascara;
        }

    }
}
