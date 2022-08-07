using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _dictionary;

        public PhoneDirectory() {
            _dictionary = new SortedDictionary<string, string>();
            _dataCount = 0;
        }

        private int Find(string name) {
            for (var i = 0; i < _dictionary.Count; i++) 
            {
                KeyValuePair<string, string> entry = _dictionary.ElementAt(i);
                if (entry.Key.Equals(name)) 
                {
                    return i;
                }
            }

            return -1;
        }

        public string GetNumber(string name) 
        {
            if (_dictionary.ContainsKey(name)) 
            {
                return _dictionary[name];
            } 
            else 
            {
                return null;
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            if (_dictionary.ContainsKey(name)) 
            {
                _dictionary[name] = number;
            }
            else 
            {
                var newEntry = new PhoneEntry {name = name, number = number};
                _dictionary.Add(newEntry.name, newEntry.number);
            }
        }
    }
}
