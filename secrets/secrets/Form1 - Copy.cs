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
			

			byte[] bytes = File.ReadAllBytes("encryptme.txt");
			MessageBox.Show(bytes[4].ToString());
			MessageBox.Show(bytes[1].ToString());
			///////////////////////////////////////////////////////////////random bytes///
			byte[] random = new Byte[bytes.Length];

			//RNGCryptoServiceProvider is an implementation of a random number generator.
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			rng.GetBytes(random); // The array is now filled with cryptographically strong random bytes.

			//////////////////////////do the stuff///////////
			for (int i = 0; i < bytes.Length; i++)
			{
				//keyGenNew(bytes.Length);
				//int section = bytes[i];
				//section = section + (int)key[i];
				bytes[i] = (byte)(bytes[i] ^ random[i]);
				File.WriteAllBytes("encrypted.txt", bytes);
			}
			byteKey = random;
		}

		private void fileDecrypt_Click(object sender, EventArgs e)
		{
			byte[] bytes = File.ReadAllBytes("encrypted.txt");
			MessageBox.Show(bytes.Length.ToString());

			for (int i = 0; i < bytes.Length; i++)
			{

				bytes[i] = (byte)(bytes[i] ^ byteKey[i]);
				File.WriteAllBytes("dencrypted.txt", bytes);
			}
		}


		//private byte[] GetBinaryFile(string filename)
		//{
		//	byte[] bytes;
		//	using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
		//	{
		//		bytes = new byte[file.Length];
		//		file.Read(bytes, 0, (int)file.Length);
		//	}
		//	return bytes;
		//}
	}
}
