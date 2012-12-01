using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlTypes;
using WLMembership.Model;

public partial class CommandArea_Controls_EditSingleEvent : System.Web.UI.UserControl
{
    public bool DeleteButtonVisible
    {
        get { return oDelete.Visible; }
        set { oDelete.Visible = value; }
    }



    public void Bind(Event e)
    {
        oMessageInThePast.Visible = e.Date.Value < DateTime.Today;
        oEventId.Value = e.EventID.ToString();
        oTitle.Text = e.Title;
        oDate.DateAsString = e.Date.ToString();
        oContentHtml.Text = e.Content;
    }


    Guid? EventId
    {
        get
        {
            try
            {
                return new Guid(oEventId.Value);
            }
            catch
            {
                return null;
            }
        }
    }


    protected void oButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid && oDate.IsValid)
        {
            // Decide if this event is already in the database
            // and then save.
            if (EventId.HasValue)
            {
                SaveToDB_Update(EventId.Value);
            }
            else
            {
                SaveToDB_New();
            }


            //Reload the page to refresh data.
            ReloadPage();
        }
    }


    protected void oDelete_Click(object sender, EventArgs e)
    {
        if (EventId.HasValue)
        {
            using (var context = new WoodlandLifeEntities())
            {
                context.DeleteObject(context.Events.First(ev => ev.EventID == EventId.Value));
                context.SaveChanges();
            }
        }

        //Reload the page to refresh data.
        ReloadPage();
    }

    private void ReloadPage()
    {
        //Reload the page to refresh data.
        Response.Redirect(Request.RawUrl);
    }


    #region Save methods

    private void SaveToDB_Update(Guid eventId)
    {
        using (var context = new WoodlandLifeEntities())
        {
            var _event = context.Events.First(e => e.EventID == eventId);
            _event.Date = oDate.Date.Value.Value;
            _event.Title = oTitle.Text;
            _event.Content = oContentHtml.Text;

            context.SaveChanges();
        }
    }



    private void SaveToDB_New()
    {
        using (var context = new WoodlandLifeEntities())
        {
            var _event = new Event();
            _event.EventID = Guid.NewGuid();
            _event.Date = oDate.Date.Value.Value;
            _event.Title = oTitle.Text;
            _event.Content = oContentHtml.Text;

            context.AddToEvents(_event);
            context.SaveChanges();
        }
    }

    #endregion
}