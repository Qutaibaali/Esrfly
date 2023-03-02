using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Esrfly.Code
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager( Main main)
        {
            this.main = main;
        }
        public void loadPage(UserControl PageuserControl) 
        {
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage !=null )
            {
                main.panelContainer.Controls.Remove(oldPage); //Remove old page
                oldPage.Dispose(); // remove old page from Cache Memory
            }
            // load new page
            PageuserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageuserControl); 
        }
    }
}
