using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "\t" "\n"

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write(i * j + "\t"); // "\t" מוסיף רווח מ"סוג" טאב (TAB)
            //    }   //  שיוצר שורות מסודרות עם רווחים קבועים, אפילו שלפעמים i*j
            //    // הוא מספר חד ספרתי ולפעמים הוא דו ספרתי
            //    Console.Write("\n"); // יורד שורה
            //    if (i == 8)
            //    {
            //        Console.WriteLine("\n"); // יורד 2 שורות, 1 בגלל רייטליין ועוד 1 בגלל \n
            //    }
            //}

            //  Console.WriteLine("\"); // המערכת לא מקבלת את זה - היא מצפה לקבת פקודה
            //Console.WriteLine("\\"); // אם בכל זאת רוצים להדפיס "\" צריך לכתוב פעמיים
            //Console.WriteLine(@"\"); // או לכתוב @ לפני ואז הוא יודע שאני רוצה פשוט להדפיס ולא לתת פקודה מיוחדת
            //Console.WriteLine(@"\t");

            #endregion

            #region default values

            // משתנה מסוג bool
            // הערך בברירת מחדל הוא false

            // string
            // default value = null

            // char
            // default value = '0'

            // int, long, short, double, float, כל סוג מספרי
            // defalut value = 0

            #endregion

            #region Arrays - מערכים

            //bool[] myBoolArr = new bool[5]; // הצהרה על מערך של 5 משתנים בוליאנים.
            //// אחרי שהגדרתי מערך של 5 משתנים, אי אפשר להוסיף או להפחית משתנים
            //// כמובן שאפשר לשנות את ערכם
            //// בשלב הזה כל אחד מהאיברים במערך יקבלו ערך default
            //myBoolArr[0] = true; // המשתנה הראשון במערך = true
            //myBoolArr[4] = true; // המשתנה החמישי (אחרון) = true


            //string[] myStrArr = { "1", "Moshe", "", "HackerU" }; // הגדרה של מערך מסוג string
            //// בעל 4 משתנים וככבר נתתי לכל אחד מהם ערכים בהגדרה הראשונית
            //// אע"פ שלא אמרתי לו כמה משתנים אני רוצה, הוא יצר את המערך עם 4 משתנים כי נתתים לו 4 ערכים

            //int[] grades = new int[3] { 100, 90, 80 }; // הגדרה והצבת ערכים.
            //// במקרה כזה אני חייב לתת 3 ערכים שונים. הקומפיילר לא יקבל 4 וגם לא 2

            //char[] myChars; // יש אפשרות להגדיר מערך גם אם עוד לא ידוע לי כמה משתנים (איברים) יהיו בו
            //// אך חשוב לזכור שאני עוד לא יכול להתשמש במערך, להציב ערכים, עד שאגדיר
            //// כמה משתנים (איברים) יהיו בו
            //int size = int.Parse(Console.ReadLine());
            //myChars = new char[size]; // כאן יצרתי את המערך, ע"י שקבעתי את הגודל שלו

            //Console.WriteLine(grades.Length); // נותן לי את מס' האיברים שיש במערך, במקרה זה 3 
            //for (int i = 0; i < grades.Length; i++) // שימושי בלולאה כדי לעבור על כל המערך
            //{
            //}

            #endregion

            #region Ex. 1

            //int[] intArr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    if (intArr[i] % 2 == 0)
            //    {
            //        Console.WriteLine(intArr[i]);
            //    }
            //}

            #endregion

            #region Ex. 2

            //int[] intArr1 = new int[10];
            //int[] intArr2 = new int[10];

            //Console.WriteLine("Please enter 10 values for each array:");
            //for (int i = 0; i < intArr1.Length; i++)
            //{
            //    Console.WriteLine("Array 1 [{0}]: ", i);
            //    intArr1[i] = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Array 2 [{0}]: ", i);
            //    intArr2[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < intArr1.Length; i++)
            //{
            //    if(intArr1[i]>intArr2[i])
            //    {
            //        Console.WriteLine(intArr1[i]);
            //    }
            //    else if(intArr2[i]>intArr1[i])
            //    {
            //        Console.WriteLine(intArr2[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("they're equals");
            //    }
            //}

            #endregion

            #region tips $

            //int a = 2;
            //int b = 3;
            //int c = 4;

            //Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            //Console.WriteLine($"a = {a}, b = {b}, c = {c}"); // אותו דבר כמו שורה למעלה

            //Console.WriteLine($"a = {5}, b = {"bee"}, c = {true}"); // אפשר גם להציב ערכים קבועים ולאו דווקא משתנים

            //Console.WriteLine($"a = \" {a} \""); // ככה כותבים " בתוך cw: \"

            #endregion

            #region snippet

            // יצירת קיצורי דרך במקלדת לשימוש ב- visual studio
            // לדוגמא cw + TAB+TAB במקום 
            // Console.WriteLine()


            /*
              מעתיקים את הנוסח הזה לקובץ טקסט

            <?xml version="1.0" encoding="utf-8"?>
            <CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
            <CodeSnippet Format="1.0.0">
            <Header>
            <Title>Console-ReadLine</Title>               // כותרת
            <Description>Console-ReadLine</Description>     // תיאור
            <Shortcut>cr</Shortcut>                         // מקשי הקיצור
            </Header>
            <Snippet>
            <Code Language="csharp">
            <![CDATA[Console.ReadLine()]]>                  // הקוד המלא
            </Code>    
            </Snippet>
            </CodeSnippet>
            </CodeSnippets>


        */

            #endregion

        }
    }
}
