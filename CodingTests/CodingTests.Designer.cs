namespace CodingTests
{
	partial class CodingTests
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
			this.btnOccurrence = new System.Windows.Forms.Button();
			this.btnOccurrencePrimitives = new System.Windows.Forms.Button();
			this.btnReverseStringPrimitive = new System.Windows.Forms.Button();
			this.btnReverseString = new System.Windows.Forms.Button();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.txtInputString = new System.Windows.Forms.TextBox();
			this.grpOccurrence = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.grpReverse = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.grpOccurrence.SuspendLayout();
			this.grpReverse.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOccurrence
			// 
			this.btnOccurrence.Location = new System.Drawing.Point(90, 87);
			this.btnOccurrence.Name = "btnOccurrence";
			this.btnOccurrence.Size = new System.Drawing.Size(121, 23);
			this.btnOccurrence.TabIndex = 3;
			this.btnOccurrence.Text = "Occurrence";
			this.btnOccurrence.UseVisualStyleBackColor = true;
			this.btnOccurrence.Click += new System.EventHandler(this.btnOccurrence_Click);
			// 
			// btnOccurrencePrimitives
			// 
			this.btnOccurrencePrimitives.Location = new System.Drawing.Point(90, 116);
			this.btnOccurrencePrimitives.Name = "btnOccurrencePrimitives";
			this.btnOccurrencePrimitives.Size = new System.Drawing.Size(121, 23);
			this.btnOccurrencePrimitives.TabIndex = 4;
			this.btnOccurrencePrimitives.Text = "Occurrence Primitives";
			this.btnOccurrencePrimitives.UseVisualStyleBackColor = true;
			this.btnOccurrencePrimitives.Click += new System.EventHandler(this.btnOccurrencePrimitives_Click);
			// 
			// btnReverseStringPrimitive
			// 
			this.btnReverseStringPrimitive.Location = new System.Drawing.Point(154, 93);
			this.btnReverseStringPrimitive.Name = "btnReverseStringPrimitive";
			this.btnReverseStringPrimitive.Size = new System.Drawing.Size(143, 23);
			this.btnReverseStringPrimitive.TabIndex = 7;
			this.btnReverseStringPrimitive.Text = "Reverse String Primitives";
			this.btnReverseStringPrimitive.UseVisualStyleBackColor = true;
			this.btnReverseStringPrimitive.Click += new System.EventHandler(this.btnReverseStringPrimitive_Click);
			// 
			// btnReverseString
			// 
			this.btnReverseString.Location = new System.Drawing.Point(6, 93);
			this.btnReverseString.Name = "btnReverseString";
			this.btnReverseString.Size = new System.Drawing.Size(143, 23);
			this.btnReverseString.TabIndex = 6;
			this.btnReverseString.Text = "Reverse String";
			this.btnReverseString.UseVisualStyleBackColor = true;
			this.btnReverseString.Click += new System.EventHandler(this.btnReverseString_Click);
			// 
			// txtFind
			// 
			this.txtFind.Location = new System.Drawing.Point(28, 61);
			this.txtFind.MaxLength = 10;
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(121, 20);
			this.txtFind.TabIndex = 1;
			// 
			// txtInputString
			// 
			this.txtInputString.AcceptsTab = true;
			this.txtInputString.Location = new System.Drawing.Point(6, 38);
			this.txtInputString.Multiline = true;
			this.txtInputString.Name = "txtInputString";
			this.txtInputString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtInputString.Size = new System.Drawing.Size(291, 49);
			this.txtInputString.TabIndex = 5;
			// 
			// grpOccurrence
			// 
			this.grpOccurrence.Controls.Add(this.label3);
			this.grpOccurrence.Controls.Add(this.label2);
			this.grpOccurrence.Controls.Add(this.label1);
			this.grpOccurrence.Controls.Add(this.txtSource);
			this.grpOccurrence.Controls.Add(this.txtFind);
			this.grpOccurrence.Controls.Add(this.btnOccurrence);
			this.grpOccurrence.Controls.Add(this.btnOccurrencePrimitives);
			this.grpOccurrence.Location = new System.Drawing.Point(23, 29);
			this.grpOccurrence.Name = "grpOccurrence";
			this.grpOccurrence.Size = new System.Drawing.Size(303, 173);
			this.grpOccurrence.TabIndex = 7;
			this.grpOccurrence.TabStop = false;
			this.grpOccurrence.Text = "Occurrence";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(152, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Find In:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Find:";
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(155, 61);
			this.txtSource.MaxLength = 10;
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(121, 20);
			this.txtSource.TabIndex = 2;
			// 
			// grpReverse
			// 
			this.grpReverse.Controls.Add(this.label4);
			this.grpReverse.Controls.Add(this.txtInputString);
			this.grpReverse.Controls.Add(this.btnReverseString);
			this.grpReverse.Controls.Add(this.btnReverseStringPrimitive);
			this.grpReverse.Location = new System.Drawing.Point(346, 29);
			this.grpReverse.Name = "grpReverse";
			this.grpReverse.Size = new System.Drawing.Size(303, 173);
			this.grpReverse.TabIndex = 8;
			this.grpReverse.TabStop = false;
			this.grpReverse.Text = "Reverse";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.DarkRed;
			this.label3.Location = new System.Drawing.Point(25, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Ignores the leading zeros.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(6, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "String to be reversed:";
			// 
			// CodingTests
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 223);
			this.Controls.Add(this.grpReverse);
			this.Controls.Add(this.grpOccurrence);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CodingTests";
			this.Text = "Coding Tests";
			this.Load += new System.EventHandler(this.CodingTests_Load);
			this.grpOccurrence.ResumeLayout(false);
			this.grpOccurrence.PerformLayout();
			this.grpReverse.ResumeLayout(false);
			this.grpReverse.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOccurrence;
		private System.Windows.Forms.Button btnOccurrencePrimitives;
		private System.Windows.Forms.Button btnReverseStringPrimitive;
		private System.Windows.Forms.Button btnReverseString;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.TextBox txtInputString;
		private System.Windows.Forms.GroupBox grpOccurrence;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpReverse;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

