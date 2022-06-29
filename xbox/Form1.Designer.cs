namespace xbox
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.LT = new System.Windows.Forms.Label();
			this.RT = new System.Windows.Forms.Label();
			this.RSV = new System.Windows.Forms.Label();
			this.LSV = new System.Windows.Forms.Label();
			this.PLUGIN = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BUTTON = new System.Windows.Forms.Label();
			this.LSH = new System.Windows.Forms.Label();
			this.RSH = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.motorsCheck = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.GPCount = new System.Windows.Forms.Label();
			this.GPNum = new System.Windows.Forms.NumericUpDown();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.GPNum)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(12, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "левый тригер:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(256, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "правый тригер:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(12, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "левый стик:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(256, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "правый стик:";
			// 
			// LT
			// 
			this.LT.AutoSize = true;
			this.LT.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.LT.Location = new System.Drawing.Point(98, 82);
			this.LT.Name = "LT";
			this.LT.Size = new System.Drawing.Size(51, 13);
			this.LT.TabIndex = 4;
			this.LT.Text = "LT TEXT";
			// 
			// RT
			// 
			this.RT.AutoSize = true;
			this.RT.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.RT.Location = new System.Drawing.Point(347, 82);
			this.RT.Name = "RT";
			this.RT.Size = new System.Drawing.Size(53, 13);
			this.RT.TabIndex = 5;
			this.RT.Text = "RT TEXT";
			// 
			// RSV
			// 
			this.RSV.AutoSize = true;
			this.RSV.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.RSV.Location = new System.Drawing.Point(347, 161);
			this.RSV.Name = "RSV";
			this.RSV.Size = new System.Drawing.Size(60, 13);
			this.RSV.TabIndex = 6;
			this.RSV.Text = "RSV TEXT";
			// 
			// LSV
			// 
			this.LSV.AutoSize = true;
			this.LSV.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.LSV.Location = new System.Drawing.Point(99, 161);
			this.LSV.Name = "LSV";
			this.LSV.Size = new System.Drawing.Size(58, 13);
			this.LSV.TabIndex = 7;
			this.LSV.Text = "LSV TEXT";
			// 
			// PLUGIN
			// 
			this.PLUGIN.AutoSize = true;
			this.PLUGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PLUGIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.PLUGIN.Location = new System.Drawing.Point(12, 9);
			this.PLUGIN.Name = "PLUGIN";
			this.PLUGIN.Size = new System.Drawing.Size(122, 24);
			this.PLUGIN.TabIndex = 8;
			this.PLUGIN.Text = "PLUGGED IN";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(12, 257);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "нажимаемые кнопки: ";
			// 
			// BUTTON
			// 
			this.BUTTON.AutoSize = true;
			this.BUTTON.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.BUTTON.Location = new System.Drawing.Point(137, 257);
			this.BUTTON.Name = "BUTTON";
			this.BUTTON.Size = new System.Drawing.Size(83, 13);
			this.BUTTON.TabIndex = 10;
			this.BUTTON.Text = "BUTTON TEXT";
			// 
			// LSH
			// 
			this.LSH.AutoSize = true;
			this.LSH.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.LSH.Location = new System.Drawing.Point(98, 174);
			this.LSH.Name = "LSH";
			this.LSH.Size = new System.Drawing.Size(59, 13);
			this.LSH.TabIndex = 11;
			this.LSH.Text = "LSH TEXT";
			// 
			// RSH
			// 
			this.RSH.AutoSize = true;
			this.RSH.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.RSH.Location = new System.Drawing.Point(347, 174);
			this.RSH.Name = "RSH";
			this.RSH.Size = new System.Drawing.Size(61, 13);
			this.RSH.TabIndex = 12;
			this.RSH.Text = "RSH TEXT";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(79, 161);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Y";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new System.Drawing.Point(79, 174);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(14, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "X";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label8.Location = new System.Drawing.Point(327, 174);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(14, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "X";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label9.Location = new System.Drawing.Point(327, 161);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(14, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "Y";
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.ForeColor = System.Drawing.Color.Yellow;
			this.label10.Location = new System.Drawing.Point(418, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(210, 63);
			this.label10.TabIndex = 17;
			this.label10.Text = "*при нажатии на определённый тригер, будет крутится соответствующий мотор с той с" +
    "илой, с которой нажимается тригер.";
			this.label10.Click += new System.EventHandler(this.HideLabel);
			// 
			// motorsCheck
			// 
			this.motorsCheck.AutoSize = true;
			this.motorsCheck.Checked = true;
			this.motorsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.motorsCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.motorsCheck.Location = new System.Drawing.Point(13, 46);
			this.motorsCheck.Name = "motorsCheck";
			this.motorsCheck.Size = new System.Drawing.Size(182, 17);
			this.motorsCheck.TabIndex = 18;
			this.motorsCheck.Text = "моторы по нажатию триггеров";
			this.motorsCheck.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(13, 343);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(162, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "количество подключённых гп: ";
			// 
			// GPCount
			// 
			this.GPCount.AutoSize = true;
			this.GPCount.ForeColor = System.Drawing.Color.White;
			this.GPCount.Location = new System.Drawing.Point(179, 343);
			this.GPCount.Name = "GPCount";
			this.GPCount.Size = new System.Drawing.Size(63, 13);
			this.GPCount.TabIndex = 20;
			this.GPCount.Text = "GP COUNT";
			// 
			// GPNum
			// 
			this.GPNum.Location = new System.Drawing.Point(583, 336);
			this.GPNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.GPNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.GPNum.Name = "GPNum";
			this.GPNum.Size = new System.Drawing.Size(45, 20);
			this.GPNum.TabIndex = 21;
			this.GPNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1;
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(640, 365);
			this.Controls.Add(this.GPNum);
			this.Controls.Add(this.GPCount);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.motorsCheck);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.RSH);
			this.Controls.Add(this.LSH);
			this.Controls.Add(this.BUTTON);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PLUGIN);
			this.Controls.Add(this.LSV);
			this.Controls.Add(this.RSV);
			this.Controls.Add(this.RT);
			this.Controls.Add(this.LT);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "тест гп";
			((System.ComponentModel.ISupportInitialize)(this.GPNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LT;
		private System.Windows.Forms.Label RT;
		private System.Windows.Forms.Label RSV;
		private System.Windows.Forms.Label LSV;
		private System.Windows.Forms.Label PLUGIN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label BUTTON;
		private System.Windows.Forms.Label LSH;
		private System.Windows.Forms.Label RSH;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox motorsCheck;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label GPCount;
		private System.Windows.Forms.NumericUpDown GPNum;
		private System.Windows.Forms.Timer timer;
	}
}

