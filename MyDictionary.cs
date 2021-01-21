using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] tkeys;
        Tvalue[] tvalues;
        public MyDictionary()
        {
            tkeys = new Tkey[0];
            tvalues = new Tvalue[0];
        }
        public void Add(Tkey tkey, Tvalue tvalue)
        {
            Tkey[] tempArray = tkeys;
            tkeys = new Tkey[tkeys.Length + 1];
            for(int i = 0; i<tempArray.Length; i++)
            {
                tkeys[i] = tempArray[i];

                Tvalue[] _tempArray = tvalues;
                tvalues = new Tvalue[tvalues.Length + 1];
                for(int j = 0; j<_tempArray.Length; j++)
                {
                    tvalues[j] = _tempArray[j];
                }
                tvalues[tvalues.Length - 1] = tvalue;
            }
            tkeys[tkeys.Length - 1] = tkey;
        }
    }
}
