namespace Auto_Definition
{
    internal class LibraryUtility
    {
        //including sorting(defragging), saving and loading

        private static readonly string LibraryDefaultPath = System.Windows.Forms.Application.StartupPath;//Define directory, DO NOT USE DIRECTLY
        private static readonly string chnPath = LibraryPath() + "chn.bin";
        private static readonly string engPath = LibraryPath() + "eng.bin";
        private static readonly string frequencyPath = LibraryPath() + "frequency.bin";

        public LibraryUtility()
        {
        }

        public static string LibraryPath()//get storage path
        {
            if (LibraryDefaultPath.EndsWith("\\"))
                return LibraryDefaultPath;
            else
                return LibraryDefaultPath + "\\";
        }

        private static void CheckLibs()
        {
            //detect lib file on HDD; if file not found, or empty, skip loading

            if (!(System.IO.File.Exists(chnPath) && System.IO.File.Exists(engPath) && System.IO.File.Exists(frequencyPath)))
            {
                DeleteLibrary();
            }//prevent non-exist lib
        }

        public static void DeleteLibrary()
        {
            System.Windows.Forms.MessageBox.Show("Local cache not found, a new cache will be created.");
            System.IO.File.WriteAllLines(chnPath, new string[Library.DefaultLength()]);
            System.IO.File.WriteAllLines(engPath, new string[Library.DefaultLength()]);
            System.IO.File.WriteAllLines(frequencyPath, new string[Library.DefaultLength()]);
        }

        public static void Load(Library targetLib)
        {
            try
            {
                CheckLibs();//check if exist
                string[] chn = System.IO.File.ReadAllLines(chnPath);
                string[] eng = System.IO.File.ReadAllLines(engPath); ;
                string[] frequencyString = System.IO.File.ReadAllLines(frequencyPath);

                for (int i = 0; i < chn.Length; i++)//convert to Entry and add
                {
                    if (chn[i].Length == 0 || eng[i].Length == 0 || frequencyString[i] == "0")
                    {
                        break;
                    }//skip loading while reaching the end

                    Entry entryToAdd = new Entry(chn[i], eng[i], int.Parse(frequencyString[i]));
                    targetLib.Add(entryToAdd);
                }
            }//prevent empty entry, null/outOfBound
            catch { }
        }

        public static void Save(Library sourceLib, string Path)
        {
            try
            {
                string[] chn = new string[Library.CurrentLength()];
                string[] eng = new string[Library.CurrentLength()];
                string[] frequencyString = new string[Library.CurrentLength()];

                for (int i = 0; i < Library.CurrentLength(); i++)
                {
                    //if (sourceLib.GetEntry(i) == null)
                    //{
                    //chn[i] = "";
                    //eng[i] = "";
                    //frequencyString[i] = "0";
                    //}//prevent empty entry : string ""
                    //else
                    //{
                    chn[i] = sourceLib.GetEntry(i).GetChinese();
                    eng[i] = sourceLib.GetEntry(i).GetEnglish();
                    frequencyString[i] = sourceLib.GetEntry(i).GetFrequency().ToString();

                    //}
                }

                System.IO.File.WriteAllLines(frequencyPath, frequencyString);
                System.IO.File.WriteAllLines(engPath, eng);
                System.IO.File.WriteAllLines(chnPath, chn);
            }
            catch { DeleteLibrary(); }
        }
    }
}