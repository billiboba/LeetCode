public class Solution4
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double median = 0;
        int[] nums3 = new int[nums1.Length + nums2.Length];
        nums1.CopyTo(nums3, 0);
        nums2.CopyTo(nums3, nums1.Length);
        int[] sortMas = nums3.Distinct().ToArray();
        Array.Sort(sortMas);
        median = sortMas.Length % 2 == 0 ? (Convert.ToDouble(sortMas[sortMas.Length / 2 - 1]) + Convert.ToDouble(sortMas[sortMas.Length / 2])) / 2.0 : Convert.ToDouble(sortMas[sortMas.Length / 2]);
        return median;
    }

    //public static void Main()
    //{
    //    int[] nums1 = { 1 };
    //    int[] nums2 = { };
    //    double median = FindMedianSortedArrays(nums1, nums2);
    //    Console.WriteLine(median);
    //}
}