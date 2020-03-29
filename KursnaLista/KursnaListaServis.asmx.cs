using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace KursnaLista
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        /*bool UpisiKursNaDan(DateTime Datum, string valuta, double Kurs)
        {
            DateTime datumVreme = Datum;
            

        }

        List<string> ProcitajSveValute()
        {

        }*/

       
        [WebMethod]
        public double ProcitajmoTekst(DateTime datum, string valuta)
        {
            DateTime datumVreme = datum;

            double vrednost = 0;

            if (datumVreme.Equals(datum))
            {
                if(valuta.Contains("Evro"))
                {
                    return vrednost = 117.2592;
                }

                else if (valuta.Contains("Dinar"))
                {
                    return vrednost = 1.00;
                }

                else if (valuta.Contains("Dolar"))
                {
                    return vrednost = 109.292;
                }
            }
            return vrednost;
        }
    }
}
