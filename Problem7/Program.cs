namespace Problem7
/// <summary>
/// 날짜: 2025.02.25
/// 문제: 정수 n이 매개변수로 주어질 때 n의 각 자리 숫자의 합을 return하도록 solution 함수를 완성해주세요
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120906
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
            public int solution(int n)
            {
                int answer = 0;
                char[] a = n.ToString().ToArray();
                // = sting a = n.ToSting();

                foreach (var num in a)
                {
                    // '0'을 안빼주면 아스키코드의 값으로 더하기 때문에 빼줘야함
                    answer += num - '0';

                    // = answer += int.Parse(num.ToString());
                    // int.Parse()는 문자열(string)을 정수(int)로 변환하는 메서드
                }
                return answer;
            }

            public int solution2(int n)
            {
                int answer = 0;

                while (n > 0)
                {
                    answer += (n % 10);
                    n /= 10;
                }
                return answer;
            }
        }
    }
}
