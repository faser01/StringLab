using System;
using System.Collections.Generic;
using System.Text;



namespace StringLab
{
    class Class
    {
        static public void Print(string str)
        {

            Console.WriteLine(str);
        }
        static public void StrR(string str)
        {
            var stroka =str;

            const int interval = 1; // вставка пробела каждые interval символов

            var result = new StringBuilder();
            for (int i = 0; i < stroka.Length - 1; ++i)
            {
                result.Append(stroka[i]);
                if ((i + 1) % interval == 0)
                    result.Append(' ');
            }

            if (stroka.Length > 0)
                result.Append(stroka[stroka.Length - 1]);

            Console.WriteLine(result.ToString());
            
        }
        static public void Sym(string str)
        {
            Console.WriteLine("Колличество символовв строке - {0} = {1}", str, str.Length);
        }

    }
}
