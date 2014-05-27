/*
 * Creado por SharpDevelop.
 * Usuario: diniremix
 * Fecha: 06/03/2013
 * Hora: 10:55 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;
using System.Xml;
using System.IO;

namespace Radio21
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string ciudad="";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//
		//Form load 
		//			
		void MainFormLoad(object sender, EventArgs e)
		{
			cbociudades.SelectedIndex=0;			
		}
		
		//
		//Menu 
		//		
		
		void ActualizarlistaToolStripMenuItemClick(object sender, EventArgs e)
		{
			BtnabrirClick(sender,e);
		}
		
		void FormatoM3uToolStripMenuItem1Click(object sender, EventArgs e)
		{
			guardar("m3u");
		}
		
		void FormatoPlsToolStripMenuItemClick(object sender, EventArgs e)
		{
			guardar("pls");
		}
		
		void FormatoxspfToolStripMenuItem1Click(object sender, EventArgs e)
		{
			guardar("xspf");
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void AcercadeToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Buscador de enlaces de archivos MP3 en URL's","Acerca de Radio21",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void ForkMeOnGitHubToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/diniremix/Radio21");
		}
		
		//
		//Buttons 
		//
		
		void BtnabrirClick(object sender, EventArgs e){
			descargar();			
		}
				
		private void ListciudadesClick(object sender, EventArgs e)
		{
			if(listciudad.Items.Count>0){
				setMessage(listciudad.SelectedItem.ToString());
			}else{
				setMessage("nada que mostrar");
			}
		}
		
		//
		// methods
		//
		
		private void descargar(){
			int idCiudad=0;			
			setMessage("Buscando Servidor...");
			if(cbociudades.SelectedIndex>0){
				idCiudad=cbociudades.SelectedIndex;
				ciudad=cbociudades.Text+".html";
				WebClient webClient = new WebClient();
				webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
				webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
				webClient.DownloadFileAsync(new Uri("http://radiotiempo.com.co/21unicas/index.php?ciudad="+idCiudad.ToString()), ciudad);
			}else{
				MessageBox.Show("Selecciona una ciudad!","Radio21",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			
		}

		private void Completed(object sender, AsyncCompletedEventArgs e){
			if ( System.IO.File.Exists( ciudad) == true ){
				leerArchivo();
			}else{
				MessageBox.Show("Ocurrio un Error al descargar el archivo","Error");
				setMessage("Ocurrio un error");
			}
		}
		
		private void ProgressChanged(object sender,DownloadProgressChangedEventArgs e)	{
			DownloadProgress.Value = e.ProgressPercentage;
			setMessage("Descargando..."+e.ProgressPercentage.ToString());
		}
		
		private void leerArchivo(){
			System.IO.StreamReader sr =new System.IO.StreamReader(ciudad,System.Text.Encoding.Default,true);
			string urlStreamFile="";			
			listciudad.Items.Clear();
			setMessage("Organizando lista...");
			while (sr.Peek() != -1){
				string s = sr.ReadLine();
				if (String.IsNullOrEmpty(s)){
					continue;
				}
				if(s.Contains("<param name=\"flashvars\" value=")){
					urlStreamFile=s.Replace("<param name=\"flashvars\" value=\"mp3=../21unicas/mp3/","http://www.radiotiempo.com.co/21unicas/mp3/");
					urlStreamFile=urlStreamFile.Replace("&amp;showtime=1\" />","");
					urlStreamFile=urlStreamFile.Trim();
					listciudad.Items.Add(urlStreamFile);
				}
			}
			setMessage("completado");
			sr.Close();
		}
		
		private void guardar(string export){
			string miCiudad=ciudad;
			ciudad=ciudad.Replace(".html","");
			ciudad=ciudad+"."+export;
			int totalList=0;
			totalList=listciudad.Items.Count;
			switch(export){
				case "m3u":					
					generateM3u(totalList);
					break;
				case "pls":					
					generatePls(totalList);
					break;
				case "xspf":
					generateXspf(totalList);
					break;
			}
			checkExists();
			ciudad=miCiudad;
		}
		
		private void generateM3u(int total){
			System.IO.StreamWriter fichero = new System.IO.StreamWriter(ciudad);
			fichero.Write("#EXTINF:-1"+"\n");
			for(int i=0;i<total;i++){
				fichero.Write(listciudad.Items[i].ToString()+"\n");				
			}
			fichero.Close();
			setMessage("Lista exportada a M3U...");
		}
		
		private void generatePls(int total){
			System.IO.StreamWriter fichero = new System.IO.StreamWriter(ciudad);
			fichero.Write("[playlist]"+"\n");
			fichero.Write("NumberOfEntries="+total.ToString()+"\n");
			string arch="";
			for(int i=0;i<total;i++){
				arch=listciudad.Items[i].ToString();
				fichero.Write("Title"+i.ToString()+"="+arch+"\n");	
				fichero.Write("File"+i.ToString()+"="+arch+"\n");	
			}
			fichero.Close();
			setMessage("Lista exportada a PLS...");			
		}
		
		private void generateXspf(int total){
			System.IO.StreamWriter fichero = new System.IO.StreamWriter(ciudad);
			fichero.Write("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"+"\n");
			fichero.Write("<playlist version=\"1\" xmlns=\"http://xspf.org/ns/0/\">"+"\n");
			fichero.Write("<trackList>"+"\n");
			for(int i=0;i<total;i++){
				fichero.Write("<track>"+"\n");
				fichero.Write("<title>"+listciudad.Items[i].ToString()+"</title>"+"\n");
				fichero.Write("<location>"+listciudad.Items[i].ToString()+"</location>"+"\n");
				fichero.Write("</track>"+"\n");				
			}
			fichero.Write("</trackList>"+"\n");
			fichero.Write("</playlist>"+"\n");
			fichero.Close();
			setMessage("Lista exportada a XSPF...");
		}

		private void checkExists(){
		if ( System.IO.File.Exists( ciudad ) == true ){
				if(DialogResult.Yes== MessageBox.Show("Lista de reproduccion exportada satisfactoriamente, ¿Desea escucharla ahora?","Radio21",MessageBoxButtons.YesNo,MessageBoxIcon.Information)){
					System.Diagnostics.Process.Start(ciudad);
				}
			}else{
				MessageBox.Show("Ocurrio un error al exportar la lista de reproduccion","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		private void clearCache(){
			if(DialogResult.Yes== MessageBox.Show("Esto eliminará las listas de reproduccion almacenadas en el directorio de la aplicación, y la listas de canciones cargadas recientemente.\n"+
			                                      "¿Desea continuar?","Radio21",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)){
				listciudad.Items.Clear();
				string path=System.IO.Directory.GetCurrentDirectory();							
				DirectoryInfo folder = new DirectoryInfo(path);
	            string file_ext;
	            setMessage("limpiando cache, espere...");
	            foreach (FileInfo file in folder.GetFiles()){
		            file_ext = Path.GetExtension(file.Name).ToLower();
		            if ((file_ext == ".html") ||(file_ext == ".pls")||(file_ext == ".xspf")|| (file_ext == ".m3u")){                                        
		                    File.Delete(file.FullName);
		            }
	            }
			}			
	        setMessage("limpieza terminada.");
		}
		
		private void setMessage(string msg){
			if(string.IsNullOrEmpty(msg)){
				this.Text="Radio21::En espera";
			}			
		}			
		
		void EliminarCachéToolStripMenuItemClick(object sender, EventArgs e){
			clearCache();	
		}
	}
}
