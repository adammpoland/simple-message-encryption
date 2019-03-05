using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace secrets
{
	public partial class Form1 : Form
	{

		private string key;
		public Form1()
		{
			InitializeComponent();
		}

		private void encrypt_Click(object sender, EventArgs e)
		{
			string ogText = input.Text;
			int ogLength = input.Text.Length;
			//key = "2363738383735345624352345234523452373658487456345234524312341525435635667548";
			string cypher = "";

			//input.Text = "";
			if (key == null)
			{
				MessageBox.Show("Please Generate a Key first");
			}
			for (int i = 0; i < ogLength; i++)
			{
				int asciiVal=(int)ogText[i];
				asciiVal = asciiVal + (int)key[i];
				cypher = cypher + (char)asciiVal;
			}

			output.Text = cypher;
		}

		private void decrypt_Click(object sender, EventArgs e)
		{
			string message = "";
			string cypher = output.Text;
			//key = "2363738383735345624352345234523452373658487456345234524312341525435635667548";
			for (int i = 0; i < cypher.Length; i++)
			{
				int asciiVal = (int)cypher[i];
				asciiVal = asciiVal - (int)key[i];
				message = message + (char)asciiVal;
			}

			label2.Text = message;
		}

		private void keyGen_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			string newKey = "";


			while (newKey.Length < 400)
			{
				int keyNum = rnd.Next(1, 2000000000); // creates a number between 1 and 12
				newKey = newKey + keyNum.ToString();
			}

			newKeyOutput.Text = newKey;
			key = newKey;

			// Set a variable to the Documents path.
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			// Write the string array to a new file named "WriteLines.txt".
			using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "SecretKey.keyz")))
			{
					outputFile.WriteLine(key);
			}
		}

		private void loadKey_Click(object sender, EventArgs e)
		{
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			KeyLoader keyloader = new KeyLoader();
			if(keyloader.ShowDialog() == DialogResult.OK){
				key = keyloader.keyValue;
				newKeyOutput.Text = keyloader.keyValue;
			}
		}
	}
}
