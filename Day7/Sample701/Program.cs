using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();      // 一つ目のPersonクラスのメソッドのインスタンスを生成
            p2 = new Person();      // 二つ目のPersonクラスのメソッドのインスタンスを生成
            p1.Name = "山田太郎";   // フィールドnameに値を代入
            p1.Age = 19;            // フィールドageに値を代入
            p2.SetAgeAndName("佐藤花子", 23);   // SetAgeAndName()メソッドで、nameとageを設定
            p1.ShowAgeAndName();    // メソッドから、名前と年齢を表示
                                    // プロパティから名前と何例を表示
            Console.WriteLine("名前：{0} 年齢：{1}", p2.Name, p2.Age);
            // Console.WriteLine($"名前：{p2.Name} 年齢：{p2.Age}"); これでもいける
        }
    }
}
