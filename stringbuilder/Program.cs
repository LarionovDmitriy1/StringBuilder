using System.Text;
Console.WriteLine("Введите строку");
string select = Console.ReadLine();
StringBuilder st = new StringBuilder(select);
void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Меню");
    Console.WriteLine();
    Console.WriteLine("1. Заменить какой-либо символ на другой");
    Console.WriteLine("2. Удалить символы");
    Console.WriteLine("3. Добавить к исходной строке ещё строку");
    Console.WriteLine("4. Просмотреть строку");
}
void GetMenu()
{
    string menu1 = Console.ReadLine();
    bool menu2 = int.TryParse(menu1, out var menu);
    if (menu == 1)
    {
        if (st.Length == 0)
        {
            Console.WriteLine();
            Console.WriteLine("В строке нет символов");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(st);
            Console.WriteLine();
            Console.WriteLine("Что вы хотите заменить?");
            string sel = Console.ReadLine();
            string a = st.ToString();
            bool b = char.TryParse(a, out var sell);
            if (!a.Contains(sel))
            {
                Console.WriteLine();
                Console.WriteLine("Такого символа нет");
                Console.WriteLine();
            }
            else if (sell == ' ')
            {
                Console.WriteLine();
                Console.WriteLine("Нельзя заменить пустое место");
                Console.WriteLine();
            }
            else
            {
                if (sell == ' ')
                {
                    Console.WriteLine();
                    Console.WriteLine("Нельзя заменить на пустое место");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("На что вы хотите заменить?");
                    string zam = Console.ReadLine();
                    st.Replace(sel, zam);
                }
            }
        }
    }
    else if (menu == 2)
    {
        if (st.Length == 0)
        {
            Console.WriteLine();
            Console.WriteLine("В строке нет символов");
            Console.WriteLine();
        }
        else
        {
            st.Remove(0, st.Length);
            Console.WriteLine();
            Console.WriteLine("Символы удалены");
            Console.WriteLine();
        }
    }
    else if (menu == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Введите строку");
        string select = Console.ReadLine();
        if (st.Length == 0)
        {
            st.Append(select);
        }
        else
        {
            st.Append(' ' + select);
        }
    }
    else if (menu == 4)
    {
        if (st.Length == 0)
        {
            Console.WriteLine();
            Console.WriteLine("В строке нет символов");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(st);
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Введите пункт из меню");
        Console.WriteLine();
    }
}
while (true)
{
    Menu();
    GetMenu();
}