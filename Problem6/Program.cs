using System.Runtime.InteropServices.Marshalling;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem6
/// <summary>
/// 날짜: 2025.02.24
/// 문제: 선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.
//        가장 긴 변의 길이는 다른 두 변의 길이의 합보다 작아야 합니다.
//        삼각형의 세 변의 길이가 담긴 배열 sides이 매개변수로 주어집니다.
//        세 변으로 삼각형을 만들 수 있다면 1, 만들 수 없다면 2를 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120889
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
            public int solution(int[] sides)
            {
                int a = sides[0];
                int b = sides[1];
                int c = sides[2];

                // 정삼각형일 때
                if (a == b && b == c && a == c)
                {
                    return 1;
                }

                // 이등변 삼각형일 때
                if ((a == b && a != c && a + b != c) || (a == c && a != b && a + c != b) || (b == c && b != a && b + c != a))
                {
                    return 1;
                }

                int max = sides.Max();
                int sum = 0;
                foreach (var num in sides)
                {
                    if (num == max)
                        continue;

                    sum += num;
                }

                if (sum > max)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            // 정렬만 기억했다면 매우 쉬웠던 문제..
            public int solution2(int[] sides)
            {
                int answer = 0;
                Array.Sort(sides);
                if (sides[0] + sides[1] > sides[2]) answer = 1;
                else answer = 2;

                return answer;
                // return sides[0] + sides[1] > sides[2] ? 1 : 2;
                // return sides.Max() < (sides.Sum() - sides.Max()) ? 1 : 2;
            }
        }
    }
}
