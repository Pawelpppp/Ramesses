using System;
using System.Collections.Generic;
using System.Text;

namespace Ramzes.Models
{
    public class Result
    {
        public string Path { get; set; }
        public int Value { get; set; }
        public Result(string s, int va)
        {
            Path = s;
            Value = va;
        }

        public override string ToString()
        {
            return Path + ", value= " + Value;
        }
    }
}
