using System;
namespace lesson
{
	public static class Class1
	{
        public static int Sum()
        {
            return -1;
        }

		public static int Sum(int a)
		{
			return a;
		}

        public static int Sum(int a,int b)
        {
            return a + b;
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Sum(params int[] nums)
        {

            int sum = 0;

            foreach(int item in nums)
            {
                sum += item;
            }

            return sum;

        }

    }
}

