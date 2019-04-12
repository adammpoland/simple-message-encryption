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
using System.Security.Cryptography;

namespace secrets
{
	public partial class Form1 : Form
	{

		private string key;
		private byte[] byteKey;
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
			if (newKeyOutput.Text=="")
			{
				MessageBox.Show("Please Generate a Key first");
		    }else{
				
				for (int i = 0; i < ogLength; i++)
				{
					int asciiVal = (int)ogText[i];
					asciiVal = asciiVal + (int)key[i];
					cypher = cypher + (char)asciiVal;
				}

				output.Text = cypher;
			}
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
			keyGenNew(500);
		}

		private void keyGenNew(int size)
		{
			Random rnd = new Random();
			string newKey = "";


			while (newKey.Length < size)
			{
				int keyNum = rnd.Next(0, 15); // creates a number between 1 and 12
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

		private void fileEncrypt_Click(object sender, EventArgs e)
		{
			string selectedFileName = " ";
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = "c:\\";
			//openFileDialog1.Filter = "*.key";
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				 selectedFileName = openFileDialog1.FileName;
				//...
			}

			byte[] bytes = File.ReadAllBytes(selectedFileName);
			//MessageBox.Show(bytes[4].ToString());
			MessageBox.Show(selectedFileName);
			///////////////////////////////////////////////////////////////random bytes///
			byte[] random = new Byte[bytes.Length];

			//RNGCryptoServiceProvider is an implementation of a random number generator.
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			rng.GetBytes(random); // The array is now filled with cryptographically strong random bytes.
			MessageBox.Show(bytes.Length.ToString());
			//////////////////////////do the stuff///////////

			for (int i = 0; i < bytes.Length; i++)
			{				
				bytes[i] = (byte)(bytes[i] ^ random[i]);
			}

			File.WriteAllBytes(selectedFileName + ".lock", bytes);

			byteKey = random;
			File.WriteAllBytes(selectedFileName +".key", random);
			MessageBox.Show(selectedFileName + " has been encrypted");

		}

		private void fileDecrypt_Click(object sender, EventArgs e)
		{
			string selectedKey = " ";
			string selectedFile = "";
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			//openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "Key files (*.key)|*.key";
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				selectedKey = openFileDialog1.FileName;
				//...
			}
			byteKey = File.ReadAllBytes(selectedKey);


			OpenFileDialog openFileDialog2 = new OpenFileDialog();

			//openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "Locked files (*.lock)|*.lock";
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog2.ShowDialog() == DialogResult.OK)
			{
				selectedFile = openFileDialog2.FileName;
				//...
			}


			byte[] bytes = File.ReadAllBytes(selectedFile);
			MessageBox.Show(bytes.Length.ToString());
			string file = Path.GetFileNameWithoutExtension(selectedFile);
			//string path = Path.GetFullPath(selectedFile);
			string path = GetDirectoryName(selectedFile);
			string FnP = path + @"\" + file;
			MessageBox.Show(FnP);
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] = (byte)(bytes[i] ^ byteKey[i]);
			}
			File.WriteAllBytes(FnP, bytes);
			MessageBox.Show(FnP + " has been decrypted");

		}

		static string GetDirectoryName(string f)
		{
			try
			{
				return f.Substring(0, f.LastIndexOf('\\'));
			}
			catch
			{
				return string.Empty;
			}
		}

	}
}
