using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace racman
{
    public partial class SaveFilesWindow : Form
    {
        public SaveFilesWindow()
        {
            InitializeComponent();
        }

        private string ip = AttachPS3Form.ip;
        private string user = AttachPS3Form.user;
        private string game = AttachPS3Form.game;

        private void SaveFilesWindow_Load(object sender, EventArgs e)
        {
            string a = $"ftp://{ip}/dev_hdd0/home/{user}/savedata/{game}_RC1_SAVEDATA_";

            /*Somehow download all 5 as efficient as possible
             *ftp://192.168.10.106/dev_hdd0/home/00000001/savedata/NPEA00385_RC1_SAVEDATA_A/
             *ftp://192.168.10.106/dev_hdd0/home/00000001/savedata/NPEA00385_RC1_SAVEDATA_B/
             *ftp://192.168.10.106/dev_hdd0/home/00000001/savedata/NPEA00385_RC1_SAVEDATA_C/
             *ftp://192.168.10.106/dev_hdd0/home/00000001/savedata/NPEA00385_RC1_SAVEDATA_D/
             *ftp://192.168.10.106/dev_hdd0/home/00000001/savedata/NPEA00385_RC1_SAVEDATA_E/
             */

            //func.UploadFile(blah,blah);
            //func.DownloadFile(blah,blah);


        }
    }
}
