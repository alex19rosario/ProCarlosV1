using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ProCarlosV1.Localization
{
    public static class ProCarlosV1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProCarlosV1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProCarlosV1LocalizationConfigurer).GetAssembly(),
                        "ProCarlosV1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
