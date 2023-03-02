using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Esrfly.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl _HomeUserControl;
        public HomeUserControl()
        {
            InitializeComponent();

        }
        public static HomeUserControl Instance()
        {
            //return _HomeUserControl if it is empity or create a new HomeUserControl, 
         
            return _HomeUserControl ?? (new HomeUserControl());
        }
    }
}
