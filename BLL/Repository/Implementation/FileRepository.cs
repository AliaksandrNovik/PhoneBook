using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Serialization;

namespace BLL.Repository
{
    public class FileRepository<T> where T : Identified
    {
        private Dictionary<string, T> _valuesDict;
        public FileRepository(string fileName)
        {
            this.FileName = fileName;
            if (!File.Exists(FileName))
            {
                var file = File.Create(FileName);
                file.Close();
            }
            else
            {
                _valuesDict = Serializer.DeSerializeObject<Dictionary<string, T>>(this.FileName);
            }

            if (_valuesDict == null)
                _valuesDict = new Dictionary<string, T>();
    }

        public string FileName
        { get; set; }

        public IReadOnlyCollection<T> GetAll()
        {
            return _valuesDict.Values.ToList();
        }

        public T GetById(string id)
        {
            if (_valuesDict.ContainsKey(id))
            {
                return _valuesDict[id];
            }
            else
            {
                return null;
            }
        }

        public void Upsert(T value)
        {
            var id = value.Id;
            if (_valuesDict.ContainsKey(id))
                _valuesDict.Remove(id);

            _valuesDict.Add(value.Id, value);
            Update();
        }

        public bool Delete(string id)
        {
            bool result = _valuesDict.Remove(id);
            Update();
            return result;
        }

        private void Update()
        {
            Serializer.SerializeObject(_valuesDict, this.FileName);
        }
        
    }
}
