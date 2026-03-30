namespace Task5
{
    public partial class MainForm : Form
    {
        private Slovar currentDictionary;
        private string currentFilePath;
        private bool isMainDictionary = false;
        public MainForm()
        {
            InitializeComponent();
            currentDictionary = new Slovar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentDictionary.LoadDictionary(ofd.FileName);
                        currentFilePath = ofd.FileName;
                        isMainDictionary = true;
                        RefreshDictionaryList();
                        statusLabel.Text = $"Loaded {currentDictionary.Count} words from {ofd.FileName}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading dictionary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void RefreshDictionaryList()
        {
            var allWords = currentDictionary.GetAllWords();
            listBoxWords.DataSource = allWords;
            statusLabel.Text += $" | Total words: {allWords.Count}";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentDictionary.SaveDictionary(sfd.FileName);
                        currentFilePath = sfd.FileName;
                        isMainDictionary = false;
                        statusLabel.Text = $"Dictionary saved to {sfd.FileName}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving dictionary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            currentDictionary = new Slovar();
            currentFilePath = null;
            isMainDictionary = false;
            RefreshDictionaryList();
            statusLabel.Text = "New empty dictionary created.";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (isMainDictionary)
            {
                MessageBox.Show("Cannot delete the main dictionary.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(currentFilePath) && File.Exists(currentFilePath))
            {
                var result = MessageBox.Show($"Are you sure you want to delete the file '{currentFilePath}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(currentFilePath);
                        currentDictionary = new Slovar();
                        currentFilePath = null;
                        isMainDictionary = false;
                        RefreshDictionaryList();
                        statusLabel.Text = "Dictionary file deleted.";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No dictionary file associated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string newWord = DictonaryText.Text.Trim();
            if (string.IsNullOrEmpty(newWord))
            {
                MessageBox.Show("Please enter a word.", "Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentDictionary.AddWord(newWord))
            {
                statusLabel.Text = $"Added '{newWord}'";
                RefreshDictionaryList();
                DictonaryText.Clear();
            }
            else
            {
                MessageBox.Show($"Word '{newWord}' already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedItem == null)
            {
                MessageBox.Show("Select a word to delete.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string word = listBoxWords.SelectedItem.ToString();
            if (currentDictionary.DeleteWord(word))
            {
                statusLabel.Text = $"Deleted '{word}'";
                RefreshDictionaryList();
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string prefix = DictonaryText.Text.Trim();
            var filtered = currentDictionary.GetWordsStartingWith(prefix);
            listBoxWords.DataSource = filtered;
        }

        private void FindWordmorph_Click(object sender, EventArgs e)
        {
            string pattern = WordmorphTextbox.Text.Trim();
            if (string.IsNullOrEmpty(pattern))
            {
                MessageBox.Show("Enter a word for word‑form search.", "Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = currentDictionary.FindWordForms(pattern);
            listBoxResults.DataSource = results;
            statusLabel.Text = $"Word‑form search found {results.Count} words.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = WordmorphTextbox.Text.Trim();
            if (string.IsNullOrEmpty(pattern))
            {
                MessageBox.Show("Enter a pattern for fuzzy search.", "Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = currentDictionary.FuzzySearch(pattern, 3);
            listBoxResults.DataSource = results;
            statusLabel.Text = $"Fuzzy search found {results.Count} words (Levenshtein ≤ 3).";
        }
    }
}
