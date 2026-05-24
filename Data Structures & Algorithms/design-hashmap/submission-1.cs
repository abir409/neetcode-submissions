public class MyHashMap {

    private int bucketSize = 1000;
    private List<(int key, int value)>[] buckets;
    public MyHashMap() {
        buckets = new List<(int key, int value)>[bucketSize];

        for(int i = 0; i < bucketSize; i++)
        {
            buckets[i] = new List<(int key, int value)>();
        }
    }
    public int GetIndex(int key)
    {
        return key % bucketSize;
    }
    public void Put(int key, int value) {

        int index = GetIndex(key);
        var bucket = buckets[index];

        for(int i = 0; i< bucket.Count; i++)
        {
            if(bucket[i].key == key)
            {
                bucket[i] = (key,value);
                return;
            }
        }
        bucket.Add((key,value));
    }
    
    public int Get(int key) {
        int index = GetIndex(key);
        var bucket = buckets[index];

        foreach(var pair in bucket)
        {
            if(pair.key == key)
            {
                return pair.value;
            }
        }
        return -1;
    }
    
    public void Remove(int key) {

        int index = GetIndex(key);
        var bucket = buckets[index];

        for(int i = 0; i<bucket.Count; i++)
        {
            if(bucket[i].key== key)
            {
                bucket.RemoveAt(i);
                return;
            }
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */