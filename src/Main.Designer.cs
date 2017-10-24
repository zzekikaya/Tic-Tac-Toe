namespace Tic_Tac_Toe
{
	 partial class Main
	 {
		  /// <summary>
		  /// Erforderliche Designervariable.
		  /// </summary>
		  private System.ComponentModel.IContainer components = null;

		  /// <summary>
		  /// Verwendete Ressourcen bereinigen.
		  /// </summary>
		  /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		  protected override void Dispose(bool disposing)
		  {
				if (disposing && (components != null))
				{
					 components.Dispose();
				}
				base.Dispose(disposing);
		  }

		  #region Vom Windows Form-Designer generierter Code

		  /// <summary>
		  /// Erforderliche Methode für die Designerunterstützung.
		  /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		  /// </summary>
		  private void InitializeComponent()
		  {
				this.A1 = new System.Windows.Forms.Button();
				this.A2 = new System.Windows.Forms.Button();
				this.A3 = new System.Windows.Forms.Button();
				this.B3 = new System.Windows.Forms.Button();
				this.B2 = new System.Windows.Forms.Button();
				this.B1 = new System.Windows.Forms.Button();
				this.C3 = new System.Windows.Forms.Button();
				this.C2 = new System.Windows.Forms.Button();
				this.C1 = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// A1
				// 
				this.A1.Location = new System.Drawing.Point(12, 12);
				this.A1.Name = "A1";
				this.A1.Size = new System.Drawing.Size(50, 50);
				this.A1.TabIndex = 0;
				this.A1.UseVisualStyleBackColor = true;
				this.A1.Click += new System.EventHandler(this.Button_Click);
				// 
				// A2
				// 
				this.A2.Location = new System.Drawing.Point(68, 12);
				this.A2.Name = "A2";
				this.A2.Size = new System.Drawing.Size(50, 50);
				this.A2.TabIndex = 1;
				this.A2.UseVisualStyleBackColor = true;
				this.A2.Click += new System.EventHandler(this.Button_Click);
				// 
				// A3
				// 
				this.A3.Location = new System.Drawing.Point(124, 12);
				this.A3.Name = "A3";
				this.A3.Size = new System.Drawing.Size(50, 50);
				this.A3.TabIndex = 2;
				this.A3.UseVisualStyleBackColor = true;
				this.A3.Click += new System.EventHandler(this.Button_Click);
				// 
				// B3
				// 
				this.B3.Location = new System.Drawing.Point(124, 68);
				this.B3.Name = "B3";
				this.B3.Size = new System.Drawing.Size(50, 50);
				this.B3.TabIndex = 5;
				this.B3.UseVisualStyleBackColor = true;
				this.B3.Click += new System.EventHandler(this.Button_Click);
				// 
				// B2
				// 
				this.B2.Location = new System.Drawing.Point(68, 68);
				this.B2.Name = "B2";
				this.B2.Size = new System.Drawing.Size(50, 50);
				this.B2.TabIndex = 4;
				this.B2.UseVisualStyleBackColor = true;
				this.B2.Click += new System.EventHandler(this.Button_Click);
				// 
				// B1
				// 
				this.B1.Location = new System.Drawing.Point(12, 68);
				this.B1.Name = "B1";
				this.B1.Size = new System.Drawing.Size(50, 50);
				this.B1.TabIndex = 3;
				this.B1.UseVisualStyleBackColor = true;
				this.B1.Click += new System.EventHandler(this.Button_Click);
				// 
				// C3
				// 
				this.C3.Location = new System.Drawing.Point(124, 124);
				this.C3.Name = "C3";
				this.C3.Size = new System.Drawing.Size(50, 50);
				this.C3.TabIndex = 8;
				this.C3.UseVisualStyleBackColor = true;
				this.C3.Click += new System.EventHandler(this.Button_Click);
				// 
				// C2
				// 
				this.C2.Location = new System.Drawing.Point(68, 124);
				this.C2.Name = "C2";
				this.C2.Size = new System.Drawing.Size(50, 50);
				this.C2.TabIndex = 7;
				this.C2.UseVisualStyleBackColor = true;
				this.C2.Click += new System.EventHandler(this.Button_Click);
				// 
				// C1
				// 
				this.C1.Location = new System.Drawing.Point(12, 124);
				this.C1.Name = "C1";
				this.C1.Size = new System.Drawing.Size(50, 50);
				this.C1.TabIndex = 6;
				this.C1.UseVisualStyleBackColor = true;
				this.C1.Click += new System.EventHandler(this.Button_Click);
				// 
				// Form1
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(189, 190);
				this.Controls.Add(this.C3);
				this.Controls.Add(this.C2);
				this.Controls.Add(this.C1);
				this.Controls.Add(this.B3);
				this.Controls.Add(this.B2);
				this.Controls.Add(this.B1);
				this.Controls.Add(this.A3);
				this.Controls.Add(this.A2);
				this.Controls.Add(this.A1);
				this.Name = "Form1";
				this.Text = "Form1";
				this.Load += new System.EventHandler(this.Form1_Load);
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.Button A1;
		  private System.Windows.Forms.Button A2;
		  private System.Windows.Forms.Button A3;
		  private System.Windows.Forms.Button B3;
		  private System.Windows.Forms.Button B2;
		  private System.Windows.Forms.Button B1;
		  private System.Windows.Forms.Button C3;
		  private System.Windows.Forms.Button C2;
		  private System.Windows.Forms.Button C1;
	 }
}

