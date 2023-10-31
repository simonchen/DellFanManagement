
namespace DellFanManagement.App
{
    partial class DellFanManagementGuiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DellFanManagementGuiForm));
            this.fansGroupBox = new System.Windows.Forms.GroupBox();
            this.fan2RpmLabel = new System.Windows.Forms.Label();
            this.fan1RpmLabel = new System.Windows.Forms.Label();
            this.thermalSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.thermalSettingRadioButtonPerformance = new System.Windows.Forms.RadioButton();
            this.thermalSettingRadioButtonQuiet = new System.Windows.Forms.RadioButton();
            this.thermalSettingRadioButtonCool = new System.Windows.Forms.RadioButton();
            this.thermalSettingRadioButtonOptimized = new System.Windows.Forms.RadioButton();
            this.temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.temperatureLabel18 = new System.Windows.Forms.Label();
            this.temperatureLabel17 = new System.Windows.Forms.Label();
            this.temperatureLabel16 = new System.Windows.Forms.Label();
            this.temperatureLabel15 = new System.Windows.Forms.Label();
            this.temperatureLabel14 = new System.Windows.Forms.Label();
            this.temperatureLabel13 = new System.Windows.Forms.Label();
            this.temperatureLabel12 = new System.Windows.Forms.Label();
            this.temperatureLabel11 = new System.Windows.Forms.Label();
            this.temperatureLabel10 = new System.Windows.Forms.Label();
            this.temperatureLabel9 = new System.Windows.Forms.Label();
            this.temperatureLabel8 = new System.Windows.Forms.Label();
            this.temperatureLabel7 = new System.Windows.Forms.Label();
            this.temperatureLabel6 = new System.Windows.Forms.Label();
            this.temperatureLabel5 = new System.Windows.Forms.Label();
            this.temperatureLabel4 = new System.Windows.Forms.Label();
            this.temperatureLabel3 = new System.Windows.Forms.Label();
            this.temperatureLabel2 = new System.Windows.Forms.Label();
            this.temperatureLabel1 = new System.Windows.Forms.Label();
            this.operationModeGroupBox = new System.Windows.Forms.GroupBox();
            this.operationModeRadioButtonConsistency = new System.Windows.Forms.RadioButton();
            this.operationModeRadioButtonManual = new System.Windows.Forms.RadioButton();
            this.operationModeRadioButtonAutomatic = new System.Windows.Forms.RadioButton();
            this.manualGroupBox = new System.Windows.Forms.GroupBox();
            this.manualFan2GroupBox = new System.Windows.Forms.GroupBox();
            this.manualFan2RadioButtonHigh = new System.Windows.Forms.RadioButton();
            this.manualFan2RadioButtonMedium = new System.Windows.Forms.RadioButton();
            this.manualFan2RadioButtonOff = new System.Windows.Forms.RadioButton();
            this.manualFan1GroupBox = new System.Windows.Forms.GroupBox();
            this.manualFan1RadioButtonHigh = new System.Windows.Forms.RadioButton();
            this.manualFan1RadioButtonMedium = new System.Windows.Forms.RadioButton();
            this.manualFan1RadioButtonOff = new System.Windows.Forms.RadioButton();
            this.consistencyModeGroupBox = new System.Windows.Forms.GroupBox();
            this.consistencyModeApplyChangesButton = new System.Windows.Forms.Button();
            this.consistencyModeRpmThresholdTextBox = new System.Windows.Forms.TextBox();
            this.consistencyModeRpmThresholdLabel = new System.Windows.Forms.Label();
            this.consistencyModeUpperTemperatureThresholdTextBox = new System.Windows.Forms.TextBox();
            this.consistencyModeUpperTemperatureThresholdLabel = new System.Windows.Forms.Label();
            this.consistencyModeLowerTemperatureThresholdTextBox = new System.Windows.Forms.TextBox();
            this.consistencyModeLowerTemperatureThresholdLabel = new System.Windows.Forms.Label();
            this.alertsCheckBox = new System.Windows.Forms.CheckBox();
            this.ecFanControlRadioButtonOn = new System.Windows.Forms.RadioButton();
            this.ecFanControlRadioButtonOff = new System.Windows.Forms.RadioButton();
            this.ecFanControlGroupBox = new System.Windows.Forms.GroupBox();
            this.restartBackgroundThreadButton = new System.Windows.Forms.Button();
            this.aboutGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.aboutProductLabel = new System.Windows.Forms.Label();
            this.audioKeepAliveGroupBox = new System.Windows.Forms.GroupBox();
            this.audioKeepAliveComboBox = new System.Windows.Forms.ComboBox();
            this.audioKeepAliveCheckbox = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.consistencyModeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconCheckBox = new System.Windows.Forms.CheckBox();
            this.animatedCheckBox = new System.Windows.Forms.CheckBox();
            this.fansGroupBox.SuspendLayout();
            this.thermalSettingGroupBox.SuspendLayout();
            this.temperatureGroupBox.SuspendLayout();
            this.operationModeGroupBox.SuspendLayout();
            this.manualGroupBox.SuspendLayout();
            this.manualFan2GroupBox.SuspendLayout();
            this.manualFan1GroupBox.SuspendLayout();
            this.consistencyModeGroupBox.SuspendLayout();
            this.ecFanControlGroupBox.SuspendLayout();
            this.aboutGroupBox.SuspendLayout();
            this.audioKeepAliveGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fansGroupBox
            // 
            this.fansGroupBox.Controls.Add(this.fan2RpmLabel);
            this.fansGroupBox.Controls.Add(this.fan1RpmLabel);
            this.fansGroupBox.Location = new System.Drawing.Point(18, 18);
            this.fansGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.fansGroupBox.Name = "fansGroupBox";
            this.fansGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.fansGroupBox.Size = new System.Drawing.Size(334, 98);
            this.fansGroupBox.TabIndex = 1;
            this.fansGroupBox.TabStop = false;
            this.fansGroupBox.Text = "风扇:";
            // 
            // fan2RpmLabel
            // 
            this.fan2RpmLabel.AutoSize = true;
            this.fan2RpmLabel.Location = new System.Drawing.Point(9, 57);
            this.fan2RpmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fan2RpmLabel.Name = "fan2RpmLabel";
            this.fan2RpmLabel.Size = new System.Drawing.Size(252, 24);
            this.fan2RpmLabel.TabIndex = 2;
            this.fan2RpmLabel.Text = "风扇 2 RPM: (Not measured)";
            // 
            // fan1RpmLabel
            // 
            this.fan1RpmLabel.AutoSize = true;
            this.fan1RpmLabel.Location = new System.Drawing.Point(9, 28);
            this.fan1RpmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fan1RpmLabel.Name = "fan1RpmLabel";
            this.fan1RpmLabel.Size = new System.Drawing.Size(252, 24);
            this.fan1RpmLabel.TabIndex = 1;
            this.fan1RpmLabel.Text = "风扇 1 RPM: (Not measured)";
            // 
            // thermalSettingGroupBox
            // 
            this.thermalSettingGroupBox.Controls.Add(this.thermalSettingRadioButtonPerformance);
            this.thermalSettingGroupBox.Controls.Add(this.thermalSettingRadioButtonQuiet);
            this.thermalSettingGroupBox.Controls.Add(this.thermalSettingRadioButtonCool);
            this.thermalSettingGroupBox.Controls.Add(this.thermalSettingRadioButtonOptimized);
            this.thermalSettingGroupBox.Location = new System.Drawing.Point(525, 176);
            this.thermalSettingGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.thermalSettingGroupBox.Name = "thermalSettingGroupBox";
            this.thermalSettingGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.thermalSettingGroupBox.Size = new System.Drawing.Size(196, 186);
            this.thermalSettingGroupBox.TabIndex = 6;
            this.thermalSettingGroupBox.TabStop = false;
            this.thermalSettingGroupBox.Text = "热度调节:";
            // 
            // thermalSettingRadioButtonPerformance
            // 
            this.thermalSettingRadioButtonPerformance.Location = new System.Drawing.Point(9, 146);
            this.thermalSettingRadioButtonPerformance.Margin = new System.Windows.Forms.Padding(4);
            this.thermalSettingRadioButtonPerformance.Name = "thermalSettingRadioButtonPerformance";
            this.thermalSettingRadioButtonPerformance.Size = new System.Drawing.Size(127, 28);
            this.thermalSettingRadioButtonPerformance.TabIndex = 3;
            this.thermalSettingRadioButtonPerformance.TabStop = true;
            this.thermalSettingRadioButtonPerformance.Text = "最佳性能";
            this.thermalSettingRadioButtonPerformance.UseVisualStyleBackColor = true;
            // 
            // thermalSettingRadioButtonQuiet
            // 
            this.thermalSettingRadioButtonQuiet.Location = new System.Drawing.Point(9, 108);
            this.thermalSettingRadioButtonQuiet.Margin = new System.Windows.Forms.Padding(4);
            this.thermalSettingRadioButtonQuiet.Name = "thermalSettingRadioButtonQuiet";
            this.thermalSettingRadioButtonQuiet.Size = new System.Drawing.Size(179, 28);
            this.thermalSettingRadioButtonQuiet.TabIndex = 2;
            this.thermalSettingRadioButtonQuiet.TabStop = true;
            this.thermalSettingRadioButtonQuiet.Text = "安静 (无cpu睿频)";
            this.thermalSettingRadioButtonQuiet.UseVisualStyleBackColor = true;
            // 
            // thermalSettingRadioButtonCool
            // 
            this.thermalSettingRadioButtonCool.Location = new System.Drawing.Point(9, 70);
            this.thermalSettingRadioButtonCool.Margin = new System.Windows.Forms.Padding(4);
            this.thermalSettingRadioButtonCool.Name = "thermalSettingRadioButtonCool";
            this.thermalSettingRadioButtonCool.Size = new System.Drawing.Size(179, 28);
            this.thermalSettingRadioButtonCool.TabIndex = 1;
            this.thermalSettingRadioButtonCool.TabStop = true;
            this.thermalSettingRadioButtonCool.Text = "清凉 (风噪大)";
            this.thermalSettingRadioButtonCool.UseVisualStyleBackColor = true;
            // 
            // thermalSettingRadioButtonOptimized
            // 
            this.thermalSettingRadioButtonOptimized.Location = new System.Drawing.Point(9, 33);
            this.thermalSettingRadioButtonOptimized.Margin = new System.Windows.Forms.Padding(4);
            this.thermalSettingRadioButtonOptimized.Name = "thermalSettingRadioButtonOptimized";
            this.thermalSettingRadioButtonOptimized.Size = new System.Drawing.Size(127, 28);
            this.thermalSettingRadioButtonOptimized.TabIndex = 0;
            this.thermalSettingRadioButtonOptimized.TabStop = true;
            this.thermalSettingRadioButtonOptimized.Text = "平衡优化";
            this.thermalSettingRadioButtonOptimized.UseVisualStyleBackColor = true;
            // 
            // temperatureGroupBox
            // 
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel18);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel17);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel16);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel15);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel14);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel13);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel12);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel11);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel10);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel9);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel8);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel7);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel6);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel5);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel4);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel3);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel2);
            this.temperatureGroupBox.Controls.Add(this.temperatureLabel1);
            this.temperatureGroupBox.Location = new System.Drawing.Point(18, 124);
            this.temperatureGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.temperatureGroupBox.Name = "temperatureGroupBox";
            this.temperatureGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.temperatureGroupBox.Size = new System.Drawing.Size(498, 298);
            this.temperatureGroupBox.TabIndex = 4;
            this.temperatureGroupBox.TabStop = false;
            this.temperatureGroupBox.Text = "温度:";
            // 
            // temperatureLabel18
            // 
            this.temperatureLabel18.AutoSize = true;
            this.temperatureLabel18.Location = new System.Drawing.Point(250, 262);
            this.temperatureLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel18.Name = "temperatureLabel18";
            this.temperatureLabel18.Size = new System.Drawing.Size(275, 24);
            this.temperatureLabel18.TabIndex = 3;
            this.temperatureLabel18.Text = "Quadro RTX 5000: 50 (50-100)";
            // 
            // temperatureLabel17
            // 
            this.temperatureLabel17.AutoSize = true;
            this.temperatureLabel17.Location = new System.Drawing.Point(250, 234);
            this.temperatureLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel17.Name = "temperatureLabel17";
            this.temperatureLabel17.Size = new System.Drawing.Size(234, 24);
            this.temperatureLabel17.TabIndex = 3;
            this.temperatureLabel17.Text = "CPU Package: 50 (50-100)";
            // 
            // temperatureLabel16
            // 
            this.temperatureLabel16.AutoSize = true;
            this.temperatureLabel16.Location = new System.Drawing.Point(250, 206);
            this.temperatureLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel16.Name = "temperatureLabel16";
            this.temperatureLabel16.Size = new System.Drawing.Size(240, 24);
            this.temperatureLabel16.TabIndex = 15;
            this.temperatureLabel16.Text = "CPU Core #16: 50 (50-100)";
            // 
            // temperatureLabel15
            // 
            this.temperatureLabel15.AutoSize = true;
            this.temperatureLabel15.Location = new System.Drawing.Point(250, 177);
            this.temperatureLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel15.Name = "temperatureLabel15";
            this.temperatureLabel15.Size = new System.Drawing.Size(240, 24);
            this.temperatureLabel15.TabIndex = 14;
            this.temperatureLabel15.Text = "CPU Core #15: 50 (50-100)";
            // 
            // temperatureLabel14
            // 
            this.temperatureLabel14.AutoSize = true;
            this.temperatureLabel14.Location = new System.Drawing.Point(250, 148);
            this.temperatureLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel14.Name = "temperatureLabel14";
            this.temperatureLabel14.Size = new System.Drawing.Size(240, 24);
            this.temperatureLabel14.TabIndex = 13;
            this.temperatureLabel14.Text = "CPU Core #14: 50 (50-100)";
            // 
            // temperatureLabel13
            // 
            this.temperatureLabel13.AutoSize = true;
            this.temperatureLabel13.Location = new System.Drawing.Point(250, 120);
            this.temperatureLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel13.Name = "temperatureLabel13";
            this.temperatureLabel13.Size = new System.Drawing.Size(240, 24);
            this.temperatureLabel13.TabIndex = 12;
            this.temperatureLabel13.Text = "CPU Core #13: 50 (50-100)";
            // 
            // temperatureLabel12
            // 
            this.temperatureLabel12.AutoSize = true;
            this.temperatureLabel12.Location = new System.Drawing.Point(250, 92);
            this.temperatureLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel12.Name = "temperatureLabel12";
            this.temperatureLabel12.Size = new System.Drawing.Size(240, 24);
            this.temperatureLabel12.TabIndex = 11;
            this.temperatureLabel12.Text = "CPU Core #12: 50 (50-100)";
            // 
            // temperatureLabel11
            // 
            this.temperatureLabel11.AutoSize = true;
            this.temperatureLabel11.Location = new System.Drawing.Point(250, 63);
            this.temperatureLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel11.Name = "temperatureLabel11";
            this.temperatureLabel11.Size = new System.Drawing.Size(240, 24);
            this.temperatureLabel11.TabIndex = 10;
            this.temperatureLabel11.Text = "CPU Core #11: 50 (50-100)";
            // 
            // temperatureLabel10
            // 
            this.temperatureLabel10.AutoSize = true;
            this.temperatureLabel10.Location = new System.Drawing.Point(250, 34);
            this.temperatureLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel10.Name = "temperatureLabel10";
            this.temperatureLabel10.Size = new System.Drawing.Size(240, 24);
            this.temperatureLabel10.TabIndex = 9;
            this.temperatureLabel10.Text = "CPU Core #10: 50 (50-100)";
            // 
            // temperatureLabel9
            // 
            this.temperatureLabel9.AutoSize = true;
            this.temperatureLabel9.Location = new System.Drawing.Point(9, 262);
            this.temperatureLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel9.Name = "temperatureLabel9";
            this.temperatureLabel9.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel9.TabIndex = 8;
            this.temperatureLabel9.Text = "CPU Core #9: 50 (50-100)";
            // 
            // temperatureLabel8
            // 
            this.temperatureLabel8.AutoSize = true;
            this.temperatureLabel8.Location = new System.Drawing.Point(9, 234);
            this.temperatureLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel8.Name = "temperatureLabel8";
            this.temperatureLabel8.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel8.TabIndex = 7;
            this.temperatureLabel8.Text = "CPU Core #8: 50 (50-100)";
            // 
            // temperatureLabel7
            // 
            this.temperatureLabel7.AutoSize = true;
            this.temperatureLabel7.Location = new System.Drawing.Point(9, 206);
            this.temperatureLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel7.Name = "temperatureLabel7";
            this.temperatureLabel7.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel7.TabIndex = 6;
            this.temperatureLabel7.Text = "CPU Core #7: 50 (50-100)";
            // 
            // temperatureLabel6
            // 
            this.temperatureLabel6.AutoSize = true;
            this.temperatureLabel6.Location = new System.Drawing.Point(9, 177);
            this.temperatureLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel6.Name = "temperatureLabel6";
            this.temperatureLabel6.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel6.TabIndex = 5;
            this.temperatureLabel6.Text = "CPU Core #6: 50 (50-100)";
            // 
            // temperatureLabel5
            // 
            this.temperatureLabel5.AutoSize = true;
            this.temperatureLabel5.Location = new System.Drawing.Point(9, 148);
            this.temperatureLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel5.Name = "temperatureLabel5";
            this.temperatureLabel5.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel5.TabIndex = 4;
            this.temperatureLabel5.Text = "CPU Core #5: 50 (50-100)";
            // 
            // temperatureLabel4
            // 
            this.temperatureLabel4.AutoSize = true;
            this.temperatureLabel4.Location = new System.Drawing.Point(9, 120);
            this.temperatureLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel4.Name = "temperatureLabel4";
            this.temperatureLabel4.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel4.TabIndex = 3;
            this.temperatureLabel4.Text = "CPU Core #4: 50 (50-100)";
            // 
            // temperatureLabel3
            // 
            this.temperatureLabel3.AutoSize = true;
            this.temperatureLabel3.Location = new System.Drawing.Point(9, 92);
            this.temperatureLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel3.Name = "temperatureLabel3";
            this.temperatureLabel3.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel3.TabIndex = 2;
            this.temperatureLabel3.Text = "CPU Core #3: 50 (50-100)";
            // 
            // temperatureLabel2
            // 
            this.temperatureLabel2.AutoSize = true;
            this.temperatureLabel2.Location = new System.Drawing.Point(9, 63);
            this.temperatureLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel2.Name = "temperatureLabel2";
            this.temperatureLabel2.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel2.TabIndex = 1;
            this.temperatureLabel2.Text = "CPU Core #2: 50 (50-100)";
            // 
            // temperatureLabel1
            // 
            this.temperatureLabel1.AutoSize = true;
            this.temperatureLabel1.Location = new System.Drawing.Point(9, 34);
            this.temperatureLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel1.Name = "temperatureLabel1";
            this.temperatureLabel1.Size = new System.Drawing.Size(229, 24);
            this.temperatureLabel1.TabIndex = 0;
            this.temperatureLabel1.Text = "CPU Core #1: 50 (50-100)";
            // 
            // operationModeGroupBox
            // 
            this.operationModeGroupBox.Controls.Add(this.operationModeRadioButtonConsistency);
            this.operationModeGroupBox.Controls.Add(this.operationModeRadioButtonManual);
            this.operationModeGroupBox.Controls.Add(this.operationModeRadioButtonAutomatic);
            this.operationModeGroupBox.Location = new System.Drawing.Point(525, 18);
            this.operationModeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.operationModeGroupBox.Name = "operationModeGroupBox";
            this.operationModeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.operationModeGroupBox.Size = new System.Drawing.Size(196, 148);
            this.operationModeGroupBox.TabIndex = 5;
            this.operationModeGroupBox.TabStop = false;
            this.operationModeGroupBox.Text = "模式:";
            // 
            // operationModeRadioButtonConsistency
            // 
            this.operationModeRadioButtonConsistency.Location = new System.Drawing.Point(9, 106);
            this.operationModeRadioButtonConsistency.Margin = new System.Windows.Forms.Padding(4);
            this.operationModeRadioButtonConsistency.Name = "operationModeRadioButtonConsistency";
            this.operationModeRadioButtonConsistency.Size = new System.Drawing.Size(114, 32);
            this.operationModeRadioButtonConsistency.TabIndex = 2;
            this.operationModeRadioButtonConsistency.TabStop = true;
            this.operationModeRadioButtonConsistency.Text = "平滑";
            this.operationModeRadioButtonConsistency.UseVisualStyleBackColor = true;
            // 
            // operationModeRadioButtonManual
            // 
            this.operationModeRadioButtonManual.Location = new System.Drawing.Point(9, 70);
            this.operationModeRadioButtonManual.Margin = new System.Windows.Forms.Padding(4);
            this.operationModeRadioButtonManual.Name = "operationModeRadioButtonManual";
            this.operationModeRadioButtonManual.Size = new System.Drawing.Size(114, 28);
            this.operationModeRadioButtonManual.TabIndex = 1;
            this.operationModeRadioButtonManual.TabStop = true;
            this.operationModeRadioButtonManual.Text = "手动";
            this.operationModeRadioButtonManual.UseVisualStyleBackColor = true;
            // 
            // operationModeRadioButtonAutomatic
            // 
            this.operationModeRadioButtonAutomatic.Location = new System.Drawing.Point(9, 33);
            this.operationModeRadioButtonAutomatic.Margin = new System.Windows.Forms.Padding(4);
            this.operationModeRadioButtonAutomatic.Name = "operationModeRadioButtonAutomatic";
            this.operationModeRadioButtonAutomatic.Size = new System.Drawing.Size(114, 29);
            this.operationModeRadioButtonAutomatic.TabIndex = 0;
            this.operationModeRadioButtonAutomatic.TabStop = true;
            this.operationModeRadioButtonAutomatic.Text = "自动";
            this.operationModeRadioButtonAutomatic.UseVisualStyleBackColor = true;
            // 
            // manualGroupBox
            // 
            this.manualGroupBox.Controls.Add(this.manualFan2GroupBox);
            this.manualGroupBox.Controls.Add(this.manualFan1GroupBox);
            this.manualGroupBox.Location = new System.Drawing.Point(729, 18);
            this.manualGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.manualGroupBox.Name = "manualGroupBox";
            this.manualGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.manualGroupBox.Size = new System.Drawing.Size(291, 189);
            this.manualGroupBox.TabIndex = 9;
            this.manualGroupBox.TabStop = false;
            this.manualGroupBox.Text = "手动控制:";
            // 
            // manualFan2GroupBox
            // 
            this.manualFan2GroupBox.Controls.Add(this.manualFan2RadioButtonHigh);
            this.manualFan2GroupBox.Controls.Add(this.manualFan2RadioButtonMedium);
            this.manualFan2GroupBox.Controls.Add(this.manualFan2RadioButtonOff);
            this.manualFan2GroupBox.Location = new System.Drawing.Point(150, 32);
            this.manualFan2GroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.manualFan2GroupBox.Name = "manualFan2GroupBox";
            this.manualFan2GroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.manualFan2GroupBox.Size = new System.Drawing.Size(132, 148);
            this.manualFan2GroupBox.TabIndex = 1;
            this.manualFan2GroupBox.TabStop = false;
            this.manualFan2GroupBox.Text = "风扇 2:";
            // 
            // manualFan2RadioButtonHigh
            // 
            this.manualFan2RadioButtonHigh.Location = new System.Drawing.Point(9, 108);
            this.manualFan2RadioButtonHigh.Margin = new System.Windows.Forms.Padding(4);
            this.manualFan2RadioButtonHigh.Name = "manualFan2RadioButtonHigh";
            this.manualFan2RadioButtonHigh.Size = new System.Drawing.Size(90, 28);
            this.manualFan2RadioButtonHigh.TabIndex = 5;
            this.manualFan2RadioButtonHigh.TabStop = true;
            this.manualFan2RadioButtonHigh.Text = "高速";
            this.manualFan2RadioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // manualFan2RadioButtonMedium
            // 
            this.manualFan2RadioButtonMedium.Location = new System.Drawing.Point(9, 70);
            this.manualFan2RadioButtonMedium.Margin = new System.Windows.Forms.Padding(4);
            this.manualFan2RadioButtonMedium.Name = "manualFan2RadioButtonMedium";
            this.manualFan2RadioButtonMedium.Size = new System.Drawing.Size(90, 28);
            this.manualFan2RadioButtonMedium.TabIndex = 5;
            this.manualFan2RadioButtonMedium.TabStop = true;
            this.manualFan2RadioButtonMedium.Text = "中速";
            this.manualFan2RadioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // manualFan2RadioButtonOff
            // 
            this.manualFan2RadioButtonOff.Location = new System.Drawing.Point(9, 33);
            this.manualFan2RadioButtonOff.Margin = new System.Windows.Forms.Padding(4);
            this.manualFan2RadioButtonOff.Name = "manualFan2RadioButtonOff";
            this.manualFan2RadioButtonOff.Size = new System.Drawing.Size(71, 28);
            this.manualFan2RadioButtonOff.TabIndex = 5;
            this.manualFan2RadioButtonOff.TabStop = true;
            this.manualFan2RadioButtonOff.Text = "关";
            this.manualFan2RadioButtonOff.UseVisualStyleBackColor = true;
            // 
            // manualFan1GroupBox
            // 
            this.manualFan1GroupBox.Controls.Add(this.manualFan1RadioButtonHigh);
            this.manualFan1GroupBox.Controls.Add(this.manualFan1RadioButtonMedium);
            this.manualFan1GroupBox.Controls.Add(this.manualFan1RadioButtonOff);
            this.manualFan1GroupBox.Location = new System.Drawing.Point(9, 32);
            this.manualFan1GroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.manualFan1GroupBox.Name = "manualFan1GroupBox";
            this.manualFan1GroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.manualFan1GroupBox.Size = new System.Drawing.Size(132, 148);
            this.manualFan1GroupBox.TabIndex = 0;
            this.manualFan1GroupBox.TabStop = false;
            this.manualFan1GroupBox.Text = "风扇 1:";
            // 
            // manualFan1RadioButtonHigh
            // 
            this.manualFan1RadioButtonHigh.Location = new System.Drawing.Point(9, 108);
            this.manualFan1RadioButtonHigh.Margin = new System.Windows.Forms.Padding(4);
            this.manualFan1RadioButtonHigh.Name = "manualFan1RadioButtonHigh";
            this.manualFan1RadioButtonHigh.Size = new System.Drawing.Size(90, 28);
            this.manualFan1RadioButtonHigh.TabIndex = 2;
            this.manualFan1RadioButtonHigh.TabStop = true;
            this.manualFan1RadioButtonHigh.Text = "高速";
            this.manualFan1RadioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // manualFan1RadioButtonMedium
            // 
            this.manualFan1RadioButtonMedium.Location = new System.Drawing.Point(9, 70);
            this.manualFan1RadioButtonMedium.Margin = new System.Windows.Forms.Padding(4);
            this.manualFan1RadioButtonMedium.Name = "manualFan1RadioButtonMedium";
            this.manualFan1RadioButtonMedium.Size = new System.Drawing.Size(90, 28);
            this.manualFan1RadioButtonMedium.TabIndex = 1;
            this.manualFan1RadioButtonMedium.TabStop = true;
            this.manualFan1RadioButtonMedium.Text = "中速";
            this.manualFan1RadioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // manualFan1RadioButtonOff
            // 
            this.manualFan1RadioButtonOff.Location = new System.Drawing.Point(9, 33);
            this.manualFan1RadioButtonOff.Margin = new System.Windows.Forms.Padding(4);
            this.manualFan1RadioButtonOff.Name = "manualFan1RadioButtonOff";
            this.manualFan1RadioButtonOff.Size = new System.Drawing.Size(71, 28);
            this.manualFan1RadioButtonOff.TabIndex = 0;
            this.manualFan1RadioButtonOff.TabStop = true;
            this.manualFan1RadioButtonOff.Text = "关";
            this.manualFan1RadioButtonOff.UseVisualStyleBackColor = true;
            // 
            // consistencyModeGroupBox
            // 
            this.consistencyModeGroupBox.Controls.Add(this.consistencyModeApplyChangesButton);
            this.consistencyModeGroupBox.Controls.Add(this.consistencyModeRpmThresholdTextBox);
            this.consistencyModeGroupBox.Controls.Add(this.consistencyModeRpmThresholdLabel);
            this.consistencyModeGroupBox.Controls.Add(this.consistencyModeUpperTemperatureThresholdTextBox);
            this.consistencyModeGroupBox.Controls.Add(this.consistencyModeUpperTemperatureThresholdLabel);
            this.consistencyModeGroupBox.Controls.Add(this.consistencyModeLowerTemperatureThresholdTextBox);
            this.consistencyModeGroupBox.Controls.Add(this.consistencyModeLowerTemperatureThresholdLabel);
            this.consistencyModeGroupBox.Location = new System.Drawing.Point(729, 216);
            this.consistencyModeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.consistencyModeGroupBox.Name = "consistencyModeGroupBox";
            this.consistencyModeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.consistencyModeGroupBox.Size = new System.Drawing.Size(291, 207);
            this.consistencyModeGroupBox.TabIndex = 10;
            this.consistencyModeGroupBox.TabStop = false;
            this.consistencyModeGroupBox.Text = "平滑模式选项";
            // 
            // consistencyModeApplyChangesButton
            // 
            this.consistencyModeApplyChangesButton.Location = new System.Drawing.Point(8, 160);
            this.consistencyModeApplyChangesButton.Margin = new System.Windows.Forms.Padding(4);
            this.consistencyModeApplyChangesButton.Name = "consistencyModeApplyChangesButton";
            this.consistencyModeApplyChangesButton.Size = new System.Drawing.Size(276, 38);
            this.consistencyModeApplyChangesButton.TabIndex = 14;
            this.consistencyModeApplyChangesButton.Text = "适应更改 (&A)";
            this.consistencyModeApplyChangesButton.UseVisualStyleBackColor = true;
            // 
            // consistencyModeRpmThresholdTextBox
            // 
            this.consistencyModeRpmThresholdTextBox.Location = new System.Drawing.Point(212, 116);
            this.consistencyModeRpmThresholdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.consistencyModeRpmThresholdTextBox.MaxLength = 4;
            this.consistencyModeRpmThresholdTextBox.Name = "consistencyModeRpmThresholdTextBox";
            this.consistencyModeRpmThresholdTextBox.Size = new System.Drawing.Size(68, 30);
            this.consistencyModeRpmThresholdTextBox.TabIndex = 5;
            this.consistencyModeRpmThresholdTextBox.Text = "2400";
            // 
            // consistencyModeRpmThresholdLabel
            // 
            this.consistencyModeRpmThresholdLabel.Location = new System.Drawing.Point(10, 122);
            this.consistencyModeRpmThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.consistencyModeRpmThresholdLabel.Name = "consistencyModeRpmThresholdLabel";
            this.consistencyModeRpmThresholdLabel.Size = new System.Drawing.Size(142, 24);
            this.consistencyModeRpmThresholdLabel.TabIndex = 4;
            this.consistencyModeRpmThresholdLabel.Text = "RPM 限值:";
            // 
            // consistencyModeUpperTemperatureThresholdTextBox
            // 
            this.consistencyModeUpperTemperatureThresholdTextBox.Location = new System.Drawing.Point(238, 74);
            this.consistencyModeUpperTemperatureThresholdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.consistencyModeUpperTemperatureThresholdTextBox.MaxLength = 2;
            this.consistencyModeUpperTemperatureThresholdTextBox.Name = "consistencyModeUpperTemperatureThresholdTextBox";
            this.consistencyModeUpperTemperatureThresholdTextBox.Size = new System.Drawing.Size(42, 30);
            this.consistencyModeUpperTemperatureThresholdTextBox.TabIndex = 3;
            this.consistencyModeUpperTemperatureThresholdTextBox.Text = "85";
            // 
            // consistencyModeUpperTemperatureThresholdLabel
            // 
            this.consistencyModeUpperTemperatureThresholdLabel.Location = new System.Drawing.Point(9, 78);
            this.consistencyModeUpperTemperatureThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.consistencyModeUpperTemperatureThresholdLabel.Name = "consistencyModeUpperTemperatureThresholdLabel";
            this.consistencyModeUpperTemperatureThresholdLabel.Size = new System.Drawing.Size(268, 24);
            this.consistencyModeUpperTemperatureThresholdLabel.TabIndex = 2;
            this.consistencyModeUpperTemperatureThresholdLabel.Text = "CPU高温限制";
            // 
            // consistencyModeLowerTemperatureThresholdTextBox
            // 
            this.consistencyModeLowerTemperatureThresholdTextBox.Location = new System.Drawing.Point(238, 30);
            this.consistencyModeLowerTemperatureThresholdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.consistencyModeLowerTemperatureThresholdTextBox.MaxLength = 2;
            this.consistencyModeLowerTemperatureThresholdTextBox.Name = "consistencyModeLowerTemperatureThresholdTextBox";
            this.consistencyModeLowerTemperatureThresholdTextBox.Size = new System.Drawing.Size(44, 30);
            this.consistencyModeLowerTemperatureThresholdTextBox.TabIndex = 1;
            this.consistencyModeLowerTemperatureThresholdTextBox.Text = "65";
            // 
            // consistencyModeLowerTemperatureThresholdLabel
            // 
            this.consistencyModeLowerTemperatureThresholdLabel.Location = new System.Drawing.Point(9, 34);
            this.consistencyModeLowerTemperatureThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.consistencyModeLowerTemperatureThresholdLabel.Name = "consistencyModeLowerTemperatureThresholdLabel";
            this.consistencyModeLowerTemperatureThresholdLabel.Size = new System.Drawing.Size(265, 24);
            this.consistencyModeLowerTemperatureThresholdLabel.TabIndex = 0;
            this.consistencyModeLowerTemperatureThresholdLabel.Text = "CPU低温限值";
            // 
            // alertsCheckBox
            // 
            this.alertsCheckBox.Enabled = false;
            this.alertsCheckBox.Location = new System.Drawing.Point(1021, 338);
            this.alertsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.alertsCheckBox.Name = "alertsCheckBox";
            this.alertsCheckBox.Size = new System.Drawing.Size(10, 28);
            this.alertsCheckBox.TabIndex = 13;
            this.alertsCheckBox.Text = "A&lerts";
            this.alertsCheckBox.UseVisualStyleBackColor = true;
            this.alertsCheckBox.Visible = false;
            // 
            // ecFanControlRadioButtonOn
            // 
            this.ecFanControlRadioButtonOn.Location = new System.Drawing.Point(9, 33);
            this.ecFanControlRadioButtonOn.Margin = new System.Windows.Forms.Padding(4);
            this.ecFanControlRadioButtonOn.Name = "ecFanControlRadioButtonOn";
            this.ecFanControlRadioButtonOn.Size = new System.Drawing.Size(60, 28);
            this.ecFanControlRadioButtonOn.TabIndex = 2;
            this.ecFanControlRadioButtonOn.TabStop = true;
            this.ecFanControlRadioButtonOn.Text = "开";
            this.ecFanControlRadioButtonOn.UseVisualStyleBackColor = true;
            // 
            // ecFanControlRadioButtonOff
            // 
            this.ecFanControlRadioButtonOff.Location = new System.Drawing.Point(80, 33);
            this.ecFanControlRadioButtonOff.Margin = new System.Windows.Forms.Padding(4);
            this.ecFanControlRadioButtonOff.Name = "ecFanControlRadioButtonOff";
            this.ecFanControlRadioButtonOff.Size = new System.Drawing.Size(53, 28);
            this.ecFanControlRadioButtonOff.TabIndex = 3;
            this.ecFanControlRadioButtonOff.TabStop = true;
            this.ecFanControlRadioButtonOff.Text = "关";
            this.ecFanControlRadioButtonOff.UseVisualStyleBackColor = true;
            // 
            // ecFanControlGroupBox
            // 
            this.ecFanControlGroupBox.Controls.Add(this.ecFanControlRadioButtonOn);
            this.ecFanControlGroupBox.Controls.Add(this.ecFanControlRadioButtonOff);
            this.ecFanControlGroupBox.Location = new System.Drawing.Point(362, 18);
            this.ecFanControlGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ecFanControlGroupBox.Name = "ecFanControlGroupBox";
            this.ecFanControlGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ecFanControlGroupBox.Size = new System.Drawing.Size(154, 72);
            this.ecFanControlGroupBox.TabIndex = 2;
            this.ecFanControlGroupBox.TabStop = false;
            this.ecFanControlGroupBox.Text = "EC 控制风扇:";
            // 
            // restartBackgroundThreadButton
            // 
            this.restartBackgroundThreadButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartBackgroundThreadButton.Location = new System.Drawing.Point(360, 99);
            this.restartBackgroundThreadButton.Margin = new System.Windows.Forms.Padding(4);
            this.restartBackgroundThreadButton.Name = "restartBackgroundThreadButton";
            this.restartBackgroundThreadButton.Size = new System.Drawing.Size(158, 32);
            this.restartBackgroundThreadButton.TabIndex = 3;
            this.restartBackgroundThreadButton.Text = "重启后台监控";
            this.restartBackgroundThreadButton.UseVisualStyleBackColor = true;
            // 
            // aboutGroupBox
            // 
            this.aboutGroupBox.Controls.Add(this.richTextBox1);
            this.aboutGroupBox.Controls.Add(this.aboutProductLabel);
            this.aboutGroupBox.Location = new System.Drawing.Point(1039, 18);
            this.aboutGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.aboutGroupBox.Name = "aboutGroupBox";
            this.aboutGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.aboutGroupBox.Size = new System.Drawing.Size(10, 278);
            this.aboutGroupBox.TabIndex = 11;
            this.aboutGroupBox.TabStop = false;
            this.aboutGroupBox.Text = "About:";
            this.aboutGroupBox.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 56);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(10, 210);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // aboutProductLabel
            // 
            this.aboutProductLabel.AutoSize = true;
            this.aboutProductLabel.Location = new System.Drawing.Point(9, 28);
            this.aboutProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutProductLabel.Name = "aboutProductLabel";
            this.aboutProductLabel.Size = new System.Drawing.Size(312, 24);
            this.aboutProductLabel.TabIndex = 0;
            this.aboutProductLabel.Text = "Dell Fan Management, version DEV";
            // 
            // audioKeepAliveGroupBox
            // 
            this.audioKeepAliveGroupBox.Controls.Add(this.audioKeepAliveComboBox);
            this.audioKeepAliveGroupBox.Controls.Add(this.audioKeepAliveCheckbox);
            this.audioKeepAliveGroupBox.Location = new System.Drawing.Point(1039, 304);
            this.audioKeepAliveGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.audioKeepAliveGroupBox.Name = "audioKeepAliveGroupBox";
            this.audioKeepAliveGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.audioKeepAliveGroupBox.Size = new System.Drawing.Size(10, 118);
            this.audioKeepAliveGroupBox.TabIndex = 12;
            this.audioKeepAliveGroupBox.TabStop = false;
            this.audioKeepAliveGroupBox.Text = "Audio keep alive:";
            this.audioKeepAliveGroupBox.Visible = false;
            // 
            // audioKeepAliveComboBox
            // 
            this.audioKeepAliveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioKeepAliveComboBox.FormattingEnabled = true;
            this.audioKeepAliveComboBox.Location = new System.Drawing.Point(9, 74);
            this.audioKeepAliveComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.audioKeepAliveComboBox.Name = "audioKeepAliveComboBox";
            this.audioKeepAliveComboBox.Size = new System.Drawing.Size(10, 32);
            this.audioKeepAliveComboBox.TabIndex = 1;
            // 
            // audioKeepAliveCheckbox
            // 
            this.audioKeepAliveCheckbox.AutoSize = true;
            this.audioKeepAliveCheckbox.Location = new System.Drawing.Point(9, 34);
            this.audioKeepAliveCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.audioKeepAliveCheckbox.Name = "audioKeepAliveCheckbox";
            this.audioKeepAliveCheckbox.Size = new System.Drawing.Size(47, 28);
            this.audioKeepAliveCheckbox.TabIndex = 0;
            this.audioKeepAliveCheckbox.Text = "&K";
            this.audioKeepAliveCheckbox.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consistencyModeStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 441);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1103, 31);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 13;
            // 
            // consistencyModeStatusLabel
            // 
            this.consistencyModeStatusLabel.Name = "consistencyModeStatusLabel";
            this.consistencyModeStatusLabel.Size = new System.Drawing.Size(178, 24);
            this.consistencyModeStatusLabel.Text = "Fan speed is locked";
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "Dell Fan Management";
            // 
            // trayIconCheckBox
            // 
            this.trayIconCheckBox.AutoSize = true;
            this.trayIconCheckBox.Checked = true;
            this.trayIconCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trayIconCheckBox.Location = new System.Drawing.Point(534, 369);
            this.trayIconCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.trayIconCheckBox.Name = "trayIconCheckBox";
            this.trayIconCheckBox.Size = new System.Drawing.Size(126, 28);
            this.trayIconCheckBox.TabIndex = 7;
            this.trayIconCheckBox.Text = "任务栏图标";
            this.trayIconCheckBox.UseVisualStyleBackColor = true;
            // 
            // animatedCheckBox
            // 
            this.animatedCheckBox.AutoSize = true;
            this.animatedCheckBox.Checked = true;
            this.animatedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.animatedCheckBox.Location = new System.Drawing.Point(534, 399);
            this.animatedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.animatedCheckBox.Name = "animatedCheckBox";
            this.animatedCheckBox.Size = new System.Drawing.Size(72, 28);
            this.animatedCheckBox.TabIndex = 8;
            this.animatedCheckBox.Text = "动画";
            this.animatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DellFanManagementGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1103, 472);
            this.Controls.Add(this.alertsCheckBox);
            this.Controls.Add(this.animatedCheckBox);
            this.Controls.Add(this.trayIconCheckBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.audioKeepAliveGroupBox);
            this.Controls.Add(this.aboutGroupBox);
            this.Controls.Add(this.restartBackgroundThreadButton);
            this.Controls.Add(this.ecFanControlGroupBox);
            this.Controls.Add(this.consistencyModeGroupBox);
            this.Controls.Add(this.manualGroupBox);
            this.Controls.Add(this.operationModeGroupBox);
            this.Controls.Add(this.temperatureGroupBox);
            this.Controls.Add(this.thermalSettingGroupBox);
            this.Controls.Add(this.fansGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DellFanManagementGuiForm";
            this.Text = "Dell 风扇管理 (仅适用于EC控制风扇，汉化修改 - cxy)";
            this.fansGroupBox.ResumeLayout(false);
            this.fansGroupBox.PerformLayout();
            this.thermalSettingGroupBox.ResumeLayout(false);
            this.temperatureGroupBox.ResumeLayout(false);
            this.temperatureGroupBox.PerformLayout();
            this.operationModeGroupBox.ResumeLayout(false);
            this.manualGroupBox.ResumeLayout(false);
            this.manualFan2GroupBox.ResumeLayout(false);
            this.manualFan1GroupBox.ResumeLayout(false);
            this.consistencyModeGroupBox.ResumeLayout(false);
            this.consistencyModeGroupBox.PerformLayout();
            this.ecFanControlGroupBox.ResumeLayout(false);
            this.aboutGroupBox.ResumeLayout(false);
            this.aboutGroupBox.PerformLayout();
            this.audioKeepAliveGroupBox.ResumeLayout(false);
            this.audioKeepAliveGroupBox.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fansGroupBox;
        private System.Windows.Forms.Label fan1RpmLabel;
        private System.Windows.Forms.Label fan2RpmLabel;
        private System.Windows.Forms.GroupBox thermalSettingGroupBox;
        private System.Windows.Forms.RadioButton thermalSettingRadioButtonPerformance;
        private System.Windows.Forms.RadioButton thermalSettingRadioButtonQuiet;
        private System.Windows.Forms.RadioButton thermalSettingRadioButtonCool;
        private System.Windows.Forms.RadioButton thermalSettingRadioButtonOptimized;
        private System.Windows.Forms.GroupBox temperatureGroupBox;
        private System.Windows.Forms.Label temperatureLabel18;
        private System.Windows.Forms.Label temperatureLabel17;
        private System.Windows.Forms.Label temperatureLabel16;
        private System.Windows.Forms.Label temperatureLabel15;
        private System.Windows.Forms.Label temperatureLabel14;
        private System.Windows.Forms.Label temperatureLabel13;
        private System.Windows.Forms.Label temperatureLabel12;
        private System.Windows.Forms.Label temperatureLabel11;
        private System.Windows.Forms.Label temperatureLabel10;
        private System.Windows.Forms.Label temperatureLabel9;
        private System.Windows.Forms.Label temperatureLabel8;
        private System.Windows.Forms.Label temperatureLabel7;
        private System.Windows.Forms.Label temperatureLabel6;
        private System.Windows.Forms.Label temperatureLabel5;
        private System.Windows.Forms.Label temperatureLabel4;
        private System.Windows.Forms.Label temperatureLabel3;
        private System.Windows.Forms.Label temperatureLabel2;
        private System.Windows.Forms.Label temperatureLabel1;
        private System.Windows.Forms.GroupBox operationModeGroupBox;
        private System.Windows.Forms.RadioButton operationModeRadioButtonConsistency;
        private System.Windows.Forms.RadioButton operationModeRadioButtonManual;
        private System.Windows.Forms.RadioButton operationModeRadioButtonAutomatic;
        private System.Windows.Forms.GroupBox manualGroupBox;
        private System.Windows.Forms.GroupBox manualFan2GroupBox;
        private System.Windows.Forms.RadioButton manualFan2RadioButtonHigh;
        private System.Windows.Forms.RadioButton manualFan2RadioButtonMedium;
        private System.Windows.Forms.RadioButton manualFan2RadioButtonOff;
        private System.Windows.Forms.GroupBox manualFan1GroupBox;
        private System.Windows.Forms.RadioButton manualFan1RadioButtonHigh;
        private System.Windows.Forms.RadioButton manualFan1RadioButtonMedium;
        private System.Windows.Forms.RadioButton manualFan1RadioButtonOff;
        private System.Windows.Forms.GroupBox consistencyModeGroupBox;
        private System.Windows.Forms.Button consistencyModeApplyChangesButton;
        private System.Windows.Forms.TextBox consistencyModeRpmThresholdTextBox;
        private System.Windows.Forms.Label consistencyModeRpmThresholdLabel;
        private System.Windows.Forms.TextBox consistencyModeUpperTemperatureThresholdTextBox;
        private System.Windows.Forms.Label consistencyModeUpperTemperatureThresholdLabel;
        private System.Windows.Forms.TextBox consistencyModeLowerTemperatureThresholdTextBox;
        private System.Windows.Forms.Label consistencyModeLowerTemperatureThresholdLabel;
        private System.Windows.Forms.RadioButton ecFanControlRadioButtonOn;
        private System.Windows.Forms.RadioButton ecFanControlRadioButtonOff;
        private System.Windows.Forms.GroupBox ecFanControlGroupBox;
        private System.Windows.Forms.Button restartBackgroundThreadButton;
        private System.Windows.Forms.GroupBox aboutGroupBox;
        private System.Windows.Forms.Label aboutProductLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox audioKeepAliveGroupBox;
        private System.Windows.Forms.ComboBox audioKeepAliveComboBox;
        private System.Windows.Forms.CheckBox audioKeepAliveCheckbox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel consistencyModeStatusLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.CheckBox trayIconCheckBox;
        private System.Windows.Forms.CheckBox alertsCheckBox;
        private System.Windows.Forms.CheckBox animatedCheckBox;
    }
}

