using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Notepad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("*                                                           *");
            Console.WriteLine("*           1:新建笔记          2：打开笔记                 *");
            Console.WriteLine("*           3:新建分类          4：管理分类                 *");
            Console.WriteLine("*           5:保存笔记          6：退出                     *");
            Console.WriteLine("*                                                           *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("请输入菜单选项（1-6）：");
            Note note = new Note();
            Classify classify = new Classify();
            while(true){
                int option;
                option = Int16.Parse(Console.ReadLine());
                switch (option)
            {
                case 1:
                    note.Create();
                   break;
                case 2:
                    note.Open();
                    break;
                case 3:
                    classify.Create();
                    break;
                case 4:
                    classify.Manage();
                    break;
                case 5:
                    note.Save();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("输入有误！");
                    break;
            }
            }
            
        }
        class Note
        {
            public void Create()
            {
                Console.WriteLine("创建笔记");
            }

            public void Open()
            {
                Console.WriteLine("打开笔记");
            }
            public void Save()
            {
                Console.WriteLine("保存笔记");
            }
        }
        class Classify
        {
            public void Create()
            {
                Console.WriteLine("新建分类");
            }
            public void Manage()
            {
                Console.WriteLine("管理分类");
            }
        }
    }
}

