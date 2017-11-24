using IniParser.NetStandard.Model;
using IniParser.NetStandard.Model.Configuration;

namespace IniParser.NetStandard.Parser
{

    public class ConcatenateDuplicatedKeysIniDataParser : IniDataParser
    {
        public new ConcatenateDuplicatedKeysIniParserConfiguration Configuration
        {
            get
            {
                return (ConcatenateDuplicatedKeysIniParserConfiguration)base.Configuration;
            }
            set
            {
                base.Configuration = value;
            }
        }

        public ConcatenateDuplicatedKeysIniDataParser()
            :this(new ConcatenateDuplicatedKeysIniParserConfiguration())
        {}

        public ConcatenateDuplicatedKeysIniDataParser(ConcatenateDuplicatedKeysIniParserConfiguration parserConfiguration)
            :base(parserConfiguration)
        {}

        protected override void HandleDuplicatedKeyInCollection(string key, string value, KeyDataCollection keyDataCollection, string sectionName)
        {
            keyDataCollection[key] += Configuration.ConcatenateSeparator + value;
        }
    }

}
