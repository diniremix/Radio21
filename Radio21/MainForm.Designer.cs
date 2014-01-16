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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarCachéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.forkMeOnGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoM3uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoPlcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoXspfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cbociudades = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listciudad
			// 
			this.listciudad.FormattingEnabled = true;
			this.listciudad.Location = new System.Drawing.Point(6, 57);
			this.listciudad.Name = "listciudad";
			this.listciudad.Size = new System.Drawing.Size(560, 316);
			this.listciudad.TabIndex = 3;
			this.listciudad.Click += new System.EventHandler(this.ListciudadesClick);
			// 
			// DownloadProgress
			// 
			this.DownloadProgress.Location = new System.Drawing.Point(328, 24);
			this.DownloadProgress.Name = "DownloadProgress";
			this.DownloadProgress.Size = new System.Drawing.Size(238, 23);
			this.DownloadProgress.TabIndex = 4;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.opcionesToolStripMenuItem,
									this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(592, 24);
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
			this.actualizarlistaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarlistaToolStripMenuItem.Image")));
			this.actualizarlistaToolStripMenuItem.Name = "actualizarlistaToolStripMenuItem";
			this.actualizarlistaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.actualizarlistaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.actualizarlistaToolStripMenuItem.Text = "Actualizar &listado";
			this.actualizarlistaToolStripMenuItem.Click += new System.EventHandler(this.ActualizarlistaToolStripMenuItemClick);
			// 
			// exportarListaToolStripMenuItem
			// 
			this.exportarListaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.formatoM3uToolStripMenuItem1,
									this.formatoPlsToolStripMenuItem,
									this.formatoxspfToolStripMenuItem1});
			this.exportarListaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportarListaToolStripMenuItem.Image")));
			this.exportarListaToolStripMenuItem.Name = "exportarListaToolStripMenuItem";
			this.exportarListaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.exportarListaToolStripMenuItem.Text = "&Exportar a";
			// 
			// formatoM3uToolStripMenuItem1
			// 
			this.formatoM3uToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("formatoM3uToolStripMenuItem1.Image")));
			this.formatoM3uToolStripMenuItem1.Name = "formatoM3uToolStripMenuItem1";
			this.formatoM3uToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.formatoM3uToolStripMenuItem1.Text = "formato &m3u";
			this.formatoM3uToolStripMenuItem1.Click += new System.EventHandler(this.FormatoM3uToolStripMenuItem1Click);
			// 
			// formatoPlsToolStripMenuItem
			// 
			this.formatoPlsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("formatoPlsToolStripMenuItem.Image")));
			this.formatoPlsToolStripMenuItem.Name = "formatoPlsToolStripMenuItem";
			this.formatoPlsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.formatoPlsToolStripMenuItem.Text = "formato &pls";
			this.formatoPlsToolStripMenuItem.Click += new System.EventHandler(this.FormatoPlsToolStripMenuItemClick);
			// 
			// formatoxspfToolStripMenuItem1
			// 
			this.formatoxspfToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("formatoxspfToolStripMenuItem1.Image")));
			this.formatoxspfToolStripMenuItem1.Name = "formatoxspfToolStripMenuItem1";
			this.formatoxspfToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.formatoxspfToolStripMenuItem1.Text = "formato &xspf";
			this.formatoxspfToolStripMenuItem1.Click += new System.EventHandler(this.FormatoxspfToolStripMenuItem1Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.eliminarCachéToolStripMenuItem,
									this.preferenciasToolStripMenuItem});
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.opcionesToolStripMenuItem.Text = "&Opciones";
			// 
			// eliminarCachéToolStripMenuItem
			// 
			this.eliminarCachéToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarCachéToolStripMenuItem.Image")));
			this.eliminarCachéToolStripMenuItem.Name = "eliminarCachéToolStripMenuItem";
			this.eliminarCachéToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.eliminarCachéToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.eliminarCachéToolStripMenuItem.Text = "&Eliminar caché";
			this.eliminarCachéToolStripMenuItem.Click += new System.EventHandler(this.EliminarCachéToolStripMenuItemClick);
			// 
			// preferenciasToolStripMenuItem
			// 
			this.preferenciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("preferenciasToolStripMenuItem.Image")));
			this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
			this.preferenciasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.preferenciasToolStripMenuItem.Text = "&Preferencias";
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
			this.acercadeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercadeToolStripMenuItem.Image")));
			this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
			this.acercadeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.acercadeToolStripMenuItem.Text = "Acerca &de";
			this.acercadeToolStripMenuItem.Click += new System.EventHandler(this.AcercadeToolStripMenuItemClick);
			// 
			// forkMeOnGitHubToolStripMenuItem
			// 
			this.forkMeOnGitHubToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("forkMeOnGitHubToolStripMenuItem.Image")));
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
			this.cbociudades.Location = new System.Drawing.Point(128, 26);
			this.cbociudades.Name = "cbociudades";
			this.cbociudades.Size = new System.Drawing.Size(121, 21);
			this.cbociudades.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "Seleccionar Ciudad: ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbociudades);
			this.groupBox1.Controls.Add(this.DownloadProgress);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.listciudad);
			this.groupBox1.Location = new System.Drawing.Point(12, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(572, 380);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lista de ciudades";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(265, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "progreso:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 421);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Radio21";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarCachéToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
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
	}
}
