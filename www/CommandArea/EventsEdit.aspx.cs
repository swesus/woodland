using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WLMembership.Model;

public partial class CommandArea_EventsEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PopulateEventsList();
    }

    private void PopulateEventsList()
    {
        // Add an empty event edit:
        if (true)
        {
            var oEventsEdit = LoadAnEmptyEventsEdit();
            oEventsEdit.DeleteButtonVisible = false;
            oEventsListPlaceHolder.Controls.Add(oEventsEdit);
        }

        // Add the events from the database:

        using(var context = new WoodlandLifeEntities())
        {
            foreach (var e in context.Events.OrderBy(e => e.Date))
            {
                var oEventsEdit = LoadAnEmptyEventsEdit();
                oEventsEdit.Bind(e);
                oEventsListPlaceHolder.Controls.Add(oEventsEdit);
            }
        }
    }

    private ASP.commandarea_controls_editsingleevent_ascx LoadAnEmptyEventsEdit()
    {
        return (ASP.commandarea_controls_editsingleevent_ascx)
            LoadControl(typeof(ASP.commandarea_controls_editsingleevent_ascx), null);
    }

    private static DataRowCollection GetEventRows()
    {
        string sql_Select = 
            " SELECT * FROM TBL_WoodlandLife_Events " +
            " ORDER BY Date ";

        return JuggleDrumManager.DB.Query(sql_Select).Rows;
    }


}
