    public static class ListHelper
    {
        public static List<T> ThinOut<T>(this List<T> source, int MaxItems)
        {
            //source already less than max items
            if (source.Count < MaxItems)
            {
                return source;
            }

            int multiplier = (source.Count / MaxItems);

            //since multiplier is an int, it will round down
            //ie: 179/100 would equal 1
            //this wouldn't work well, so up it by 1
            multiplier++;

            List<T> rv = new List<T>();

            //pull out every X item, as specified by the multiplier
            //and add that to a new list
            for (int i = 0; i < source.Count; i = i + multiplier)
            {
                rv.Add(source[i]);
            }

            return rv;
        }
    }