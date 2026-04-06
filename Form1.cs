using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TagEditor
{
    public partial class Form1 : Form
    {
        private string _currentFilePath = string.Empty;
        private Image _currentCoverImage = null;
        private byte[] _currentCoverData = null;
        private bool _hasChanges = false;

        // Valores originais para cancelamento
        private string _origTitle, _origArtist, _origAlbum, _origYear;
        private string _origTrack, _origTrackTotal, _origDisc, _origDiscTotal;
        private string _origGenre, _origComment, _origComposer;

        public Form1()
        {
            InitializeComponent();
            SetupEvents();
        }

        private void SetupEvents()
        {
            // Marcar mudanças ao editar campos
            foreach (Control ctrl in panelFields.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                {
                    ctrl.TextChanged += (s, e) => _hasChanges = true;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Áudio|*.mp3;*.mp4;*.m4a;*.wav;*.ogg;*.flac;*.aiff;*.wma;*.ape|Todos os Arquivos|*.*";
                ofd.Title = "Selecionar Arquivo de Áudio";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadFile(ofd.FileName);
                }
            }
        }

        private void LoadFile(string filePath)
        {
            try
            {
                _currentFilePath = filePath;
                txtFilePath.Text = System.IO.Path.GetFileName(filePath);
                lblFileName.Text = filePath;

                using (TagLib.File tagFile = TagLib.File.Create(filePath))
                {
                    // Preencher campos com tags existentes
                    txtTitle.Text = tagFile.Tag.Title ?? string.Empty;
                    txtArtist.Text = string.Join("; ", tagFile.Tag.Performers);
                    txtAlbum.Text = tagFile.Tag.Album ?? string.Empty;
                    txtYear.Text = tagFile.Tag.Year > 0 ? tagFile.Tag.Year.ToString() : string.Empty;
                    
                    // Faixa e total
                    txtTrack.Text = tagFile.Tag.Track > 0 ? tagFile.Tag.Track.ToString() : string.Empty;
                    txtTrackTotal.Text = tagFile.Tag.TrackCount > 0 ? tagFile.Tag.TrackCount.ToString() : string.Empty;
                    
                    // Disco e total
                    txtDisc.Text = tagFile.Tag.Disc > 0 ? tagFile.Tag.Disc.ToString() : string.Empty;
                    txtDiscTotal.Text = tagFile.Tag.DiscCount > 0 ? tagFile.Tag.DiscCount.ToString() : string.Empty;
                    
                    // Outros campos
                    txtGenre.Text = string.Join("; ", tagFile.Tag.Genres);
                    txtComment.Text = tagFile.Tag.Comment ?? string.Empty;
                    txtComposer.Text = string.Join("; ", tagFile.Tag.Composers);

                    // Salvar valores originais
                    SaveOriginalValues();

                    // Carregar capa
                    LoadCoverArt(tagFile);
                }

                _hasChanges = false;
                toolStripStatus.Text = $"Arquivo carregado: {System.IO.Path.GetFileName(filePath)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o arquivo:\n{ex.Message}", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetFields();
            }
        }

        private void LoadCoverArt(TagLib.File tagFile)
        {
            if (tagFile.Tag.Pictures != null && tagFile.Tag.Pictures.Length > 0)
            {
                TagLib.IPicture pic = tagFile.Tag.Pictures[0];
                _currentCoverData = pic.Data.Data;

                using (MemoryStream ms = new MemoryStream(_currentCoverData))
                {
                    _currentCoverImage = Image.FromStream(ms);
                    picCover.Image = new Bitmap(_currentCoverImage);
                }
            }
            else
            {
                _currentCoverImage = null;
                _currentCoverData = null;
                picCover.Image = null;
            }
        }

        private void SaveOriginalValues()
        {
            _origTitle = txtTitle.Text;
            _origArtist = txtArtist.Text;
            _origAlbum = txtAlbum.Text;
            _origYear = txtYear.Text;
            _origTrack = txtTrack.Text;
            _origTrackTotal = txtTrackTotal.Text;
            _origDisc = txtDisc.Text;
            _origDiscTotal = txtDiscTotal.Text;
            _origGenre = txtGenre.Text;
            _origComment = txtComment.Text;
            _origComposer = txtComposer.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentFilePath) || !System.IO.File.Exists(_currentFilePath))
            {
                MessageBox.Show("Por favor, selecione um arquivo de áudio primeiro.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (TagLib.File tagFile = TagLib.File.Create(_currentFilePath))
                {
                    // Salvar tags básicas
                    tagFile.Tag.Title = txtTitle.Text.Trim();
                    tagFile.Tag.Performers = new string[] { txtArtist.Text.Trim() };
                    tagFile.Tag.Album = txtAlbum.Text.Trim();
                    
                    if (int.TryParse(txtYear.Text, out int year) && year > 0)
                        tagFile.Tag.Year = (uint)year;
                    else
                        tagFile.Tag.Year = 0;

                    // Faixa
                    if (uint.TryParse(txtTrack.Text, out uint track))
                        tagFile.Tag.Track = track;
                    else
                        tagFile.Tag.Track = 0;

                    if (uint.TryParse(txtTrackTotal.Text, out uint trackTotal))
                        tagFile.Tag.TrackCount = trackTotal;
                    else
                        tagFile.Tag.TrackCount = 0;

                    // Disco
                    if (uint.TryParse(txtDisc.Text, out uint disc))
                        tagFile.Tag.Disc = disc;
                    else
                        tagFile.Tag.Disc = 0;

                    if (uint.TryParse(txtDiscTotal.Text, out uint discTotal))
                        tagFile.Tag.DiscCount = discTotal;
                    else
                        tagFile.Tag.DiscCount = 0;

                    // Gênero, comentário, compositor
                    tagFile.Tag.Genres = string.IsNullOrWhiteSpace(txtGenre.Text) 
                        ? new string[0] 
                        : txtGenre.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    tagFile.Tag.Comment = txtComment.Text.Trim();
                    tagFile.Tag.Composers = string.IsNullOrWhiteSpace(txtComposer.Text)
                        ? new string[0]
                        : txtComposer.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                    // Salvar capa
                    if (_currentCoverData != null)
                    {
                        TagLib.Picture pic = new TagLib.Picture(_currentCoverData);
                        tagFile.Tag.Pictures = new TagLib.IPicture[] { pic };
                    }
                    else
                    {
                        tagFile.Tag.Pictures = new TagLib.IPicture[0];
                    }

                    // Salvar alterações no arquivo
                    tagFile.Save();
                }

                _hasChanges = false;
                SaveOriginalValues();
                toolStripStatus.Text = "Tags salvas com sucesso!";
                
                MessageBox.Show("Tags salvas com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar as tags:\n{ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatus.Text = "Erro ao salvar tags";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_hasChanges)
            {
                DialogResult result = MessageBox.Show(
                    "Deseja descartar as alterações não salvas?",
                    "Cancelar Alterações",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    RestoreOriginalValues();
                    _hasChanges = false;
                    toolStripStatus.Text = "Alterações descartadas";
                }
            }
        }

        private void RestoreOriginalValues()
        {
            txtTitle.Text = _origTitle;
            txtArtist.Text = _origArtist;
            txtAlbum.Text = _origAlbum;
            txtYear.Text = _origYear;
            txtTrack.Text = _origTrack;
            txtTrackTotal.Text = _origTrackTotal;
            txtDisc.Text = _origDisc;
            txtDiscTotal.Text = _origDiscTotal;
            txtGenre.Text = _origGenre;
            txtComment.Text = _origComment;
            txtComposer.Text = _origComposer;
        }

        private void btnChangeCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os Arquivos|*.*";
                ofd.Title = "Selecionar Capa do Álbum";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _currentCoverImage = Image.FromFile(ofd.FileName);
                        picCover.Image = new Bitmap(_currentCoverImage);

                        // Converter para bytes
                        using (MemoryStream ms = new MemoryStream())
                        {
                            string ext = System.IO.Path.GetExtension(ofd.FileName).ToLower();
                            System.Drawing.Imaging.ImageFormat format = 
                                ext == ".png" ? System.Drawing.Imaging.ImageFormat.Png : 
                                System.Drawing.Imaging.ImageFormat.Jpeg;
                            
                            _currentCoverImage.Save(ms, format);
                            _currentCoverData = ms.ToArray();
                        }

                        _hasChanges = true;
                        toolStripStatus.Text = "Nova capa selecionada. Clique em Salvar para aplicar.";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar a imagem:\n{ex.Message}", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRemoveCover_Click(object sender, EventArgs e)
        {
            if (_currentCoverData != null)
            {
                DialogResult result = MessageBox.Show(
                    "Deseja remover a capa do álbum?",
                    "Remover Capa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _currentCoverImage?.Dispose();
                    _currentCoverImage = null;
                    _currentCoverData = null;
                    picCover.Image = null;
                    _hasChanges = true;
                    toolStripStatus.Text = "Capa removida. Clique em Salvar para aplicar.";
                }
            }
        }

        private void ResetFields()
        {
            txtFilePath.Text = string.Empty;
            lblFileName.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtArtist.Text = string.Empty;
            txtAlbum.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtTrack.Text = string.Empty;
            txtTrackTotal.Text = string.Empty;
            txtDisc.Text = string.Empty;
            txtDiscTotal.Text = string.Empty;
            txtGenre.Text = string.Empty;
            txtComment.Text = string.Empty;
            txtComposer.Text = string.Empty;
            picCover.Image = null;
            _currentCoverImage?.Dispose();
            _currentCoverImage = null;
            _currentCoverData = null;
            _currentFilePath = string.Empty;
            _hasChanges = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_hasChanges)
            {
                DialogResult result = MessageBox.Show(
                    "Existem alterações não salvas. Deseja salvar antes de sair?",
                    "Sair",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    btnSave_Click(this, EventArgs.Empty);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            _currentCoverImage?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
