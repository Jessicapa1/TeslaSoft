using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TeslaSoft.Localization
{
    public static class TeslaSoftLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TeslaSoftConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TeslaSoftLocalizationConfigurer).GetAssembly(),
                        "TeslaSoft.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
