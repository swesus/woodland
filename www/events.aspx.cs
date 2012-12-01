using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Events : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SetViewToPreviousPage();
    }


    private void SetViewToPreviousPage()
    {
        bool onPreviousPage = !string.IsNullOrEmpty(Request.QueryString["Previous"]);

        if (onPreviousPage)
        {
            oHeader.InnerText = "Past Events";
        }
        else
        {
            using (var context = new WLMembership.Model.WoodlandLifeEntities())
            {
                var query = from ev in context.Events
                            where ev.Date.Value < DateTime.Today
                            select ev;

                bool previousListExists = query.Count() > 0;

                if (previousListExists)
                {
                    oMessagePrevious.Visible = true;
                }
            }
        }
    }
}
