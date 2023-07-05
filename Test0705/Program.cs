/*
 * 程式邏輯題目1:
 * 請設計一個函數，輸入為數字，輸出則為*符號為輸入數字邊長的空心正三角形。
 */
int size = 3; // 輸入邊長為3
Console.WriteLine($"以下為邊長為{size}的空心正三角形");
for (int i = 0; i < size; i++)
{
    if (i != size - 1) // 非底邊時的繪製
    {
        for (int j = 0; j < 2 * size - 1; j++)
        {
            if (j == size - i - 1 || j == size + i - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
    else
    {
        //底邊繪製
        for (int j = 0; j < size; j++)
        {
            Console.Write("* ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("=============================");

/*
 * 程式邏輯題目2:
 * QA部門今天舉辦團康活動，有n個人圍成一圈，順序排號。從第一個人開始報數（從1到3報數），凡報到3的人退出圈子。
請利用一段程式計算出，最後留下的那位同事，是所有同事裡面的第幾順位?
 */
int JosephusCirculeRemainIndex(int n) // n為人數
{
    int p = 0;
    for (int i = 2; i <= n; i++)
    {
        p = (p + 3) % i;
    }
    return p + 1; // 最後一位留下的人的位置
}
Console.WriteLine($"最後留下的同事是所有同事裡第{JosephusCirculeRemainIndex(10)}順位"); //人數10人, 最後一位在第4個位置



