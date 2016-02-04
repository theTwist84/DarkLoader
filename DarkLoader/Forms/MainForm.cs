using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SigScan.Classes;
using System.Net;
using Newtonsoft.Json;
namespace DarkLoader
{
    public partial class MainForm : Form
    {
        public static Process Game;
        public static bool HaloIsRunning = false;

        //Lets keep the previous scan in memory so only the first scan is slow.
        IntPtr pAddr;
        IntPtr MpPatchAddr;

        bool WeRunningYup = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogFile.WriteToLog("Started RogueLoader");

            LaunchArgumentsForm.Text = RogueLoader.Properties.Settings.Default.LaunchArgs;
            GameName.Text = RogueLoader.Properties.Settings.Default.GameName;
            Thread loadPatches = new Thread(MagicPatches.LoadPatches);
            loadPatches.Start();
        }

        private void CheckForUpdates()
        {
            var url = "https://raw.githubusercontent.com/no1dead/RogueLoader/master/RogueLoader-Versions.json";
            try
            {
                var versionJson = (new WebClient()).DownloadString(url);
                FileVersions.NewFiles = JsonConvert.DeserializeObject<FileVersions.Files>(versionJson);
                FileVersions.OldFiles = JsonConvert.DeserializeObject<FileVersions.Files>(File.ReadAllText("RogueLoader-Versions.json"));
                FileVersions.File file = FileVersions.FindNewByFilename("RogueLoader.exe");
                Version newVersion = Version.Parse(file.version);
                Version currentVersion = Version.Parse(Application.ProductVersion);
                if (currentVersion < newVersion)
                {
                    this.Invoke(new MethodInvoker(delegate { this.Text = "RogueLoader - Update Available!"; }));

                    DialogResult result1 = MessageBox.Show("There's a new version of RogueLoader available. Would you like to download it?", "Oh goody!", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        Process.Start(file.url);
                    }
                }

                FileVersions.File patchesNew = FileVersions.FindNewByFilename("RogueLoader-Patches.json");
                FileVersions.File patchesOld = FileVersions.FindOldByFilename("RogueLoader-Patches.json");

                if (Convert.ToInt32(patchesNew.version) > Convert.ToInt32(patchesOld.version))
                {
                    DialogResult result1 = MessageBox.Show("There's new patches available for RogueLoader. Would you like to download them?", "Oh goody!", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to download the latest Patch File? This will overwrite any changes you've made! If you haven't made any, you'll be fine. If you have, please backup your changes before hitting OK.", "Replace Patches?", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Program.GetLatestPatchJson(true);
                        }
                    }
                }
            }
            catch (Exception e) {
            }
        }



        IntPtr PtrMapName;
        IntPtr PtrMapReset;
        IntPtr PtrMapTime;
        IntPtr PtrMapType;
        IntPtr PtrGameType;
        IntPtr PtrMpPatch;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            WeRunningYup = false;
        }


        private void LaunchGeme_click(object sender, EventArgs e)
        {
            LaunchGame();
        }

        private void LaunchGame()
        {
            var rogueProcesses = Process.GetProcesses().Where(pr => pr.ProcessName.Contains("_rogued"));

            foreach (var process in rogueProcesses)
            {
                process.Kill();
                process.WaitForExit();
            }

            //Set Variables so game can launch through RogueLoader
            Game.StartInfo.FileName = GameName.Text + ".exe";
            Game.StartInfo.WorkingDirectory = Application.StartupPath;
            Game.StartInfo.Arguments = LaunchArgumentsForm.Text;
            Game.Start();


            //Freeze process to allow startup patches to be run.
            Thread.Sleep(3000);
            Memory.SuspendProcess(Game.Id);
            MagicPatches.RunStartupPatches();
            Memory.ResumeProcess(Game.Id);

            //Run Exe Patches and save to file with a _rogued suffix.
            byte[] GameMagicExe = File.ReadAllBytes(Application.StartupPath + @"\" + GameName.Text + ".exe");
            string tmpExe = Path.Combine(Application.StartupPath, GameName.Text + "_rogued.exe");
            MagicPatches.ExePatches(GameMagicExe);
            File.WriteAllBytes(tmpExe, GameMagicExe);
            }


        PatchEditor patchy;
        private void btnPatchEditor_click(object sender, EventArgs e)
        {

            if (!PatchEditor.FormShowing)
            {
                patchy = new PatchEditor();
                patchy.Show();
            }
            else
            {
                patchy.Focus();
            }
        }

        private void LaunchArgumentsForm_TextChanged(object sender, EventArgs e)
        {
            RogueLoader.Properties.Settings.Default.LaunchArgs = LaunchArgumentsForm.Text;
        }

        private void GameName_TextChanged(object sender, EventArgs e)
        {
            RogueLoader.Properties.Settings.Default.GameName = GameName.Text;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            LogFile.WriteToLog("Saved Settings!");
            RogueLoader.Properties.Settings.Default.Save();
        }
    }
}