namespace Problem14
/// <summary>
/// 날짜: 2025.02.27
/// 문제: 정수 n이 매개변수로 주어질 때, n의 약수를 오름차순으로 담은 배열을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120897
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
            public int[] solution(int n)
            {
                List<int> answer = new List<int>();
                int count = n / 2;
                for (int i = 1; i <= count; i++)
                {
                    if (n % i == 0)
                    {
                        answer.Add(i);
                    }
                }

                answer.Add(n);

                answer.Sort();

                return answer.ToArray();
            }
        }
    }
}
