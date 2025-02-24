namespace Problem2
/// <summary>
/// 날짜: 2025.02.19
/// 문제: 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120817
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public class Solution
        {
            public double solution(int[] numbers)
            {
                double answer = 0;

                double numbersSum = 0;

                foreach (var index in numbers)
                {
                    numbersSum += index;
                }

                answer = numbersSum / numbers.Length;

                return answer;

                // 다른 답
                // return numbers.Average();
                // return (double)(numbers[0]+numbers[numbers.Length-1])/2;
            }
        }
    }
}