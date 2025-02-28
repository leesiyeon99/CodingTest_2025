namespace Problem16
/// <summary>
/// 날짜: 2025.02.28
/// 문제: 영어 대소문자로 이루어진 문자열 my_string이 매개변수로 주어질 때, 
/// my_string을 모두 소문자로 바꾸고 알파벳 순서대로 정렬한 문자열을 return 하도록 solution 함수를 완성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120911
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Solution
        {
            public string solution(string my_string)
            {
                string answer = "";
                my_string = my_string.ToLower();
                char[] a = my_string.ToArray();
                Array.Sort(a);

                for (int i = 0; i < my_string.Length; i++)
                {
                    answer += a[i];
                }
                return answer;
            }
        }
    }
}
