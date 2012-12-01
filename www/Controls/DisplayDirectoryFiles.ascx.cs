using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_DisplayDirectoryFiles : System.Web.UI.UserControl
{
    public string Directory { get; set; }
    
    protected string[] FileNames
    {
        get 
        {
            var query = from f in System.IO.Directory.GetFiles(Server.MapPath(Directory))
                        select System.IO.Path.GetFileName(f);

            return query.ToArray();
        }
    }

    protected string FormatListItem(string FileName)
    {
        return string.Format(
            "<li><a href='{0}{1}'>{2}</a></li>",
            this.Directory.Replace("~", ""),
            FileName,
            FileName.Split('.')[0].Replace("-", " ")
        );
    }
}
