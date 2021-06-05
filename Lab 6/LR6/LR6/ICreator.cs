using System;
using System.Collections.Generic;
using System.Text;

namespace LR6
{
    interface ICreator
    {
        enum Degrees { }
        int Course { get; set; }
        void UpDegree();
    }
}