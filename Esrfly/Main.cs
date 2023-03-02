using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Esrfly.Code;

namespace Esrfly
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);
            //load Home Page
            pageManager.loadPage(Gui.GuiHome.HomeUserControl.Instance());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //load Home Page
            pageManager.loadPage(Gui.GuiHome.HomeUserControl.Instance());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
