using System;

namespace Lecture_3.GenericsIntro {
    class MyList<T> {
        T[] items;

        // Constructor
        public MyList() {
            items = new T[0];
        }
        public void Add(T item) {
            T[] tempArr = items;
            items = new T[items.Length+1];
            for(int i = 0; i < tempArr.Length; i++) {
                items[i] = tempArr[i];
            }
            items[items.Length-1] = item;
        }
    }
}

