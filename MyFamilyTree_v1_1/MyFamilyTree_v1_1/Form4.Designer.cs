namespace MyFamilyTree_v1_1
{
	partial class Form4
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
			this.labelWelcome = new System.Windows.Forms.Label();
			this.tbFullName = new System.Windows.Forms.TextBox();
			this.labelInstructions = new System.Windows.Forms.Label();
			this.labelFullName = new System.Windows.Forms.Label();
			this.btnLogIn = new System.Windows.Forms.Button();
			this.labelFeedback = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelWelcome
			// 
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWelcome.Location = new System.Drawing.Point(119, 64);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(404, 37);
			this.labelWelcome.TabIndex = 0;
			this.labelWelcome.Text = "Welcome to MyFamilyTree!";
			// 
			// tbFullName
			// 
			this.tbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFullName.Location = new System.Drawing.Point(40, 427);
			this.tbFullName.Name = "tbFullName";
			this.tbFullName.Size = new System.Drawing.Size(564, 31);
			this.tbFullName.TabIndex = 1;
			// 
			// labelInstructions
			// 
			this.labelInstructions.AutoSize = true;
			this.labelInstructions.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInstructions.Location = new System.Drawing.Point(155, 153);
			this.labelInstructions.Name = "labelInstructions";
			this.labelInstructions.Size = new System.Drawing.Size(330, 125);
			this.labelInstructions.TabIndex = 2;
			this.labelInstructions.Text = "To get you into your own position in our\r\nonly registered family tree, you shall " +
    "just\r\ninput your full name in the text box below\r\n\r\nHave fun exploring!";
			this.labelInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelFullName
			// 
			this.labelFullName.AutoSize = true;
			this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFullName.Location = new System.Drawing.Point(267, 379);
			this.labelFullName.Name = "labelFullName";
			this.labelFullName.Size = new System.Drawing.Size(102, 24);
			this.labelFullName.TabIndex = 3;
			this.labelFullName.Text = "Full Name:";
			// 
			// btnLogIn
			// 
			this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogIn.Location = new System.Drawing.Point(250, 503);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(130, 59);
			this.btnLogIn.TabIndex = 4;
			this.btnLogIn.Text = "Log In";
			this.btnLogIn.UseVisualStyleBackColor = true;
			this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
			// 
			// labelFeedback
			// 
			this.labelFeedback.AutoSize = true;
			this.labelFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFeedback.ForeColor = System.Drawing.Color.Red;
			this.labelFeedback.Location = new System.Drawing.Point(36, 461);
			this.labelFeedback.Name = "labelFeedback";
			this.labelFeedback.Size = new System.Drawing.Size(51, 20);
			this.labelFeedback.TabIndex = 5;
			this.labelFeedback.Text = "label1";
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 623);
			this.Controls.Add(this.labelFeedback);
			this.Controls.Add(this.btnLogIn);
			this.Controls.Add(this.labelFullName);
			this.Controls.Add(this.labelInstructions);
			this.Controls.Add(this.tbFullName);
			this.Controls.Add(this.labelWelcome);
			this.Name = "Form4";
			this.Text = "Form4";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelWelcome;
		private System.Windows.Forms.TextBox tbFullName;
		private System.Windows.Forms.Label labelInstructions;
		private System.Windows.Forms.Label labelFullName;
		private System.Windows.Forms.Button btnLogIn;
		private System.Windows.Forms.Label labelFeedback;
	}
}