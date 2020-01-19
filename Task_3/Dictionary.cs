using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Dictionary<Tkey, TValue>
    {
        private readonly List<Tkey> key;
        private readonly List<TValue> value;

        public Dictionary()
        {
            this.key = new List<Tkey>();
            this.value = new List<TValue>();
        }

        public void Add(Tkey key, TValue value)
        {
            this.key.Add(key);
            this.value.Add(value);
        }

        public int Count
        {
            get { return key.Count; }
        }

        public string this[int index]
        {
            get
            {
                if (key.Count() >= index)
                {
                    return $"По индексу {index}: {value[index]}  + { key[index] }";
                }
                return $"По индексу {index} нечего не найдено";
            }
        }

        public string this[Tkey index]
        {
            get
            {
                if (key.Contains(index))
                {
                    return key[key.IndexOf(index)].ToString() + " " + value[key.IndexOf(index)].ToString();
                }
                return $"Нет такого слова {index.ToString()}";
            }
        }

        public override string ToString()
        {
            string all = default;
            for (int i = 0; i < key.Count; i++)
            {
                all += $"{this[i]} \n";
            }
            return all;
        }

    }
}
