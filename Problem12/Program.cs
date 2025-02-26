namespace Problem12
/// <summary>
/// 날짜: 2025.02.26
/// 문제: 정수 배열 numbers가 매개변수로 주어집니다. 
/// numbers의 원소 중 두 개를 곱해 만들 수 있는 최댓값을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120862
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
            public int solution(int[] numbers)
            {
                int[] minusArray = new int[numbers.Length];

                Array.Sort(numbers);
                int answer = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0)
                    {
                        minusArray[i] = (int)MathF.Abs(numbers[i]);
                    }
                    else
                    {
                        minusArray[i] = 0;
                    }
                }

                Array.Sort(minusArray);

                int minus = minusArray[numbers.Length - 1] * minusArray[numbers.Length - 2];

                if (answer < 0 )
                {
                    return answer;
                }

                if (minus > answer)
                {
                    return minus;
                }
                else
                {
                    return answer;
                }
            }

            public int solution2(int[] numbers)
            {
                int answer = 0;

                var sort = numbers;
                Array.Sort(sort);

                var max1 = sort[0] * sort[1];
                var max2 = sort[sort.Length - 1] * sort[sort.Length - 2];

                answer = (max1 > max2) ? max1 : max2;

                return answer;
            }
        }
    }
}
