    public enum SortOrder
    {
        Ascending,
        Descending
    }
    public static class Sorting
    {
        private static void Swap<T>(ref T value1, ref T value2) =>
            (value1, value2) = (value2, value1);
        public static bool CheckSortOrder<T>(this T[] array, SortOrder sortOrder = SortOrder.Ascending)
            where T : IComparable<T>
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));
            switch (sortOrder)
            {
                case SortOrder.Ascending:
                    for (var i = 1; i < array.Length; i++)
                    {
                        if (array[i - 1].CompareTo(array[i]) > 0)
                            return false;
                    }
                    break;
                case SortOrder.Descending:
                    for (var i = 1; i < array.Length; i++)
                    {
                        if (array[i - 1].CompareTo(array[i]) < 0)
                            return false;
                    }
                    break;
            }
            return true;
        }
        public static void BubbleSort<T>(this T[] array, SortOrder sortOrder = SortOrder.Ascending)
            where T : IComparable<T>
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));
            switch (sortOrder)
            {
                case SortOrder.Ascending:
                    for (var i = 0; i < array.Length; i++)
                    {
                        for (var j = i + 1; j < array.Length; j++)
                        {
                            if (array[i].CompareTo(array[j]) > 0)
                                Swap(ref array[i], ref array[j]);
                        }
                    }
                    break;
                case SortOrder.Descending:
                    for (var i = 0; i < array.Length; i++)
                    {
                        for (var j = i + 1; j < array.Length; j++)
                        {
                            if (array[i].CompareTo(array[j]) < 0)
                                Swap(ref array[i], ref array[j]);
                        }
                    }
                    break;
            }
        }
    }