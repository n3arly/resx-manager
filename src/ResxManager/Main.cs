using ResxManager.Helpers;
using System.Reflection;

namespace ResxManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Events
        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                GetButtonValidateFields();
                keyValueGrid.Rows.Clear();
                if (txtKey.Enabled)
                {
                    string value = ResxEngine.GetSourceFileString(txtReadResourceFile.Text, txtKey.Text);
                    AddNewRow(txtKey.Text, value);
                }
                else
                {
                    Dictionary<string, string> allStrings = ResxEngine.GetAllSourceFileStrings(txtReadResourceFile.Text);

                    foreach (var item in allStrings)
                    {
                        AddNewRow(item.Key, item.Value);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void rdbOneKey_Click(object sender, EventArgs e) => txtKey.Enabled = true;

        private void rdbAllKeys_Click(object sender, EventArgs e) => txtKey.Enabled = false;

        private void Main_Load(object sender, EventArgs e)
        {
            MainFormHelper.LoadSupportedCulturesToComboBox(cmbSupportedCultures);
            MainFormHelper.LoadSupportedCulturesToComboBox(gridCmbCulture);
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                btnGenerate.Enabled = false;
                GenerateButtonValidateFields();
                ResxEngine engine = new ResxEngine(AppSettingsHelper.ApiKey);
                Dictionary<string, string> targetLangauges = new Dictionary<string, string>();
                foreach (DataGridViewRow row in languagesToCreateGrid.Rows)
                {
                    if (languagesToCreateGrid.Rows.Count != row.Index + 1)
                    {
                        targetLangauges.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                        createProgressBar.Increment(100 / (languagesToCreateGrid.Rows.Count - 1));
                    }
                }
                await engine.CreateTranlatedResourceFiles(txtCreateResourceFile.Text, cmbSupportedCultures.SelectedValue.ToString(), targetLangauges);
                MessageBox.Show("Generating completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                btnGenerate.Enabled = true;
                createProgressBar.Value = 0;
            }
        }
        #endregion

        #region Custom Private Members
        private void AddNewRow(string key, string value)
        {
            int index = keyValueGrid.Rows.Add();
            keyValueGrid.Rows[index].Cells["Key"].Value = key;
            keyValueGrid.Rows[index].Cells["Value"].Value = value;
        }
        #endregion

        #region Validators
        private void GetButtonValidateFields()
        {
            if (string.IsNullOrEmpty(txtReadResourceFile.Text))
                throw new Exception("Invalid resource file.");

            if (txtKey.Enabled && string.IsNullOrEmpty(txtKey.Text))
                throw new Exception("Key cannot be empty.");
        }

        private void GenerateButtonValidateFields()
        {
            if (string.IsNullOrEmpty(txtCreateResourceFile.Text))
                throw new Exception("Invalid resource file.");

            if (languagesToCreateGrid.Rows.Count == 0)
                throw new Exception("Add languages to create to grid.");
            else
            {
                foreach (DataGridViewRow row in languagesToCreateGrid.Rows)
                {
                    if (row.Index + 1 != languagesToCreateGrid.Rows.Count && (row.Cells[0].Value == null || row.Cells[1].Value == null))
                        throw new Exception("Culture and Path cannot be empty.");
                }
            }

        }
        #endregion
    }
}
