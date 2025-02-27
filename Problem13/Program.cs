namespace Problem13
/// <summary>
/// 날짜: 2025.02.27
/// 문제: 문자열 my_string과 정수 num1, num2가 매개변수로 주어질 때, 
/// my_string에서 인덱스 num1과 인덱스 num2에 해당하는 문자를 바꾼 문자열을 return 하도록 solution 함수를 완성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120895
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
            public string solution(string my_string, int num1, int num2)
            {
                string answer = "";
                char a = my_string[num1];
                char b = my_string[num2];

                char[] array = my_string.ToArray();
                array[num1] = b;
                array[num2] = a;

                for (int i = 0; i < array.Length; i++)
                {
                    answer += array[i];
                }

                return answer;
            }

            public string solution2(string my_string, int num1, int num2)
            {
                var str1 = my_string.Substring(num1, 1);
                var str2 = my_string.Substring(num2, 1);
                my_string = my_string.Remove(num1, 1).Insert(num1, str2);
                my_string = my_string.Remove(num2, 1).Insert(num2, str1);
                return my_string;
            }

            public string solution3(string my_string, int num1, int num2)
            {
                string answer = "";
                var str1 = my_string[num1];
                var str2 = my_string[num2];
                for (var i = 0; i < my_string.Length; ++i)
                {
                    if (i == num1)
                    {
                        answer += str2;
                    }
                    else if (i == num2)
                    {
                        answer += str1;
                    }
                    else
                    {
                        answer += my_string[i];
                    }
                }
                return answer;
            }
        }
    }
}
