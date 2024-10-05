/*
 * Created by SharpDevelop.
 * User: yussu
 * Date: 3.10.2024
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hesap_Makinesi
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button sumButton;
		private System.Windows.Forms.Button subtractButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.Button divideButton;
		private System.Windows.Forms.Button modButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button allClearButton;
		private System.Windows.Forms.Button calculateButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.sumButton = new System.Windows.Forms.Button();
			this.subtractButton = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.divideButton = new System.Windows.Forms.Button();
			this.modButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.allClearButton = new System.Windows.Forms.Button();
			this.calculateButton = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 384);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new System.Drawing.Size(300, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(164, 17);
			this.toolStripStatusLabel1.Text = "Yusuf Bıyık - EEM - 03.10.2024";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.button3);
			this.flowLayoutPanel1.Controls.Add(this.button4);
			this.flowLayoutPanel1.Controls.Add(this.button5);
			this.flowLayoutPanel1.Controls.Add(this.button6);
			this.flowLayoutPanel1.Controls.Add(this.button7);
			this.flowLayoutPanel1.Controls.Add(this.button8);
			this.flowLayoutPanel1.Controls.Add(this.button9);
			this.flowLayoutPanel1.Controls.Add(this.button10);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 108);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 230);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(59, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(50, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(115, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(50, 50);
			this.button3.TabIndex = 2;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(3, 59);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(50, 50);
			this.button4.TabIndex = 3;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(59, 59);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(50, 50);
			this.button5.TabIndex = 4;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new System.Drawing.Point(115, 59);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(50, 50);
			this.button6.TabIndex = 5;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Location = new System.Drawing.Point(3, 115);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(50, 50);
			this.button7.TabIndex = 6;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Location = new System.Drawing.Point(59, 115);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(50, 50);
			this.button8.TabIndex = 7;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Location = new System.Drawing.Point(115, 115);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(50, 50);
			this.button9.TabIndex = 8;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Location = new System.Drawing.Point(3, 171);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(162, 50);
			this.button10.TabIndex = 9;
			this.button10.Text = "0";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// resultLabel
			// 
			this.resultLabel.BackColor = System.Drawing.Color.DarkGreen;
			this.resultLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.resultLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.resultLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.resultLabel.Location = new System.Drawing.Point(6, 7);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(288, 98);
			this.resultLabel.TabIndex = 2;
			this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.sumButton);
			this.flowLayoutPanel2.Controls.Add(this.subtractButton);
			this.flowLayoutPanel2.Controls.Add(this.multiplyButton);
			this.flowLayoutPanel2.Controls.Add(this.divideButton);
			this.flowLayoutPanel2.Controls.Add(this.modButton);
			this.flowLayoutPanel2.Controls.Add(this.clearButton);
			this.flowLayoutPanel2.Controls.Add(this.allClearButton);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(181, 108);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(113, 230);
			this.flowLayoutPanel2.TabIndex = 3;
			// 
			// sumButton
			// 
			this.sumButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.sumButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.sumButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.sumButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.sumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sumButton.Location = new System.Drawing.Point(3, 3);
			this.sumButton.Name = "sumButton";
			this.sumButton.Size = new System.Drawing.Size(50, 50);
			this.sumButton.TabIndex = 1;
			this.sumButton.Text = "+";
			this.sumButton.UseVisualStyleBackColor = false;
			this.sumButton.Click += new System.EventHandler(this.SumButtonClick);
			// 
			// subtractButton
			// 
			this.subtractButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.subtractButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.subtractButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.subtractButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.subtractButton.Location = new System.Drawing.Point(59, 3);
			this.subtractButton.Name = "subtractButton";
			this.subtractButton.Size = new System.Drawing.Size(50, 50);
			this.subtractButton.TabIndex = 2;
			this.subtractButton.Text = "-";
			this.subtractButton.UseVisualStyleBackColor = false;
			this.subtractButton.Click += new System.EventHandler(this.SubtractButtonClick);
			// 
			// multiplyButton
			// 
			this.multiplyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.multiplyButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.multiplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.multiplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.multiplyButton.Location = new System.Drawing.Point(3, 59);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(50, 50);
			this.multiplyButton.TabIndex = 3;
			this.multiplyButton.Text = "*";
			this.multiplyButton.UseVisualStyleBackColor = false;
			this.multiplyButton.Click += new System.EventHandler(this.MultiplyButtonClick);
			// 
			// divideButton
			// 
			this.divideButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.divideButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.divideButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.divideButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.divideButton.Location = new System.Drawing.Point(59, 59);
			this.divideButton.Name = "divideButton";
			this.divideButton.Size = new System.Drawing.Size(50, 50);
			this.divideButton.TabIndex = 4;
			this.divideButton.Text = "/";
			this.divideButton.UseVisualStyleBackColor = false;
			this.divideButton.Click += new System.EventHandler(this.DivideButtonClick);
			// 
			// modButton
			// 
			this.modButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.modButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.modButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.modButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.modButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modButton.Location = new System.Drawing.Point(3, 115);
			this.modButton.Name = "modButton";
			this.modButton.Size = new System.Drawing.Size(50, 50);
			this.modButton.TabIndex = 7;
			this.modButton.Text = "%";
			this.modButton.UseVisualStyleBackColor = false;
			this.modButton.Click += new System.EventHandler(this.ModButtonClick);
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearButton.Location = new System.Drawing.Point(59, 115);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(50, 50);
			this.clearButton.TabIndex = 5;
			this.clearButton.Text = "C";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// allClearButton
			// 
			this.allClearButton.BackColor = System.Drawing.Color.DarkRed;
			this.allClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.allClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
			this.allClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
			this.allClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.allClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.allClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.allClearButton.Location = new System.Drawing.Point(3, 171);
			this.allClearButton.Name = "allClearButton";
			this.allClearButton.Size = new System.Drawing.Size(106, 50);
			this.allClearButton.TabIndex = 6;
			this.allClearButton.Text = "AC";
			this.allClearButton.UseVisualStyleBackColor = false;
			this.allClearButton.Click += new System.EventHandler(this.AllClearButtonClick);
			// 
			// calculateButton
			// 
			this.calculateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.calculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
			this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.calculateButton.Location = new System.Drawing.Point(6, 335);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(288, 46);
			this.calculateButton.TabIndex = 4;
			this.calculateButton.Text = "Hesapla";
			this.calculateButton.UseVisualStyleBackColor = false;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 406);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.MaximumSize = new System.Drawing.Size(316, 445);
			this.MinimumSize = new System.Drawing.Size(316, 445);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Hesap Makinesi";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
