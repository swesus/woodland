using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class CommandArea_UploadedFiles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            DataRowCollection fileInfoRows = GetFileInfoRows();
            CreateFileInfoControls(fileInfoRows);
    }

    private void CreateFileInfoControls(DataRowCollection fileInfoRows)
    {
        foreach (DataRow fileInfo in fileInfoRows)
        {
            ASP.commandarea_controls_edituploadedfileinfo_ascx oEditUploadedFileInfo = 
                (ASP.commandarea_controls_edituploadedfileinfo_ascx)
                    LoadControl(typeof(ASP.commandarea_controls_edituploadedfileinfo_ascx), null);

            oEditUploadedFileInfo.BindToRow(fileInfo);
            oFileInfoPlaceHolder.Controls.Add(oEditUploadedFileInfo);
        }
    }

    private DataRowCollection GetFileInfoRows()
    {
        string sql_Select = "SELECT * FROM TBL_WoodlandLife_Files";
        return JuggleDrumManager.DB.Query(sql_Select).Rows;
    }
}