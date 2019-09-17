using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    class ReferClass
    {
        /*
         * Name of the player
         */
        public static String playerName;

        /*
         * This method disposes the current form
         */
        public static void ExitGame(Form form)
        {
            form.Dispose();
        }

    }
}
