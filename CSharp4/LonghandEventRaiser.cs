using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4
{
    public delegate void ClickHandler(object sender, EventArgs e);

    public class LonghandEventRaiser
    {
        private ClickHandler currentHandler = null;

        private void AddHandler(ClickHandler handler)
        {
            currentHandler = currentHandler + handler;
        }

        private void RemoveHandler(ClickHandler handler)
        {
            currentHandler = currentHandler - handler;
        }

        public void OnClick()
        {
            ClickHandler tmp = currentHandler;
            if (tmp != null)
            {
                tmp.Invoke(this, EventArgs.Empty);
            }
        }
        public event ClickHandler Click
        {
            add { AddHandler(value); }
            remove { RemoveHandler(value); }
        }
    }
}
