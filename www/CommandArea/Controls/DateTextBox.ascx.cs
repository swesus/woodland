using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

public partial class CommandArea_Controls_DateTextBox : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        oErrorMessage.Visible = false;
    }

    int TextBoxToInt(TextBox value)
    {
        return int.Parse(value.Text);
    }

    private SqlDateTime? GetDateFromPage()
    {
        int day = 0;
        int month = 0;
        int year = 0;
        int minute = 0;
        int hour = 0;

        try
        {
            day = TextBoxToInt(oDay);
            month = TextBoxToInt(oMonth);
            year = TextBoxToInt(oYear);

            if (year < 100)
            {
                year += 2000;
            }
        }
        catch
        {
            return null;
        }

        try
        {
            var time = new 
            { 
                hour = TextBoxToInt(oHour),
                minute = TextBoxToInt(oMinute)
            };

            hour = time.hour;
            minute = time.minute;
        }
        catch { }

        try
        {
            return new SqlDateTime(year, month, day, hour, minute, 0);
        }
        catch
        {
            return null;
        }
    }





    public SqlDateTime? Date
    {
        get { return GetDateFromPage(); }
        set
        {
            if (value.HasValue)
            {
                DateTime d = value.Value.Value;

                oDay.Text = d.Day.ToString();
                oMonth.Text = d.Month.ToString();
                oYear.Text = d.Year.ToString();
                oHour.Text = d.Hour.ToString();
                oMinute.Text = d.Minute.ToString();
            }
            else
            {
                oDay.Text = oMonth.Text = oYear.Text = oHour.Text = oMinute.Text = string.Empty;
            }
        }
    }


    public string DateAsString
    {
        set
        {
            try
            {
                this.Date = SqlDateTimeParse(value);
            }
            catch(Exception ex)
            {
                this.Date = null;
            }
        }
    }


    private static SqlDateTime? SqlDateTimeParse(string date)
    {
        // 15/03/2011 00:00:00
        Match match = Regex.Match(date, @"^(?<day>\d+)/(?<month>\d+)/(?<year>\d+) (?<hour>\d+):(?<minute>\d+):(?<second>\d+)$");

        if (match.Success)
        {
            try
            {
                int day = int.Parse(match.Groups["day"].ToString());
                int month = int.Parse(match.Groups["month"].ToString());
                int year = int.Parse(match.Groups["year"].ToString());
                int hour = int.Parse(match.Groups["hour"].ToString());
                int minute = int.Parse(match.Groups["minute"].ToString());
                int second = int.Parse(match.Groups["second"].ToString());

                return new SqlDateTime(year, month, day, hour, minute, second);
            }
            catch { }
        }

        return null;
    }

    public bool IsValid
    {
        get
        {
            bool isValid = false;
            try
            {
                isValid = GetDateFromPage().Value.Value > new DateTime();
            }
            catch { }

            if (!isValid)
            {
                oErrorMessage.Visible = true;
            }

            return isValid;
        }
    }
}
