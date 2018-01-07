using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Notepod2
{
    class Notes : ICreate, IOpen, ISave, IClassify, IManagement
    {
        public void createNotes()
        {
            StreamWriter sw = new StreamWriter(@"E:/C#/note.txt", true);
            Console.WriteLine("已新建笔记");
        }

        public void openNotes()
        {
            String file = @"E:/C#/note.txt";
            FileInfo info = new FileInfo(file);
            Process p = new Process();
            p.StartInfo.FileName = file;
            p.StartInfo.WorkingDirectory = info.DirectoryName;
            p.Start();
        }

        public void saveNotes()
        {
            Console.WriteLine("请输入编辑的内容：");
            String text = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"E:/C#/note.txt");
            sw.WriteLine(text);
            Console.WriteLine("笔记已保存成功");
            sw.Close();
        }

        public void classifyNotes()
        {
            Console.WriteLine("新建分类成功");
        }

        public void manageClass()
        {
            Console.WriteLine("管理分类模块");
        }
    }
}
