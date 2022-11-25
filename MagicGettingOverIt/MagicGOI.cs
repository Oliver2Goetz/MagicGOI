using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;

namespace MagicGettingOverIt {

    public partial class MagicGOI : Form {

        private static String magicRoot = "";
        private static String savefileDirectory = "";

        private static String registryPath = @"HKEY_CURRENT_USER\SOFTWARE\Bennett Foddy\Getting Over It";

        public MagicGOI() {
            InitializeComponent();
        }

        private void MagicGettingOverIt_Load(object sender, EventArgs e) {
            this.setMagicRoot();
            this.initializeSavefileDirectory();
            this.refreshSavefiles();
        }

        private void setMagicRoot() {
            magicRoot = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MagicGettingOverIt";
        }

        private void initializeSavefileDirectory() {
            if(!Directory.Exists(magicRoot)) {
                Directory.CreateDirectory(magicRoot);
            }

            savefileDirectory = magicRoot + "\\" + "savefiles";
            if(!Directory.Exists(savefileDirectory)) {
                Directory.CreateDirectory(savefileDirectory);
            }
        }

        #region form

        // Make window moveable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MagicCSGO_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /*
         * Exit form on click
         */
        private void pictureboxExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion form

        #region savefile management

        private void buttonSavefileLoad_Click(object sender, EventArgs e) {
            if (comboboxSaves.SelectedIndex != -1) {
                string selected = (string)comboboxSaves.SelectedItem;

                if (0 < selected.Length) {
                    try {
                        string filename0 = selected + "_0.xml";
                        string filename1 = selected + "_1.xml";

                        byte[] savefileContent0 = File.ReadAllBytes(savefileDirectory + "\\" + filename0);
                        byte[] savefileContent1 = File.ReadAllBytes(savefileDirectory + "\\" + filename1);

                        if (0 < savefileContent0.Length && 0 < savefileContent1.Length) {
                            this.changeRegistryEntry("SaveGame0_h1867918426", savefileContent0);
                            this.changeRegistryEntry("SaveGame1_h1867918427", savefileContent1);
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Error loading savefile.", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void buttonSavefileSave_Click(object sender, EventArgs e) {
            string savefileName = textboxSavefileName.Text;

            if(0 < savefileName.Length) {
                try {
                    String newSavefilePath0 = savefileName + "_0.xml";
                    String newSavefilePath1 = savefileName + "_1.xml";

                    byte[] bytesFile0 = this.readFromRegistry("SaveGame0_h1867918426");
                    byte[] bytesFile1 = this.readFromRegistry("SaveGame1_h1867918427");

                    File.WriteAllBytes(savefileDirectory + "\\" + newSavefilePath0, bytesFile0);
                    File.WriteAllBytes(savefileDirectory + "\\" + newSavefilePath1, bytesFile1);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error saving savefile.", MessageBoxButtons.OK);
                }
            }

            refreshSavefiles();
        }

        private void buttonSavefilesRefresh_Click(object sender, EventArgs e) {
            this.refreshSavefiles();
        }

        private void buttonSavefileDelete_Click(object sender, EventArgs e) {
            string selected = (string)comboboxSaves.SelectedItem;

            string filename0 = selected + "_0.xml";
            string filename1 = selected + "_1.xml";

            try {
                File.Delete(savefileDirectory + "\\" + filename0);
                File.Delete(savefileDirectory + "\\" + filename1);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error deleting savefile.", MessageBoxButtons.OK);
            }

            this.refreshSavefiles();
        }

        /*
         * Refreshs the list of savefiles in the combobox
         */
        private void refreshSavefiles() {
            string[] savefiles = Directory.GetFiles(savefileDirectory);

            comboboxSaves.SelectedIndex = -1;
            comboboxSaves.Items.Clear();
            foreach (string savefile in savefiles) {
                string basename = Path.GetFileName(savefile);
                string strippedBasename = basename.Replace("_0.xml", "").Replace("_1.xml", "");
                if (!comboboxSaves.Items.Contains(strippedBasename)) {
                    comboboxSaves.Items.Add(strippedBasename);
                }
            }
        }

        #endregion savefile management

        #region registry handling

        /*
         * Reads the value from the windows registry for the given path and key
         */
        public byte[] readFromRegistry(String key) {
            return (byte[])Registry.GetValue(registryPath, key, new object());
        }

        /*
         * Changes a value in the windows registry for the given path and key
         */
        public void changeRegistryEntry(String key, byte[] value) {
            Registry.SetValue(registryPath, key, value, RegistryValueKind.Binary);
        }

        #endregion registry handling

    }
}
