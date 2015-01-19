using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GisManage.MapService
{
    class MapService
    {
        /// <summary>
        /// 读取Log文件
        /// </summary>
        /// <param name="path"></param>
        public void ReadLog(string path)
        {
            
            path = @"D:\codes\Runtime\Workspace\admin\\temp\空白地图.log";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                List<string> lines = new List<string>();
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line.Trim());
                }
            }


            string sdFile = @"d:\codes\runtime\workspace\admin\空白地图.sd";
            if (File.Exists(sdFile))
            {
                Console.WriteLine("转换为服务定义文件成功！ - " + sdFile);               
            }
        }
    }
}
