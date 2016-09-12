namespace DOM_Get_Node_Value_from_Point
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGetElement = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelX = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelY = new System.Windows.Forms.ToolStripLabel();
            this.browserView = new DotNetBrowser.WinForms.WinFormsBrowserView();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGetElement,
            this.toolStripLabelX,
            this.toolStripLabelY,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGetElement
            // 
            this.toolStripGetElement.Name = "toolStripGetElement";
            this.toolStripGetElement.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabelX
            // 
            this.toolStripLabelX.Name = "toolStripLabelX";
            this.toolStripLabelX.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabelY
            // 
            this.toolStripLabelY.Name = "toolStripLabelY";
            this.toolStripLabelY.Size = new System.Drawing.Size(0, 22);
            // 
            // browserView
            // 
            this.browserView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserView.Location = new System.Drawing.Point(0, 25);
            this.browserView.Name = "browserView";
            this.browserView.Size = new System.Drawing.Size(922, 478);
            this.browserView.TabIndex = 1;
            this.browserView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(384, 22);
            this.toolStripLabel1.Text = "Right-click the component to obtain information about the DOM node.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 503);
            this.Controls.Add(this.browserView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripGetElement;
        private DotNetBrowser.WinForms.WinFormsBrowserView browserView;
        private System.Windows.Forms.ToolStripLabel toolStripLabelX;
        private System.Windows.Forms.ToolStripLabel toolStripLabelY;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

