using DeepL;
using DeepL.Model;
using System.Collections;
using System.Resources;

namespace ResxManager
{
    public class ResxEngine
    {
        private Translator _translator;
        private static Dictionary<string, string> _resourceDataSet = new Dictionary<string, string>();
        private ResXResourceWriter _resourceWriter;
        private static ResXResourceReader _resourceReader;

        /// <summary>
        /// Engine that translates source files using DeepL infrastructure.
        /// </summary>
        /// <param name="apiKey">API key required to use the DeepL API.</param>
        public ResxEngine(string apiKey)
        {
            _translator = new Translator(apiKey);
        }

        /// <summary>
        /// Retrieves data from the source resource file.
        /// </summary>
        /// <param name="sourceResourceFileName">Name of the source resource file.</param>
        private static void GetSourceData(string sourceResourceFileName)
        {
            _resourceDataSet.Clear();
            _resourceReader = new ResXResourceReader(sourceResourceFileName);
            foreach (DictionaryEntry entry in _resourceReader)
            {
                _resourceDataSet.Add(entry.Key.ToString(), entry.Value.ToString());
            }
        }

        /// <summary>
        /// Creates a new language file from the resource file.
        /// </summary>
        /// <param name="sourceResourceFileName">Name of the source resource file.</param>
        /// <param name="targetResourceFileName">Name of the file to be created.</param>
        /// <param name="sourceCulture">Culture of the source file, e.g. "en-US, en, es, fr".</param>
        /// <param name="targetCulture">Culture of the file to be created, e.g. "en-US, en, es, fr"</param>
        public async Task CreateTranlatedResourceFile(string sourceResourceFileName, string targetResourceFileName, string sourceCulture, string targetCulture)
        {
            GetSourceData(sourceResourceFileName);
            _resourceWriter = new ResXResourceWriter(targetResourceFileName);
            foreach (var row in _resourceDataSet)
            {
                TextResult translateResult = await _translator.TranslateTextAsync(row.Value, sourceCulture, targetCulture);
                _resourceWriter.AddResource(row.Key, translateResult.Text);
            }
            _resourceWriter.Generate();
        }

        /// <summary>
        /// Creates new language files from the resource file.
        /// </summary>
        /// <param name="sourceResourceFileName">Name of the source resource file.</param>
        /// <param name="sourceCulture">Culture of the source file, e.g. "en-US, en, es, fr".</param>
        /// <param name="targetLanguages">This parameter specifies the culture and path of the files to be created. The key specifies the culture, the value specifies the path.</param>
        public async Task CreateTranlatedResourceFiles(string sourceResourceFileName, string sourceCulture, Dictionary<string, string> targetLanguages)
        {
            foreach (var targetLanguage in targetLanguages)
            {
                await CreateTranlatedResourceFile(sourceResourceFileName, targetLanguage.Value, sourceCulture, targetLanguage.Key);
            }
        }

        /// <summary>
        /// Returns a dictionary of all keys and values in the resource file.
        /// </summary>
        /// <param name="sourceResourceFileName">Name of the resource file.</param>
        public static Dictionary<string, string> GetAllSourceFileStrings(string sourceResourceFileName)
        {
            GetSourceData(sourceResourceFileName);
            return _resourceDataSet;
        }

        /// <summary>
        /// Returns the value of the entered key as a string.
        /// </summary>
        /// <param name="sourceResourceFileName">Name of the resource file.</param>
        /// <param name="key">Name of the key in the resource file.</param>
        public static string GetSourceFileString(string sourceResourceFileName, string key)
        {
            GetAllSourceFileStrings(sourceResourceFileName);
            return _resourceDataSet.Single(e => e.Key == key).Value;
        }
    }
}
