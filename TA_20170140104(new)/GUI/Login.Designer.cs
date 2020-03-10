namespace TA_20170140104_new_.GUI
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.button2 = new System.Windows.Forms.Button();
			this.password_txt = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(232, 175);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 36);
			this.button2.TabIndex = 11;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// password_txt
			// 
			this.password_txt.Location = new System.Drawing.Point(137, 113);
			this.password_txt.Name = "password_txt";
			this.password_txt.Size = new System.Drawing.Size(170, 22);
			this.password_txt.TabIndex = 10;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(137, 69);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(170, 22);
			this.textBox1.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "UserName";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(137, 175);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 36);
			this.button1.TabIndex = 6;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(375, 288);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.password_txt);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox password_txt;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}