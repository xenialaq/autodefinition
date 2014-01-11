namespace Auto_Definition
{
    internal class Entry
    {
        private string Chinese;
        private string English;
        private int attr_frequency;

        public void Update(string chnToUp, string engToUp, int frequencyToUp)
        {
            Chinese = chnToUp; English = engToUp; attr_frequency = frequencyToUp;
        }

        public void Update(string chnToUp, int frequencyToUp)
        {
            Chinese = chnToUp; attr_frequency = frequencyToUp;
        }

        public void Update(int frequencyToUp)
        {
            attr_frequency = frequencyToUp;
        }

        public string GetChinese()
        {
            return Chinese;
        }

        public string GetEnglish()
        {
            return English;
        }

        public int GetFrequency()
        {
            return attr_frequency;
        }

        public Entry(string chineseString, string englishString, int frequency)//constructors only apply to new, not in array
        {
            Chinese = chineseString;
            English = englishString;
            attr_frequency = frequency;
        }

        public Entry(string chineseString, string englishString)
        {
            Chinese = chineseString;
            English = englishString;
            attr_frequency = 1;
        }

        public Entry()
        {
            Chinese = "";
            English = "";
            attr_frequency = 0;
        }

        private string remove_prefix(string word)
        {
            if ((word.StartsWith("un") || word.StartsWith("in") || word.StartsWith("im")) && word.Length > 5)
                return word.Substring(2, word.Length - 2);
            else
                return word;
        }

        private bool is_adj(string word)
        {
            string baseWord = remove_prefix(word);
            return English.EndsWith("able") || English.EndsWith("ible") || English.EndsWith("ful") || English.EndsWith("ional") || English.EndsWith("cial") || English.EndsWith("istic");
        }

        private bool is_noun(string word)
        {
            string baseWord = remove_prefix(word);
            return baseWord.EndsWith("ion") || baseWord.EndsWith("nce") || baseWord.EndsWith("ncy") || baseWord.EndsWith("ism") || baseWord.EndsWith("er") || baseWord.EndsWith("or") || baseWord.EndsWith("logy") || baseWord.EndsWith("ness");
        }

        private bool is_verb(string word)
        {
            string baseWord = remove_prefix(word);
            return English.EndsWith("ize") || English.EndsWith("ise");
        }

        public string guessPartOfSpeech()
        {
            if (English.Length < 7 || English.Contains(" "))
                return "NA";

            else if (is_adj(English))
                return "adj";
            else if (is_noun(English))
                return "noun";
            else if (is_verb(English))
                return "verb";
            else if (English.EndsWith("ily") || English.EndsWith("ward"))
                return "adv";
            else if (English.EndsWith("ion"))
                return "n";

            else
                return "NA";
        }
    }
}