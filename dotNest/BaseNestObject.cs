using System;

namespace dotNest
{
    public class BaseNestObject
    {
        public DateTime TimeStamp { get; internal set; }
        public int Version { get; internal set; }
    }
}