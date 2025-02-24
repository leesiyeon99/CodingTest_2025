namespace Problem5
/// <summary>
/// 날짜: 2025.02.24
/// 문제: 어떤 세균은 1시간에 두배만큼 증식한다고 합니다. 
/// 처음 세균의 마리수 n과 경과한 시간 t가 매개변수로 주어질 때 t시간 후 세균의 수를 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120910
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int a = solution.solution2(2, 10);
            Console.WriteLine(a);
        }

        public class Solution
        {
            public int solution(int n, int t)
            {
                int answer = 0;
                for (int i = 0; i < t; i++)
                {
                    n = n * 2;
                }
                return answer = n;
            }

            // 1) 다른 문제 풀이 방법
            // 문제의 식은 n * 2^t와 같다
            // 비트연산자 n << t (n을 t비트만큼 왼쪽으로 이동) 과 n * 2^t 식이 같기 때문에
            // ex) 3 << 2의 경우 0000 0011 -> 0000 1100 3 * 2^2와 같다.
            // 곱셈보다 속도가 빠르므로 최적화할 때 좋은 비트 연산자를 사용하는 것이 더 효율적임
            public int solution2(int n, int t)
            {
                int answer = 0;
                answer = n << t;
                return answer;
            }

            // 2) 다른 문제 풀이 방법
            // 문제의 식은 n * 2^t와 같으므로 MathF.Pow를 써서 제곱해주는 방법도 있음
            // 하지만 Math.Pow는 double을 반환하므로 캐스팅(데이터 타입을 변환하는 과정) 필요, 성능이 떨어질 수 있음
            public int solution3(int n, int t)
            {
                int answer = 0;
                answer = n * (int)MathF.Pow(2, t);
                return answer;
            }

            /*
             캐스팅
            1. 명시적 캐스팅
            - 큰 데이터 타입 → 작은 데이터 타입 변환 (데이터 손실 가능)
            - (타입) 값 형식으로 변환
            2. 묵시적 캐스팅
            - 작은 데이터 타입 → 큰 데이터 타입 변환 (데이터 손실 없음)
            - 자동으로 변환되므로 (타입)을 사용하지 않음
             */

            // 결론: 캐스팅이 필요없고 곱셈보다 속도가 빠른 비트 연산자를 쓰는게 최적화에 좋음
        }
    }
}
