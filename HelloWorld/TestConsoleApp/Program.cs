using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<int>() { 5, 4, 3, 2, 1 };
            var result = BubbleSort.Sort(list);
            Console.Read();
        }

        private static int SumFromTo(int start, int end)
        {
            if (start == end)
                return end;
            else
                return start + SumFromTo(start + 1, end);
        }

        private static void StringTest()
        {
            char[] ch = new char[] { 'a', 'a', 'a' };
            string a1 = new string(ch);
            string a2 = "aaa";
            string a3 = "aaa";
            string a4 = (a2 + "1").Remove(3);
            string a5 = new string(ch);
            var result1 = ReferenceEquals(a1, a2);
            var result2 = ReferenceEquals(a3, a2);
            var result3 = ReferenceEquals(a4, a2);
            var result4 = ReferenceEquals(a1, a5);
            Console.Write(result1);
        }

        private static void AsyncTest()
        {
            Console.WriteLine("Main: " + Thread.CurrentThread.ManagedThreadId + "-1");
            var result = GetUserController();

            Console.WriteLine("Main: " + Thread.CurrentThread.ManagedThreadId + "-2");

            Console.WriteLine("Main: " + "Reasule: " + result.Result + "  " + Thread.CurrentThread.ManagedThreadId + "-3");
            Console.WriteLine("Main: " + Thread.CurrentThread.ManagedThreadId + "-4");
        }

        private static async Task TestAsync()
        {
            await Task.Delay(1000);
            // 业务代码
        }

        public static void TestOne()
        {
            Task task = TestAsync();
            task.Wait();
        }
        public static async Task<long> GetUserController()
        {
            Console.WriteLine("GetUserController: " + Thread.CurrentThread.ManagedThreadId + "-1");
            Console.WriteLine("----------------------");
            var result = await GetUserIDService();
            Console.WriteLine("----------------------");
            Console.WriteLine("GetUserController: " + Thread.CurrentThread.ManagedThreadId + "-2");
            return result;
        }
        public static async Task<long> GetUserIDService()
        {
            //System.Threading.Thread.Sleep(1000);
            Console.WriteLine("GetUserIDService: " + Thread.CurrentThread.ManagedThreadId + "-1");
            var result = await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine("GetUserIDService: " + Thread.CurrentThread.ManagedThreadId + "-2");
                return new Random().Next();
            });
            Console.WriteLine("GetUserIDService: " + Thread.CurrentThread.ManagedThreadId + "-3");
            return result;
        }
    }

    public class VedioAssRename
    {
        public string AssFilePath { get; set; }

        public string VedioName { get; set; }
    }

    public class BlogPost
    {
        public string Title { get; set; }

        public static void BuildBlogPostLinks(params BlogPost[] blogPosts)
        {
            if (blogPosts == null)
            {
                Console.WriteLine("blogPosts in null");
                return;
            }

            foreach (var blogPost in blogPosts)
            {
                if (blogPost == null)
                {
                    Console.WriteLine("blogPost in null");
                }
                else
                {
                    Console.WriteLine("blogpost.Title: " + blogPost.Title);
                }
            }
        }

        private static void TestMethod()
        {
            BlogPost.BuildBlogPostLinks(null);
            BlogPost.BuildBlogPostLinks(null, null);
            BlogPost blogPost = null;
            BlogPost.BuildBlogPostLinks(blogPost);
        }
    }
}
