using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserHelpControler
{
    public class Controler
    {
        public void OtvoriUserHelp(Form form, string topic)
        {
            string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            Help.ShowHelp(form, putanja + "\\Help\\SkyFlyReservationUserManual.chm", HelpNavigator.Topic, topic);
        }
    }
}
