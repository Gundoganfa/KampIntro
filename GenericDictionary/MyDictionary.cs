using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDictionary
{

    class MyDictionary <TKey, TValue>
    {
        TKey[] keyList;
        TValue[] valueList;
        TKey[] tempKeyList;
        TValue[] tempValueList;

        public MyDictionary()
        {
            // create instances for key and value lists
            // just after a new instance of the class is created
            keyList = new TKey[] { };
            valueList = new TValue[] { };
        }
        public void Add(TKey key, TValue value)
        {
            tempKeyList = keyList;
            tempValueList = valueList;

            keyList = new TKey[keyList.Length + 1];
            valueList = new TValue[valueList.Length + 1];

            for (int i = 0; i < tempKeyList.Length; i++)
            { //keyList and valueList have same length
                keyList[i] = tempKeyList[i];
                valueList[i] = tempValueList[i];
            }
            
            keyList[keyList.Length - 1] = key;
            valueList[keyList.Length - 1] = value;

            Console.WriteLine(key + " " + value + " added!");
        }
    }
}
