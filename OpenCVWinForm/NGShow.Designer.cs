namespace OpenCVWinForm
{
    partial class NGShow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NGShow));
            this.Lb_inform_NG = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lb_inform_NG
            // 
            this.Lb_inform_NG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lb_inform_NG.Font = new System.Drawing.Font("Palatino Linotype", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_inform_NG.ForeColor = System.Drawing.Color.Red;
            this.Lb_inform_NG.Location = new System.Drawing.Point(0, 354);
            this.Lb_inform_NG.Name = "Lb_inform_NG";
            this.Lb_inform_NG.Size = new System.Drawing.Size(791, 137);
            this.Lb_inform_NG.TabIndex = 3;
            this.Lb_inform_NG.Text = "Kiem Tra Oc";
            this.Lb_inform_NG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(157, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(447, 270);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "NG";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NGShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 491);
            this.Controls.Add(this.Lb_inform_NG);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NGShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NG Show";
            this.Load += new System.EventHandler(this.NGShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Lb_inform_NG;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
    }
}