using System.Collections.Generic;

namespace Auto_Definition
{
    internal class Library
    {
        //including search(contains&indexOf)/add/remove/contain of entry, as well as getting entry

        //private static readonly int max_entry = 20000;//Define limit
        private static readonly int min_entry = 500;//Recommended minimum limit

        //Entry[] datum = new Entry[max_entry];//Initialize library
        private static List<Entry> data = new List<Entry>(min_entry);

        //entries set to null unless initialized

        public static int CurrentLength()//return storage status
        {
            return data.Count;
        }

        public static int DefaultLength()//return storage status
        {
            return min_entry;
        }

        public Library()
        {
            //no need to initialize any Entry.
            //capacity of data is not the real count and therefore no null will occur.
        }

        public void Add(Entry entryToAdd)
        {
            for (int i = 0; i < data.Count; i++)
            {
                Entry libEntry = data[i];
                if (libEntry.GetEnglish().ToLower() == entryToAdd.GetEnglish())//Stored data searched first
                {
                    libEntry.Update(libEntry.GetFrequency() + 1);
                    return;//Exit loop, skipping adding new entry
                }
            }
            data.Add(new Entry(entryToAdd.GetChinese().Trim(), entryToAdd.GetEnglish().ToLower(), 1));//case-insensitive
        }

        public bool Contains(string word)
        {
            foreach (Entry libEntry in data)
                if (libEntry.GetEnglish().ToLower() == word)
                    return true;
            return false;
        }

        public Entry GetEntry(int index)
        {
            if (index < data.Count)
                return data[index];
            else
                return null;
        }

        public int IndexOf(string word)
        {
            for (int i = 0; i < data.Count; i++)
                if (data[i].GetEnglish() == word)
                    return i;
            return -1;
        }

        public void Wipe()
        {
            data.Clear();
        }
    }
}