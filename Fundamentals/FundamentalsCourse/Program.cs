using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FundamentalsCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UPRAZNENIE ot Glava 2
            //ushort fValue = 52130;
            //sbyte sValue = -115;
            //uint tValue = 4825932;
            //byte foValue = 97;
            //short fiValue = -10000;
            //ushort siValue = 20000;
            //byte seValue = 224;
            //uint eValue = 970700000;
            //byte nValue = 112;
            //sbyte teValue = -44;
            //int elValue = -1000000;
            //ushort twValue = 1990;
            //ulong thValue = 123456789123456789;
            ////real types
            //double r1V = 34.567839023;
            //float r2V = 12.345f;
            //float r3V = 8923.1234567f;
            //decimal r4V = 3456.091124875956542151256683467m;
            //float edno = 3334.456329237f;
            //double dve = 3334.456329237;
            //bool istina = Math.Abs(edno - dve) < 0.000001;
            //Console.WriteLine(istina);
            //Console.WriteLine(edno);
            //Console.WriteLine(dve);
            //int sest = 0x100;
            //Console.WriteLine(sest);
            //char uni = '\u0048';
            //Console.WriteLine(uni);

            //string str1 = "Hello";
            //string str2 = "World";
            //object obj = str1 + " " + str2; ;
            //Console.WriteLine(obj);
            //string str3 = (string)obj;

            //string str4 = "The \"use\" of quotations causes difficulties";

            //short a = 5;
            //short b = 4;
            //Console.WriteLine(a+b);
            //Console.WriteLine(a+b++);
            //Console.WriteLine(a+b);
            //Console.WriteLine(a+b);
            //Console.WriteLine(a+(++b));
            //Console.WriteLine(a+b);

            //byte a = 0b00001000;
            //byte b = 0b00000110;
            //Console.WriteLine("{0} {1}",a,b);
            //Console.WriteLine(a|b);
            //Console.WriteLine(a&b);
            //Console.WriteLine(a^b);
            //Console.WriteLine(a<<2);
            //Console.WriteLine(a>>2);
            //Console.WriteLine(b>>2);
            //Console.WriteLine(b<<2);
            //Console.WriteLine(~a&b);
            //Console.WriteLine(a&~b);
            //int x = 6;
            //Console.WriteLine(x|=2);
            // Console.WriteLine(x%=2);                  
            //int num1 = int.Parse(Console.ReadLine());
            //bool bit3 = (num1 & 8) != 0;
            //if (bit3)
            //{
            //    Console.WriteLine("zada4ata e gotova");
            //}
            //else
            //{
            //    Console.WriteLine("ne");
            //}
            //int number=Convert.ToInt32(Console.ReadLine());
            //double chovek=number*0.17;
            //Console.WriteLine(chovek);
            //int num=Convert.ToInt32(Console.ReadLine());
            //int a = num % 10;
            //int b = (num / 10)%10;
            //int c = (num / 100)%10;
            //int d = (num / 1000)%10;
            //int sum = a + b + c + d;
            //Console.WriteLine(sum);
            //Console.WriteLine($"{a}{b}{c}{d}");
            //Console.WriteLine($"{a}{d}{c}{b}");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int p = Convert.ToInt32(Console.ReadLine());
            //int edno = 1;
            //int mask = edno << p;
            //Console.WriteLine((n & mask) != 0 ? 1 : 0);
            //int n = Convert.ToInt32(Console.ReadLine());
            //int p = Convert.ToInt32(Console.ReadLine());
            //bool v=Convert.ToBoolean(Console.ReadLine());
            //if (v)
            //{
            //    n=n|(1<<p);
            //    Console.WriteLine(n);
            //}
            //else
            //{
            //    n=n&(~(1<<p));
            //    Console.WriteLine(n);
            //GLAVA 3
            //}
            //int num = 458219657;
            //string binary=Convert.ToString(num,2);
            //int bit3 = (num >> 3) & 1;
            //int bit4 = (num >> 4) & 1;
            //int bit5 = (num >> 5) & 1;
            //int bit24 = (num >> 24) & 1;
            //int bit25 = (num >> 25) & 1;
            //int bit26 = (num >> 26) & 1;
            //num = num & (~(1 << 24)) | (bit3 << 24);
            //num = num & (~(1 << 3)) | (bit24 << 3);
            //num = num & (~(1 << 25)) | (bit4 << 25);
            //num = num & (~(1 << 4)) | (bit25 << 4);
            //num = num & (~(1 << 26)) | (bit5 << 26);
            //num = num & (~(1 << 5)) | (bit26 << 5);
            //Console.WriteLine(bit3);
            //Console.WriteLine(bit4);
            //Console.WriteLine(bit5);
            //Console.WriteLine(bit24);
            //Console.WriteLine(bit25);
            //Console.WriteLine(bit26);
            //Console.WriteLine(binary);
            //Console.WriteLine(num);
            //string binary1 = Convert.ToString(num, 2);
            //Console.WriteLine(binary1);

            //int numer=2;
            //int number = 1048575;
            //numer =numer|(1 << 7);
            //string binary1er = Convert.ToString(numer, 2);
            //number =number&(~(1 << 14)|(1<<14));
            //Console.WriteLine(binary1er);
            //string binaryNer = Convert.ToString(number, 2);
            //Console.WriteLine(binaryNer);

            //GLAVA 4
            //Console.Write("Enter firm name:");
            //string firmName=Console.ReadLine();
            //Console.Write("Enter firm address:");
            //string firmAddress = Console.ReadLine();
            //Console.Write("Enter firm telefone number:");
            //string firmTel = Console.ReadLine();
            //Console.Write("Enter firm faxs number:");
            //string firmFaxs = Console.ReadLine();
            //Console.Write("Enter firm Web number:");
            //string firmWeb = Console.ReadLine();
            //Console.Write("Enter Manager name:");
            //string manName = Console.ReadLine();
            //Console.Write("Enter Manager famili name:");
            //string manFname = Console.ReadLine();
            //Console.Write("Enter Manager phone number:");
            //string manPhone = Console.ReadLine();
            //Console.WriteLine("The company name is {0} with address {1} and phone {2} and fax {3} numbers The web addres is {4}",firmName,firmAddress,firmTel,firmFaxs,firmWeb);
            //Console.WriteLine("The manager is {0} {1}. His phone number is {2}",manName,manFname,manPhone);

            //int num = 2014;
            //double num1 = -2014.14;
            //double num2 = 2018.14;
            //Console.WriteLine("{0,-1:x}",num);
            //Console.WriteLine("{0,-8}", num1);
            //Console.WriteLine("{0,-8}", num2);

            //int num1=int.Parse(Console.ReadLine());
            //int num2=int.Parse(Console.ReadLine());
            //int num3=int.Parse(Console.ReadLine());
            //if (num1>num2)
            //{
            //    if (num1>num3)
            //    {
            //        Console.WriteLine(num1);
            //    }
            //    else
            //    {
            //        Console.WriteLine(num3);
            //    }
            //}
            //else
            //{
            //    if (num2>num3)
            //    {
            //        Console.WriteLine(num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(num3);
            //    }
            //}
            //int type=Convert.ToInt32(Console.ReadLine());
            //string nu=Console.ReadLine();
            //switch (type)
            //{
            //    case 0:
            //        int vremInt=Convert.ToInt32(nu);
            //        vremInt += 1;
            //        Console.WriteLine(vremInt);
            //        break;
            //    case 1:
            //        double vremDou = Convert.ToDouble(nu);
            //        vremDou += 1;
            //        Console.WriteLine(vremDou);
            //        break;
            //    case 2:                    
            //        nu += "*";
            //        Console.WriteLine(nu);
            //        break;
            //    default:
            //        break;
            //}
            //int num = int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 0:
            //        Console.WriteLine("error");
            //        break;
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine(num * 10);
            //        break;
            //    case 4:
            //    case 5:
            //    case 6:
            //        Console.WriteLine(num * 100);
            //        break;
            //    case 7:
            //    case 8:
            //    case 9:
            //        Console.WriteLine(num * 1000);
            //        break;

            //    default:
            //        Console.WriteLine("error");
            //        break;
            //}
            //int N=int.Parse(Console.ReadLine());
            //int K=2*N;
            //decimal Nf = 1;
            //decimal Kf = 1;
            //int NK = N +1;
            //decimal NKf = 1;
            //while (true)
            //{
            //    if (N<=1)
            //    {
            //        break;
            //    }
            //    Nf *= N;
            //    N--;
            //}
            //while (true)
            //{
            //    if (K <= 1)
            //    {
            //        break;
            //    }
            //    Kf *= K;
            //    K--;
            //}
            //while (true)
            //{
            //    if (NK <= 1)
            //    {
            //        break;
            //    }
            //    NKf *= NK;
            //    NK--;              
            //}
            //Console.WriteLine(Kf/NKf*Nf);
            //int n=int.Parse(Console.ReadLine());
            //int x=int.Parse(Console.ReadLine());
            //double factorial = 1;
            //double power = 0;
            //double sum=1;
            //for (int k = 1; k <=n; k++)
            //{
            //    factorial *= k;
            //    power = Math.Pow(x, k);

            //    sum += factorial / power;
            //}
            //Console.WriteLine(sum);
            //int n= int.Parse(Console.ReadLine());
            //for (int i = 1; i <=n; i++)
            //{
            //    for (int l = i; l <=i+n-1; l++)
            //    {
            //        Console.Write(l);
            //    }
            //    Console.WriteLine();
            //}

            ////Преобразуване от десетична в двоична и от двоична в десетична.
            //int n = int.Parse(Console.ReadLine());
            //int m = n;
            //string delenie = String.Empty;
            //while (n >= 1)
            //{
            //    if (n % 2 == 0)
            //    {
            //        Console.Write(0);
            //        delenie += 0;
            //        n /= 2;
            //    }
            //    else
            //    {
            //        Console.Write(1);
            //        n /= 2;
            //        delenie += 1;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(delenie);
            //int lenght = delenie.Length;
            //Console.WriteLine(lenght);
            //string obratno = string.Empty;
            //for (int i = lenght - 1; i >= 0; i--)
            //{
            //    obratno += delenie[i];
            //}
            //Console.WriteLine(obratno);
            //bool cifra = false;
            //double sum = 0;
            //for (int b = 0; b <= lenght - 1; b++)
            //{
            //    cifra = Convert.ToBoolean(Convert.ToInt32(delenie[b].ToString()));
            //    if (cifra == true)
            //    {
            //        sum +=  Math.Pow(2, b);
            //    }
            //    Console.WriteLine(obratno[b]);
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine("{0:X}",m);
            ////Преобразуване от десетична в шестнайсетична и от шестнайсетична в десетична.
            //int n = int.Parse(Console.ReadLine());
            //int ostatak = 0;
            //string chest = string.Empty;
            //while (n > 0)
            //{
            //    ostatak = n % 16;
            //    n /= 16;
            //    if (ostatak == 15)
            //    {
            //        chest += "F";

            //    }
            //    else if (ostatak == 14)
            //    {
            //        chest += "E";
            //    }
            //    else if (ostatak == 13)
            //    {
            //        chest += "D";
            //    }
            //    else if (ostatak == 12)
            //    {
            //        chest += "C";
            //    }
            //    else if (ostatak == 11)
            //    {
            //        chest += "B";
            //    }
            //    else if (ostatak == 10)
            //    {
            //        chest += "A";
            //    }
            //    else
            //    {
            //        chest += ostatak;
            //    }
            //}
            //Console.WriteLine(chest);
            //int lenght = chest.Length;
            //Console.WriteLine(lenght);
            //string obratno = string.Empty;
            //for (int i = lenght - 1; i >= 0; i--)
            //{
            //    obratno += chest[i];
            //}
            //Console.WriteLine(obratno);
            ////от шестнайсетична в десетична.
            //int cifra = 0;
            //double deset = 0;
            //for (int b = 0; b <= lenght - 1; b++)
            //{

            //    if (chest[b] == 'F')
            //    {
            //        deset += 15 * Math.Pow(16, b);

            //    }
            //    else if (chest[b] == 'E')
            //    {
            //        deset += 14 * Math.Pow(16, b);

            //    }
            //    else if (chest[b] == 'D')
            //    {
            //        deset += 13 * Math.Pow(16, b);

            //    }
            //    else if (chest[b] == 'C')
            //    {
            //        deset += 12 * Math.Pow(16, b);
            //    }
            //    else if (chest[b] == 'B')
            //    {
            //        deset += 11 * Math.Pow(16, b);
            //    }
            //    else if (chest[b] == 'A')
            //    {
            //        deset += 10 * Math.Pow(16, b);
            //    }
            //    else
            //    {
            //        cifra = int.Parse(chest[b].ToString());
            //        deset += cifra * Math.Pow(16, b);
            //    }

            //}
            //Console.WriteLine(deset);
            //Zada4i ot masivi        
            //int[] masiv= {3,4,2,9,12,90,56,44};
            //for(int i=0;i<masiv.Length;i++)
            //{
            //    masiv[i]=5*masiv[i];
            //    Console.WriteLine(masiv[i]+" ");
            //}

            //int n1=int.Parse(Console.ReadLine());
            //int n2=int.Parse(Console.ReadLine());
            //int[] masive1=new int[n1];
            //int[] masive2=new int[n2];
            //bool equal = true;
            //for (int i = 0; i < masive1.Length; i++)
            //{
            //    masive1[i]=int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < masive2.Length; i++)
            //{
            //    masive2[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i=0; i<masive1.Length; i++)
            //{
            //    if (masive1.Length==masive2.Length)
            //    {
            //        if (masive1[i]==masive2[i])
            //        {

            //        }
            //        else
            //        {
            //            equal = false;
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        equal=false;
            //        break;
            //    }

            //}
            //Console.WriteLine(equal);
            //zada4a 3
            //char[] chars = { 'a', 'b', 'g', 'j' };
            //char[] chars1 = { 'a', 'b', 'g', 'j' };
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    if (chars[i]!=chars1[i])
            //    {
            //        if (chars[i]<chars1[i])
            //        {
            //            Console.WriteLine("char masive e po rano");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("char1 masive e po rano");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        if (chars.Length<chars1.Length)
            //        {
            //            Console.WriteLine("char masive e po rano");
            //        }
            //        else if (chars[i]>chars1[i])
            //        {
            //            Console.WriteLine("char1 masive e po rano");                        
            //        }
            //    }
            //}

            //zada4a 4 
            //int[] mas = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1,9,9,9,9 };
            //int beststart=0;
            //int bestLen=0;
            //int Len=0;
            //for (int i = 1; i < mas.Length; i++)
            //{
            //    if (mas[i-1]==mas[i])
            //    {                    
            //        Len+=1;
            //        if (Len>bestLen)
            //        {
            //            bestLen = Len;
            //            beststart = mas[i];                        
            //        }
            //    }
            //    else
            //    {
            //        Len = 1;                   
            //    }
            //}            
            // Console.WriteLine("{0}{1}", bestLen, beststart);

            //zada4a 5
            //int[] mas = { 2, 2, 3, 4, 5,6, 2, 2, 2, 1, 9, 9, 9, 9 };
            //int beststart = 0;
            //int bestLen = 0;
            //int Len = 0;
            //for (int i = 1; i < mas.Length; i++)
            //{
            //    if (mas[i - 1] < mas[i])
            //    {
            //        Len += 1;
            //        if (Len > bestLen)
            //        {
            //            bestLen = Len;
            //            beststart = mas[i-Len];
            //        }
            //    }
            //    else
            //    {
            //        Len = 1;
            //    }
            //}
            //Console.WriteLine("{0}{1}", bestLen, beststart);
            //zada4a 7
            //int K=int.Parse(Console.ReadLine());
            //int[] N = { 2, 4, 5, 8, 1, 20, 6 };
            //int sum = 0;
            //int srav = 0;
            //int index=0;
            //for (int i = 0; i < N.Length-1; i++)
            //{
            //    for (int j = i; j <K+i ; j++)
            //    {
            //        sum+=N[j];
            //        if (sum>srav)
            //        {
            //            srav = sum;
            //            index=i;
            //        }
            //    }
            //    sum = 0;
            //}
            //for (int i = index; i < K+index; i++)
            //{
            //    Console.Write(N[i]+" ");
            //}
            //zada4a 8
            //int[] N = { 2, 4, 5, 8, 1, 20, 6 };
            //int[] N1 = new int[N.Length];
            //int jMin = 0;
            //int temp = 0;
            //for (int i = 0; i < N.Length - 1; i++)
            //{
            //    jMin = i;
            //    for (int j = i + 1; j < N.Length; j++)
            //    {
            //        if (N[j] < N[jMin])
            //        {
            //            jMin = j;
            //        }
            //    }
            //    N1[i] = N[jMin];
            //    if (jMin != i)
            //    {
            //        temp = N[i];
            //        N[i] = N[jMin];
            //        N[jMin] = temp;
            //    }
            //}
            //foreach (var item in N)
            //{
            //    Console.Write(item + " ");
            //}
            //zada4a 9
            //int[] N = { 2, 3, -6, -1, 2, -1, 6,4,-8,8};
            //int sum = 0;
            //int max = int.MinValue;
            //for (int i = 0; i <N.Length; i++)
            //{
            //    sum+=N[i];
            //    if (sum<0)
            //    {
            //        sum = 0;
            //        continue;
            //    }
            //    if (sum>max)
            //    {
            //        max = sum;
            //    }
            //}
            //Console.WriteLine(max);
            //zada4a 10
            //int[] N = {4, 1, 1, 4, 2, 3, 4, 4, 1, 1,4,9,3};
            //int count = 1;
            //int prebroeno = 0;
            //int cifra = 0;
            //for (int i = 0; i <N.Length; i++)
            //{
            //    for (int j = i+1; j < N.Length; j++)
            //    {
            //        if (N[j]==int.MinValue)
            //        {
            //            continue;
            //        }
            //        if (N[i]==N[j])
            //        {
            //            count++;
            //            N[j] = int.MinValue;
            //        }
            //    }
            //    if (count>prebroeno)
            //    {
            //        prebroeno = count;
            //        cifra =N[ i];
            //    }
            //    count = 1;
            //    N[i] = int.MinValue;
            //}
            //Console.WriteLine("{0} {1}",cifra,prebroeno);
            //zada4a 11
            //int[] N = { 4, 3, 1, 4, 2, 5, 8 };
            //int S=int.Parse(Console.ReadLine());
            //int sum = 0;
            //int num1 = 0;
            //int num2 = 0;
            //for (int i = 0; i < N.Length; i++)
            //{
            //    for (int j = i; j < N.Length; j++)
            //    {
            //        sum+=N[j];
            //        if (sum==S)
            //        {
            //            num1 = i;
            //            num2 = j;
            //        }
            //        if (sum>S)
            //        {
            //            break;
            //        }
            //    }
            //    sum = 0;
            //}
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //for (int i = num1; i <= num2; i++)
            //{
            //    Console.Write(N[i]);
            //}

            //zada4a 12 yslovie a
            //int razmernost = int.Parse(Console.ReadLine());
            //int[,] data = new int[razmernost, razmernost];
            //for (int row = 0; row < data.GetLength(0); row++)
            //{
            //    for (int col = 0; col < data.GetLength(1); col++)
            //    {
            //        data[row, col] = col * data.GetLength(0) + 1 + row;
            //        Console.Write(data[row, col] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //zada4a 12 yslovie b
            //int razmernost = int.Parse(Console.ReadLine());
            //int[,] data = new int[razmernost, razmernost];
            //for (int row = 0; row < data.GetLength(0); row++)
            //{
            //    for (int col = 0; col < data.GetLength(1); col++)
            //    {
            //        if (col%2==0||col==0)
            //        {
            //        data[row, col] = col * data.GetLength(0) + 1 + row;
            //        Console.Write(data[row, col] + "  ");

            //        }
            //        else
            //        {
            //            data[row, col] = col * data.GetLength(0) + data.GetLength(0)- row;
            //            Console.Write(data[row, col] + "  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //zada4a 15
            //string imme = Console.ReadLine().ToUpper();
            //int dalzina = imme.Length;
            //int indexer = 0;
            //for (int i = 0; i < dalzina; i++)
            //{
            //    indexer = (int)imme[i] - 65;
            //    Console.WriteLine(indexer + " ");
            //}
            //zada4a 23
            //int N=int.Parse(Console.ReadLine());
            //int K=int.Parse(Console.ReadLine());
            //int[] mas=new int[N];
            //for(int i=1;i<=N;i++)
            //{
            //    for (int j = 1; j <= N; j++)
            //    {
            //        Console.Write("{0},{1}",i,j+" ");
            //    }
            //}
            //zada4a 13
            //Console.WriteLine("Enter the number of the rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of the columns: ");
            //int cols = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[rows, cols];
            //int bestsum = int.MinValue;
            //int bestRow = 0;
            //int bestCol = 0;
            //Console.WriteLine("Enter the cells of the matrix");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.WriteLine("matrix[{0},{1}]= ", i, j);
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            //    {
            //        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]+
            //            matrix[row+1,col]+matrix[row+1,col+1]+ matrix[row + 1, col + 2]+
            //           matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
            //        if (sum>bestsum)
            //        {
            //            bestsum = sum;
            //            bestRow = row;
            //            bestCol = col;
            //        }
            //    }
            //}
            //Console.WriteLine("The best platform is:");
            //Console.WriteLine(" {0} {1} {2}",matrix[bestRow,bestCol],matrix[bestRow, bestCol+1], matrix[bestRow, bestCol + 2]);
            //Console.WriteLine(" {0} {1} {2}",matrix[bestRow+1,bestCol],matrix[bestRow+1, bestCol+1], matrix[bestRow+1, bestCol + 2]);
            //Console.WriteLine(" {0} {1} {2}",matrix[bestRow+2,bestCol],matrix[bestRow+2, bestCol+1], matrix[bestRow+2, bestCol + 2]);
            //Console.WriteLine("The maximum sum is is: {0}",bestsum);
            ////////////Training
            //int[] testMas = { 2, 5, 78, 45, 1, 99, 5, 77, 43, 7, 3, 8 };
            //int maxi = testMas.Max();
            //int mini = testMas.Min();
            //int sum = testMas.Sum();
            //int avera = (int)testMas.Average();
            //Console.WriteLine("{0} {1} {2} {3}", maxi, mini, sum, avera);
            //for (int i = 0; i < testMas.Length; i++)
            //{
            //    Console.Write(testMas[i] + " ");
            //}
            //Console.WriteLine();

            //zada4i ot glava 8
            ////Преобразуване от десетична в двоична и от двоична в десетична.
            // int n = int.Parse(Console.ReadLine());
            // int m = n;
            // string delenie = String.Empty;
            // while (n >= 1)
            // {
            //     if (n % 2 == 0)
            //     {
            //         Console.Write(0);
            //         delenie += 0;
            //         n /= 2;
            //     }
            //     else
            //     {
            //         Console.Write(1);
            //         n /= 2;
            //         delenie += 1;
            //     }
            // }
            // Console.WriteLine();
            // // Console.WriteLine(delenie);
            // int lenght = delenie.Length;
            // // Console.WriteLine(lenght);
            // string obratno = string.Empty;
            // for (int i = lenght - 1; i >= 0; i--)
            // {
            //     obratno += delenie[i];
            // }
            // Console.WriteLine(obratno);
            // bool cifra = false;
            // double sum = 0;
            // for (int b = 0; b <= lenght - 1; b++)
            // {
            //     cifra = Convert.ToBoolean(Convert.ToInt32(delenie[b].ToString()));
            //     if (cifra == true)
            //     {
            //         sum += Math.Pow(2, b);
            //     }
            //     Console.WriteLine(obratno[b]);
            // }
            // Console.WriteLine(sum);
            // Console.WriteLine("{0:X}", m);
            // //directno preobrazuvane v dvoi4na
            // string bin = Convert.ToString(m, 2);
            // Console.WriteLine(bin);
            // //directno preobrazuvane v 6estnaiseti4na
            //string desShe= m.ToString("X");
            // Console.WriteLine(desShe);

            ////Преобразуване от десетична в шестнайсетична и от шестнайсетична в десетична.
            //int n = int.Parse(Console.ReadLine());
            //int ostatak = 0;
            //string chest = string.Empty;
            //while (n > 0)
            //{
            //    ostatak = n % 16;
            //    n /= 16;
            //    if (ostatak == 15)
            //    {
            //        chest += "F";

            //    }
            //    else if (ostatak == 14)
            //    {
            //        chest += "E";
            //    }
            //    else if (ostatak == 13)
            //    {
            //        chest += "D";
            //    }
            //    else if (ostatak == 12)
            //    {
            //        chest += "C";
            //    }
            //    else if (ostatak == 11)
            //    {
            //        chest += "B";
            //    }
            //    else if (ostatak == 10)
            //    {
            //        chest += "A";
            //    }
            //    else
            //    {
            //        chest += ostatak;
            //    }
            //}
            //Console.WriteLine(chest);
            //int lenght = chest.Length;
            ////Console.WriteLine(lenght);
            //string obratno = string.Empty;
            //for (int i = lenght - 1; i >= 0; i--)
            //{
            //    obratno += chest[i];
            //}
            //Console.WriteLine(obratno);
            //////от шестнайсетична в десетична.
            //int cifra = 0;
            //double deset = 0;
            //for (int b = 0; b <= lenght - 1; b++)
            //{

            //    if (chest[b] == 'F')
            //    {
            //        deset += 15 * Math.Pow(16, b);

            //    }
            //    else if (chest[b] == 'E')
            //    {
            //        deset += 14 * Math.Pow(16, b);

            //    }
            //    else if (chest[b] == 'D')
            //    {
            //        deset += 13 * Math.Pow(16, b);

            //    }
            //    else if (chest[b] == 'C')
            //    {
            //        deset += 12 * Math.Pow(16, b);
            //    }
            //    else if (chest[b] == 'B')
            //    {
            //        deset += 11 * Math.Pow(16, b);
            //    }
            //    else if (chest[b] == 'A')
            //    {
            //        deset += 10 * Math.Pow(16, b);
            //    }
            //    else
            //    {
            //        cifra = int.Parse(chest[b].ToString());
            //        deset += cifra * Math.Pow(16, b);
            //    }

            //}
            //Console.WriteLine(deset);
            //zada4a 9 Двоично в шестнайсетично
            // string binValue = Console.ReadLine();
            // int binLenght = binValue.Length;
            // string notLenght = string.Empty;
            // string hexResult = string.Empty;
            // if (binLenght % 4 != 0)
            // {
            //     binValue = "0" + binValue;
            //     binLenght = binValue.Length;
            //     if (binLenght % 4 != 0)
            //     {
            //         binValue = "0" + binValue;
            //         binLenght = binValue.Length;
            //     }
            //     if (binLenght % 4 != 0)
            //     {
            //         binValue = "0" + binValue;
            //         binLenght = binValue.Length;
            //     }
            // }
            // for (int i = 0; i < binLenght; i += 4)
            // {
            //     notLenght = binValue.Substring(i, 4);
            //     switch (notLenght)
            //     {
            //         case "0001":
            //             hexResult += "1";
            //             break;
            //         case "0010":
            //             hexResult += "2";
            //             break;
            //         case "0011":
            //             hexResult += "3";
            //             break;
            //         case "0100":
            //             hexResult += "4";
            //             break;
            //         case "0101":
            //             hexResult += "5";
            //             break;
            //         case "0110":
            //             hexResult += "6";
            //             break;
            //         case "0111":
            //             hexResult += "7";
            //             break;
            //         case "1000":
            //             hexResult += "8";
            //             break;
            //         case "1001":
            //             hexResult += "9";
            //             break;
            //         case "1010":
            //             hexResult += "A";
            //             break;
            //         case "1011":
            //             hexResult += "B";
            //             break;
            //         case "1100":
            //             hexResult += "C";
            //             break;
            //         case "1101":
            //             hexResult += "D";
            //             break;
            //         case "1110":
            //             hexResult += "E";
            //             break;
            //         case "1111":
            //             hexResult += "F";
            //             break;
            //         default:
            //             break;
            //     }
            // }
            //// Console.WriteLine(binValue);
            // Console.WriteLine(hexResult);
            //зада4а 8  Шестнайсетично в Двоично
            //string binValue = Console.ReadLine();
            //int binLenght = binValue.Length;
            //string notLenght = string.Empty;
            //string hexResult = string.Empty;
            //for (int i = 0; i < binLenght; i++)
            //{
            //    notLenght = binValue.Substring(i, 1);
            //    switch (notLenght)
            //    {
            //        case "1":
            //            hexResult += "0001";
            //            break;
            //        case "2":
            //            hexResult += "0010";
            //            break;
            //        case "3":
            //            hexResult += "0011";
            //            break;
            //        case "4":
            //            hexResult += "0100";
            //            break;
            //        case "5":
            //            hexResult += "0101";
            //            break;
            //        case "6":
            //            hexResult += "0110";
            //            break;
            //        case "7":
            //            hexResult += "0111";
            //            break;
            //        case "8":
            //            hexResult += "1000";
            //            break;
            //        case "9":
            //            hexResult += "1001";
            //            break;
            //        case "A":
            //            hexResult += "1010";
            //            break;
            //        case "B":
            //            hexResult += "1011";
            //            break;
            //        case "C":
            //            hexResult += "1100";
            //            break;
            //        case "D":
            //            hexResult += "1101";
            //            break;
            //        case "E":
            //            hexResult += "1110";
            //            break;
            //        case "F":
            //            hexResult += "1111";
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine(hexResult);
            //zada4a 14 Triabva da se sme ni samo tipa na promenlivite v float i sled tova na double
            //decimal num = 0.000001m;
            //decimal result = 0;
            //for (int i = 0; i < 50000000; i++)
            //{
            //    result+=num;
            //}
            //Console.WriteLine(result);
            //string rim=Console.ReadLine();
            //int lenght=rim.Length;
            //char symbol = ' ';
            //int value=0;
            //int second=0;
            //int sum=0;
            //for (int i = 0; i < lenght; i++)
            //{
            //    symbol = rim[i];
            //    switch (symbol)
            //    {
            //        case 'I':
            //            value = 1;
            //            break;
            //        case 'V':
            //            value = 5;
            //            break;
            //        case 'X':
            //            value = 10;
            //            break;
            //        case 'L':
            //            value = 50;
            //            break;
            //        case 'C':
            //            value = 100;
            //            break;
            //        case 'D':
            //            value = 500;
            //            break;
            //        case 'M':
            //            value = 1000;
            //            break;
            //        default:
            //            break;
            //    }                
            //    if (i==0)
            //    {
            //        second = value;
            //        sum= value;
            //        continue;
            //    }
            //    if (second>=value)
            //    {
            //        sum +=value;
            //    }
            //    else
            //    {
            //        sum -= value;
            //    }
            //    second = value;
            //}
            //Console.WriteLine(sum);

            //METODS Методи
            // PrintReceipt();
            //PrintSign(0);
            //PrintNumbers(end:40,start:35);

            //zada4i star u4ebnik
            //string ime=Console.ReadLine();
            //PrintName(ime);
            //string izhod = RepeatString("roki", 5);
            //Console.WriteLine(izhod);
            //int num=int.Parse(Console.ReadLine());
            //ReadandProcessMessage(num);
            //zada4i metodi zada4a 1
            //string myName=Console.ReadLine();
            //MyName(myName);
            //zada4i metodi zada4a 2
            //int num1=int.Parse(Console.ReadLine());
            //int num2=int.Parse(Console.ReadLine());
            //int num3=int.Parse(Console.ReadLine());
            //Console.WriteLine(GetMax(num1, num2));
            //Console.WriteLine(GetMoreMax(num1,num2,num3));
            //Console.WriteLine(GetMax(GetMax(num1,num2),num3));
            //zada4a 3
            //int num1 = int.Parse(Console.ReadLine());
            //string digitName=string.Empty;
            //digitName = GetLastDigit(num1);
            //Console.WriteLine(digitName);
            //zada4a 4
            //Console.WriteLine(CountOccurences(new int[] {3,2,2,5,1,-8,7,2},2));
            //zada4a 5
            //Console.WriteLine(GreaterThanNeighbours(new int[] { 1, 3, 2, 5, 4 }, 3));
            //zada4a 6
            //int n = 4;
            //int nm = -1;
            //bool boling = false;
            //for (int i = 1; i < n; i++)
            //{
            //   boling= GreaterThanNeighbours(new int[] { 1, 2, 2, 2, 4 }, i);
            //    if (boling==true)
            //    {
            //        nm= i;
            //    }
            //}
            //Console.WriteLine(nm);
            //zada4a 7
            //GetBackwardValue(25647);
            //Console.WriteLine();
            //zada4a 11
            //Console.WriteLine("For digit backward write 1;For average write 2;For Linear 3");
            //int choise=int.Parse(Console.ReadLine());
            //if (choise==1)
            //{
            //    Console.WriteLine("Write integer value");
            //    int num=int.Parse(Console.ReadLine());
            //    GetcBackwardDigits(num);
            //}
            //else if (choise == 2)
            //{
            //    Console.WriteLine("Write number of average values");
            //    Console.WriteLine(GetAverageValue(int.Parse(Console.ReadLine())));
            //}
            //else if (choise == 3)
            //{
            //    Console.WriteLine("Write parameter \"b\" and a for linear");
            //    int b=int.Parse(Console.ReadLine());
            //    int a=int.Parse(Console.ReadLine());
            //    Console.WriteLine(GetLinearEquation(b, a));
            //}
            //else
            //{
            //    Console.WriteLine("Write number between 1-3");
            //}

            // try
            // {
            //     int num = int.Parse(Console.ReadLine());
            //     double sqrt = Math.Sqrt(num);
            //     Console.WriteLine(sqrt);
            // }
            // catch (Exception)
            // {
            //     Console.WriteLine("Invalid Number");
            // }
            //finally { Console.WriteLine("Good Bye"); }
            //int start=int.Parse(Console.ReadLine());
            //int end=int.Parse(Console.ReadLine());
            //int cikal=int.Parse(Console.ReadLine());
            // int broene = 0;
            // while (broene<cikal)
            // {
            //     Readnumber(start, end);
            //     broene++;
            // }
            //zada3a 3 str 506
            //string scoba = "((a+b)/5-d)";
            //int indec = 0;
            //foreach (char arg in scoba)
            //{
            //    if (arg == '(')
            //    {
            //        indec++;
            //    }
            //    else if (arg == ')')
            //    {
            //        indec--;
            //    }
            //}
            //if (indec<0 || indec>0)
            //{
            //    Console.WriteLine("nekorectno");
            //}
            //else
            //{
            //    Console.WriteLine("korectno");
            //}
            //zada4a- 4 str 506
            //  string zasplit = "edno\\dve\\tri";
            //  char[] charArr = new char[] {'\\'};
            //  string [] splitnati=zasplit.Split('\\');
            //foreach (string c in splitnati)
            //  {
            //      Console.WriteLine(c);
            //  }
            //zada4a 5 str 506
            //string dalagText = "We are living in a yellow submarine. We do not have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.`";
            //int toLover=dalagText.ToLower().IndexOf("in");
            //int count = 0;
            //while (toLover !=-1)
            //{
            //   toLover=dalagText.ToLower().IndexOf("in",toLover+2);
            //    count++;
            //}
            //Console.WriteLine(count);
            //zada4a 6 str 506
            //string gh = "We are living in a <upcase>yellow submarine</upcase>. We do not have <upcase>anything</upcase> else.";
            //int index1 = gh.IndexOf("<upcase>");
            //string upCase = "<upcase>";
            //string upCase2 = "</upcase>";
            //int upLenght = upCase.Length;
            //int upLenght1 = upCase2.Length;
            //int index2 = gh.IndexOf("</upcase>");
            //while (index1 != -1)
            //{
            //    string in1 = gh.Substring(index1, index2 - index1 + upLenght1);
            //    string osnovno = gh.Substring(index1 + upLenght, index2 - index1 - upLenght1).ToUpper();
            //    gh = gh.Replace(in1, osnovno);
            //    index1 = gh.IndexOf("<upcase>", index1 + upLenght);
            //    index2 = gh.IndexOf("</upcase>", index2 - 3);

            //}
            //// gh = gh.Replace(index1)
            ////  Console.WriteLine(in1);
            //// Console.WriteLine(osnovno);
            //Console.WriteLine(gh);
            //zada4a 7 str 507
            //string str = "We are living in";
            //int lenght=str.Length;
            //if (lenght < 20)
            //{
            //str = str.PadRight(20, '*');
            //}
            //Console.WriteLine(str);
            //zada4a 8 str 507
            //string n = "Test";
            //foreach (char arg in n)
            //{
            //    Console.WriteLine("\\u{0:x4}", Convert.ToUInt16(arg));
            //}
            //zada4a 10 str 507
            //string kk = "We are living in a yellow submarine. We do not have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            //char sep = '.';
            //string [] splited=kk.Split(sep);
            //foreach (string  item in splited)
            //{
            //    int index = item.IndexOf(" in ");
            //    if (index >= 0) 
            //    {                                  
            //        Console.WriteLine(item);                                        
            //        index = -1;
            //    }
            //}

            string nm = "kl";
            string nm2 = "kl";
            string nm3 = "kL";
            bool eQ = nm.Equals(nm2);
            bool eQ2 = string.Equals(nm3, nm,StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("{0} ili {1}", eQ, eQ2);
            string.Compare(nm, nm2, StringComparison.CurrentCultureIgnoreCase);
          

            







        }















        //static void PrintReceiptHeader()
        //{
        //    Console.WriteLine("CASH RECEIPT");
        //    Console.WriteLine("----------------------");
        //}
        //static void PrintReceiptBody()
        //{
        //    Console.WriteLine("Charget to----------------");
        //    Console.WriteLine("Received by---------------");
        //}
        //static void PrintReceiptFooter()
        //{
        //    Console.WriteLine("---------------------");
        //    Console.WriteLine("(c)SoftUni");
        //}
        //static void PrintReceipt()
        //{
        //    PrintReceiptHeader();
        //    PrintReceiptBody(); 
        //    PrintReceiptFooter();   
        //}
        //static void PrintSign(int n)
        //{
        //    if (n > 0)
        //    {
        //        Console.WriteLine($"The number {n} is positive");
        //    }
        //    else if (n < 0)
        //    {
        //        Console.WriteLine($"The number {n} is negative");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The number {n} is zero");
        //    }
        // }
        //static void PrintNumbers(int start=0, int end = 100)
        // {
        //     for (int i = start; i <=end; i++)
        //     {
        //         Console.WriteLine("{0}",i);
        //     }
        // }
        //static void PrintName(string name)
        // {
        //     Console.WriteLine("Hello, {0}!",name);
        // }
        //static string RepeatString(string str, int count)
        // {
        //     string repeatString = string.Empty;
        //     for (int i = 0; i < count; i++)
        //     {
        //         repeatString = repeatString + str;
        //     }
        //     return repeatString;
        // }
        //static void ReadandProcessMessage(int nMessages)
        // {
        //     for (int i = 0; i < nMessages; i++)
        //     {
        //         Console.WriteLine("messageType=");
        //         string messageType=Console.ReadLine();
        //         if (messageType=="success")
        //         {
        //             Console.WriteLine("operation");
        //             string oper=Console.ReadLine();
        //             Console.WriteLine("message");
        //             string mess=Console.ReadLine();
        //             ShowSuccessMessage(oper, mess);
        //             Console.WriteLine();
        //         }
        //         else if (messageType == "error")
        //         {
        //             Console.WriteLine("operation");
        //             string oper = Console.ReadLine();
        //             Console.WriteLine("message");
        //             string mess = Console.ReadLine();
        //             Console.WriteLine("Error Code");
        //             int errCode=int.Parse(Console.ReadLine());
        //             ShowErrorMessage(oper, mess, errCode);
        //             Console.WriteLine();
        //         }
        //         else if(messageType == "warning")
        //         {
        //             Console.WriteLine("message");
        //             string mess = Console.ReadLine();
        //             ShowWarningMessage(mess);
        //             Console.WriteLine();
        //         }
        //     }        
        //}
        //static void ShowSuccessMessage(string operation,string message)
        //{
        //    Console.WriteLine("Successfully executed {0}.",operation);
        //    Console.WriteLine("======================================");
        //    Console.WriteLine("{0}",message);
        //}
        //static void ShowWarningMessage(string message)
        //{
        //    int lenght=message.Length;
        //    Console.WriteLine("Warning: {0}.", message);
        //    Console.WriteLine(new string('=',lenght+10));            
        //}
        //static void ShowErrorMessage(string operation, string message,int errorCode)
        //{
        //    int lenght = message.Length;
        //    Console.WriteLine("Error: Failed to execute {0}.", message);
        //    Console.WriteLine(new string('=', lenght + 26));
        //    Console.WriteLine("Reason: {0}.",message);
        //    Console.WriteLine("Error code {0}.",errorCode);
        //}
        //static void MyName(string name)
        //{
        //    Console.WriteLine("Hello, {0}",name);
        //}
        //static int GetMax(int n1,int n2)
        //{
        //  return  Math.Max(n1, n2);
        //}
        //static int GetMoreMax(int nm1,int nm2,int nm3)
        //{
        //    int firstBig=GetMax(nm1,nm2);
        //    return GetMax(firstBig,nm3);
        //}
        //static string GetLastDigit(int number)
        //{
        // zada4a 3
        //    int lastDigit=number%10;
        //    string name=string.Empty;
        //    switch (lastDigit)
        //    {
        //        case 0:
        //            name = "zero";
        //            break;
        //        case 1:
        //            name = "one";                   
        //            break;
        //        case 2:
        //            name = "two";
        //            break;
        //        case 3:
        //            name = "three";
        //            break;
        //        case 4:
        //            name = "four";
        //            break;
        //        case 5:
        //            name = "five";
        //            break;
        //        case 6:
        //            name = "six";
        //            break;
        //        case 7:
        //            name = "seven";
        //            break;
        //        case 8:
        //            name = "eight";
        //            break;
        //        case 9:
        //            name = "nine";
        //            break;
        //        default:
        //            break;
        //    }
        //    return name;
        //}
        //zada4a 4
        //static int CountOccurences(int[] ari, int num)
        //{
        //    int maches = 0;
        //    foreach (int exact in ari)
        //    {
        //        if (exact == num)
        //        {
        //            maches++;
        //        }
        //    }
        //    return maches;
        //}
        //zada4a 5
        //static bool GreaterThanNeighbours(int[] arri, int position)
        //{
        //    bool BoolLogic = false;
        //    int lenght = arri.Length;
        //    if (position == 0)
        //    {
        //        BoolLogic = true;
        //        return BoolLogic;
        //    }
        //    if (position == 0)
        //    {
        //        if (arri[position] > arri[1])
        //        {
        //            BoolLogic = true;
        //        }
        //    }
        //    else if (position == lenght - 1)
        //    {
        //        if (arri[position] > arri[position - 1])
        //        {
        //            BoolLogic = true;
        //        }
        //    }
        //    else
        //    {
        //        if ((arri[position] > arri[position - 1]) && (arri[position] > arri[position + 1]))
        //        {
        //            BoolLogic = true;
        //        }
        //    }
        //    return BoolLogic;
        //}
        //zada4a 7
        //static void GetBackwardValue(int num)
        //{
        //    string str = num.ToString();
        //    int lenght = str.Length;
        //    for (int i = 0; i < lenght; i++)
        //    {
        //        Console.Write(num % 10);
        //        num /= 10;
        //    }
        //}
        //zada4a 11
        //static void GetcBackwardDigits(int num)
        //{
        //    string value=num.ToString();
        //    int lenght=value.Length;
        //    for (int i=0; i<lenght; i++)
        //    {
        //        int digit=num%10;
        //        num=num/10;
        //        Console.Write(digit);
        //    }
        //}
        //static double GetAverageValue(int count)
        //{
        //    double average = 0;
        //    if (count==0)
        //    {
        //        return 0;
        //    }
        //    for (int i = 1; i <= count; i++)
        //    {
        //       double average1 = double.Parse(Console.ReadLine());
        //        average += average1;
        //    }
        //    return average / count;
        //}
        //static double GetLinearEquation(int b,int a)
        //{
        //    double x=0;
        //    if (a==0)
        //    {
        //        Console.WriteLine("parameter a not be =0");
        //        return 0;
        //    }
        //    else
        //    {
        //        x = -b / a;
        //    }
        //    return x;
        //}

        //static void Readnumber(int start, int end)
        //{
        //    int nb=int.Parse(Console.ReadLine());
        //    if (nb < start || nb > end)
        //    {
        //        throw new ArithmeticException();
        //    }
        //}














    }
}
