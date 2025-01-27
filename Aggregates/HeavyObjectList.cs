using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    class HeavyObjectList
    {
        private List<HeavyObject> heavyList;

        public HeavyObjectList()
        {
            heavyList = new List<HeavyObject>();
        }

        //Add the heavy list to the list
        public void Add(HeavyObject Obj)
        {
            heavyList.Add(Obj);
        }


        public void Print()
        {
            foreach (HeavyObject heavyObject in heavyList)
            {
                heavyObject.Print();
            }
        }

        public HeavyObject Get(int index)
        {
            if (index >= 0 && index < heavyList.Count)
            {
                return heavyList[index];
            }
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        public int Count
        {
            get { return heavyList.Count; }
        }

    }
}