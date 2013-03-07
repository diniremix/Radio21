/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 06/03/2013
 * Hora: 10:55 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Radio21
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.btnabrir = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnabrir
			// 
			this.btnabrir.Location = new System.Drawing.Point(12, 52);
			this.btnabrir.Name = "btnabrir";
			this.btnabrir.Size = new System.Drawing.Size(75, 23);
			this.btnabrir.TabIndex = 0;
			this.btnabrir.Text = "button1";
			this.btnabrir.UseVisualStyleBackColor = true;
			this.btnabrir.Click += new System.EventHandler(this.BtnabrirClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(493, 20);
			this.textBox1.TabIndex = 1;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 94);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(426, 277);
			this.listBox1.TabIndex = 3;
			this.listBox1.Click += new System.EventHandler(this.ListBox1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 387);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnabrir);
			this.Name = "MainForm";
			this.Text = "Radio21";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnabrir;
	}
}
