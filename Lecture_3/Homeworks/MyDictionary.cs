namespace Lecture_3.Homeworks {
    public class MyDictionary<TKey, TValue> {
        TKey[] keys;
        TValue[] vals;

        public MyDictionary() {
            keys = new TKey[0];
            vals = new TValue[0];
        }

        public void Add(TKey key, TValue val) {
            TKey[] tempKeys = keys;
            keys = new TKey[this.Count+1];
            TValue[] tempVals = vals;
            vals = new TValue[this.Count+1];
            for (int i = 0; i < tempKeys.Length; i++) {
                keys[i] = tempKeys[i];
                vals[i] = tempVals[i];
            }
            keys[this.Count-1] = key;
            vals[this.Count-1] = val;
        }

        public int Count {
            get {return keys.Length;}
        }
    }
}