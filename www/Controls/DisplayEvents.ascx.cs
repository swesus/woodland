using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Controls_DisplayEvents : System.Web.UI.UserControl
{
    private bool DisplayPreviousEvents
    {
        get
        {
            return !string.IsNullOrEmpty(Request.QueryString["Previous"]);
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        using (var context = new WLMembership.Model.WoodlandLifeEntities())
        {
            System.Linq.IOrderedQueryable<WLMembership.Model.Event> query;

            if (DisplayPreviousEvents)
            {
                query = from ev in context.Events
                         where ev.Date.Value < DateTime.Today
                         orderby ev.Date descending
                         select ev;
            }
            else
            {
                query = from ev in context.Events
                         where ev.Date.Value >= DateTime.Today
                         orderby ev.Date
                         select ev;
            }

            StringBuilder html = new StringBuilder();


            foreach (var ev in query)
            {
                html.AppendFormat(
                    layout,
                    FormatDate(ev.Date.Value),
                    ev.Title,
                    ev.Content
                );

            }

            oHtml.Text = html.ToString();
        }
    }

    private static string FormatDate(DateTime date)
    {
        string dayThingy;

        switch(date.Day)
        {
            case 1:
            case 21:
            case 31:
               dayThingy = "st";
                break;
                
            case 2:
            case 22:
               dayThingy = "nd";
                break;
                
            case 3:
            case 32:
               dayThingy = "rd";
                break;

            default:
               dayThingy = "th";
                break;
        }

        string month;

        switch( date.Month)
        {
            case 1:
                month = "January";
                break;
                
            case 2:
                month = "February";
                break;

            case 3:
                month = "March";
                break;

            case 4:
                month = "April";
                break;

            case 5:
                month = "May";
                break;

            case 6:
                month = "June";
                break;

            case 7:
                month = "July";
                break;

            case 8:
                month = "August";
                break;

            case 9:
                month = "September";
                break;

            case 10:
                month = "October";
                break;

            case 11:
                month = "November";
                break;

            case 12:
                month = "December";
                break;

            default:
                throw new NotImplementedException();
        }


        return string.Format(
            "{0}, {1}<sup>{2}</sup> {3} {4}, {5}:{6}",
            date.DayOfWeek.ToString(),
            date.Day.ToString(),
            dayThingy,
            month,
            date.Year.ToString(),
            date.Hour.ToString(),
            date.Minute.ToString("00")
        );
    }


    private const string layout =
                     @"

<hr />

<div class='event'>

    <h2>
        <span class='date'>{0}</span>
        {1}
    </h2>

    <div>
        {2}
    </div>

</div>";

}
