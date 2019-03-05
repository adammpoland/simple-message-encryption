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
	public partial class KeyLoader : Form
	{
		public KeyLoader()
		{
			InitializeComponent();
		}

		string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		string trueKey;
		private string keyFileName;


		private void KeyLoader_Load(object sender, EventArgs e)
		{
			string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			DirectoryInfo dirInfo = new DirectoryInfo(FilePath);

			FileInfo[] fileList = dirInfo.GetFiles();
			foreach (FileInfo file in fileList)
			{ 

				if (file.Extension == ".keyz")
				{
					ListViewItem lvi = new ListViewItem();
					//lvi.ImageIndex = 2;
					lvi.Text = file.Name;
					lvi.SubItems.Add(file.Length.ToString());
					lvi.SubItems.Add(file.LastAccessTime.ToString());

					lvDirs.Items.Add(lvi);
					
				}
				//else
				//{
				//	ListViewItem lvi = new ListViewItem();
				//	//lvi.ImageIndex = 0;
				//	lvi.Text = file.Name;
				//	lvi.SubItems.Add(file.Length.ToString());
				//	lvi.SubItems.Add(file.LastAccessTime.ToString());

				//	lvDirs.Items.Add(lvi);
				//}
			}
		}

		public string keyValue
		{
			get
			{
				MessageBox.Show(keyFileName);
				string[] linesFromFile = System.IO.File.ReadAllLines(FilePath + @"\" + "SecretKey.keyz");
				trueKey = linesFromFile[0];
				return trueKey;

			}
		}

		private void open_Click(object sender, EventArgs e)
		{
			if (lvDirs.SelectedItems.Count <= 0)
			{
				MessageBox.Show("Please Don't Try and break this");
			}
			else
			{
				string curitem = lvDirs.SelectedItems[0].Text;
				if (curitem.Contains("."))
				{
					if (curitem.Contains(".keyz"))
					{
						string tempPath = FilePath + @"\" + curitem;
						string keyFileName = lvDirs.SelectedItems[0].Text;
						DialogResult = DialogResult.OK;
					}
					else
					{
						MessageBox.Show("This file is incombatable.");

					}
				}
				else
				{
					MessageBox.Show("IDK");
				}
				//MessageBox.Show(curitem);

			}
		}
	}
}
