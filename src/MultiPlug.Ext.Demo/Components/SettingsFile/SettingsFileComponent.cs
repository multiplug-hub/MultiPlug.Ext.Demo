using System;
using System.IO;
using MultiPlug.Ext.Demo.Models.Components.SettingsFile;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MultiPlug.Ext.Demo.Components.SettingsFile
{
    internal class SettingsFileComponent
    {
        private static SettingsFileComponent m_Instance = null;

        private string m_FilePath = string.Empty;

        internal static SettingsFileComponent Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new SettingsFileComponent();
                }
                return m_Instance;
            }
        }

        private SettingsFileComponent()
        {
            m_FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LocalSettings.json");
        }

        internal void Save(LocalSettingsModel theFileObject)
        {
            try
            {
                JsonSerializerSettings Settings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    Formatting = Formatting.Indented
                };

                JsonSerializer serializer = JsonSerializer.Create(Settings);
                serializer.NullValueHandling = NullValueHandling.Ignore;
                using (Stream stream = new FileStream(m_FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (StreamWriter sw = new StreamWriter(stream))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, theFileObject);

                }
            }
            catch (Exception)
            {

            }
        }

        internal LocalSettingsModel Load()
        {
            try
            {
                using (StreamReader file = new StreamReader(m_FilePath))
                {
                    using (JsonReader Reader = new JsonTextReader(file))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        return serializer.Deserialize<LocalSettingsModel>(Reader);
                    }
                }
            }
            catch (JsonReaderException)
            {
                return new LocalSettingsModel();
            }
            catch (Exception)
            {
                return new LocalSettingsModel();
            }
        }
    }
}
