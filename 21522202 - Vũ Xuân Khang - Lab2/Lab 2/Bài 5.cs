using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Net.NetworkInformation;


namespace Lab_2
{
    public partial class Bai_5 : Form
    {
        public Bai_5()
        {
            InitializeComponent();
        }
       
        
        string pathforZip;
        string fileNameforZip;
        string pathforExtract;
        string fileNameforExtract;
        private void bt_pathzip_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string filename = ofd.SafeFileName;
            pathforZip = System.IO.Path.GetDirectoryName(ofd.FileName);
            fileNameforZip = System.IO.Path.GetFileNameWithoutExtension(filename);
            string path = System.IO.Path.GetDirectoryName(ofd.FileName) + "\\" + filename;
            tb_pathtozip.Text = path;
        }
        
        private void bt_extractpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string filename = ofd.SafeFileName;
            //fileNameforExtract = filename;
            pathforExtract = System.IO.Path.GetDirectoryName(ofd.FileName);
            string path = System.IO.Path.GetDirectoryName(ofd.FileName) + "\\" + filename;
            tb_pathtoextract.Text = path;
        }

        private void bt_zip_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string sourceFile = tb_pathtozip.Text;
            string destinationFile = pathforZip + "\\" + fileNameforZip + ".zip" ;
            using(ZipArchive archive = ZipFile.Open(destinationFile, ZipArchiveMode.Create)) 
            {
                archive.CreateEntryFromFile(sourceFile, Path.GetFileName(sourceFile));
            }
            
            MessageBox.Show("Your file has been zipped!" + '\n' + "path: " + destinationFile);
        }

        private void bt_extract_Click(object sender, EventArgs e)
        {
            string zipFile = tb_pathtoextract.Text;
            string extractPath = pathforExtract;
            ZipFile.ExtractToDirectory(zipFile, extractPath);
            MessageBox.Show("Your file has been extracted!" + '\n' + "path: " + extractPath);
        }
    }
}
