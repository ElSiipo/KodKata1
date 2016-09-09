using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KodKata1
{
    public class FileReader
    {
        private StreamReader _streamReader;

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
            _blablaDictionary = new List<string>();
            this._filePath = filepath;
        }

        public void ReadFile()
        {
            _streamReader = new StreamReader(_filePath);
            
            string line;

            while ((line = _streamReader.ReadLine()) != null)
            {
                _blablaDictionary.Add(line);
            }

        }

        public bool IsWordExistingInList(string _inputWord)
        {
           return BlablaDictionary.Contains(_inputWord);
        }

        public void ExcludeWordsByCount()
        {
            BlablaDictionary = BlablaDictionary.Where(p => p.Length == 4).ToList();
        }
    }
}
