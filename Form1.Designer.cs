namespace GasProduction
{
    partial class GasProductionSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasProductionSystem));
            this.AirSpeedLabel = new System.Windows.Forms.Label();
            this.AirTemperatureLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FireButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ApplyModelingButton = new System.Windows.Forms.Button();
            this.MechanicalContaminantsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.HumidityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PoisonContaminantsUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SmokeProgressBar = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.TempProgressBar = new System.Windows.Forms.ProgressBar();
            this.MechContProgressBar = new System.Windows.Forms.ProgressBar();
            this.HumidityProgressBar = new System.Windows.Forms.ProgressBar();
            this.PoisonContProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SIDODJI = new System.Windows.Forms.PictureBox();
            this.AirFlowControllerPB = new System.Windows.Forms.PictureBox();
            this.ConditionerPB = new System.Windows.Forms.PictureBox();
            this.FilterPB = new System.Windows.Forms.PictureBox();
            this.AntiFirePB = new System.Windows.Forms.PictureBox();
            this.RedirectPB = new System.Windows.Forms.PictureBox();
            this.FanPB2 = new System.Windows.Forms.PictureBox();
            this.FanPB1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicalContaminantsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoisonContaminantsUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SIDODJI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirFlowControllerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConditionerPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntiFirePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedirectPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanPB1)).BeginInit();
            this.SuspendLayout();
            // 
            // AirSpeedLabel
            // 
            this.AirSpeedLabel.AutoSize = true;
            this.AirSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirSpeedLabel.Location = new System.Drawing.Point(184, 9);
            this.AirSpeedLabel.Name = "AirSpeedLabel";
            this.AirSpeedLabel.Size = new System.Drawing.Size(16, 17);
            this.AirSpeedLabel.TabIndex = 0;
            this.AirSpeedLabel.Text = "0";
            // 
            // AirTemperatureLabel
            // 
            this.AirTemperatureLabel.AutoSize = true;
            this.AirTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AirTemperatureLabel.Location = new System.Drawing.Point(184, 39);
            this.AirTemperatureLabel.Name = "AirTemperatureLabel";
            this.AirTemperatureLabel.Size = new System.Drawing.Size(16, 17);
            this.AirTemperatureLabel.TabIndex = 1;
            this.AirTemperatureLabel.Text = "0";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(665, 342);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(130, 32);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "ПОЕХАЛИ!";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Скорость перегонки:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AirSpeedLabel);
            this.panel1.Controls.Add(this.AirTemperatureLabel);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 71);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Давление газа:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Монитор оператора";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FireButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 72);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Аварийные ситуации";
            // 
            // FireButton
            // 
            this.FireButton.BackColor = System.Drawing.Color.Red;
            this.FireButton.Location = new System.Drawing.Point(6, 32);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(105, 34);
            this.FireButton.TabIndex = 0;
            this.FireButton.Text = "Пожар";
            this.FireButton.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ApplyModelingButton);
            this.groupBox3.Controls.Add(this.MechanicalContaminantsUpDown);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.HumidityUpDown);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.PoisonContaminantsUpDown);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(530, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 175);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Моделирование";
            // 
            // ApplyModelingButton
            // 
            this.ApplyModelingButton.Location = new System.Drawing.Point(139, 97);
            this.ApplyModelingButton.Name = "ApplyModelingButton";
            this.ApplyModelingButton.Size = new System.Drawing.Size(120, 29);
            this.ApplyModelingButton.TabIndex = 16;
            this.ApplyModelingButton.Text = "Применить";
            this.ApplyModelingButton.UseVisualStyleBackColor = true;
            // 
            // MechanicalContaminantsUpDown
            // 
            this.MechanicalContaminantsUpDown.Location = new System.Drawing.Point(139, 71);
            this.MechanicalContaminantsUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.MechanicalContaminantsUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MechanicalContaminantsUpDown.Name = "MechanicalContaminantsUpDown";
            this.MechanicalContaminantsUpDown.Size = new System.Drawing.Size(120, 20);
            this.MechanicalContaminantsUpDown.TabIndex = 15;
            this.MechanicalContaminantsUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Механические примеси";
            // 
            // HumidityUpDown
            // 
            this.HumidityUpDown.Location = new System.Drawing.Point(139, 45);
            this.HumidityUpDown.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.HumidityUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HumidityUpDown.Name = "HumidityUpDown";
            this.HumidityUpDown.Size = new System.Drawing.Size(120, 20);
            this.HumidityUpDown.TabIndex = 13;
            this.HumidityUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Влажность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Примеси";
            // 
            // PoisonContaminantsUpDown
            // 
            this.PoisonContaminantsUpDown.Location = new System.Drawing.Point(139, 19);
            this.PoisonContaminantsUpDown.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.PoisonContaminantsUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PoisonContaminantsUpDown.Name = "PoisonContaminantsUpDown";
            this.PoisonContaminantsUpDown.Size = new System.Drawing.Size(120, 20);
            this.PoisonContaminantsUpDown.TabIndex = 10;
            this.PoisonContaminantsUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.SmokeProgressBar);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TempProgressBar);
            this.groupBox4.Controls.Add(this.MechContProgressBar);
            this.groupBox4.Controls.Add(this.HumidityProgressBar);
            this.groupBox4.Controls.Add(this.PoisonContProgressBar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 167);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Состояние системы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Дым";
            // 
            // SmokeProgressBar
            // 
            this.SmokeProgressBar.Location = new System.Drawing.Point(139, 135);
            this.SmokeProgressBar.Maximum = 120;
            this.SmokeProgressBar.Name = "SmokeProgressBar";
            this.SmokeProgressBar.Size = new System.Drawing.Size(120, 23);
            this.SmokeProgressBar.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Давление газа";
            // 
            // TempProgressBar
            // 
            this.TempProgressBar.Location = new System.Drawing.Point(139, 106);
            this.TempProgressBar.Maximum = 770;
            this.TempProgressBar.Name = "TempProgressBar";
            this.TempProgressBar.Size = new System.Drawing.Size(120, 23);
            this.TempProgressBar.TabIndex = 22;
            // 
            // MechContProgressBar
            // 
            this.MechContProgressBar.Location = new System.Drawing.Point(139, 77);
            this.MechContProgressBar.Maximum = 160;
            this.MechContProgressBar.Name = "MechContProgressBar";
            this.MechContProgressBar.Size = new System.Drawing.Size(120, 23);
            this.MechContProgressBar.TabIndex = 21;
            // 
            // HumidityProgressBar
            // 
            this.HumidityProgressBar.Location = new System.Drawing.Point(139, 48);
            this.HumidityProgressBar.Maximum = 60;
            this.HumidityProgressBar.Name = "HumidityProgressBar";
            this.HumidityProgressBar.Size = new System.Drawing.Size(120, 23);
            this.HumidityProgressBar.TabIndex = 20;
            // 
            // PoisonContProgressBar
            // 
            this.PoisonContProgressBar.Location = new System.Drawing.Point(139, 19);
            this.PoisonContProgressBar.Maximum = 120;
            this.PoisonContProgressBar.Name = "PoisonContProgressBar";
            this.PoisonContProgressBar.Size = new System.Drawing.Size(120, 23);
            this.PoisonContProgressBar.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Механические примеси";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Влажность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Вредные примеси";
            // 
            // SIDODJI
            // 
            this.SIDODJI.Image = global::GasProduction.Resource1.obemy_dobychi_prirodnogo_gaza_v_rossii;
            this.SIDODJI.Location = new System.Drawing.Point(302, 120);
            this.SIDODJI.Name = "SIDODJI";
            this.SIDODJI.Size = new System.Drawing.Size(199, 237);
            this.SIDODJI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SIDODJI.TabIndex = 17;
            this.SIDODJI.TabStop = false;
            // 
            // AirFlowControllerPB
            // 
            this.AirFlowControllerPB.Image = ((System.Drawing.Image)(resources.GetObject("AirFlowControllerPB.Image")));
            this.AirFlowControllerPB.Location = new System.Drawing.Point(561, 12);
            this.AirFlowControllerPB.Name = "AirFlowControllerPB";
            this.AirFlowControllerPB.Size = new System.Drawing.Size(70, 70);
            this.AirFlowControllerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AirFlowControllerPB.TabIndex = 16;
            this.AirFlowControllerPB.TabStop = false;
            // 
            // ConditionerPB
            // 
            this.ConditionerPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConditionerPB.Image = global::GasProduction.Resource1.magnifier_enabled;
            this.ConditionerPB.Location = new System.Drawing.Point(388, 12);
            this.ConditionerPB.Name = "ConditionerPB";
            this.ConditionerPB.Size = new System.Drawing.Size(70, 70);
            this.ConditionerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConditionerPB.TabIndex = 15;
            this.ConditionerPB.TabStop = false;
            // 
            // FilterPB
            // 
            this.FilterPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilterPB.Image = ((System.Drawing.Image)(resources.GetObject("FilterPB.Image")));
            this.FilterPB.Location = new System.Drawing.Point(475, 12);
            this.FilterPB.Name = "FilterPB";
            this.FilterPB.Size = new System.Drawing.Size(70, 70);
            this.FilterPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FilterPB.TabIndex = 14;
            this.FilterPB.TabStop = false;
            // 
            // AntiFirePB
            // 
            this.AntiFirePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AntiFirePB.Image = global::GasProduction.Resource1.antifire_disabled;
            this.AntiFirePB.Location = new System.Drawing.Point(12, 12);
            this.AntiFirePB.Name = "AntiFirePB";
            this.AntiFirePB.Size = new System.Drawing.Size(70, 70);
            this.AntiFirePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AntiFirePB.TabIndex = 13;
            this.AntiFirePB.TabStop = false;
            // 
            // RedirectPB
            // 
            this.RedirectPB.Image = ((System.Drawing.Image)(resources.GetObject("RedirectPB.Image")));
            this.RedirectPB.Location = new System.Drawing.Point(302, 12);
            this.RedirectPB.Name = "RedirectPB";
            this.RedirectPB.Size = new System.Drawing.Size(70, 70);
            this.RedirectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedirectPB.TabIndex = 12;
            this.RedirectPB.TabStop = false;
            // 
            // FanPB2
            // 
            this.FanPB2.Image = global::GasProduction.Resource1.pump_disabled;
            this.FanPB2.InitialImage = global::GasProduction.Resource1.pump_disabled;
            this.FanPB2.Location = new System.Drawing.Point(217, 12);
            this.FanPB2.Name = "FanPB2";
            this.FanPB2.Size = new System.Drawing.Size(70, 70);
            this.FanPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FanPB2.TabIndex = 11;
            this.FanPB2.TabStop = false;
            // 
            // FanPB1
            // 
            this.FanPB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FanPB1.Image = global::GasProduction.Resource1.pump_enabled;
            this.FanPB1.Location = new System.Drawing.Point(132, 12);
            this.FanPB1.Name = "FanPB1";
            this.FanPB1.Size = new System.Drawing.Size(70, 70);
            this.FanPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FanPB1.TabIndex = 10;
            this.FanPB1.TabStop = false;
            // 
            // GasProductionSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 400);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SIDODJI);
            this.Controls.Add(this.AirFlowControllerPB);
            this.Controls.Add(this.ConditionerPB);
            this.Controls.Add(this.FilterPB);
            this.Controls.Add(this.AntiFirePB);
            this.Controls.Add(this.RedirectPB);
            this.Controls.Add(this.FanPB2);
            this.Controls.Add(this.FanPB1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Name = "GasProductionSystem";
            this.Text = "Gas Production";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicalContaminantsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoisonContaminantsUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SIDODJI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirFlowControllerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConditionerPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntiFirePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedirectPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FanPB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;


        public System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.Button FireButton;
        public System.Windows.Forms.Button ApplyModelingButton;

        public System.Windows.Forms.Label AirSpeedLabel;
        public System.Windows.Forms.Label AirTemperatureLabel;

        public System.Windows.Forms.NumericUpDown MechanicalContaminantsUpDown;
        public System.Windows.Forms.NumericUpDown HumidityUpDown;
        public System.Windows.Forms.NumericUpDown PoisonContaminantsUpDown;
        
        
        public System.Windows.Forms.PictureBox FanPB1;
        public System.Windows.Forms.PictureBox FanPB2;
        public System.Windows.Forms.PictureBox RedirectPB;
        public System.Windows.Forms.PictureBox AntiFirePB;
        public System.Windows.Forms.PictureBox FilterPB;
        public System.Windows.Forms.PictureBox ConditionerPB;
        public System.Windows.Forms.PictureBox AirFlowControllerPB;
        public System.Windows.Forms.PictureBox SIDODJI;
        
        
        
        public System.Windows.Forms.ProgressBar SmokeProgressBar;
        public System.Windows.Forms.ProgressBar TempProgressBar;
        public System.Windows.Forms.ProgressBar MechContProgressBar;
        public System.Windows.Forms.ProgressBar HumidityProgressBar;
        public System.Windows.Forms.ProgressBar PoisonContProgressBar;
        

    }
}

