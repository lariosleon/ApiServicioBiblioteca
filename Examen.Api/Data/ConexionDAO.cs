namespace Examen.Api.Data
{
    public class ConexionDAO
    {
        public string GetCnx()
        {
                                                                                          
            string strgCnx = System.Configuration.ConfigurationManager.ConnectionStrings["ExamenApiConnection"].ConnectionString;

            if (object.ReferenceEquals(strgCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strgCnx;
            }
        }
    }
}
