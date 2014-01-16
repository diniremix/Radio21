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
			this.listciudad = new System.Windows.Forms.ListBox();
			this.DownloadProgress = new System.Windows.Forms.ProgressBar();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizarlistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoM3uToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoPlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoxspfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.forkMeOnGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoM3uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoPlcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoXspfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cbociudades = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnabrir
			// 
			this.btnabrir.Location = new System.Drawing.Point(12, 52);
			this.btnabrir.Name = "btnabrir";
			this.btnabrir.Size = new System.Drawing.Size(75, 23);
			this.btnabrir.TabIndex = 0;
			this.btnabrir.Text = "&Obtener lista";
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
			// listciudad
			// 
			this.listciudad.FormattingEnabled = true;
			this.listciudad.Location = new System.Drawing.Point(0, 110);
			this.listciudad.Name = "listciudad";
			this.listciudad.Size = new System.Drawing.Size(487, 251);
			this.listciudad.TabIndex = 3;
			this.listciudad.Click += new System.EventHandler(this.ListciudadesClick);
			// 
			// DownloadProgress
			// 
			this.DownloadProgress.Location = new System.Drawing.Point(12, 81);
			this.DownloadProgress.Name = "DownloadProgress";
			this.DownloadProgress.Size = new System.Drawing.Size(487, 23);
			this.DownloadProgress.TabIndex = 4;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(511, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.actualizarlistaToolStripMenuItem,
									this.exportarListaToolStripMenuItem,
									this.toolStripMenuItem1,
									this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// actualizarlistaToolStripMenuItem
			// 
			this.actualizarlistaToolStripMenuItem.Name = "actualizarlistaToolStripMenuItem";
			this.actualizarlistaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.actualizarlistaToolStripMenuItem.Text = "Actualizar &listado";
			this.actualizarlistaToolStripMenuItem.Click += new System.EventHandler(this.ActualizarlistaToolStripMenuItemClick);
			// 
			// exportarListaToolStripMenuItem
			// 
			this.exportarListaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.formatoM3uToolStripMenuItem1,
									this.formatoPlsToolStripMenuItem,
									this.formatoxspfToolStripMenuItem1});
			this.exportarListaToolStripMenuItem.Name = "exportarListaToolStripMenuItem";
			this.exportarListaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.exportarListaToolStripMenuItem.Text = "&Exportar a";
			// 
			// formatoM3uToolStripMenuItem1
			// 
			this.formatoM3uToolStripMenuItem1.Name = "formatoM3uToolStripMenuItem1";
			this.formatoM3uToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
			this.formatoM3uToolStripMenuItem1.Text = "formato &m3u";
			this.formatoM3uToolStripMenuItem1.Click += new System.EventHandler(this.FormatoM3uToolStripMenuItem1Click);
			// 
			// formatoPlsToolStripMenuItem
			// 
			this.formatoPlsToolStripMenuItem.Name = "formatoPlsToolStripMenuItem";
			this.formatoPlsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.formatoPlsToolStripMenuItem.Text = "formato &pls";
			this.formatoPlsToolStripMenuItem.Click += new System.EventHandler(this.FormatoPlsToolStripMenuItemClick);
			// 
			// formatoxspfToolStripMenuItem1
			// 
			this.formatoxspfToolStripMenuItem1.Name = "formatoxspfToolStripMenuItem1";
			this.formatoxspfToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
			this.formatoxspfToolStripMenuItem1.Text = "formato &xspf";
			this.formatoxspfToolStripMenuItem1.Click += new System.EventHandler(this.FormatoxspfToolStripMenuItem1Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.acercadeToolStripMenuItem,
									this.forkMeOnGitHubToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ay&uda";
			// 
			// acercadeToolStripMenuItem
			// 
			this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
			this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.acercadeToolStripMenuItem.Text = "Acerca &de";
			this.acercadeToolStripMenuItem.Click += new System.EventHandler(this.AcercadeToolStripMenuItemClick);
			// 
			// forkMeOnGitHubToolStripMenuItem
			// 
			this.forkMeOnGitHubToolStripMenuItem.Name = "forkMeOnGitHubToolStripMenuItem";
			this.forkMeOnGitHubToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.forkMeOnGitHubToolStripMenuItem.Text = "&Fork me on GitHub";
			this.forkMeOnGitHubToolStripMenuItem.Click += new System.EventHandler(this.ForkMeOnGitHubToolStripMenuItemClick);
			// 
			// formatoM3uToolStripMenuItem
			// 
			this.formatoM3uToolStripMenuItem.Name = "formatoM3uToolStripMenuItem";
			this.formatoM3uToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.formatoM3uToolStripMenuItem.Text = "formato m3u";
			// 
			// formatoPlcToolStripMenuItem
			// 
			this.formatoPlcToolStripMenuItem.Name = "formatoPlcToolStripMenuItem";
			this.formatoPlcToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.formatoPlcToolStripMenuItem.Text = "formato pls";
			// 
			// formatoXspfToolStripMenuItem
			// 
			this.formatoXspfToolStripMenuItem.Name = "formatoXspfToolStripMenuItem";
			this.formatoXspfToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.formatoXspfToolStripMenuItem.Text = "formato xspf";
			// 
			// cbociudades
			// 
			this.cbociudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbociudades.FormattingEnabled = true;
			this.cbociudades.Items.AddRange(new object[] {
									"Seleccione",
									"Barranquilla",
									"Cartagena",
									"Cucuta",
									"Medellin",
									"Monteria",
									"Neiva",
									"Sincelejo",
									"Valledupar",
									"Cali"});
			this.cbociudades.Location = new System.Drawing.Point(242, 49);
			this.cbociudades.Name = "cbociudades";
			this.cbociudades.Size = new System.Drawing.Size(121, 21);
			this.cbociudades.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 387);
			this.Controls.Add(this.cbociudades);
			this.Controls.Add(this.DownloadProgress);
			this.Controls.Add(this.listciudad);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnabrir);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Radio21";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem formatoxspfToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem formatoPlsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatoM3uToolStripMenuItem1;
		private System.Windows.Forms.ComboBox cbociudades;
		private System.Windows.Forms.ToolStripMenuItem forkMeOnGitHubToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatoXspfToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatoPlcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatoM3uToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exportarListaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actualizarlistaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ProgressBar DownloadProgress;
		private System.Windows.Forms.ListBox listciudad;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnabrir;		
	}
}
