namespace section3
{
    internal class SortingCondition
    {
        public static bool CompareIfGreater(int left, int right) { return left > right; }
        public static bool CompareIfLess(int left, int right) { return left < right; }
        public static bool CompareIfGreater(string left, string right) { return left.Length > right.Length; }
        public static bool CompareIfLess(string left, string right) { return left.Length < right.Length; }
    }
}
