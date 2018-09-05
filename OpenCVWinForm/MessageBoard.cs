using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenCVWinForm
{
    public class MessageBoard
    {
        private IContainer components;
        private Label label1;

        // Methods
        public MessageBoard()
        {
            //this.InitializeComponent();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (this.components != null))
        //    {
        //        this.components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private void InitializeComponent()
        //{
        //    this.label1 = new Label();
        //    base.SuspendLayout();
        //    this.label1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        //    this.label1.Font = new Font("MS UI Gothic", 162f, FontStyle.Bold, GraphicsUnit.Point, 0x80);
        //    this.label1.Location = new Point(12, 9);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new Size(0x337, 0x1b4);
        //    this.label1.TabIndex = 0;
        //    this.label1.Text = "PASS";
        //    this.label1.TextAlign = ContentAlignment.MiddleCenter;
        //    base.AutoScaleDimensions = new SizeF(6f, 12f);
        //    base.AutoScaleMode = AutoScaleMode.Font;
        //    this.BackColor = Color.White;
        //    base.ClientSize = new Size(0x34f, 0x1c6);
        //    base.Controls.Add(this.label1);
        //    base.MaximizeBox = false;
        //    base.MinimizeBox = false;
        //    base.Name = "MessageBoard";
        //    base.ShowIcon = false;
        //    base.Load += new EventHandler(this.MessageBoard_Load);
        //    base.ResumeLayout(false);
        //}

        //private void MessageBoard_Load(object sender, EventArgs e)
        //{
        //    base.TopMost = true;
        //}

        // Properties
        public Color labelColor
        {
            get
            {
                return this.label1.ForeColor;
            }
            set
            {
                this.label1.ForeColor = value;
            }
        }

        public string labelText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

    }
}
