using Ramzes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ramzes.Reader
{
    public class LoadData
    {
        private bool firstLine = true;

        public Node ReadData(string path)
        {
            Node rootNode = null;
            var parentsNodeList = new List<Node>();
            using (StreamReader sr = File.OpenText(path))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    if (firstLine)
                    {
                        rootNode = new Node() { MeValue = Int32.Parse(s) };
                        parentsNodeList.Add(rootNode);
                        firstLine = false;
                    }
                    else
                    {
                        
                        var lines = s.Split(" ");
                        //string nextline = null;
                        var hereIam = new List<Node>();
                        for (int i = 0; i < lines.Length; i++)
                        {
                            var me = new Node() { MeValue = Int32.Parse(lines[i]) };
                            var a = GetNode(parentsNodeList, i + 1);
                            if (a != null) a.ChildA = me;
                            var b = GetNode(parentsNodeList, i);
                            if (b != null) b.ChildB = me;
                            var c = GetNode(parentsNodeList, i - 1);
                            if (c != null) c.ChildC = me;
                            hereIam.Add(me);

                        }
                        parentsNodeList = hereIam;
                    }
                }
            }
            return rootNode;
        }

        private Node GetNode(List<Node> list, int index)
        {
            if (index < 0 || list.Count-1 < index)
            {
                return null;
            }
            else
                return list[index];
        }

        public void CreateFile()
        {
            using (StreamWriter sw = File.CreateText("ramzes.txt"))
            {
                sw.WriteLine("abc");
            }
        }
    }
}
