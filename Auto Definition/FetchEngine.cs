using System.Net;

namespace Auto_Definition
{
    internal class FetchEngine
    {
        private static string fetchRaw(string urlStr)
        {
            string raw;
            WebClient myWebClient = new WebClient();

            byte[] myDataBuffer = myWebClient.DownloadData(urlStr);//connection failure may happen

            raw = System.Text.Encoding.UTF8.GetString(myDataBuffer);

            myWebClient.Dispose();
            return raw;
        }

        private static string filterDef(string rawStr)
        {
            try
            {
                if (rawStr.Contains("要查找"))
                    return "!Not Found";

                string resultStr;
                rawStr = rawStr.Substring(rawStr.IndexOf("s=\"w"));

                //first crop header
                if (rawStr.Contains("v><d"))
                {//most common
                    int startPos = rawStr.IndexOf("v><d");
                    rawStr = rawStr.Remove(0, startPos + 7);
                }
                else
                {//see 'antemundane'
                    int startPos = rawStr.IndexOf("<d");
                    rawStr = rawStr.Remove(0, startPos + 5);
                    //NOTSURE IF NEEDED resultStr = rawStr.Replace("<br />", "  ");
                }

                //then crop ending
                if (rawStr.Contains("\"ti"))
                {//most common - 'arboriculture'
                    int endingPos = rawStr.IndexOf("\"ti") - 19;
                    rawStr = rawStr.Remove(endingPos, rawStr.Length - endingPos);
                }
                else
                {//see 'antemundane'
                    int endingPos = rawStr.IndexOf("<br />\r") - 8;
                    rawStr = rawStr.Remove(endingPos, rawStr.Length - endingPos);
                }

                //remaining is the block of definition
                resultStr = rawStr.Replace("<br />", "  ");

                return resultStr;
            }
            catch { return "!ERROR Occurred"; }
        }

        public static string GetDefinition(string word)
        {
            string rawString = fetchRaw("http://3g.dict.cn/s.php?q=" + word);
            rawString = filterDef(rawString);
            return rawString;
        }

        public static string GetDefinition(string word, Library libraryToSearch)
        {
            try
            {
                word = word.ToLower();//case-insensitive
                if (libraryToSearch.Contains(word))
                    return libraryToSearch.GetEntry(libraryToSearch.IndexOf(word)).GetChinese();
                else
                {
                    string rawString = fetchRaw("http://3g.dict.cn/s.php?q=" + word);

                    rawString = filterDef(rawString);

                    return rawString;
                }
            }
            catch
            {
                return "!ERROR Occurred";
            }
        }
    }
}