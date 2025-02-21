using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Likelion_07
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // 콘솔 창 크기 설정
            Console.WindowHeight = 10;  // 높이 설정
            Console.WindowWidth = 46;   // 너비 설정

            // 버퍼 크기를 창 크기와 동일하게 설정
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            //답 변수
            int answer, feedback = 0;

            //스토리
            await Another("사냥꾼");
            Thread.Sleep(6000);
            loading();

            await Another("이봐,  이봐...");
            await Another("당신, 드디어 일어났군.");

            await Another("정신은 좀 드는가?");
            Console.WriteLine();
            Console.WriteLine("1. 예.");
            Console.WriteLine("2. 아니오.");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                feedback++;
                Console.Clear();
                await Player("예.");
                Console.WriteLine();
                await Another("저기서 떨어졌는데 무사하다니");
                await Another("정말 다행이군.");
            } else if (answer == 2) {
                Console.Clear();
                await Player("아니오.");
                Console.WriteLine();
                await Another("당신 저기서 떨어졌다구");
                await Another("머리를 다친 모양이군");
                await Another("내 집으로 갑세");
                await Another("치료를 해주지.");
            }

            await Another("어쩌다 이런 변방까지 왔나?");
            Console.WriteLine();
            Console.WriteLine("1. 기억이 잘 나지 않습니다.");
            Console.WriteLine("2. 무언가에 쫒겨 도달했습니다.");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Console.Clear();
                await Player("기억이 잘 나지 않습니다.");
                Console.WriteLine();
                await Another("그런가?");
                await Another("저기 위쪽 방에 빈 방이 있네");
                await Another("조금 쉬고 있게.");
            } else if (answer == 2)
            {
                feedback = feedback + 2;
                Console.Clear();
                await Player("무언가에 쫒겨 도달했습니다.");
                Console.WriteLine();
                await Another("그런가?");
                await Another("여기 의자에서 조금 기다려주게");
                await Another("곧 약을 가져다주지.");
            }

            Console.Clear();
            await Player("그 말을 하곤 곧장 어딘가로 향했다.");
            await Player("덩치가 크고 가죽 옷을 덕지덕지 기워 입은 그는");
            await Player("사냥꾼으로 보이기도 한다.");
            await Player("집 또한 사냥 관련 물품으로");
            await Player("가득하니 흥미로워 보였다.");
            for ( int i=0; i<2; i++ )
            {
                Console.WriteLine("그 말을 하곤 곧장 어딘가로 향했다.");
                Console.WriteLine("덩치가 크고 가죽 옷을 덕지덕지 기워 입은 그는");
                Console.WriteLine("사냥꾼으로 보이기도 한다.");
                Console.WriteLine("집 또한 사냥 관련 물품으로");
                Console.WriteLine("가득하니 흥미로워 보였다.");
                Console.WriteLine();
                Console.WriteLine("1. 컵");
                Console.WriteLine("2. 카펫");
                Console.WriteLine("3. 곰 가죽");
                Console.WriteLine("4. 엽총");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    await Player("그가 가져온 컵");
                    await Player("약간 뜨뜻미지근하게 데워져 있다.");
                    Console.Clear();

                }
                else if (answer == 2)
                {
                    feedback = feedback + 3;
                    await Player("카펫.");
                    await Player("이름 모를 동물의 가죽으로 되어있다.");
                    await Player("밑에는 다락문이...?");
                    Console.Clear();

                }
                else if (answer == 3)
                {
                    await Player("벽에 걸려있다.");
                    await Player("크기가 꽤 크니 자랑스럽게 걸은 듯 하다.");
                    Console.Clear();

                }
                else if (answer == 4)
                {
                    feedback = feedback + 2;
                    await Player("수평 쌍대 엽총.");
                    await Player("손질이 잘 되어 있어 번들번들 하다.");
                    await Player("약실에는 탄이 없다.");
                    Console.Clear();

                }
            }

            if(feedback < 5)
            {
                await Another("자네 여기 약 좀 들게.");
                await Another("그 상처가 악화 되기 전에 나앗음 좋겠군.");
                Console.WriteLine("To be continue...");
                Console.ReadKey();
            }
            else if(feedback >= 5) {
                await Another("자네");
                await Another("호기심이 목숨을 좌우한다는 말을 아는가?");
                await Another("덕분에 자기 임무도 망치게 생겼군");
                await Another("스파이 녀석");
                Console.WriteLine("To be continue...");
                Console.ReadKey();
            }
            
        }

        //로딩기
        static void loading()
        {
            int length = 10, loading, speed = 500, a, b;

            Console.Clear();

            for (a = 0; a < length; a++)
            {
                loading = length - a;
                for (b = 0; b < a + 1; b++)
                {
                    Console.Write("■");
                }

                for (b = 0; b < loading - 1; b++)
                {
                    Console.Write("□");
                }
                Thread.Sleep(speed);
                if (loading > 1)
                {
                    Console.Clear();
                }
                if (loading == 7) { speed = 210; }
            }

            Console.Clear();
            Console.WriteLine("로딩 완료");
            Console.WriteLine();
            Console.WriteLine("Press Any Button For Start.");
            Console.ReadLine();
            Console.Clear();
        }

        //글자 출력기
        static async Task Another(string message)
        {
            Random random = new Random();

            foreach (char c in message)
            {
                Console.Write(c);
                await Task.Delay(random.Next(75, 230));

            }

            Console.WriteLine();
        }

        //플레이어 글자 출력기
        static async Task Player(string message)
        {
            Random random = new Random();

            foreach (char c in message)
            {
                Console.Write(c);
                await Task.Delay(random.Next(25, 100));

            }

            Console.WriteLine();
        }
    }
}
