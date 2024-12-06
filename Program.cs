using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day10
{
    internal class Program
    {
        /*Day8 함수 과제 1.다수의 인자값 요구 함수 구현**

        4개의 정수를 인자로 받아 가장 큰 수를 출력하는 함수 제작
        */
        /* 과제 1. 풀이
        //static void manyargument(int q, int w, int e, int r)
        //{
        //    int max = q;
        //    if (w > max)
        //    {
        //        max = w;
        //    }
        //    if (e > max) 
        //    {
        //        max = e;
        //    }
        //    if (r > max) 
        //    {
        //        max = r;
        //    }
        //    Console.WriteLine("최대값은"+max+"입니다");
        //}
        */
        /*Day8 함수과제 2. 다수의 인자값 및 반환형을 가진 함수 구현**

         5개의 float형을 인자로 받아
         그 중 가장 큰 두 수의 합을 실수형으로 반환하는 함수
         */
        /* 함수 과제 2. 풀이
        static float DecimalNumber (float num1,float num2,float num3,float num4,float num5)
        //{
        //    float qw;
        //    qw = num3 + num5;
        //    float qq;
        //    qq= num4 + num2;
        //    float qe;
        //    qe = num1 + num4;
        //    float qr;
        //    qr = num2 + num3;
        //
        //    Console.WriteLine(qw);
        //    return qw;
        //}
        */
        /* 과제 3. 특정 조건을 포함한 함수 제작**

           2개의 정수를 입력 받고, 두 수의 차이가 100 미만일 경우 참, 아니면 거짓 반환하는 함수
        */
        /*과제 3. 풀이
        //static bool CkarJwlt(int cka, int rjwlt ,out int area)
        //{
        //    area = cka + rjwlt;
        //
        //    return (cka + rjwlt) < 100;
        //    
        //}
        */
        /* Day 8심화 과제 1.복합조건을 가진 함수 제작
          인자값으로 정수형 하나가 주어지면, 숫자 1에서부터 인자값으로 전달받은 숫
          자 사이의 모든 자연수 중, 3의 배수이거나 5의 배수인 수들의 합을 구하여 정수
          형으로 반환하는 함수를 작성하세요
        */
        /* 심화 과제 1. 풀이
        static int Number(int num)
        {
            int strat=0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    strat += i;
                }
                
            }

            return strat;
        }
        */
        /* Day 8 심화 과제 2. 자릿수 합 디코더 제작**

            인자값으로 1이상의 수를 입력받았을 때
            주어진 정수의 각 자리 수를 더한 결과를 정수형으로 반환하는 함수를 작성하세요.
            예를 들어, 5611은 5+6+1+1 로 13을 반환하는 함수입니다.
              
         */
        /* 문제 풀이
        static int Number(int num)
        {
         int m = 0;
            while (num != 0)
            {
                m += num%10;
                num /= 10;
                
            
            }
            return m;
        }
        */
        /* 심화 과제 3. 피보나치 함수 제작
         * 피보나치 수란, 맨 첫째와 둘째 항은 각각 1이지만, 그 뒤로 오는 모든 항은 앞의 두 항의 합인
         * 수열입니다. 예를 들어 [1,1,2,3,5,8,...] 이렇게 4번째(3) 항목은 2번째(1)와 3번째(2)의 합이고
         * 마찬가지로 6번째(8) 항목은 바로 앞 4번째(3), 5번째(5)의 합인 형태입니다. 함수의 인자값으
         * 로 '몇번째' 인지 정수로 건네주면, 일치하는 피보나치 수를 반환하는 함수를 제작하세요. 참
         * 고로 11번째 피보나치 수는 89, 20번째 피보나치 수는 6765 입니다.
        */
        /*static int Number(int num)
        {
            int result = 0;
           
                for (int i = 0; i < 20; i++)
                {
                    

                }
                
            






            return result;
        }
        */
        /* Day 9 과제 풀이
        enum movement
        {
            village=1, huntingground, shop ,exit=9
        }
        */
        /* Day 9과제 2.상태를 열거형으로 구현*/
        enum movement
        {
            idle=1,run, walk,end=9
        }
        
        static void Main(string[] args)

        {
            /*과제0
            4개의 정수를 담을 수 있는 배열을 하나 생성 후,
            사용자에게 순서대로 값 입력 받아 순서대로 배열에 담기.
            해당 문을 포이치로 출력하기 (다른

            1. int 4개를 담을 배열을 선언
            2. "1번 요소를 입력하여주십시오" 출력 후 입력받기
            3. 나머지 번호도 마찬가지로 입력
            4. "입력된 요소는 다음과 같습니다" 다음 줄에 입력된 값들 4개 출력
            */
            /*과제풀이
            //int[] numbers= new int[4];
            //
            //Console.WriteLine("1번요소를 입력하여 주십시오");
            //int.TryParse(Console.ReadLine(), out numbers[0]);
            //Console.WriteLine("2번요소를 입력하여 주십시오");
            //int.TryParse(Console.ReadLine(), out numbers[1]);
            //Console.WriteLine("3번요소를 입력하여 주십시오");
            //int.TryParse(Console.ReadLine(), out numbers[2]);
            //Console.WriteLine("4번요소를 입력하여 주십시오");
            //int.TryParse(Console.ReadLine(), out numbers[3]);
            //
            //foreach (int qksqhrdyd in numbers)
            //{
            //    Console.WriteLine($"입력된 요소는 과 같습니다 "+ qksqhrdyd);
            //}
            */
            /*과제1
             * 플레이어에게 4개의 스킬이 있고, 각각 쿨타임이 존재. 매 턴마다 쿨타임이 줄어드는 기능 제작

            엔터 한번 입력 받을때마다 혹은 특정 키 한번 입력 할때마다 한 턴이 흐름

            1. 길이가 4인 int 배열 skillCooldowns를 만들기
            2. 초기값은 [5, 3, 10, 7]
            3. 매 턴마다 배열의 모든 값을 1씩 줄임
            4. 쿨타임이 0 이하가 되면 "스킬 X 사용 가능!"을 출력하고, 값을 그대로 0으로 유지
            5. 매 턴마다 배열의 상태를 출력
            */
            /* 과제풀이
            int[] skillCooldowns = new int[4];
            skillCooldowns[0] = 5;
            skillCooldowns[1] = 3;
            skillCooldowns[2] = 10;
            skillCooldowns[3] = 7;
            string[] skillname = new string[4];
            skillname[0] = "스킬1";
            skillname[1] = "스킬2";
            skillname[2] = "스킬3";
            skillname[3] = "스킬4";
            Console.WriteLine($"{skillname[0]}\n{skillname[1]}\n{skillname[2]}\n{skillname[3]}\n 사용할 스킬입력");
            int skill;
            int.TryParse(Console.ReadLine(), out skill);

            switch (skill)
            {
                 case 1:
                    Console.Clear();
                    for (int i = 5; i > 0; i--)
                    {
                        skillCooldowns[0] = i - 1;
                        Console.WriteLine($"{skillname[0]}이 {skillCooldowns[0]} 남았습니다");

                        Console.ReadLine();
                        if (skillCooldowns[0] <= 0)
                        {
                            Console.WriteLine($"{skillname[0]}이 사용가능!");
                    }

                    }

                    break;
                case 2:
                    Console.Clear();
                    for (int i = 3; i > 0; i--)
                    {
                        skillCooldowns[1] = i - 1;
                        Console.WriteLine($"{skillname[1]}이 {skillCooldowns[1]} 남았습니다");
                        Console.ReadLine();
                        if (skillCooldowns[1] <= 0)
                        {
                            Console.WriteLine($"{skillname[1]}이 사용가능!");
                        }

                    }

                    break;
                case 3:
                    Console.Clear();
                    for (int i = 10; i > 0; i--)
                    {
                        skillCooldowns[2] = i - 1;
                        Console.WriteLine($"{skillname[2]}이 {skillCooldowns[2]} 남았습니다");
                        Console.ReadLine();
                        if (skillCooldowns[2] <= 0)
                        {
                            Console.WriteLine($"{skillname[2]}이 사용가능!");
                        }

                    }

                    break;
                case 4:
                    Console.Clear();
                    for (int i = 7; i > 0; i--)
                    {
                        skillCooldowns[3] = i - 1;
                        Console.WriteLine($"{skillname[3]}이 {skillCooldowns[3]} 남았습니다");
                        Console.ReadLine();
                        if (skillCooldowns[3] <= 0)
                        {
                            Console.WriteLine($"{skillname[3]}이 사용가능!");
                        }

                    }

                    break;


            }
            */
            /*과제2
            4x4 16개의  정수를 담을 수 있는 2차원 배열을 만든 후,
            반복문을 이용하여 3의 배수들로 채워 넣는다.
            그 후 2행3열 요소와 3행 2열 요소를 바꾼 후 출력하여보자

            1. int형 2차원 배열을 선언
            2. 반복문을 통하여 순서대로 3의 배수들로 채워넣음
            3. 2행3열 요소와 3행 2열 요소를 바꾼다
            4. 4x4의 형태로 들어있는 숫자들을 출력
            */
            /*과제풀이
            //int[,] ints = new int[4,4];
            //int x = 3;
            //for (int i=0;i<4;i++)//i가 0~3까지 1씩증가
            //{
            //    for (int j=0;j<4;j++)//j가 0~3까지 1씩증가
            //    {
            //        ints[i, j] = x;
            //        x += 3;//x에 3씩 더하기
            //    }
            //}
            ////2열3행 3열2행 바꾸기
            ////21[1,2] 30[2,1]
            //ints[1, 2] = 30;
            //ints[2, 1] = 21;
            //
            //
            //for (int i = 0; i < ints.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ints.GetLength(1);j++)
            //    {
            //        Console.Write($"{ ints[i, j]}\n");
            //    }
            //   
            //}
            */
            /*심화과제1
             1차원 스트링 배열을 하나 만들고, 유저에게 원하는 크기를 입력받아 생성함.

            숫자가 아니거나, 음수거나, 10이 넘어가는 숫자를 입력시, 무한으로 재요구 하기

            생성 후, n칸의 인벤토리가 생성되었다고 출력하기.

            유저에게 무한 반복으로 몇번째 칸을 열람하겠냐고 숫자를 입력 받은 후,
            해당 칸이 "", 즉 비어있었다면 , "비어있습니다. 넣고자 하는 값을 입력하세요" 출력,
            해당 칸이 ""가 아닌 값이 들어있었다면 해당 값을 출력하기.
            종료를 원하면 0을 입력하라고 하기.

            1. "원하는 인벤토리의 크기를 입력하세요" 출력 후 숫자 입력받기. 1~10 아니면 무한반복
            2. "n개 만큼의 인벤토리가 생성되었습니다" 출력
            3. "열람을 원하는 번호를 입력해주시기 바랍니다" 출력 후 유저의 입력 받기

                (배열 0번째는 사람 눈엔 1번째)

            4. 칸이 비어있다면("" 이 들어있다면) "칸이 비었습니다. 값을 입력하세요" 출력
            5. 번호에 해당하는 칸에 내용물이 있었다면 해당 내용을 출력
            6. 출력 후 다시 "열람을 원하는 번호를 입력해주시기 바랍니다" 후 계속 유저 입력 받기
            7. 0을 입력받으면 무한반복 종료
            */
            /*과제풀이
            int inventorySize;
            bool numVer = false;
            while (true)
            {
                Console.WriteLine("원하는 인벤토리의 크기를 입력하세요");
                numVer = int.TryParse(Console.ReadLine(), out inventorySize);


                if (inventorySize > 10)
                {
                    Console.Clear();
                    Console.WriteLine("1~10사이의 수를 입력해주세요");


                }

                else if (numVer == false)
                {
                    Console.Clear();
                    Console.WriteLine("숫자로만 입력해주세요");


                }

                else if (inventorySize < 0)
                {
                    Console.Clear();
                    Console.WriteLine("1~10사이의 수를 입력해주세요");


                }
                else
                {
                    break;
                }

            }    

            string[] inventory = new string[inventorySize];
            for (int i = 0; i < inventorySize; i++)
            {
                inventory[i] = "";
            }

            Console.Clear();
            Console.WriteLine($"{inventorySize}개 만큼의 인벤토리가 생성되었습니다");
            int end = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("열람을 원하는 번호를 입력해주세요");
                Console.WriteLine("종료는 0번입니다");


                    int.TryParse(Console.ReadLine(), out int num);
                if (num ==end)
                {
                    Console.WriteLine("종료합니다");
                    break;
                }
                while (true)
                {
                    if (inventory.Length < num)
                    {
                        Console.Clear();
                        Console.WriteLine($"{inventory.Length}보다 입력한 숫자가 큽니다");
                        Console.WriteLine($"{inventory.Length}보다 작게 입력하세요");
                        int.TryParse(Console.ReadLine(), out num);
                    }
                    else
                    {
                        break;
                    }
                }
                switch (num)
                {
                    case 1:

                        if (inventory[0]=="")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[0]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[0] = Console.ReadLine());
                        }
                        else if (inventory[0] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[0]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[0] = Console.ReadLine());
                        }
                        else { break; }
                       break;
                    case 2:

                        if (inventory[1] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[1]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[1] = Console.ReadLine());
                        }
                        else if (inventory[1] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[1]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[1] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    case 3:

                        if (inventory[2] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[2]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[0] = Console.ReadLine());
                        }
                        else if (inventory[2] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[2]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[2] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    case 4:

                        if (inventory[3] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[3]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[3] = Console.ReadLine());
                        }
                        else if (inventory[3] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[3]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[3] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    case 5:

                        if (inventory[4] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[4]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[4] = Console.ReadLine());
                        }
                        else if (inventory[4] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[4]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[4] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    case 6:

                        if (inventory[5] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[5]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[5] = Console.ReadLine());
                        }
                        else if (inventory[5] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[5]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[5] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    case 7:

                        if (inventory[6] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[6]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[6] = Console.ReadLine());
                        }
                        else if (inventory[6] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[6]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[6] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    case 8:

                        if (inventory[7] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[7]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[7] = Console.ReadLine());
                        }
                        else if (inventory[7] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[7]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[7] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    case 9:

                        if (inventory[8] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[8]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[8] = Console.ReadLine());
                        }
                        else if (inventory[8] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[8]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[8] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    case 10:

                        if (inventory[9] == "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[9]}이 들어있습니다");
                            Console.WriteLine("원하는 값을 넣어주세요");
                            Console.WriteLine(inventory[9] = Console.ReadLine());
                        }
                        else if (inventory[9] != "")
                        {
                            Console.Clear();
                            Console.WriteLine($"{num}번째 인벤토리에 {inventory[9]}이 들어있습니다");
                            Console.WriteLine("변경하시려면 다시 입력하세요");
                            Console.WriteLine(inventory[9] = Console.ReadLine());
                        }
                        else { break; }
                        break;
                    default:

                        Console.Clear();
                        Console.WriteLine($"{inventory.Length}를 벗어났습니다");
                        break;

               }

            }


            }



            */
            /*
                //if (turnChoice == 1)
                // {
                //    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                //     //q스킬
                //    if (skillCooldown[0] == 0)
                //    {
                //   
                //        Console.WriteLine($"1.{skillName[0]}:\t 사용 가능!!!");
                //    }
                //    else if (skillCooldown[0]>0)
                //    { 
                //    Console.WriteLine($"1.{skillName[0]}:\t{skillCooldown[0]-=1}");
                //
                //    }
                //    //w스킬
                //    if (skillCooldown[1] == 0)
                //    {
                //        Console.WriteLine($"2.{skillName[1]}:\t사용가능 !!!!");
                //    }
                //    else if (skillCooldown[1] > 0)
                //    {
                //        Console.WriteLine($"2.{skillName[1]}:\t{skillCooldown[1] -= 1}");
                //    }
                //
                //    //e 스킬
                //    if (skillCooldown[2] == 0)
                //    {
                //        Console.WriteLine($"3.{skillName[2]}:\t 사용 가능");
                //    }
                //    else if (skillCooldown[2] > 0)
                //    {
                //        
                //    Console.WriteLine($"3.{skillName[2]}:\t{skillCooldown[2]-=1}"); 
                //    }
                //    //r스킬
                //    if (skillCooldown[3] == 0)
                //    {
                //        Console.WriteLine($"4.{skillName[3]}:\t사용 가능");
                //    }
                //    else if (skillCooldown[3] > 0)
                //    {
                //    Console.WriteLine($"4.{skillName[3]}:\t{skillCooldown[3]-=1}");
                //        
                //    }
                //    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");
                //
                //    Console.WriteLine("1.턴 넘기기");
                //    Console.WriteLine("2.스킬사용");
                //    int.TryParse(Console.ReadLine(), out turnChoice);
                //
                //
                //}


                //if (turnChoice == 2)
                //{

                // Console.WriteLine($"1.{skillName[0]}\n2.{skillName[1]}\n3.{skillName[2]}\n4.{skillName[3]} \n 중에 사용할 스킬 번호로 입력! ");
                // int.TryParse(Console.ReadLine(), out int skillNameNum);
            */
            /* 심화과제2 스킬사용 머리빠지는줄
            string[] skillName = new string[4];
            skillName[0] = "Q";
            skillName[1] = "W";
            skillName[2] = "E";
            skillName[3] = "R";

            int[] skillCooldown = new int[4];
            skillCooldown[0] = 5;
            skillCooldown[1] = 3;
            skillCooldown[2] = 10;
            skillCooldown[3] = 7;

            bool cka= false;

            Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
            Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
            Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

            Console.WriteLine("1.턴 넘기기");
            Console.WriteLine("2.스킬사용");
            Console.WriteLine("0.종료하기");

            cka = int.TryParse(Console.ReadLine(), out int choice);
            while (true)
            {

                if (cka == false)
                {
                    Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                    cka = int.TryParse(Console.ReadLine(), out choice);
               }
                else if (choice >= 3)
                {
                    Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                    cka = int.TryParse(Console.ReadLine(), out choice);
                }
                else if (choice < 0)
                {
                    Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                    cka = int.TryParse(Console.ReadLine(), out choice);
                }
                else { break; }
            }


            while (choice > 0)
            {

                Console.Clear();
                switch (choice)
                {
                    case 1://턴 넘기기

                        if (choice == 1)
                        {

                            Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                            //q스킬
                            if (skillCooldown[0] == 1)
                            {

                                Console.WriteLine($"1.{skillName[0]}:\t 사용 가능!!!!");
                            }
                            else if (skillCooldown[0] > 0)
                            {
                                Console.WriteLine($"1.{skillName[0]}:\t{skillCooldown[0] -= 1}");

                            }
                            //w스킬
                            if (skillCooldown[1] <= 1)
                            {
                                Console.WriteLine($"2.{skillName[1]}:\t 사용 가능!!!!");
                            }
                            else if (skillCooldown[1] > 0)
                            {
                                Console.WriteLine($"2.{skillName[1]}:\t{skillCooldown[1] -= 1}");
                            }

                            //e 스킬
                            if (skillCooldown[2] == 1)
                            {
                                Console.WriteLine($"3.{skillName[2]}:\t 사용 가능!!!!");
                            }
                            else if (skillCooldown[2] > 0)
                            {

                                Console.WriteLine($"3.{skillName[2]}:\t{skillCooldown[2] -= 1}");
                            }
                            //r스킬
                            if (skillCooldown[3] == 1)
                            {
                                Console.WriteLine($"4.{skillName[3]}:\t 사용 가능!!!!");
                            }
                            else if (skillCooldown[3] > 0)
                            {
                                Console.WriteLine($"4.{skillName[3]}:\t{skillCooldown[3] -= 1}");

                            }
                            Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                            Console.WriteLine("1.턴 넘기기");
                            Console.WriteLine("2.스킬사용");
                            Console.WriteLine("0.종료하기");
                            cka =int.TryParse(Console.ReadLine(), out choice);
                            while (true)
                            {

                                if (cka == false)
                                {
                                    Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                    cka = int.TryParse(Console.ReadLine(), out choice);
                                }
                                else if (choice >= 3)
                                {
                                    Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                    cka = int.TryParse(Console.ReadLine(), out choice);
                                }
                                else if (choice < 0)
                                {
                                    Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                    cka = int.TryParse(Console.ReadLine(), out choice);
                                }
                                else { break; }
                            }


                        }
                        else if (choice == 0)
                        {
                            break;
                        }
                        break;


                        //Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                        //Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");
                        //Console.WriteLine("1.턴 넘기기");
                        //Console.WriteLine("2.스킬사용");
                        //Console.WriteLine("0.종료하기");
                        //
                        //for (int i = 5; i > 0; i--)//Q스킬
                        //{
                        //
                        //
                        //    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]=i-1}\n2.{skillName[1]}:\t{skillCooldown[1]=i-1}\n3.{skillName[2]}:\t{skillCooldown[2]=i-1}\n1.{skillName[3]}:\t{skillCooldown[3]=i-1} ");
                        //    int.TryParse(Console.ReadLine(), out choice);
                        //}
                        //
                        //int.TryParse(Console.ReadLine(), out choice);
                        //
                        //break;

































                    case 2://스킬 사용

                        Console.Clear();
                        Console.WriteLine("사용할 스킬을 숫자로 입력해주세요");
                        Console.WriteLine($"1.{skillName[0]}\t2.{skillName[1]}\t3.{skillName[2]}\t4.{skillName[3]}");
                        int.TryParse(Console.ReadLine(), out choice);
                        while (true)
                        {

                            if (cka == false)
                            {
                                Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                cka = int.TryParse(Console.ReadLine(), out choice);
                            }
                            else if (choice >= 5)
                            {
                                Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                cka = int.TryParse(Console.ReadLine(), out choice);
                            }
                            else if (choice < 0)
                            {
                                Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                cka = int.TryParse(Console.ReadLine(), out choice);
                            }
                            else { break; }
                        }



                        switch (choice)

                            {
                                case 1://q스킬
                                Console.Clear();

                                if (skillCooldown[0] == 1)
                                    {

                                        Console.WriteLine($"{skillName[0]}을 사용 합니다");
                                    skillCooldown[0] = 5;
                                    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                                    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                                    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                                        Console.WriteLine("1.턴 넘기기");
                                        Console.WriteLine("2.스킬사용");
                                        Console.WriteLine("0.종료하기");
                                        int.TryParse(Console.ReadLine(), out choice);
                                    while (true)
                                    {

                                        if (cka == false)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice >= 3)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice < 0)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else { break; }
                                    }
                                }
                                    else if (skillCooldown[0] > 0)
                                    {

                                        Console.WriteLine($"{skillName[0]}은 아직 사용이 불가능합니다");
                                    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                                    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                                    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                                        Console.WriteLine("1.턴 넘기기");
                                        Console.WriteLine("2.스킬사용");
                                        Console.WriteLine("0.종료하기");
                                        int.TryParse(Console.ReadLine(), out choice);
                                    while (true)
                                    {

                                        if (cka == false)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice >= 3)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice < 0)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else { break; }
                                    }
                                }
                                    else if (choice == 0)
                                    { break; }


                                    break;




                                case 2://w스킬
                                Console.Clear();
                                if (skillCooldown[1] == 1)

                                    {

                                        Console.WriteLine($"{skillName[1]}을 사용 합니다");
                                         skillCooldown[1] = 3;
                                    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                                    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                                    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                                        Console.WriteLine("1.턴 넘기기");
                                        Console.WriteLine("2.스킬사용");
                                        Console.WriteLine("0.종료하기");
                                        int.TryParse(Console.ReadLine(), out choice);
                                    while (true)
                                    {

                                        if (cka == false)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice >= 3)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice < 0)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else { break; }
                                    }

                                }
                                    else if (skillCooldown[1] > 0)
                                    {
                                        Console.WriteLine($"{skillName[1]}은 아직 사용이 불가능합니다");
                                    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                                    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                                    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                                        Console.WriteLine("1.턴 넘기기");
                                        Console.WriteLine("2.스킬사용");
                                        Console.WriteLine("0.종료하기");
                                        int.TryParse(Console.ReadLine(), out choice);
                                    while (true)
                                    {

                                        if (cka == false)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice >= 3)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice < 0)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else { break; }
                                    }
                                }

                                    break;


                                case 3://e스킬
                                Console.Clear();
                                if (skillCooldown[2] == 1)
                                    {
                                        Console.WriteLine($"{skillName[2]}을 사용 합니다");
                                    skillCooldown[2] = 10;
                                    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                                    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                                    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                                        Console.WriteLine("1.턴 넘기기");
                                        Console.WriteLine("2.스킬사용");
                                        Console.WriteLine("0.종료하기");
                                        int.TryParse(Console.ReadLine(), out choice);
                                    while (true)
                                    {

                                        if (cka == false)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice >= 3)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice < 0)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else { break; }
                                    }

                                }
                                    else if (skillCooldown[2] > 0)
                                    {
                                        Console.WriteLine($"{skillName[2]}은 아직 사용이 불가능합니다");
                                    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                                    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                                    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                                        Console.WriteLine("1.턴 넘기기");
                                        Console.WriteLine("2.스킬사용");
                                        Console.WriteLine("0.종료하기");
                                        int.TryParse(Console.ReadLine(), out choice);
                                    while (true)
                                    {

                                        if (cka == false)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice >= 3)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice < 0)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else { break; }
                                    }
                                }
                                    break;


                                case 4://R스킬
                                Console.Clear();
                                if (skillCooldown[3] == 1)
                                    {
                                        Console.WriteLine($"{skillName[3]}을 사용 합니다");
                                    skillCooldown[3] = 7;
                                    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                                    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                                    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                                        Console.WriteLine("1.턴 넘기기");
                                        Console.WriteLine("2.스킬사용");
                                        Console.WriteLine("0.종료하기");
                                        int.TryParse(Console.ReadLine(), out choice);
                                    while (true)
                                    {

                                        if (cka == false)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice >= 3)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice < 0)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else { break; }
                                    }

                                }
                                    else if (skillCooldown[3] > 0)
                                    {
                                        Console.WriteLine($"{skillName[3]}은 아직 사용이 불가능합니다");
                                    Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                                    Console.Write($"1.{skillName[0]}:\t{skillCooldown[0]}\n2.{skillName[1]}:\t{skillCooldown[1]}\n3.{skillName[2]}:\t{skillCooldown[2]}\n1.{skillName[3]}:\t{skillCooldown[3]} ");
                                    Console.WriteLine("\n---------------------\n액션을 선택해주세요\n---------------------");

                                        Console.WriteLine("1.턴 넘기기");
                                        Console.WriteLine("2.스킬사용");
                                        Console.WriteLine("0.종료하기");
                                        int.TryParse(Console.ReadLine(), out choice);
                                    while (true)
                                    {

                                        if (cka == false)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice >= 3)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else if (choice < 0)
                                        {
                                            Console.WriteLine("선택지가 아닙니다 다시 입력해주세요");
                                            cka = int.TryParse(Console.ReadLine(), out choice);
                                        }
                                        else { break; }
                                    }
                                }
                                    break;
                                case 0:
                                    break;

                            }


                        break;

                        */
            /*Day8 함수 과제 1.다수의 인자값 요구 함수 구현**

            4개의 정수를 인자로 받아 가장 큰 수를 출력하는 함수 제작
            //manyargument(1, 100, 90, 101);
            */
            /*Day8 함수 과제 2. 다수의 인자값 및 반환형을 가진 함수 구현**

            5개의 float형을 인자로 받아, 그 중 가장 큰 두 수의 합을 실수형으로 반환하는 함수
            */
            /*과제 2. 풀이
              float decimalnumberfive;
              decimalnumberfive = DecimalNumber(-2, -9,-15 , -4, -20);
            */
            /* Day 8 과제 3. 특정 조건을 포함한 함수 제작**

            2개의 정수를 입력 받고, 두 수의 차이가 100 미만일 경우 참, 아니면 거짓 반환하는 함수
            */
            /* 과제 3. 풀이
            //int mainckarjwlt;
            //CkarJwlt(50, 30,out mainckarjwlt);
            //bool result = CkarJwlt(50,30,out mainckarjwlt);
            //Console.WriteLine(result);
            //Console.WriteLine(mainckarjwlt);
            */
            /* Day 8 심화 과제 1.복합조건을 가진 함수 제작
            //    인자값으로 정수형 하나가 주어지면, 숫자 1에서부터 인자값으로 전달받은 숫
            //    자 사이의 모든 자연수 중, 3의 배수이거나 5의 배수인 수들의 합을 구하여 정수
            //    형으로 반환하는 함수를 작성하세요
            */
            /*심화 과제 1.풀이
            Console.WriteLine("숫자를 입력하세요");
            int n =(int.Parse(Console.ReadLine()));
            int m = Number(n);


            Console.WriteLine($"1부터 {n}사이의 3의배수와 5의 배수를 더한 합 은{m} ");
            */
            /* Day 8 심화 과제 2. 자릿수 합 디코더 제작**

            인자값으로 1이상의 수를 입력받았을 때
            주어진 정수의 각 자리 수를 더한 결과를 정수형으로 반환하는 함수를 작성하세요.
            예를 들어, 5611은 5+6+1+1 로 13을 반환하는 함수입니다.

            */
            /* 문제 풀이
            Console.WriteLine("숫자를 입력하세요");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Number(n));
            */
            /* 심화 과제 3. 피보나치 함수 제작
             * 피보나치 수란, 맨 첫째와 둘째 항은 각각 1이지만, 그 뒤로 오는 모든 항은 앞의 두 항의 합인
             * 수열입니다. 예를 들어 [1,1,2,3,5,8,...] 이렇게 4번째(3) 항목은 2번째(1)와 3번째(2)의 합이고
             * 마찬가지로 6번째(8) 항목은 바로 앞 4번째(3), 5번째(5)의 합인 형태입니다. 함수의 인자값으
             * 로 '몇번째' 인지 정수로 건네주면, 일치하는 피보나치 수를 반환하는 함수를 제작하세요. 참
             * 고로 11번째 피보나치 수는 89, 20번째 피보나치 수는 6765 입니다.
            */
            /*
            Console.WriteLine(" 숫자 입력");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine(Number(m));
            */
            /* Day9 과제 1.열거형 리팩토링
            //위 코드는 과거 스위치문을 배울 때, 적었던 코드입니다.해당
            //코드는 스위치 문에서 1,2와 같이 숫자로만 적혀있어 가독성이
            //떨어지는 문제를 가지고 있습니다.열거형을 활용하여 해당 코
            드를 더욱 알아보기 쉽게 수정하여주세요.
            */
            /*문제 풀이
                Console.WriteLine("이동 할 장소를 설정해주세요");
                Console.WriteLine("1. 마을");
                Console.WriteLine("2. 사냥터");
                Console.WriteLine("3. 상점");
                Console.WriteLine("9.종료");
                movement  choices;
                Enum.TryParse(Console.ReadLine(), out choices);

                Console.Clear();
                switch (choices)
                {
                    case movement.village:
                        Console.WriteLine("마을로 이동합니다");
                        break;
                    case movement.huntingground:
                        Console.WriteLine("사냥터로 이동합니다");
                        break;
                    case movement.shop:
                        Console.WriteLine("상점으로 이동합니다");
                        break;
                    case movement.exit:
                    Console.WriteLine("종료입니다");
                    break;
                    default:
                        Console.WriteLine("1,2,3 어느것도 아니에요");
                        break;
                }

            */
            /* Day 9과제 2.상태를 열거형으로 구현
            누군가가 만든 프로그램에서, 플레이어의 현재 행동이 int state 로 정의되어
            있습니다. state변수에 1이 담겨 있으면 idle, 2가 담겨있으면 run, 3이 들어있
            으면 walk , 9가 담겨있으면 죽은 상태 입니다. 열거형을 활용하여 해당 코드
            를 어떻게 수정할 수 있는지 작성해주세요. 유저에게 콘솔 입력으로 1,2,3,9 
            외의 입력이 들어오면, 옳지 못한 입력이라고 출력 후,
            다시 입력을 요구하는 기능을 만드세요.
            */

            //1.제대로 입력이 되었다면, 예를 들어 run에 해당하는 상태가 입력되었다면 
            //idle에서 run으로 바뀌었다는 멘트 출력

            //2.이미 idle 상태였는데 idle 상태가 또 입력되면 ‘이미 idle상태입니다’ 출력 
            //3.입력 받고 다시 무한으로 계속 진행. 9가 입력되면 ‘죽었다는 관련 멘트’ 

            //나오고 무한루프 종료

            //int state=1 =idle
            //  2= run
            //3=walk
            //9=사망



             movement character= (movement)1;
            string[] characterstatus = new string[4];
            // characterstatus[0] = "idle";
            // characterstatus[1] = "run";
            // characterstatus[2] = "walk";
            // characterstatus[3] = "end";
            
            bool cka = false;
                Console.WriteLine("행동을 선택하세요");
                Console.WriteLine($"1.{movement.idle}");
                Console.WriteLine($"2.{movement.run}");
                Console.WriteLine($"3.{movement.walk}");
                Console.WriteLine($"9.{movement.end}");

                cka=int.TryParse(Console.ReadLine(), out int state);
            while (true)
            {
                if (state > characterstatus.Length)
                {
                    Console.WriteLine("없는 선택지입니다 다시 선택해주세요");
                    int.TryParse(Console.ReadLine(), out state);
                }
                else if (state < 0)
                {
                    Console.WriteLine("없는 선택지입니다 다시 선택해주세요");
                    int.TryParse(Console.ReadLine(), out state);
                }
                else if (cka == false)
                {
                    Console.WriteLine("숫자로 다시 선택해주세요");
                    int.TryParse(Console.ReadLine(), out state);
                }
                else { break; }
            }


            while (true)
            {
                
                        Console.WriteLine("숫자를 선택하세요");
                        Console.WriteLine($"1.{movement.idle}");
                        Console.WriteLine($"2.{movement.run}");
                        Console.WriteLine($"3.{movement.walk}");
                        Console.WriteLine($"9.{movement.end}");
                        int.TryParse(Console.ReadLine(), out state);
                

                switch (state)
                {

                    case (int)movement.idle:
                        
                        if ( characterstatus[0]!="idle")
                        { 
                           characterstatus[0] = "idle";

                           Console.WriteLine($"{characterstatus[0]}상태입니다");
                        }
                        else if ( characterstatus[0] == "idle")
                        {
                            Console.WriteLine($"이미 {characterstatus[0]}상태입니다");
                        }
                        break;

                    case (int)movement.run:
                        if (characterstatus[1] != "run")
                        {

                            characterstatus[1] = "run";
                            Console.WriteLine($"{characterstatus[1]}상태입니다");
                        }
                        else if (characterstatus[1] == "run")
                        {
                            Console.WriteLine($"이미 {characterstatus[1]}상태입니다");
                        }
                        break;

                    case (int)movement.walk:
                        if (characterstatus[3] != "walk")
                        {

                            characterstatus[3] = "walk";
                            Console.WriteLine($"{characterstatus[3]}상태입니다");
                        }
                        else if (characterstatus[3] == "walk")
                        {
                            Console.WriteLine($"이미 {characterstatus[3]}상태입니다");
                        }

                        break;

                    case (int)movement.end:
                        characterstatus[3] = "";
                        Console.WriteLine($"{characterstatus[3]}");
                        

                        break;
                    default:
                        
                        
                        break;
                }
                        

                
            }






    }
}
}