using DotNetBrowser.DOM;
using DotNetBrowser.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DOM_Get_Node_Value_from_Point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Check for right_click mouse button
            if (e.Button == MouseButtons.Right)
            {
                //For debug
                toolStripLabelX.Text = "X: " + e.X.ToString();
                toolStripLabelY.Text = "Y: " + e.Location.Y.ToString();

                Point dot = new Point(e.X, e.Y);
                
                DOMNodeAtPoint point = browserView.Browser.NodeAtPoint(dot);

                try
                {
                    toolStripGetElement.Text = "Node name: " + point.Node.NodeName.ToString();

                }
                catch { }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManualResetEvent resetEvent = new ManualResetEvent(false);
            FinishLoadingFrameHandler listener = new FinishLoadingFrameHandler((object sender1, FinishLoadingEventArgs e1) =>
            {
                if (e1.IsMainFrame)
                {
                    resetEvent.Set();
                }
            });
            browserView.Browser.FinishLoadingFrameEvent += listener;
            try
            {
                browserView.Browser.LoadURL("teamdev.com");
                resetEvent.WaitOne(new TimeSpan(0, 0, 45));
            }
            finally
            {
                browserView.Browser.FinishLoadingFrameEvent -= listener;
            }
        }
    }
}
