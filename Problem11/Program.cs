namespace Problem11
/// <summary>
/// 날짜: 2025.02.26
/// 문제: 가위는 2 바위는 0 보는 5로 표현합니다. 가위 바위 보를 내는 순서대로 나타낸 문자열 rsp가 매개변수로 주어질 때, 
/// rsp에 저장된 가위 바위 보를 모두 이기는 경우를 순서대로 나타낸 문자열을 return하도록 solution 함수를 완성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120839
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
            public string solution(string rsp)
            {
                string answer = "";
                char[] array = rsp.ToArray();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '2')
                    {
                        answer += '0';
                    }
                    if (array[i] == '0')
                    {
                        answer += '5';
                    }
                    if (array[i] == '5')
                    {
                        answer += '2';
                    }
                }

                return answer;

                // 다른 문제 풀이 방법
                //  string answer = String.Concat(rsp.Select(x => x == '2' ? '0' : x == '0' ? '5' : '2'));
                // rsp.Select(x => ...) : rsp 문자열의 각 문자를 x로 가져와 조건에 따라 변환
                // String.Concat(...) : 변환된 문자들을 하나의 문자열로 합침
            }
        }
    }
}
