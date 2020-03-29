using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KursnaLista
{
    public partial class KursnaListaForma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btPrikazi_Click(object sender, EventArgs e)
        {
            WebService1 ws = new WebService1();
            
            DateTime datetime = Convert.ToDateTime(tbDatum.Text);

            tbKurs.Text = ws.ProcitajmoTekst(datetime, dplValuta1.Text).ToString();

            if (tbDatum.Equals(DateTime.Now))
            {
                if(dplValuta1.Equals("Evro"))
                {
                    tbKurs.Text = ws.ProcitajmoTekst(datetime, dplValuta1.Text).ToString();
                    tbKurs.Focus();
                }
            }
        }
    }
}