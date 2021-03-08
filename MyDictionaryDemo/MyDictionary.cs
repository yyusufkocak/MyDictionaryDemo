using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }


         public void Add(K key,V value)
        {
            K[] tempArrayK = keys;
            keys = new K[keys.Length + 1];

            V[] tempArrayV = values;
            values = new V[values.Length + 1];



            for (int i = 0; i <tempArrayK.Length; i++)
            {
                keys[i]=tempArrayK[i];
                values[i] = tempArrayV[i];

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        
        public int Count
        {
            get { return keys.Length; }
        }



    }
}
