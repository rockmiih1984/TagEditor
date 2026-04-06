namespace TagEditor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCover = new System.Windows.Forms.Panel();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.lblCoverHint = new System.Windows.Forms.Label();
            this.btnChangeCover = new System.Windows.Forms.Button();
            this.btnRemoveCover = new System.Windows.Forms.Button();
            this.panelFields = new System.Windows.Forms.Panel();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.lblComposer = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtDiscTotal = new System.Windows.Forms.TextBox();
            this.lblDiscTotal = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.lblDisc = new System.Windows.Forms.Label();
            this.txtTrackTotal = new System.Windows.Forms.TextBox();
            this.lblTrackTotal = new System.Windows.Forms.Label();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.lblTrack = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitleField = new System.Windows.Forms.Label();
            this.panelFile = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.panelFields.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 60, 114);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230);
            this.lblSubtitle.Location = new System.Drawing.Point(25, 52);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(265, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Edite metadados de arquivos de audio facilmente";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tag Editor Pro";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelMain.Controls.Add(this.panelCover);
            this.panelMain.Controls.Add(this.panelFields);
            this.panelMain.Controls.Add(this.panelFile);
            this.panelMain.Controls.Add(this.panelActions);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 90);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(984, 522);
            this.panelMain.TabIndex = 1;
            // 
            // panelCover
            // 
            this.panelCover.BackColor = System.Drawing.Color.White;
            this.panelCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCover.Controls.Add(this.picCover);
            this.panelCover.Controls.Add(this.lblCoverHint);
            this.panelCover.Controls.Add(this.btnChangeCover);
            this.panelCover.Controls.Add(this.btnRemoveCover);
            this.panelCover.Location = new System.Drawing.Point(23, 130);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(280, 320);
            this.panelCover.TabIndex = 2;
            // 
            // picCover
            // 
            this.picCover.BackColor = System.Drawing.Color.FromArgb(230, 235, 240);
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(15, 15);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(250, 250);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 0;
            this.picCover.TabStop = false;
            // 
            // lblCoverHint
            // 
            this.lblCoverHint.AutoSize = true;
            this.lblCoverHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCoverHint.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblCoverHint.Location = new System.Drawing.Point(45, 270);
            this.lblCoverHint.Name = "lblCoverHint";
            this.lblCoverHint.Size = new System.Drawing.Size(190, 15);
            this.lblCoverHint.TabIndex = 1;
            this.lblCoverHint.Text = "Clique para alterar ou remover capa";
            // 
            // btnChangeCover
            // 
            this.btnChangeCover.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnChangeCover.FlatAppearance.BorderSize = 0;
            this.btnChangeCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCover.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnChangeCover.ForeColor = System.Drawing.Color.White;
            this.btnChangeCover.Location = new System.Drawing.Point(15, 288);
            this.btnChangeCover.Name = "btnChangeCover";
            this.btnChangeCover.Size = new System.Drawing.Size(120, 28);
            this.btnChangeCover.TabIndex = 2;
            this.btnChangeCover.Text = "Alterar Capa";
            this.btnChangeCover.UseVisualStyleBackColor = false;
            this.btnChangeCover.Click += new System.EventHandler(this.btnChangeCover_Click);
            // 
            // btnRemoveCover
            // 
            this.btnRemoveCover.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnRemoveCover.FlatAppearance.BorderSize = 0;
            this.btnRemoveCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCover.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRemoveCover.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCover.Location = new System.Drawing.Point(145, 288);
            this.btnRemoveCover.Name = "btnRemoveCover";
            this.btnRemoveCover.Size = new System.Drawing.Size(120, 28);
            this.btnRemoveCover.TabIndex = 3;
            this.btnRemoveCover.Text = "Remover Capa";
            this.btnRemoveCover.UseVisualStyleBackColor = false;
            this.btnRemoveCover.Click += new System.EventHandler(this.btnRemoveCover_Click);
            // 
            // panelFields
            // 
            this.panelFields.BackColor = System.Drawing.Color.White;
            this.panelFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFields.Controls.Add(this.txtComposer);
            this.panelFields.Controls.Add(this.lblComposer);
            this.panelFields.Controls.Add(this.txtGenre);
            this.panelFields.Controls.Add(this.lblGenre);
            this.panelFields.Controls.Add(this.txtComment);
            this.panelFields.Controls.Add(this.lblComment);
            this.panelFields.Controls.Add(this.txtDiscTotal);
            this.panelFields.Controls.Add(this.lblDiscTotal);
            this.panelFields.Controls.Add(this.txtDisc);
            this.panelFields.Controls.Add(this.lblDisc);
            this.panelFields.Controls.Add(this.txtTrackTotal);
            this.panelFields.Controls.Add(this.lblTrackTotal);
            this.panelFields.Controls.Add(this.txtTrack);
            this.panelFields.Controls.Add(this.lblTrack);
            this.panelFields.Controls.Add(this.txtYear);
            this.panelFields.Controls.Add(this.lblYear);
            this.panelFields.Controls.Add(this.txtAlbum);
            this.panelFields.Controls.Add(this.lblAlbum);
            this.panelFields.Controls.Add(this.txtArtist);
            this.panelFields.Controls.Add(this.lblArtist);
            this.panelFields.Controls.Add(this.txtTitle);
            this.panelFields.Controls.Add(this.lblTitleField);
            this.panelFields.Location = new System.Drawing.Point(325, 20);
            this.panelFields.Name = "panelFields";
            this.panelFields.Size = new System.Drawing.Size(620, 430);
            this.panelFields.TabIndex = 1;
            // 
            // txtComposer
            // 
            this.txtComposer.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtComposer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComposer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComposer.Location = new System.Drawing.Point(20, 380);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(570, 25);
            this.txtComposer.TabIndex = 11;
            // 
            // lblComposer
            // 
            this.lblComposer.AutoSize = true;
            this.lblComposer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComposer.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblComposer.Location = new System.Drawing.Point(18, 362);
            this.lblComposer.Name = "lblComposer";
            this.lblComposer.Size = new System.Drawing.Size(76, 15);
            this.lblComposer.TabIndex = 10;
            this.lblComposer.Text = "COMPOSITOR";
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGenre.Location = new System.Drawing.Point(20, 320);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(275, 25);
            this.txtGenre.TabIndex = 9;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblGenre.Location = new System.Drawing.Point(18, 302);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(56, 15);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "GENERO";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComment.Location = new System.Drawing.Point(315, 320);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(275, 25);
            this.txtComment.TabIndex = 7;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComment.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblComment.Location = new System.Drawing.Point(313, 302);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(101, 15);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "COMENTARIO";
            // 
            // txtDiscTotal
            // 
            this.txtDiscTotal.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtDiscTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiscTotal.Location = new System.Drawing.Point(515, 260);
            this.txtDiscTotal.Name = "txtDiscTotal";
            this.txtDiscTotal.Size = new System.Drawing.Size(75, 25);
            this.txtDiscTotal.TabIndex = 5;
            // 
            // lblDiscTotal
            // 
            this.lblDiscTotal.AutoSize = true;
            this.lblDiscTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiscTotal.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblDiscTotal.Location = new System.Drawing.Point(513, 242);
            this.lblDiscTotal.Name = "lblDiscTotal";
            this.lblDiscTotal.Size = new System.Drawing.Size(64, 15);
            this.lblDiscTotal.TabIndex = 4;
            this.lblDiscTotal.Text = "DISC TOTAL";
            // 
            // txtDisc
            // 
            this.txtDisc.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDisc.Location = new System.Drawing.Point(430, 260);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(75, 25);
            this.txtDisc.TabIndex = 3;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDisc.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblDisc.Location = new System.Drawing.Point(428, 242);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(46, 15);
            this.lblDisc.TabIndex = 2;
            this.lblDisc.Text = "DISCO";
            // 
            // txtTrackTotal
            // 
            this.txtTrackTotal.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtTrackTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrackTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTrackTotal.Location = new System.Drawing.Point(315, 260);
            this.txtTrackTotal.Name = "txtTrackTotal";
            this.txtTrackTotal.Size = new System.Drawing.Size(75, 25);
            this.txtTrackTotal.TabIndex = 1;
            // 
            // lblTrackTotal
            // 
            this.lblTrackTotal.AutoSize = true;
            this.lblTrackTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrackTotal.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTrackTotal.Location = new System.Drawing.Point(313, 242);
            this.lblTrackTotal.Name = "lblTrackTotal";
            this.lblTrackTotal.Size = new System.Drawing.Size(82, 15);
            this.lblTrackTotal.TabIndex = 0;
            this.lblTrackTotal.Text = "FAIXAS TOTAL";
            // 
            // txtTrack
            // 
            this.txtTrack.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTrack.Location = new System.Drawing.Point(230, 260);
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size(75, 25);
            this.txtTrack.TabIndex = 1;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrack.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTrack.Location = new System.Drawing.Point(228, 242);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(70, 15);
            this.lblTrack.TabIndex = 0;
            this.lblTrack.Text = "N DA FAIXA";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtYear.Location = new System.Drawing.Point(20, 260);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(190, 25);
            this.txtYear.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblYear.Location = new System.Drawing.Point(18, 242);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 15);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "ANO";
            // 
            // txtAlbum
            // 
            this.txtAlbum.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlbum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAlbum.Location = new System.Drawing.Point(20, 200);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(570, 25);
            this.txtAlbum.TabIndex = 7;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAlbum.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblAlbum.Location = new System.Drawing.Point(18, 182);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(58, 15);
            this.lblAlbum.TabIndex = 6;
            this.lblAlbum.Text = "ALBUM";
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArtist.Location = new System.Drawing.Point(20, 140);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(570, 25);
            this.txtArtist.TabIndex = 5;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblArtist.Location = new System.Drawing.Point(18, 122);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(61, 15);
            this.lblArtist.TabIndex = 4;
            this.lblArtist.Text = "ARTISTA";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(20, 80);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(570, 25);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitleField
            // 
            this.lblTitleField.AutoSize = true;
            this.lblTitleField.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleField.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTitleField.Location = new System.Drawing.Point(18, 62);
            this.lblTitleField.Name = "lblTitleField";
            this.lblTitleField.Size = new System.Drawing.Size(58, 15);
            this.lblTitleField.TabIndex = 2;
            this.lblTitleField.Text = "TITULO";
            // 
            // panelFile
            // 
            this.panelFile.BackColor = System.Drawing.Color.White;
            this.panelFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFile.Controls.Add(this.lblFileName);
            this.panelFile.Controls.Add(this.btnBrowse);
            this.panelFile.Controls.Add(this.txtFilePath);
            this.panelFile.Controls.Add(this.lblFile);
            this.panelFile.Location = new System.Drawing.Point(23, 20);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(280, 95);
            this.panelFile.TabIndex = 0;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(100, 110, 125);
            this.lblFileName.Location = new System.Drawing.Point(15, 68);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(225, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 28);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtFilePath.Location = new System.Drawing.Point(15, 32);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(205, 23);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFile.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblFile.Location = new System.Drawing.Point(13, 14);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(121, 15);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "ARQUIVO DE AUDIO";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.Transparent;
            this.panelActions.Controls.Add(this.btnSave);
            this.panelActions.Controls.Add(this.btnCancel);
            this.panelActions.Location = new System.Drawing.Point(325, 460);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(620, 50);
            this.panelActions.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(370, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SALVAR TAGS";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(30, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(230, 235, 240);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 612);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(221, 17);
            this.toolStripStatus.Text = "Selecione um arquivo de audio para iniciar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 634);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 670);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag Editor Pro - Editor de Tags de Audio";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelCover.ResumeLayout(false);
            this.panelCover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.panelFields.ResumeLayout(false);
            this.panelFields.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Panel panelCover;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label lblCoverHint;
        private System.Windows.Forms.Button btnChangeCover;
        private System.Windows.Forms.Button btnRemoveCover;
        private System.Windows.Forms.Panel panelFields;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitleField;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtTrack;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.TextBox txtTrackTotal;
        private System.Windows.Forms.Label lblTrackTotal;
        private System.Windows.Forms.TextBox txtDiscTotal;
        private System.Windows.Forms.Label lblDiscTotal;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.Label lblComposer;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
    }
}
