using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using System.ComponentModel;


using System.Data;
using System.Drawing;

using System.Xml;
using System.Threading;
using System.IO;
namespace OpenCVWinForm
{
    public class BaslerCameraProperty : Form
    {
        // Fields
   
        private CameraSetting cameraSetting;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private IContainer components;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label2;
        private Label label25;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown10;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
        private NumericUpDown numericUpDown9;
        private RadioButton radioButton1;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radiobuttonteaching;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        public string stCurrentDir = Application.StartupPath;

        // Methods
        public BaslerCameraProperty()
        {
            this.InitializeComponent();
        }

        private void BaslerCameraProperty_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            base.Visible = false;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.StartPosition = FormStartPosition.CenterParent;
            string path = this.stCurrentDir + @"\conf\camprt.xml";
            this.cameraSetting = new CameraSetting();
            if (!File.Exists(path))
            {
                this.cameraSetting.exposureMode = 0;
                this.cameraSetting.exposureTime = 0x1388;
                this.cameraSetting.gainMode = 0;
                this.cameraSetting.gain = 0.0;
                this.cameraSetting.whiteLevelMode = 0;
                this.cameraSetting.whiteLevel = 127.0;
                this.cameraSetting.gamma = 1.0;
                this.cameraSetting.packetSize = 0x5dc;
                this.cameraSetting.mode = 9;
                CameraSetting.WriteCameraProterty<CameraSetting>(this.cameraSetting, path);
            }
            CameraSetting.ReadCameraProperty<CameraSetting>(out this.cameraSetting, path);
            if (this.cameraSetting.packetSize < 0x5dc)
            {
                this.cameraSetting.packetSize = 0x5dc;
                CameraSetting.WriteCameraProterty<CameraSetting>(this.cameraSetting, path);
                CameraSetting.ReadCameraProperty<CameraSetting>(out this.cameraSetting, path);
            }
            this.checkBox1.Checked = this.cameraSetting.gainMode != 0;
            this.checkBox2.Checked = this.cameraSetting.whiteLevelMode != 0;
            this.numericUpDown7.Value = this.cameraSetting.exposureTime;
            this.numericUpDown1.Value = (decimal)this.cameraSetting.gain;
            this.numericUpDown2.Value = (decimal)this.cameraSetting.whiteLevel;
            this.numericUpDown3.Value = (decimal)this.cameraSetting.blackLevel;
            this.numericUpDown5.Value = (decimal)this.cameraSetting.gamma;
            this.numericUpDown4.Value = this.cameraSetting.packetSize;
            this.label11.Text = this.cameraSetting.deviceName;
            this.SetCaptureSize();
            this.SelectResize();
            if ((this.cameraSetting.deviceName.IndexOf("uc") >= 0) || (this.cameraSetting.deviceName.IndexOf("gc") >= 0))
            {
                this.radioButton11.Enabled = true;
                this.radioButton10.Enabled = true;
                if (this.cameraSetting.color == 1)
                {
                    this.radioButton11.Checked = true;
                }
                else
                {
                    this.radioButton10.Checked = true;
                }
            }
            else
            {
                this.radioButton11.Enabled = true;
                this.radioButton11.Checked = true;
                this.radioButton10.Enabled = false;
            }
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.ActiveControl = this.button2;
            base.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pPath = this.stCurrentDir + @"\conf\camprt.xml";
            this.cameraSetting.exposureTime = (int)this.numericUpDown7.Value;
            int num = this.checkBox1.Checked ? 2 : 0;
            this.cameraSetting.gainMode = num;
            this.cameraSetting.gain = (double)this.numericUpDown1.Value;
            num = this.checkBox2.Checked ? 1 : 0;
            this.cameraSetting.whiteLevelMode = num;
            this.cameraSetting.whiteLevel = (double)this.numericUpDown2.Value;
            this.cameraSetting.blackLevel = (double)this.numericUpDown3.Value;
            this.cameraSetting.gamma = (double)this.numericUpDown5.Value;
            this.cameraSetting.packetSize = (int)this.numericUpDown4.Value;
            if ((((int)this.numericUpDown6.Value) % 2) == 1)
            {
                this.cameraSetting.capWidth = ((int)this.numericUpDown6.Value) - 1;
            }
            else
            {
                this.cameraSetting.capWidth = (int)this.numericUpDown6.Value;
            }
            if ((((int)this.numericUpDown8.Value) % 2) == 1)
            {
                this.cameraSetting.capHeight = ((int)this.numericUpDown8.Value) - 1;
            }
            else
            {
                this.cameraSetting.capHeight = (int)this.numericUpDown8.Value;
            }
            if ((((int)this.numericUpDown9.Value) % 2) == 1)
            {
                this.cameraSetting.capX = ((int)this.numericUpDown9.Value) - 1;
            }
            else
            {
                this.cameraSetting.capX = (int)this.numericUpDown9.Value;
            }
            if ((((int)this.numericUpDown10.Value) % 2) == 1)
            {
                this.cameraSetting.capY = ((int)this.numericUpDown10.Value) - 1;
            }
            else
            {
                this.cameraSetting.capY = (int)this.numericUpDown10.Value;
            }
            this.cameraSetting.deviceName = this.label11.Text;
            this.cameraSetting.fullsize = this.checkBox5.Checked;
            if (this.radioButton1.Checked)
            {
                this.cameraSetting.capSize = 0;
            }
            else if (this.radioButton2.Checked)
            {
                this.cameraSetting.capSize = 1;
            }
            else if (this.radioButton3.Checked)
            {
                this.cameraSetting.capSize = 2;
            }
            else if (this.radioButton4.Checked)
            {
                this.cameraSetting.capSize = 3;
            }
            if (this.radioButton12.Checked)
            {
                this.cameraSetting.reSize = 0;
            }
            else if (this.radioButton13.Checked)
            {
                this.cameraSetting.reSize = 1;
            }
            else if (this.radioButton14.Checked)
            {
                this.cameraSetting.reSize = 2;
            }
            else if (this.radioButton15.Checked)
            {
                this.cameraSetting.reSize = 3;
            }
            else
            {
                this.cameraSetting.reSize = -1;
            }
            if (this.radioButton11.Checked)
            {
                this.cameraSetting.color = 1;
            }
            else
            {
                this.cameraSetting.color = 0;
            }
            CameraSetting.WriteCameraProterty<CameraSetting>(this.cameraSetting, pPath);
            base.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(BaslerCameraProperty));
            this.label4 = new Label();
            this.numericUpDown4 = new NumericUpDown();
            this.label3 = new Label();
            this.numericUpDown3 = new NumericUpDown();
            this.button2 = new Button();
            this.label2 = new Label();
            this.numericUpDown2 = new NumericUpDown();
            this.label1 = new Label();
            this.numericUpDown1 = new NumericUpDown();
            this.label25 = new Label();
            this.numericUpDown7 = new NumericUpDown();
                        this.numericUpDown5 = new NumericUpDown();
            this.label5 = new Label();
            this.checkBox1 = new CheckBox();
            this.checkBox2 = new CheckBox();
            this.checkBox3 = new CheckBox();
            this.checkBox4 = new CheckBox();
            this.label6 = new Label();
            this.numericUpDown6 = new NumericUpDown();
            this.numericUpDown8 = new NumericUpDown();
            this.numericUpDown9 = new NumericUpDown();
            this.numericUpDown10 = new NumericUpDown();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.checkBox5 = new CheckBox();
            this.groupBox1 = new GroupBox();
            this.radioButton9 = new RadioButton();
            this.radioButton8 = new RadioButton();
            this.radioButton7 = new RadioButton();
            this.radioButton6 = new RadioButton();
            this.radioButton5 = new RadioButton();
            this.radioButton4 = new RadioButton();
            this.radioButton3 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.radioButton1 = new RadioButton();
            this.label11 = new Label();
            this.groupBox2 = new GroupBox();
            this.radioButton11 = new RadioButton();
            this.radioButton10 = new RadioButton();
            this.groupBox3 = new GroupBox();
            this.radioButton12 = new RadioButton();
            this.radioButton13 = new RadioButton();
            this.radioButton14 = new RadioButton();
            this.radioButton15 = new RadioButton();
            this.radiobuttonteaching = new RadioButton();
            this.numericUpDown4.BeginInit();
            this.numericUpDown3.BeginInit();
            this.numericUpDown2.BeginInit();
            this.numericUpDown1.BeginInit();
            this.numericUpDown7.BeginInit();
            this.numericUpDown5.BeginInit();
            this.numericUpDown6.BeginInit();
            this.numericUpDown8.BeginInit();
            this.numericUpDown9.BeginInit();
            this.numericUpDown10.BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            base.SuspendLayout();
            manager.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = Color.WhiteSmoke;
            this.label4.Name = "label4";
            manager.ApplyResources(this.numericUpDown4, "numericUpDown4");
            this.numericUpDown4.BackColor = Color.Black;
            this.numericUpDown4.ForeColor = SystemColors.Control;
            int[] bits = new int[4];
            bits[0] = 100;
            this.numericUpDown4.Increment = new decimal(bits);
            int[] numArray2 = new int[4];
            numArray2[0] = 0x2710;
            this.numericUpDown4.Maximum = new decimal(numArray2);
            this.numericUpDown4.Name = "numericUpDown4";
            int[] numArray3 = new int[4];
            numArray3[0] = 0x5dc;
            this.numericUpDown4.Value = new decimal(numArray3);
            manager.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = Color.WhiteSmoke;
            this.label3.Name = "label3";
            manager.ApplyResources(this.numericUpDown3, "numericUpDown3");
            this.numericUpDown3.BackColor = Color.Black;
            this.numericUpDown3.DecimalPlaces = 5;
            this.numericUpDown3.ForeColor = SystemColors.Control;
            int[] numArray4 = new int[4];
            numArray4[0] = 0x3ff;
            this.numericUpDown3.Maximum = new decimal(numArray4);
            this.numericUpDown3.Name = "numericUpDown3";
            int[] numArray5 = new int[4];
            numArray5[0] = 0x200;
            this.numericUpDown3.Value = new decimal(numArray5);
            manager.ApplyResources(this.button2, "button2");
            this.button2.BackColor = Color.DarkGray;
            //this.button2.DialogResult = DialogResult.Cancel;
            this.button2.ForeColor = Color.WhiteSmoke;
            this.button2.Name = "button2";
            //this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new EventHandler(this.button2_Click);
            manager.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = Color.WhiteSmoke;
            this.label2.Name = "label2";
            manager.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.BackColor = Color.Black;
            this.numericUpDown2.DecimalPlaces = 5;
            this.numericUpDown2.ForeColor = SystemColors.Control;
            int[] numArray6 = new int[4];
            numArray6[0] = 0xff;
            this.numericUpDown2.Maximum = new decimal(numArray6);
            this.numericUpDown2.Name = "numericUpDown2";
            int[] numArray7 = new int[4];
            numArray7[0] = 0x7f;
            this.numericUpDown2.Value = new decimal(numArray7);
            manager.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = Color.WhiteSmoke;
            this.label1.Name = "label1";
            manager.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.BackColor = Color.Black;
            this.numericUpDown1.DecimalPlaces = 5;
            this.numericUpDown1.ForeColor = SystemColors.Control;
            int[] numArray8 = new int[4];
            numArray8[0] = 0x3ff;
            this.numericUpDown1.Maximum = new decimal(numArray8);
            this.numericUpDown1.Name = "numericUpDown1";
            int[] numArray9 = new int[4];
            numArray9[0] = 450;
            this.numericUpDown1.Value = new decimal(numArray9);
            manager.ApplyResources(this.label25, "label25");
            this.label25.ForeColor = Color.WhiteSmoke;
            this.label25.Name = "label25";
            manager.ApplyResources(this.numericUpDown7, "numericUpDown7");
            this.numericUpDown7.BackColor = Color.Black;
            this.numericUpDown7.ForeColor = SystemColors.Control;
            int[] numArray10 = new int[4];
            numArray10[0] = 0x989680;
            this.numericUpDown7.Maximum = new decimal(numArray10);
            int[] numArray11 = new int[4];
            numArray11[0] = 100;
            this.numericUpDown7.Minimum = new decimal(numArray11);
            this.numericUpDown7.Name = "numericUpDown7";
            int[] numArray12 = new int[4];
            numArray12[0] = 0x1f40;
            this.numericUpDown7.Value = new decimal(numArray12);
           
            manager.ApplyResources(this.numericUpDown5, "numericUpDown5");
            this.numericUpDown5.BackColor = Color.Black;
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.ForeColor = SystemColors.Control;
            int[] numArray13 = new int[4];
            numArray13[0] = 1;
            numArray13[3] = 0x20000;
            this.numericUpDown5.Increment = new decimal(numArray13);
            this.numericUpDown5.Name = "numericUpDown5";
            int[] numArray14 = new int[4];
            numArray14[0] = 10;
            numArray14[3] = 0x10000;
            this.numericUpDown5.Value = new decimal(numArray14);
            manager.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = Color.WhiteSmoke;
            this.label5.Name = "label5";
            manager.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = Color.WhiteSmoke;
            this.label6.Name = "label6";
            this.numericUpDown6.BackColor = Color.Black;
            this.numericUpDown6.ForeColor = SystemColors.Control;
            manager.ApplyResources(this.numericUpDown6, "numericUpDown6");
            int[] numArray15 = new int[4];
            numArray15[0] = 0x989680;
            this.numericUpDown6.Maximum = new decimal(numArray15);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown8.BackColor = Color.Black;
            this.numericUpDown8.ForeColor = SystemColors.Control;
            manager.ApplyResources(this.numericUpDown8, "numericUpDown8");
            int[] numArray16 = new int[4];
            numArray16[0] = 0x989680;
            this.numericUpDown8.Maximum = new decimal(numArray16);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown9.BackColor = Color.Black;
            this.numericUpDown9.ForeColor = SystemColors.Control;
            manager.ApplyResources(this.numericUpDown9, "numericUpDown9");
            int[] numArray17 = new int[4];
            numArray17[0] = 0x989680;
            this.numericUpDown9.Maximum = new decimal(numArray17);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown10.BackColor = Color.Black;
            this.numericUpDown10.ForeColor = SystemColors.Control;
            manager.ApplyResources(this.numericUpDown10, "numericUpDown10");
            int[] numArray18 = new int[4];
            numArray18[0] = 0x989680;
            this.numericUpDown10.Maximum = new decimal(numArray18);
            this.numericUpDown10.Name = "numericUpDown10";
            manager.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = Color.WhiteSmoke;
            this.label7.Name = "label7";
            manager.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = Color.WhiteSmoke;
            this.label8.Name = "label8";
            manager.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = Color.WhiteSmoke;
            this.label9.Name = "label9";
            manager.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = Color.Black;
            this.label10.Name = "label10";
            manager.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDown8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDown9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDown10);
            this.groupBox1.ForeColor = Color.WhiteSmoke;
            manager.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            manager.ApplyResources(this.radioButton9, "radioButton9");
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new EventHandler(this.radioButton9_CheckedChanged);
            manager.ApplyResources(this.radioButton8, "radioButton8");
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new EventHandler(this.radioButton8_CheckedChanged);
            manager.ApplyResources(this.radioButton7, "radioButton7");
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new EventHandler(this.radioButton7_CheckedChanged);
            manager.ApplyResources(this.radioButton6, "radioButton6");
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new EventHandler(this.radioButton6_CheckedChanged);
            manager.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new EventHandler(this.radioButton5_CheckedChanged);
            manager.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new EventHandler(this.radioButton3_CheckedChanged);
            manager.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new EventHandler(this.radioButton2_CheckedChanged);
            manager.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged);
            manager.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = Color.WhiteSmoke;
            this.label11.Name = "label11";
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.ForeColor = Color.WhiteSmoke;
            manager.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            manager.ApplyResources(this.radioButton11, "radioButton11");
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.TabStop = true;
            this.radioButton11.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.radioButton10, "radioButton10");
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.TabStop = true;
            this.radioButton10.UseVisualStyleBackColor = true;
            this.groupBox3.Controls.Add(this.radiobuttonteaching);
            this.groupBox3.Controls.Add(this.radioButton15);
            this.groupBox3.Controls.Add(this.radioButton14);
            this.groupBox3.Controls.Add(this.radioButton12);
            this.groupBox3.Controls.Add(this.radioButton13);
            this.groupBox3.ForeColor = Color.WhiteSmoke;
            manager.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            manager.ApplyResources(this.radioButton12, "radioButton12");
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.TabStop = true;
            this.radioButton12.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.radioButton13, "radioButton13");
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.TabStop = true;
            this.radioButton13.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.radioButton14, "radioButton14");
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.TabStop = true;
            this.radioButton14.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.radioButton15, "radioButton15");
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.TabStop = true;
            this.radioButton15.UseVisualStyleBackColor = true;
            manager.ApplyResources(this.radiobuttonteaching, "radiobuttonteaching");
            this.radiobuttonteaching.Name = "radiobuttonteaching";
            this.radiobuttonteaching.TabStop = true;
            this.radiobuttonteaching.UseVisualStyleBackColor = true;
            manager.ApplyResources(this, "$this");
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DarkGray;
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.checkBox4);
            base.Controls.Add(this.checkBox3);
            base.Controls.Add(this.checkBox2);
            base.Controls.Add(this.checkBox1);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.numericUpDown5);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.numericUpDown4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.numericUpDown3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.numericUpDown2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.numericUpDown1);
            base.Controls.Add(this.label25);
            base.Controls.Add(this.numericUpDown7);
           
            this.ForeColor = Color.WhiteSmoke;
            base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "BaslerCameraProperty";
            base.Load += new EventHandler(this.BaslerCameraProperty_Load);
            this.numericUpDown4.EndInit();
            this.numericUpDown3.EndInit();
            this.numericUpDown2.EndInit();
            this.numericUpDown1.EndInit();
            this.numericUpDown7.EndInit();
            this.numericUpDown5.EndInit();
            this.numericUpDown6.EndInit();
            this.numericUpDown8.EndInit();
            this.numericUpDown9.EndInit();
            this.numericUpDown10.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
       

 

 

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.SetCaptureSizeData(0x1200, 0xcd8);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.SetCaptureSizeData(0xf00, 0xabc);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                this.SetCaptureSizeData(0xa1e, 0x796);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton5.Checked)
            {
                this.SetCaptureSizeData(0x640, 0x4b0);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton6.Checked)
            {
                this.SetCaptureSizeData(0x500, 0x400);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton7.Checked)
            {
                this.SetCaptureSizeData(0x400, 0x300);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton8.Checked)
            {
                this.SetCaptureSizeData(640, 480);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton9.Checked)
            {
                this.SetCaptureSizeData(0x50e, 0x3c4);
            }
        }

        private void SelectCapSize(int wm, int hm, int wc, int hc)
        {
            if ((((wm * hm) > 0xd59f80) && (wc == 0x1200)) && (hc == 0xcd8))
            {
                this.radioButton1.Checked = true;
            }
            else if ((((wm * hm) > 0x989680) && (wc == 0xf00)) && (hc == 0xabc))
            {
                this.radioButton2.Checked = true;
            }
            else if ((((wm * hm) > 0x4c4b40) && (wc == 0xa1e)) && (hc == 0x796))
            {
                this.radioButton3.Checked = true;
            }
            else if ((((wm * hm) > 0x1cfde0) && (wc == 0x640)) && (hc == 0x4b0))
            {
                this.radioButton5.Checked = true;
            }
            else if ((((wm * hm) > 0x13d620) && (wc == 0x500)) && (hc == 0x400))
            {
                this.radioButton6.Checked = true;
            }
            else if ((((wm * hm) > 0x12ebc0) && (wc == 0x50e)) && (hc == 0x3c4))
            {
                this.radioButton9.Checked = true;
            }
            else if ((((wm * hm) > 0xbe6e0) && (wc == 0x400)) && (hc == 0x300))
            {
                this.radioButton7.Checked = true;
            }
            else if ((((wm * hm) > 0x493e0) && (wc == 640)) && (hc == 480))
            {
                this.radioButton8.Checked = true;
            }
            else
            {
                this.numericUpDown6.Value = this.cameraSetting.capWidth;
                this.numericUpDown8.Value = this.cameraSetting.capHeight;
                this.numericUpDown9.Value = this.cameraSetting.capX;
                this.numericUpDown10.Value = this.cameraSetting.capY;
            }
        }

        private void SelectResize()
        {
            this.radiobuttonteaching.Enabled = true;
            this.radioButton12.Enabled = true;
            this.radioButton13.Enabled = true;
            this.radioButton14.Enabled = true;
            this.radioButton15.Enabled = true;
            if (this.cameraSetting.reSize == 0)
            {
                this.radioButton12.Checked = true;
            }
            else if (this.cameraSetting.reSize == 1)
            {
                this.radioButton13.Checked = true;
            }
            else if (this.cameraSetting.reSize == 2)
            {
                this.radioButton14.Checked = true;
            }
            else if (this.cameraSetting.reSize == 3)
            {
                this.radioButton15.Checked = true;
            }
            else
            {
                this.radiobuttonteaching.Checked = true;
            }
        }

        private void SetCaptureSize()
        {
            long num = this.cameraSetting.widthMax * this.cameraSetting.heightMax;
            int capWidth = this.cameraSetting.capWidth;
            int capHeight = this.cameraSetting.capHeight;
            this.radioButton1.Enabled = true;
            this.radioButton1.Checked = false;
            this.radioButton2.Enabled = true;
            this.radioButton2.Checked = false;
            this.radioButton3.Enabled = true;
            this.radioButton3.Checked = false;
            this.radioButton4.Enabled = true;
            this.radioButton4.Checked = false;
            this.radioButton5.Enabled = true;
            this.radioButton5.Checked = false;
            this.radioButton6.Enabled = true;
            this.radioButton6.Checked = false;
            this.radioButton7.Enabled = true;
            this.radioButton7.Checked = false;
            this.radioButton8.Enabled = true;
            this.radioButton8.Checked = false;
            this.radioButton9.Enabled = true;
            this.radioButton9.Checked = false;
            this.numericUpDown6.Value = this.cameraSetting.capWidth;
            this.numericUpDown8.Value = this.cameraSetting.capHeight;
            this.numericUpDown9.Value = this.cameraSetting.capX;
            this.numericUpDown10.Value = this.cameraSetting.capY;
            this.SelectCapSize(this.cameraSetting.widthMax, this.cameraSetting.heightMax, this.cameraSetting.capWidth, this.cameraSetting.capHeight);
            if (num <= 0xd59f80L)
            {
                if (num > 0x989680L)
                {
                    this.radioButton1.Enabled = false;
                }
                else if (num > 0x4c4b40L)
                {
                    this.radioButton1.Enabled = false;
                    this.radioButton2.Enabled = false;
                }
                else if (num > 0x1d24f0L)
                {
                    this.radioButton1.Enabled = false;
                    this.radioButton2.Enabled = false;
                    this.radioButton3.Enabled = false;
                }
                else if (num > 0x13d620L)
                {
                    this.radioButton1.Enabled = false;
                    this.radioButton2.Enabled = false;
                    this.radioButton3.Enabled = false;
                    this.radioButton5.Enabled = false;
                }
                else if (num > 0x12ebc0L)
                {
                    this.radioButton1.Enabled = false;
                    this.radioButton2.Enabled = false;
                    this.radioButton3.Enabled = false;
                    this.radioButton5.Enabled = false;
                    this.radioButton6.Enabled = false;
                }
                else if (num > 0x493e0L)
                {
                    this.radioButton1.Enabled = false;
                    this.radioButton2.Enabled = false;
                    this.radioButton3.Enabled = false;
                    this.radioButton5.Enabled = false;
                    this.radioButton6.Enabled = false;
                    this.radioButton9.Enabled = false;
                }
            }
        }

        private void SetCaptureSizeData(int w, int h)
        {
            this.numericUpDown6.Value = w;
            this.numericUpDown8.Value = h;
            if ((((this.cameraSetting.widthMax - w) / 2) % 2) == 1)
            {
                this.numericUpDown9.Value = ((this.cameraSetting.widthMax - w) / 2) - 1;
            }
            else
            {
                this.numericUpDown9.Value = (this.cameraSetting.widthMax - w) / 2;
            }
            if ((((this.cameraSetting.heightMax - h) / 2) % 2) == 1)
            {
                this.numericUpDown10.Value = ((this.cameraSetting.heightMax - h) / 2) - 1;
            }
            else
            {
                this.numericUpDown10.Value = (this.cameraSetting.heightMax - h) / 2;
            }
        }

        public Control button2 { get; set; }
    }

 

}
