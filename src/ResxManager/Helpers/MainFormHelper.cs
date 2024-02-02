using ResxManager.Models;

namespace ResxManager.Helpers
{
    public static class MainFormHelper
    {
        /// <summary>
        /// Fills the combobox with the languages supported by DeepL.
        /// </summary>
        /// <param name="comboBox">Combobox to fill.</param>
        public static void LoadSupportedCulturesToComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = FillSupportedCultures();
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        /// <summary>
        /// Fills the datagridview combobox with the languages supported by DeepL.
        /// </summary>
        /// <param name="comboBox">Combobox to fill.</param>
        public static void LoadSupportedCulturesToComboBox(DataGridViewComboBoxColumn comboBox)
        {
            comboBox.DataSource = FillSupportedCultures();
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        /// <summary>
        /// Returns the languages supported by DeepL in List type.
        /// </summary>
        private static List<ObjectItem> FillSupportedCultures()
        {
            return new List<ObjectItem>
            {
                new ObjectItem{Key="bg",Value="Bulgarian bg"},
                new ObjectItem{Key="cs",Value="Czech cs"},
                new ObjectItem{Key="da",Value="Danish da"},
                new ObjectItem{Key="de",Value="German de"},
                new ObjectItem{Key="el",Value="Greek el"},
                new ObjectItem{Key="en-GB",Value="English(British) en-GB"},
                new ObjectItem{Key="en-US",Value="English(USA) en-US"},
                new ObjectItem{Key="es",Value="Spanish es"},
                new ObjectItem{Key="et",Value="Estonian et"},
                new ObjectItem{Key="fi",Value="Finnish fi"},
                new ObjectItem{Key="fr",Value="French fr"},
                new ObjectItem{Key="hu",Value="Hungarian hu"},
                new ObjectItem{Key="id",Value="Indonesian id"},
                new ObjectItem{Key="it",Value="Italian ite"},
                new ObjectItem{Key="ja",Value="Japanese ja"},
                new ObjectItem{Key="ko",Value="Korean ko"},
                new ObjectItem{Key="lt",Value="Lithuanian lt"},
                new ObjectItem{Key="lv",Value="Latvian lv"},
                new ObjectItem{Key="nb",Value="Norwegian nb"},
                new ObjectItem{Key="nl",Value="Dutch nl"},
                new ObjectItem{Key="pl",Value="Polish pl"},
                new ObjectItem{Key="pt-BR",Value="Porteguese(Brazilian) pt-BR"},
                new ObjectItem{Key="pt-PT",Value="Portuguese(European) pt-PT"},
                new ObjectItem{Key="ro",Value="Romanian ro"},
                new ObjectItem{Key="ru",Value="Russian ru"},
                new ObjectItem{Key="sk",Value="Slovak sk"},
                new ObjectItem{Key="sl",Value="Slovenian sl"},
                new ObjectItem{Key="sv",Value="Swedish sv"},
                new ObjectItem{Key="tr",Value="Turkish tr"},
                new ObjectItem{Key="uk",Value="Ukrainian uk"},
                new ObjectItem{Key="zh",Value="Chinese zh"},
            };
        }
    }
}
