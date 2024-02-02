# Resx Manager
---
This tool, together with the AI-based translation application DeepL, is used to develop multilingual applications on .Net, translates source files, creates new source language files or displays language files directly.

### Used Technologies
- .NET 7 
- Windows Form Application
- [DeepL.net 1.8](https://www.nuget.org/packages/DeepL.net/1.8.0)

### Application Configuration
This section only contains the DeepL API key for translating using the DeepL infrastructure. You can use the tool by updating the ApiKey value in the appSettings.json file in the build directory with your own. [Click](https://www.deepl.com/en/pro-api) For DeepL API
```json
{
  "ApiKey": "Your ApiKey"
}
```

### For Developers
All explanations about the methods, variables, etc. used are in the source code.

## Application Tabs
---
### Create
By specifying the path and culture of the source file, the file can be translated into the desired languages with AI. The grid on the screen should contain the languages and paths into which the source file will be translated.
### Read
After specifying the location of the source file, it allows you to read all the data in it or only the desired data.
