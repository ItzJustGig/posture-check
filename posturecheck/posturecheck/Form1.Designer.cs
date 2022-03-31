namespace posturecheck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.postureTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.postureCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.breakTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.breakCheckBox = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.tabNextCheck = new System.Windows.Forms.TabPage();
            this.lblBreakTime = new System.Windows.Forms.Label();
            this.lblPostureTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSkin = new System.Windows.Forms.Button();
            this.comboSkins = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postureTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabNextCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.postureTimeUpDown);
            this.groupBox1.Controls.Add(this.postureCheckBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // postureTimeUpDown
            // 
            resources.ApplyResources(this.postureTimeUpDown, "postureTimeUpDown");
            this.postureTimeUpDown.DecimalPlaces = 1;
            this.postureTimeUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.postureTimeUpDown.Name = "postureTimeUpDown";
            this.postureTimeUpDown.Tag = "";
            this.toolTip.SetToolTip(this.postureTimeUpDown, resources.GetString("postureTimeUpDown.ToolTip"));
            // 
            // postureCheckBox
            // 
            resources.ApplyResources(this.postureCheckBox, "postureCheckBox");
            this.postureCheckBox.Checked = true;
            this.postureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.postureCheckBox.Name = "postureCheckBox";
            this.postureCheckBox.UseVisualStyleBackColor = true;
            this.postureCheckBox.CheckedChanged += new System.EventHandler(this.postureCheckBox_CheckedChanged);
            // 
            // breakTimeUpDown
            // 
            resources.ApplyResources(this.breakTimeUpDown, "breakTimeUpDown");
            this.breakTimeUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.breakTimeUpDown.DecimalPlaces = 1;
            this.breakTimeUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.breakTimeUpDown.Name = "breakTimeUpDown";
            this.breakTimeUpDown.Tag = "";
            this.toolTip.SetToolTip(this.breakTimeUpDown, resources.GetString("breakTimeUpDown.ToolTip"));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.breakTimeUpDown);
            this.groupBox2.Controls.Add(this.breakCheckBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // breakCheckBox
            // 
            resources.ApplyResources(this.breakCheckBox, "breakCheckBox");
            this.breakCheckBox.Checked = true;
            this.breakCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.breakCheckBox.Name = "breakCheckBox";
            this.breakCheckBox.UseVisualStyleBackColor = true;
            this.breakCheckBox.CheckedChanged += new System.EventHandler(this.breakCheckBox_CheckedChanged);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabSetup);
            this.tabController.Controls.Add(this.tabNextCheck);
            resources.ApplyResources(this.tabController, "tabController");
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.groupBox1);
            this.tabSetup.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabSetup, "tabSetup");
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // tabNextCheck
            // 
            this.tabNextCheck.Controls.Add(this.lblBreakTime);
            this.tabNextCheck.Controls.Add(this.lblPostureTime);
            this.tabNextCheck.Controls.Add(this.label2);
            this.tabNextCheck.Controls.Add(this.label1);
            resources.ApplyResources(this.tabNextCheck, "tabNextCheck");
            this.tabNextCheck.Name = "tabNextCheck";
            this.tabNextCheck.UseVisualStyleBackColor = true;
            // 
            // lblBreakTime
            // 
            resources.ApplyResources(this.lblBreakTime, "lblBreakTime");
            this.lblBreakTime.Name = "lblBreakTime";
            // 
            // lblPostureTime
            // 
            resources.ApplyResources(this.lblPostureTime, "lblPostureTime");
            this.lblPostureTime.Name = "lblPostureTime";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSkin
            // 
            resources.ApplyResources(this.btnSkin, "btnSkin");
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.UseVisualStyleBackColor = true;
            this.btnSkin.Click += new System.EventHandler(this.btnSkin_Click);
            // 
            // comboSkins
            // 
            this.comboSkins.FormattingEnabled = true;
            resources.ApplyResources(this.comboSkins, "comboSkins");
            this.comboSkins.Name = "comboSkins";
            this.comboSkins.SelectedIndexChanged += new System.EventHandler(this.comboSkins_SelectedIndexChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboSkins);
            this.Controls.Add(this.btnSkin);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postureTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabNextCheck.ResumeLayout(false);
            this.tabNextCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox postureCheckBox;
        private System.Windows.Forms.NumericUpDown postureTimeUpDown;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown breakTimeUpDown;
        private System.Windows.Forms.CheckBox breakCheckBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabNextCheck;
        private System.Windows.Forms.Label lblBreakTime;
        private System.Windows.Forms.Label lblPostureTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSkin;
        private System.Windows.Forms.ComboBox comboSkins;
    }
}

