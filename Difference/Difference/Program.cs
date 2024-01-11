namespace Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("차이를 원하는 두수를 차례로 입력하세요.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(solution(num1,num2));


        }
        static int solution(int num1, int num2)
        {
            int answer = num1-num2;
            return answer;
        }
    }
}
