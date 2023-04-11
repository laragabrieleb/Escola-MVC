namespace EscolaMVC
{
    public static class Utils
    {
        public static string RemoverMascaraCPFouCNPJ(string documento) 
        {
            string docSemMascara = documento.Replace("-", "").Replace(".", "");

            return docSemMascara;
        }

    }
}
