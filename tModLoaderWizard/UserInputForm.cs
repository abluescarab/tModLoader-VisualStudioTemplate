using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace tModLoaderWizard {
    public partial class UserInputForm : Form {
        public static List<Tuple<string, string>> parameters;

        public UserInputForm() {
            InitializeComponent();
        }

        private void UserInputForm_Load(object sender, EventArgs e) {
            parameters = new List<Tuple<string, string>>();
            cmbLanguageVersion.SelectedIndex = 0;
            cmbSide.SelectedIndex = 0;
            txtAuthor.Text = Environment.UserName;
        }

        public DialogResult ShowDialog(string safeProjectName) {
            txtDisplayName.Text = safeProjectName;
            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            parameters.Add(new Tuple<string, string>("$displayname$", txtDisplayName.Text));
            parameters.Add(new Tuple<string, string>("$author$", txtAuthor.Text));
            parameters.Add(new Tuple<string, string>("$version$", numMajor.Value + "." + numMinor.Value + "." + numBuild.Value + "." + numRevision.Value));
            parameters.Add(new Tuple<string, string>("$homepage$", txtHomepage.Text));
            parameters.Add(new Tuple<string, string>("$dllreferences$", txtDllReferences.Text));
            parameters.Add(new Tuple<string, string>("$modreferences$", txtModReferences.Text));
            parameters.Add(new Tuple<string, string>("$weakreferences$", txtWeakReferences.Text));
            parameters.Add(new Tuple<string, string>("$buildignore$", txtBuildIgnore.Text));
            parameters.Add(new Tuple<string, string>("$languageversion$", cmbLanguageVersion.GetItemText(cmbLanguageVersion.SelectedItem)));
            parameters.Add(new Tuple<string, string>("$side$", cmbSide.GetItemText(cmbSide.SelectedItem)));
            parameters.Add(new Tuple<string, string>("$nocompile$", chkNoCompile.Checked.ToString().ToLower()));
            parameters.Add(new Tuple<string, string>("$hidecode$", (!chkIncludeSource.Checked).ToString().ToLower()));
            parameters.Add(new Tuple<string, string>("$hideresources$", chkHideResources.Checked.ToString().ToLower()));
            parameters.Add(new Tuple<string, string>("$includesource$", chkIncludeSource.Checked.ToString().ToLower()));
            parameters.Add(new Tuple<string, string>("$includepdb$", chkIncludePDB.Checked.ToString().ToLower()));
            parameters.Add(new Tuple<string, string>("$workingdirectory$", txtTerrariaDirectory.Text));
            parameters.Add(new Tuple<string, string>("$description$", txtDescription.Text));

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            parameters.Clear();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnTerrariaBrowse_Click(object sender, EventArgs e) {
            using(CommonOpenFileDialog dlg = new CommonOpenFileDialog {
                InitialDirectory = txtTerrariaDirectory.Text,
                DefaultDirectory = txtTerrariaDirectory.Text,
                IsFolderPicker = true,
                Multiselect = false,
                Title = "Select Terraria directory",
                RestoreDirectory = true
            }) {
                if(dlg.ShowDialog() == CommonFileDialogResult.Ok) {
                    txtTerrariaDirectory.Text = dlg.FileName;
                }
            }
        }
    }
}
