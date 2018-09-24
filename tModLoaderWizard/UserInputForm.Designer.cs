namespace tModLoaderWizard {
    partial class UserInputForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpTerrariaExecutable = new System.Windows.Forms.TableLayoutPanel();
            this.txtTerrariaDirectory = new System.Windows.Forms.TextBox();
            this.btnTerrariaBrowse = new System.Windows.Forms.Button();
            this.lblTerrariaDirectory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLanguageVersion = new System.Windows.Forms.Label();
            this.txtWeakReferences = new System.Windows.Forms.TextBox();
            this.lblWeakReferences = new System.Windows.Forms.Label();
            this.txtBuildIgnore = new System.Windows.Forms.TextBox();
            this.lblBuildIgnore = new System.Windows.Forms.Label();
            this.txtHomepage = new System.Windows.Forms.TextBox();
            this.lblHomepage = new System.Windows.Forms.Label();
            this.txtModReferences = new System.Windows.Forms.TextBox();
            this.txtDllReferences = new System.Windows.Forms.TextBox();
            this.lblModReferences = new System.Windows.Forms.Label();
            this.lblDllReferences = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.tlpVersion = new System.Windows.Forms.TableLayoutPanel();
            this.numRevision = new System.Windows.Forms.NumericUpDown();
            this.numBuild = new System.Windows.Forms.NumericUpDown();
            this.numMinor = new System.Windows.Forms.NumericUpDown();
            this.numMajor = new System.Windows.Forms.NumericUpDown();
            this.cmbLanguageVersion = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkIncludePDB = new System.Windows.Forms.CheckBox();
            this.chkIncludeSource = new System.Windows.Forms.CheckBox();
            this.chkHideResources = new System.Windows.Forms.CheckBox();
            this.chkNoCompile = new System.Windows.Forms.CheckBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.cmbSide = new System.Windows.Forms.ComboBox();
            this.tlpForm.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpTerrariaExecutable.SuspendLayout();
            this.tlpVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMajor)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpForm.ColumnCount = 3;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpForm.Controls.Add(this.tlpButtons, 2, 16);
            this.tlpForm.Controls.Add(this.tlpTerrariaExecutable, 1, 14);
            this.tlpForm.Controls.Add(this.lblTerrariaDirectory, 0, 14);
            this.tlpForm.Controls.Add(this.lblDescription, 2, 0);
            this.tlpForm.Controls.Add(this.lblLanguageVersion, 0, 8);
            this.tlpForm.Controls.Add(this.txtWeakReferences, 1, 6);
            this.tlpForm.Controls.Add(this.lblWeakReferences, 0, 6);
            this.tlpForm.Controls.Add(this.txtBuildIgnore, 1, 7);
            this.tlpForm.Controls.Add(this.lblBuildIgnore, 0, 7);
            this.tlpForm.Controls.Add(this.txtHomepage, 1, 3);
            this.tlpForm.Controls.Add(this.lblHomepage, 0, 3);
            this.tlpForm.Controls.Add(this.txtModReferences, 1, 5);
            this.tlpForm.Controls.Add(this.txtDllReferences, 1, 4);
            this.tlpForm.Controls.Add(this.lblModReferences, 0, 5);
            this.tlpForm.Controls.Add(this.lblDllReferences, 0, 4);
            this.tlpForm.Controls.Add(this.lblVersion, 0, 2);
            this.tlpForm.Controls.Add(this.lblAuthor, 0, 1);
            this.tlpForm.Controls.Add(this.txtAuthor, 1, 1);
            this.tlpForm.Controls.Add(this.lblDisplayName, 0, 0);
            this.tlpForm.Controls.Add(this.txtDisplayName, 1, 0);
            this.tlpForm.Controls.Add(this.tlpVersion, 1, 2);
            this.tlpForm.Controls.Add(this.cmbLanguageVersion, 1, 8);
            this.tlpForm.Controls.Add(this.txtDescription, 2, 1);
            this.tlpForm.Controls.Add(this.chkIncludePDB, 1, 13);
            this.tlpForm.Controls.Add(this.chkIncludeSource, 1, 12);
            this.tlpForm.Controls.Add(this.chkHideResources, 1, 11);
            this.tlpForm.Controls.Add(this.chkNoCompile, 1, 10);
            this.tlpForm.Controls.Add(this.lblSide, 0, 9);
            this.tlpForm.Controls.Add(this.cmbSide, 1, 9);
            this.tlpForm.Location = new System.Drawing.Point(12, 12);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 17;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpForm.Size = new System.Drawing.Size(672, 425);
            this.tlpForm.TabIndex = 0;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnOK, 0, 0);
            this.tlpButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(416, 390);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(256, 35);
            this.tlpButtons.TabIndex = 58;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 29);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(131, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 29);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tlpTerrariaExecutable
            // 
            this.tlpTerrariaExecutable.ColumnCount = 2;
            this.tlpTerrariaExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tlpTerrariaExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpTerrariaExecutable.Controls.Add(this.txtTerrariaDirectory, 0, 0);
            this.tlpTerrariaExecutable.Controls.Add(this.btnTerrariaBrowse, 1, 0);
            this.tlpTerrariaExecutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTerrariaExecutable.Location = new System.Drawing.Point(160, 364);
            this.tlpTerrariaExecutable.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTerrariaExecutable.Name = "tlpTerrariaExecutable";
            this.tlpTerrariaExecutable.RowCount = 1;
            this.tlpTerrariaExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTerrariaExecutable.Size = new System.Drawing.Size(256, 26);
            this.tlpTerrariaExecutable.TabIndex = 57;
            // 
            // txtTerrariaDirectory
            // 
            this.txtTerrariaDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerrariaDirectory.Location = new System.Drawing.Point(3, 3);
            this.txtTerrariaDirectory.Name = "txtTerrariaDirectory";
            this.txtTerrariaDirectory.Size = new System.Drawing.Size(165, 20);
            this.txtTerrariaDirectory.TabIndex = 54;
            this.txtTerrariaDirectory.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Terraria";
            // 
            // btnTerrariaBrowse
            // 
            this.btnTerrariaBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTerrariaBrowse.Location = new System.Drawing.Point(174, 3);
            this.btnTerrariaBrowse.Name = "btnTerrariaBrowse";
            this.btnTerrariaBrowse.Size = new System.Drawing.Size(79, 20);
            this.btnTerrariaBrowse.TabIndex = 55;
            this.btnTerrariaBrowse.Text = "Browse...";
            this.btnTerrariaBrowse.UseVisualStyleBackColor = true;
            this.btnTerrariaBrowse.Click += new System.EventHandler(this.btnTerrariaBrowse_Click);
            // 
            // lblTerrariaDirectory
            // 
            this.lblTerrariaDirectory.AutoSize = true;
            this.lblTerrariaDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTerrariaDirectory.Location = new System.Drawing.Point(3, 364);
            this.lblTerrariaDirectory.Name = "lblTerrariaDirectory";
            this.lblTerrariaDirectory.Size = new System.Drawing.Size(154, 26);
            this.lblTerrariaDirectory.TabIndex = 56;
            this.lblTerrariaDirectory.Text = "Terraria Directory:";
            this.lblTerrariaDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(419, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(250, 26);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLanguageVersion
            // 
            this.lblLanguageVersion.AutoSize = true;
            this.lblLanguageVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLanguageVersion.Location = new System.Drawing.Point(3, 208);
            this.lblLanguageVersion.Name = "lblLanguageVersion";
            this.lblLanguageVersion.Size = new System.Drawing.Size(154, 26);
            this.lblLanguageVersion.TabIndex = 45;
            this.lblLanguageVersion.Text = "Language Version:";
            this.lblLanguageVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWeakReferences
            // 
            this.txtWeakReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWeakReferences.Location = new System.Drawing.Point(163, 159);
            this.txtWeakReferences.Name = "txtWeakReferences";
            this.txtWeakReferences.Size = new System.Drawing.Size(250, 20);
            this.txtWeakReferences.TabIndex = 9;
            // 
            // lblWeakReferences
            // 
            this.lblWeakReferences.AutoSize = true;
            this.lblWeakReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeakReferences.Location = new System.Drawing.Point(3, 156);
            this.lblWeakReferences.Name = "lblWeakReferences";
            this.lblWeakReferences.Size = new System.Drawing.Size(154, 26);
            this.lblWeakReferences.TabIndex = 42;
            this.lblWeakReferences.Text = "Weak References:";
            this.lblWeakReferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuildIgnore
            // 
            this.txtBuildIgnore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuildIgnore.Location = new System.Drawing.Point(163, 185);
            this.txtBuildIgnore.Name = "txtBuildIgnore";
            this.txtBuildIgnore.Size = new System.Drawing.Size(250, 20);
            this.txtBuildIgnore.TabIndex = 10;
            this.txtBuildIgnore.Text = "*.csproj, *.user, obj\\*, bin\\*, .vs\\*";
            // 
            // lblBuildIgnore
            // 
            this.lblBuildIgnore.AutoSize = true;
            this.lblBuildIgnore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuildIgnore.Location = new System.Drawing.Point(3, 182);
            this.lblBuildIgnore.Name = "lblBuildIgnore";
            this.lblBuildIgnore.Size = new System.Drawing.Size(154, 26);
            this.lblBuildIgnore.TabIndex = 40;
            this.lblBuildIgnore.Text = "Build Ignore:";
            this.lblBuildIgnore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHomepage
            // 
            this.txtHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHomepage.Location = new System.Drawing.Point(163, 81);
            this.txtHomepage.Name = "txtHomepage";
            this.txtHomepage.Size = new System.Drawing.Size(250, 20);
            this.txtHomepage.TabIndex = 6;
            // 
            // lblHomepage
            // 
            this.lblHomepage.AutoSize = true;
            this.lblHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHomepage.Location = new System.Drawing.Point(3, 78);
            this.lblHomepage.Name = "lblHomepage";
            this.lblHomepage.Size = new System.Drawing.Size(154, 26);
            this.lblHomepage.TabIndex = 38;
            this.lblHomepage.Text = "Homepage:";
            this.lblHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModReferences
            // 
            this.txtModReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModReferences.Location = new System.Drawing.Point(163, 133);
            this.txtModReferences.Name = "txtModReferences";
            this.txtModReferences.Size = new System.Drawing.Size(250, 20);
            this.txtModReferences.TabIndex = 8;
            // 
            // txtDllReferences
            // 
            this.txtDllReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDllReferences.Location = new System.Drawing.Point(163, 107);
            this.txtDllReferences.Name = "txtDllReferences";
            this.txtDllReferences.Size = new System.Drawing.Size(250, 20);
            this.txtDllReferences.TabIndex = 7;
            // 
            // lblModReferences
            // 
            this.lblModReferences.AutoSize = true;
            this.lblModReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModReferences.Location = new System.Drawing.Point(3, 130);
            this.lblModReferences.Name = "lblModReferences";
            this.lblModReferences.Size = new System.Drawing.Size(154, 26);
            this.lblModReferences.TabIndex = 9;
            this.lblModReferences.Text = "Mod References:";
            this.lblModReferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDllReferences
            // 
            this.lblDllReferences.AutoSize = true;
            this.lblDllReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDllReferences.Location = new System.Drawing.Point(3, 104);
            this.lblDllReferences.Name = "lblDllReferences";
            this.lblDllReferences.Size = new System.Drawing.Size(154, 26);
            this.lblDllReferences.TabIndex = 7;
            this.lblDllReferences.Text = "DLL References:";
            this.lblDllReferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(3, 52);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(154, 26);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version:";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Location = new System.Drawing.Point(3, 26);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(154, 26);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAuthor.Location = new System.Drawing.Point(163, 29);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(250, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplayName.Location = new System.Drawing.Point(3, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(154, 26);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Display Name:";
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisplayName.Location = new System.Drawing.Point(163, 3);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(250, 20);
            this.txtDisplayName.TabIndex = 0;
            // 
            // tlpVersion
            // 
            this.tlpVersion.ColumnCount = 4;
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVersion.Controls.Add(this.numRevision, 3, 0);
            this.tlpVersion.Controls.Add(this.numBuild, 2, 0);
            this.tlpVersion.Controls.Add(this.numMinor, 1, 0);
            this.tlpVersion.Controls.Add(this.numMajor, 0, 0);
            this.tlpVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVersion.Location = new System.Drawing.Point(160, 52);
            this.tlpVersion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVersion.Name = "tlpVersion";
            this.tlpVersion.RowCount = 1;
            this.tlpVersion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVersion.Size = new System.Drawing.Size(256, 26);
            this.tlpVersion.TabIndex = 3;
            // 
            // numRevision
            // 
            this.numRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numRevision.Location = new System.Drawing.Point(195, 3);
            this.numRevision.Name = "numRevision";
            this.numRevision.Size = new System.Drawing.Size(58, 20);
            this.numRevision.TabIndex = 5;
            // 
            // numBuild
            // 
            this.numBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBuild.Location = new System.Drawing.Point(131, 3);
            this.numBuild.Name = "numBuild";
            this.numBuild.Size = new System.Drawing.Size(58, 20);
            this.numBuild.TabIndex = 4;
            // 
            // numMinor
            // 
            this.numMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMinor.Location = new System.Drawing.Point(67, 3);
            this.numMinor.Name = "numMinor";
            this.numMinor.Size = new System.Drawing.Size(58, 20);
            this.numMinor.TabIndex = 3;
            // 
            // numMajor
            // 
            this.numMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMajor.Location = new System.Drawing.Point(3, 3);
            this.numMajor.Name = "numMajor";
            this.numMajor.Size = new System.Drawing.Size(58, 20);
            this.numMajor.TabIndex = 2;
            this.numMajor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbLanguageVersion
            // 
            this.cmbLanguageVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLanguageVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguageVersion.FormattingEnabled = true;
            this.cmbLanguageVersion.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.cmbLanguageVersion.Location = new System.Drawing.Point(163, 211);
            this.cmbLanguageVersion.Name = "cmbLanguageVersion";
            this.cmbLanguageVersion.Size = new System.Drawing.Size(250, 21);
            this.cmbLanguageVersion.Sorted = true;
            this.cmbLanguageVersion.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(419, 29);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.tlpForm.SetRowSpan(this.txtDescription, 14);
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(250, 358);
            this.txtDescription.TabIndex = 17;
            // 
            // chkIncludePDB
            // 
            this.chkIncludePDB.AutoSize = true;
            this.chkIncludePDB.Checked = true;
            this.chkIncludePDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludePDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkIncludePDB.Location = new System.Drawing.Point(163, 341);
            this.chkIncludePDB.Name = "chkIncludePDB";
            this.chkIncludePDB.Size = new System.Drawing.Size(250, 20);
            this.chkIncludePDB.TabIndex = 16;
            this.chkIncludePDB.Text = "Include debug information (PDB)";
            this.chkIncludePDB.UseVisualStyleBackColor = true;
            // 
            // chkIncludeSource
            // 
            this.chkIncludeSource.AutoSize = true;
            this.chkIncludeSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkIncludeSource.Location = new System.Drawing.Point(163, 315);
            this.chkIncludeSource.Name = "chkIncludeSource";
            this.chkIncludeSource.Size = new System.Drawing.Size(250, 20);
            this.chkIncludeSource.TabIndex = 15;
            this.chkIncludeSource.Text = "Include source";
            this.chkIncludeSource.UseVisualStyleBackColor = true;
            // 
            // chkHideResources
            // 
            this.chkHideResources.AutoSize = true;
            this.chkHideResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkHideResources.Location = new System.Drawing.Point(163, 289);
            this.chkHideResources.Name = "chkHideResources";
            this.chkHideResources.Size = new System.Drawing.Size(250, 20);
            this.chkHideResources.TabIndex = 14;
            this.chkHideResources.Text = "Hide resources";
            this.chkHideResources.UseVisualStyleBackColor = true;
            // 
            // chkNoCompile
            // 
            this.chkNoCompile.AutoSize = true;
            this.chkNoCompile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkNoCompile.Location = new System.Drawing.Point(163, 263);
            this.chkNoCompile.Name = "chkNoCompile";
            this.chkNoCompile.Size = new System.Drawing.Size(250, 20);
            this.chkNoCompile.TabIndex = 13;
            this.chkNoCompile.Text = "No compile";
            this.chkNoCompile.UseVisualStyleBackColor = true;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSide.Location = new System.Drawing.Point(3, 234);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(154, 26);
            this.lblSide.TabIndex = 51;
            this.lblSide.Text = "Side:";
            this.lblSide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSide
            // 
            this.cmbSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSide.FormattingEnabled = true;
            this.cmbSide.Items.AddRange(new object[] {
            "Both",
            "Client",
            "NoSync",
            "Server"});
            this.cmbSide.Location = new System.Drawing.Point(163, 237);
            this.cmbSide.Name = "cmbSide";
            this.cmbSide.Size = new System.Drawing.Size(250, 21);
            this.cmbSide.Sorted = true;
            this.cmbSide.TabIndex = 12;
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 449);
            this.Controls.Add(this.tlpForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tModLoader Template Wizard";
            this.Load += new System.EventHandler(this.UserInputForm_Load);
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpTerrariaExecutable.ResumeLayout(false);
            this.tlpTerrariaExecutable.PerformLayout();
            this.tlpVersion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMajor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TextBox txtModReferences;
        private System.Windows.Forms.TextBox txtDllReferences;
        private System.Windows.Forms.Label lblModReferences;
        private System.Windows.Forms.Label lblDllReferences;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtBuildIgnore;
        private System.Windows.Forms.Label lblBuildIgnore;
        private System.Windows.Forms.TextBox txtHomepage;
        private System.Windows.Forms.Label lblHomepage;
        private System.Windows.Forms.TextBox txtWeakReferences;
        private System.Windows.Forms.Label lblWeakReferences;
        private System.Windows.Forms.TableLayoutPanel tlpVersion;
        private System.Windows.Forms.NumericUpDown numMajor;
        private System.Windows.Forms.NumericUpDown numRevision;
        private System.Windows.Forms.NumericUpDown numBuild;
        private System.Windows.Forms.NumericUpDown numMinor;
        private System.Windows.Forms.Label lblLanguageVersion;
        private System.Windows.Forms.ComboBox cmbLanguageVersion;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.ComboBox cmbSide;
        private System.Windows.Forms.CheckBox chkIncludePDB;
        private System.Windows.Forms.CheckBox chkIncludeSource;
        private System.Windows.Forms.CheckBox chkHideResources;
        private System.Windows.Forms.CheckBox chkNoCompile;
        private System.Windows.Forms.TableLayoutPanel tlpTerrariaExecutable;
        private System.Windows.Forms.TextBox txtTerrariaDirectory;
        private System.Windows.Forms.Button btnTerrariaBrowse;
        private System.Windows.Forms.Label lblTerrariaDirectory;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}