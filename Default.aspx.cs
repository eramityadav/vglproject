using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

        goto label1;

        int target = -5;
        int num = 3;

        target = -num;  // Noncompliant; target = -3. Is that really what's meant?
        target = +num; // Noncompliant; target = 3

        label1:
        int i = 0;
        int j = 0;
        int k;
        //k = i / j;


    }
}
