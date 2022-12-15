using System.Threading;

Random r = new Random();
int[,] m_one = new int[r.Next(2, 7), r.Next(2, 7)];
int x_pos, y_pos;
for(int i = 0; i < m_one.GetUpperBound(0) + 1; i++)
{
    for(int j = 0; j < m_one.GetUpperBound(1) + 1; j++)
    {
        m_one[i, j] = r.Next(0, 100);
    }
}
Console.WriteLine("Отрисовка матрицы по строкам");
for(int i = 0; i < m_one.GetUpperBound(0) + 1; i++)
{
    for(int j = 0; j < m_one.GetUpperBound(1) + 1; j++)
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Enum.GetName(typeof(ConsoleColor), r.Next(1, 15)));
        if (j != m_one.GetUpperBound(1))
        {
            if (m_one[i, j] % 10 == m_one[i, j])
            {
                Console.Write($" {m_one[i, j]} ");
            }
            else
            {
                Console.Write($"{m_one[i, j]} ");
            }
        }
        else
        {
            if (m_one[i, j] % 10 == m_one[i, j])
            {
                Console.Write($" {m_one[i, j]}");
            }
            else
            {
                Console.Write($"{m_one[i, j]}");
            }
        }
        Thread.Sleep(25);
    }
    Console.Write("\n");
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("Отрисовка матрицы с перевернутыми строками и столбцами");
for (int i = 0; i < m_one.GetUpperBound(1) + 1; i++)
{
    for (int j = 0; j < m_one.GetUpperBound(0) + 1; j++)
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Enum.GetName(typeof(ConsoleColor), r.Next(1, 15)));
        if (j == m_one.GetUpperBound(0) && i == m_one.GetUpperBound(1))
        {
            if (m_one[j, i] % 10 == m_one[j, i])
            {
                Console.Write($" {m_one[j, i]}");
            }
            else
            {
                Console.Write($"{m_one[j, i]}");
            }
        }
        else
        {
            if (m_one[j, i] % 10 == m_one[j, i])
            {
                Console.Write($" {m_one[j, i]} ");
            }
            else
            {
                Console.Write($"{m_one[j, i]} ");
            }
        }
    }
    Console.Write("\n");
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("Отрисовка массива по столбцам по очереди\nдля наглядности сделана задержка после отображения каждого элемента");

y_pos = Console.CursorTop;
x_pos = Console.CursorLeft;

if (m_one.GetUpperBound(0) == m_one.GetUpperBound(1))
{
    for (int i = 0; i < m_one.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < m_one.GetUpperBound(1) + 1; j++)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Enum.GetName(typeof(ConsoleColor), r.Next(0, 15)));
            if (Console.ForegroundColor == default)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            if (m_one[j, i] % 10 == m_one[j, i])
            {
                Console.Write($" {m_one[j, i]}");
            }
            else
            {
                Console.Write($"{m_one[j, i]}");
            }
            Thread.Sleep(25);
            Console.BackgroundColor = default;
            Console.CursorTop++;
            Console.CursorLeft = x_pos;
        }
        if (i == m_one.GetUpperBound(1))
        {
            Console.ForegroundColor = ConsoleColor.White;
            break;
        }
        Console.CursorTop = y_pos;
        x_pos += 3;
        Console.CursorLeft = x_pos;
    }
}
//для не квадратных матриц
else
{
    int changeSize = m_one.GetUpperBound(0) - m_one.GetUpperBound(1);
    for (int i = 0; i < m_one.GetUpperBound(0) + 1 - changeSize; i++)
    {
        for (int j = 0; j < m_one.GetUpperBound(1) + 1 + changeSize; j++)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Enum.GetName(typeof(ConsoleColor), r.Next(1, 15)));
            if (Console.ForegroundColor == default)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            if (m_one[j, i] % 10 == m_one[j, i])
            {
                Console.Write($" {m_one[j, i]}");
            }
            else
            {
                Console.Write($"{m_one[j, i]}");
            }
            Thread.Sleep(25);
            Console.BackgroundColor = default;
            Console.CursorTop++;
            Console.CursorLeft = x_pos;
        }
        if (i == m_one.GetUpperBound(0) - changeSize)
        {
            Console.ForegroundColor = ConsoleColor.White;
            break;
        }
        Console.CursorTop = y_pos;
        x_pos += 3;
        Console.CursorLeft = x_pos;
    }
}