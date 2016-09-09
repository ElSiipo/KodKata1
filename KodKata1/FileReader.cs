using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KodKata1
{
    public class FileReader
    {
       
        private List<String> _blablaDictionary;
        public List<String> BlablaDictionary
        {
            get { return _blablaDictionary; }
            set 
            {
                if (_blablaDictionary != value)
                {
                    _blablaDictionary = value;
                } 
            }
        }

        private string _inputWord;
        public string InputWord
        {
            get { return _inputWord; }
            set { _inputWord = value; }
        }

        private string _filePath;

        public FileReader(string filepath)
        {
            _blablaDictionary = ReadFile(filepath);
            this._filePath = filepath;
        }

        public static List<string> ReadFile(string filepath)
        {
            var list = new List<string>();
            
            using (var _streamReader = new StreamReader(filepath))
            {
                if (File.Exists(filepath))
                {
                    string line;
                    while ((line = _streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }

            return list;
        }

        public bool IsWordExistingInList(string _inputWord)
        {
           return BlablaDictionary.Contains(_inputWord);
        }

        public void ExcludeWordsByCount()
        {
            BlablaDictionary = BlablaDictionary.Where(p => p.Length == InputWord.Length).ToList();
        }
    }
}
