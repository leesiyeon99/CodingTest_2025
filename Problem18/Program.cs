namespace Problem18
/// <summary>
/// 날짜: 2025.02.28
/// 문제: 우주여행을 하던 머쓱이는 엔진 고장으로 PROGRAMMERS-962 행성에 불시착하게 됐습니다. 
/// 입국심사에서 나이를 말해야 하는데, PROGRAMMERS-962 행성에서는 나이를 알파벳으로 말하고 있습니다. 
/// a는 0, b는 1, c는 2, ..., j는 9입니다. 예를 들어 23살은 cd, 51살은 fb로 표현합니다. 
/// 나이 age가 매개변수로 주어질 때 PROGRAMMER-962식 나이를 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120834
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
            public string solution(int age)
            {
                string answer = "";
                string age2 = age.ToString();
                age2 = age2.Replace('0', 'a').Replace('1', 'b').Replace('2', 'c').Replace('3', 'd').Replace('4', 'e').Replace('5', 'f').Replace('6', 'g').Replace('7', 'h').Replace('8', 'i').Replace('9', 'j');

                return answer =age2;
            }

            public string solution2(int age)
            {
                string answer = "";

                while (age > 0)
                {
                    answer = ((char)('a' + age % 10)) + answer;
                    age = age / 10;
                }
                return answer;
            }
        }
    }
}
