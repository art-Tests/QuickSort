namespace quickSort
{
    public class QuickSort
    {
        /// <summary>
        /// 快速排序法
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        public static void Sort(int[] numbers)
        {
            Sort(numbers, 0, numbers.Length - 1);
        }

        /// <summary>
        /// 快速排序切分運算
        /// </summary>
        /// <param name="numbers">數據集合</param>
        /// <param name="left">左游標index</param>
        /// <param name="right">右游標index</param>
        private static void Sort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                // 取得集合正中間的數字作為基準
                int middle = numbers[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    // 左游标向右扫描， 跨过所有小于基准元素的数组元素,
                    // 直到遇到一个大于或等于基准元素的数组元素， 在那个位置停下。
                    while (numbers[++i] < middle) ;
                    // 右游标向左扫描， 跨过所有大于基准元素的数组元素,
                    // 直到遇到一个小于或等于基准元素的数组元素，在那个位置停下
                    while (numbers[--j] > middle) ;
                    // 兩個游標沒有相遇，就交換數字；相遇則跳出迴圈
                    if (i >= j) break;
                    Swap(numbers, i, j);
                }

                Sort(numbers, left, i - 1); // 遞迴切分後的小區塊
                Sort(numbers, j + 1, right); // 遞迴切分後的大區塊
            }
        }

        /// <summary>
        /// 交換數字
        /// </summary>
        /// <param name="numbers">原始數據集合</param>
        /// <param name="i">左游標index</param>
        /// <param name="j">右游標index</param>
        private static void Swap(int[] numbers, int i, int j)
        {
            int number = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = number;
        }
    }
}