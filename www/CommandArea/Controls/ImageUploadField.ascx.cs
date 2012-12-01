using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommandArea_Controls_ImageUploadField : System.Web.UI.UserControl
{
    public string Label
    {
        get { return oLabel.Text;}
        set { oLabel.Text = value; }
    }

    private int _MaxWidth = int.MaxValue;
    public int MaxWidth { get { return _MaxWidth; } set { _MaxWidth = value; } }

    private int _MaxHeight = int.MaxValue;
    public int MaxHeight { get { return _MaxHeight; } set { _MaxHeight = value; } }

    public string SaveImageAndReturnFileName()
    {
        if(oFileUpload.HasFile)
        {
            JuggleDrumManager.Image image = 
                new JuggleDrumManager.Image(oFileUpload.FileContent, oFileUpload.FileName);

            image.MaxHeight = MaxHeight;
            image.MaxWidth = MaxWidth;
            image.SaveToDisk();
            return image.FileName;
        }
        else
        {
            return null;
        }
    }
}