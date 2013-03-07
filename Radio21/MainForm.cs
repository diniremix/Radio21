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

namespace Radio21
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string fichero=@"radiotiempo21unicas.html";
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
		
		void BtnabrirClick(object sender, EventArgs e){
			System.IO.StreamReader sr =new System.IO.StreamReader(fichero,System.Text.Encoding.Default,true);
			string cadena="";
			// Leer el contenido mientras no se llegue al final
			while (sr.Peek() != -1){
				// Leer una líena del fichero
				string s = sr.ReadLine();
				// Si no está vacía, añadirla al control
				// Si está vacía, continuar el bucle
				if (String.IsNullOrEmpty(s)){
					continue;
				}
				if(s.Contains("<param name=\"flashvars\" value=")){
					cadena=s.Replace("<param name=\"flashvars\" value=\"mp3=../21unicas/mp3/","http://www.radiotiempo.com.co/21unicas/mp3/");
					cadena=cadena.Replace("&amp;showtime=1\" />","");
					cadena=cadena.Trim();
					listBox1.Items.Add(cadena);					
				}							
			}
			// Cerrar el fichero
			sr.Close();
			guardar();
		}//btn
		
		void ListBox1Click(object sender, EventArgs e)
		{
			textBox1.Text= listBox1.SelectedItem.ToString();
			this.Text=listBox1.SelectedItem.ToString();
		}
		
		void guardar(){
			System.IO.StreamWriter fichero = new System.IO.StreamWriter("lista.txt");
			for(int i=0;i<listBox1.Items.Count;i++){
				fichero.Write(listBox1.Items[i].ToString()+"\n");
			}
			fichero.Close();
			//ejecutar el juego
			if ( System.IO.File.Exists( "lista.txt" ) == true ){
				MessageBox.Show("archivo guardado","Bien");
			}else{
				MessageBox.Show("No se puede encontrar el archivo","Error");
			}
		}
	}
}
