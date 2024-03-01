int[] arr = [3, 1, 2, 6, 8, 10, 4];
SelectionSort.Sort(arr);
Console.WriteLine(string.Join(',', arr));

internal interface ISortingAlgorithms
{
    static abstract void Sort(int[] array);
}

internal abstract class BubbleSort : ISortingAlgorithms
{
    // space = O(1)
    // best time = O(n)
    // worst time = O(n^2)
    public static void Sort(int[] array)
    {
        for(var end = array.Length; end > 0; end--)
        {
            var changes = 0;
            for(var idx = 1; idx < end; idx++)
            {
                if(array[idx - 1] <= array[idx]) continue;
                changes++;
                // buble it
                (array[idx - 1], array[idx]) = (array[idx], array[idx - 1]);
            }
            
            if(changes == 0)
                break;
        }
    }
}

internal abstract class InsertionSort : ISortingAlgorithms
{
    public static void Sort(int[] array)
    {
        // space O(1)
        // time best case O(n)
        // time worst case O(n²)
        for (var i = 1; i < array.Length; i++)
        {
            // number to insert
            var val = array[i];
            var j = i;

            // move before insert
            while (--j >= 0 && val < array[j])
                array[j + 1] = array[j];
            
            // insert the min in its place
            array[++j] = val;
        }
    }
}
internal abstract class SelectionSort : ISortingAlgorithms
{
    public static void Sort(int[] array)
    {
        // space O(1)
        // time best/worst case O(n)
        for (var i = 0; i < array.Length; i++)
        {
            var min = i;
            for (var j = i; j < array.Length; j++)
            {
                // find the min
                if (array[min] > array[j])
                    min = j;
            }
            // swap the current with the selected one
            (array[i], array[min]) = (array[min], array[i]);
        }
    }
}