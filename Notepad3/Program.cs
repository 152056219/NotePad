using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.Menu1();
        }
    }
    class SortFunction
    {
        Notebook mynote = new Notebook();
        //新建分类
        public void sort(Object sender1, FunctionEventArgs e2)
        {
            if (e2._choose == 2)
            {
                //创建一个文件夹
                Console.WriteLine("请输入笔记的类型：");
                mynote.Classify = Console.ReadLine();
                if (!System.IO.Directory.Exists(@"E:\C#\" + mynote.classify))
                {
                    string activeDir = @"E:\C#";
                    string newPath = System.IO.Path.Combine(activeDir, mynote.classify);
                    System.IO.Directory.CreateDirectory(newPath);
                    Console.WriteLine("创建成功！");
                }
                else
                {
                    Console.WriteLine("文件类已经存在");
                }
            }
        }
        //查询所有分类
        public List<string> findCategory()
        {
            string[] folders = System.IO.Directory.GetDirectories(@"E:\C#");
            List<string> list = new List<string>();
            foreach (string category in folders)
            {
                list.Add(category.Substring(category.LastIndexOf('\\') + 1));
            }
            return list;
        }

        public void showCategory(Object sender1, FunctionEventArgs e2)
        {
            if (e2._choose == 1)
            {
                foreach (string category in findCategory())
                {
                    Console.WriteLine("存在的分类有：" + category);
                }
            }
        }

        //修改分类
        public void ModifySort(Object sender1, FunctionEventArgs e2)
        {
            if (e2._choose == 4)
            {
                Console.Clear();
                Console.WriteLine("请输入需要修改的分类：");
                mynote.Classify = Console.ReadLine();
                if (!System.IO.Directory.Exists(@"E:\C#" + mynote.classify))
                {
                    try
                    {
                        System.IO.Directory.Delete(@"E:\C#\" + mynote.classify);
                        Console.WriteLine("修改后的分类名");
                        mynote.classify = Console.ReadLine();
                        string activeDir = @"E:\C#";
                        string newPath = System.IO.Path.Combine(activeDir, mynote.classify);
                        System.IO.Directory.CreateDirectory(newPath);
                        Console.WriteLine("修改成功！");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("修改的分类不存在");
                    }
                }
            }
        }
        //删除分类
        public void Delete(Object sender1, FunctionEventArgs e2)
        {
            if (e2._choose == 3)
            {
                Console.WriteLine("请输入需要删除的分类：");
                mynote.classify = Console.ReadLine();
                if (System.IO.Directory.Exists(@"E:\C#\" + mynote.classify))
                {

                    try
                    {
                        System.IO.Directory.Delete(@"E:\C#\" + mynote.classify);
                        Console.WriteLine("删除成功!");

                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("删除的文件类型不存在!");
                }
            }
        }
    }
    class Notebook
    {
        public string title;//笔记名称
        public string content;//笔记内容
        public string classify;//笔记类型

        public string Classify
        {
            get { return classify; }
            set { classify = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public DateTime Time
        {
            get { return DateTime.Now; }
        }

        Menu me = new Menu();
        //新建笔记
        public void SetNote(Object sender, FunctionEventArgs e)
        {
            if (e._choose == 1)
            {
                Console.WriteLine("请输入笔记的名称：");
                this.Title = Console.ReadLine();
                Console.WriteLine("请输入笔记的内容：");
                this.Content = Console.ReadLine();
                Console.WriteLine("请输入笔记的类型：");
                this.Classify = Console.ReadLine();
                //note.Classify = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("是否保存笔记：（y/n）    ");
                if (Console.ReadLine().Equals("y"))
                {
                    //NoteBookEventArgs nb = new NoteBookEventArgs(x);
                    // NoteBook(nb);
                    save(sender, e);
                }
                else
                {
                    System.Environment.Exit(0);
                }
                me.Menu1();
            }
        }

        //笔记保存
        public void save(Object sender, FunctionEventArgs e)
        {
            //创建一个文件夹
            string activeDir = @"E:\C#";

            string newPath = System.IO.Path.Combine(activeDir, classify);
            System.IO.Directory.CreateDirectory(newPath);
            //创建子文件夹
            newPath = System.IO.Path.Combine(newPath, title + ".txt");

            if (!System.IO.File.Exists(newPath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(newPath))
                {
                    //将内容保存
                    fs.Close();
                    System.IO.File.WriteAllText(newPath, content);
                    Console.WriteLine("保存成功！");
                }
            }
        }

        //打开笔记
        public void Open(Object sender, FunctionEventArgs e)
        {
            if (e._choose == 2)
            {
                Console.WriteLine("请输入文档类型：");
                classify = Console.ReadLine();
                Console.WriteLine("请输入文档名字：");
                title = Console.ReadLine();
                string text = System.IO.File.ReadAllText(@"E:\C#\" + classify + "\\" + title + ".txt");
                System.Console.WriteLine("文档中的内容是 : {0}", text);
                me.Menu1();
            }
        }
    }
    class Menu
    {
        //声明委托
        public delegate void FunctionEventHandler(Object sender, FunctionEventArgs e);
        //声明事件
        public event FunctionEventHandler function;

        // 可以供继承自 Menu 的类重写，以便继承类拒绝其他对象对它的监视
        protected virtual void OnFunction(FunctionEventArgs e)
        {
            if (function != null)
            { // 如果有对象注册
                function(this, e);  // 调用所有注册对象的方法
            }
        }
        //菜单
        public void Menu1()
        {

            Notebook note = new Notebook();
            //给委托赋值
            this.function += note.Open;
            this.function += note.SetNote;

            while (true)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*     1.新建笔记      2.打开笔记          *");
                Console.WriteLine("*     3.管理分类      4.退出              *");
                Console.WriteLine("*******************************************");

                int option = Convert.ToInt32(Console.ReadLine());

                if (option > 0 && option < 5)
                {
                    FunctionEventArgs e = new FunctionEventArgs(option);
                    OnFunction(e);
                    if (option == 3)
                    {
                        Console.Clear();
                        ManageSort ct = new ManageSort();
                        ct.Sort();
                        Menu1();
                    }
                    if (option == 4)
                    {
                        System.Environment.Exit(0);

                    }
                }
                else
                {
                    Console.WriteLine("输入有误请重新输入");
                    Menu1();
                }
            }
        }
    }
    class FunctionEventArgs : EventArgs
    {
        public readonly int _choose;
        public FunctionEventArgs(int choose)
        {
            this._choose = choose;
        }
    }
    class ManageSort
    {
        //声明委托
        public delegate void FunctionEventHandler(Object sender1, FunctionEventArgs e2);
        //声明事件
        public event FunctionEventHandler function1;

        // 可以供继承自 Menu 的类重写，以便继承类拒绝其他对象对它的监视
        protected virtual void OnFunction1(FunctionEventArgs e2)
        {
            if (function1 != null)
            { // 如果有对象注册
                function1(this, e2);  // 调用所有注册对象的方法
            }
        }

        //分类管理界面
        public void Sort()
        {
            SortFunction n = new SortFunction();
            Notebook n1 = new Notebook();
            //给委托赋值
            this.function1 += n.sort;
            this.function1 += n.Delete;
            this.function1 += n.showCategory;
            this.function1 += n.ModifySort;

            while (true)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*     1.查询         2.新建               *");
                Console.WriteLine("*     3.删除         4.修改               *");
                Console.WriteLine("*     5.返回                              *");
                Console.WriteLine("*******************************************");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y > 0 && y < 5)
                {
                    FunctionEventArgs e = new FunctionEventArgs(y);
                    OnFunction1(e);
                    if (y == 5)
                    {
                        Console.Clear();
                        Menu mm = new Menu();
                        mm.Menu1();
                    }
                }
            }
        }
    }
}
