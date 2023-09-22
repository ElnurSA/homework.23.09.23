//static string Test(int num2, string name, int number = 100, string surname = "XXX")
//{
//    return num2 + name + number;
//}

//Console.WriteLine(Test(5, "sada"));






//static void Test(int a, params int[] arr)
//{
//    int sum = 0;
//    foreach(var item in arr)
//    {
//        sum += item;
//    }

//    int result = sum * a;

//    Console.WriteLine(result);

//}


//static void Test(int b, params string[] number)
//{
//    Console.WriteLine("hello");
//}


//Test(1, "5");

using lesson;

//int num = 2;


//switch (num)
//{
//    case 2:
//        Console.WriteLine(Class1.Sum()); 
//        break;
//    case 1:
//        Class1.Sum(15);
//        break;
//    case 3:
//        Class1.Sum(100, 5);
//        break;
//    default:
//        Console.WriteLine("something wrong");
//        break;
//}





//int a = 100;
//int b = a;
//b = 200;




//Console.WriteLine(a);
//Console.WriteLine(b);


//string name = "test";

//string surname = name;

//surname = "salamlar";

//Console.WriteLine(name);
//Console.WriteLine(surname);

//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = arr1;

//arr2[0] = 300;


//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//int[] nums = { 2, 3, 4, 5 };

//Console.WriteLine(nums[0]);

//Test(nums);

//Console.WriteLine(nums[0]);


//static void Test(int[] arr)
//{
//    arr[0] = 5;
//    Console.WriteLine(arr[0] + 10);
//}


//int b = 20;

//Console.WriteLine(b);

//Test(ref b);

//Console.WriteLine(b);


//static void Test(ref int a)
//{
//    a = 300;
//    Console.WriteLine(a);
//}



//int a = 5;
//int c = 10;

//int b = ++a;

//a++;

//c = --a;

//Console.WriteLine(a);

//Console.WriteLine(b);

//Console.WriteLine(c);



//int[] nums1 = { 2, 3, 4, 5 };

//int a = nums1[0];

//int b = a++;

//int[] nums2 = nums1;

//nums2[0] = a;



//Test(nums2);


//Console.WriteLine(nums2[0]);



//static void Test(int[] arr)
//{
//    arr[0] = 50;
//}



//string name1 = "      Test";
//string name2 = "test";

//Console.WriteLine(name1.ToLower().Trim() == name2.ToLower().Trim());

//Console.WriteLine(name1.Length);

//Console.WriteLine(name1.ToLower());
//Console.WriteLine(name1.ToUpper());

//Console.WriteLine(name1.Trim());

//int a = 5;

//Console.WriteLine(a.ToString().GetType());

//string str = "Azerbaycan";

//Console.WriteLine(str.Replace("A", "a"));


//var data = str.ToCharArray();


//Console.WriteLine(data[0]);

//for(int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine(str[i]);
//}


//Console.WriteLine(str.Contains("a"));

//string str1 = "Azerbaycan";
//string str2 = "Respublicasi";

//string result = string.Concat(str1, "", str2);

//Console.WriteLine();





//string st1 = "salam";

//string st2 = "Salam";

//bool result = st1.ToLower().Equals(st2.ToLower());

//Console.WriteLine(result);



//string str1 = "Azerbaycan gozel respublikadi";

//var result = str1.Split(" ");

//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}

//var result = str1.ToCharArray();

//for (int i = 0; i < result.Length; i++)
//{
//    Console.WriteLine(result[i]);
//}

//foreach(int item in result)
//{
//    Console.WriteLine(item);
//}


//string str = "test";

//Console.WriteLine(str.StartsWith("t"));


//Console.WriteLine("Add string : ");

//string str = Console.ReadLine();

//string[] words = { "Test1", "Test2", "Test3", "salam", "Sagol" };

//int count = GetStrCountWithCondition(str, words);

//Console.WriteLine(count);

//static int GetStrCountWithCondition(string str, string[] words)
//{
//    int count = 0;

//    foreach(var word in words)
//    {
//        if (word.ToLower().StartsWith(str.ToLower()))
//        {
//            count++;
//        }
//    }

//    return count;
//}