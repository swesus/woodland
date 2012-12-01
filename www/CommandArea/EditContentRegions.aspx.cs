using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommandArea_EditContentRegions : System.Web.UI.Page
{
    protected void SaveAll(object sender, EventArgs e)
    {
        oEvents.Save();
        oMission_Top.Save();
        oMission_Bottom.Save();
        oWhoAreWe_Shev.Save();
        oWhoAreWe_Tom.Save();
        oWhoAreWe_3.Save();
        oThinkTank.Save();
        oHowToFindUs.Save();
    }
}