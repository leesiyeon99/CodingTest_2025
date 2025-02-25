namespace Problem8
/// <summary>
/// 날짜: 2025.02.24
/// 문제: 영어에선 a, e, i, o, u 다섯 가지 알파벳을 모음으로 분류합니다. 
/// 문자열 my_string이 매개변수로 주어질 때 모음을 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120849
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
                string vowels = "aeiou";
                foreach (char vowel in vowels)
                {
                    my_string = my_string.Replace(vowel.ToString(), "");
                    // 문자열에서 해당 문자가 여러 번 등장해도 전부 바꿔줌. 
                }
                return my_string;
            }
            public string solution2(string my_string)
            {
                string answer = my_string;
                answer = answer.Replace("a", "");
                answer = answer.Replace("e", "");
                answer = answer.Replace("i", "");
                answer = answer.Replace("o", "");
                answer = answer.Replace("u", "");

                return answer;
            }
        }
    }
}
