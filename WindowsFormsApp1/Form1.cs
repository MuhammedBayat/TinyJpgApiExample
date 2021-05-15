using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyPng;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPG Dosyası |*.jpg| PNG Dosyası|*.png";
            fileDialog.RestoreDirectory = true;
            fileDialog.CheckFileExists = false;
            fileDialog.Title = "Select Image(s)";
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> filePaths = fileDialog.FileNames.Select(x => x.Replace("\\", "/")).ToList();
                List<string> fileNames = fileDialog.SafeFileNames.ToList();

                CompressImages(filePaths, fileNames);
            }
        }
        async void CompressImages(List<string> filePathList, List<string> fileNameList)
        {
            LblToplam.Text = filePathList.Count.ToString();
            PgBarDurum.Step = PgBarDurum.Maximum / filePathList.Count;
            for (int i = 0; i < filePathList.Count; i++)
            {
                using (var png = new TinyPngClient("L7w7QPlChLcpx9M0jwVcX1KTP6dp51j8"))
                {
                    await png.Compress(filePathList[i].ToString())
                             .Download()
                             .SaveImageToDisk("D:/test/" + fileNameList[i].ToString());
                    PgBarDurum.PerformStep();
                    lblCounter.Text = (i + 1).ToString();
                }
            }
        }
    }
}
