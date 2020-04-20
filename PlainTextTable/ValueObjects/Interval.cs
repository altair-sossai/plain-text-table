using System;

namespace PlainTextTable.ValueObjects
{
    public class Interval
    {
        private int _end;
        private int _start;

        public int Start
        {
            get => _start;
            set => _start = Math.Max(0, value);
        }

        public int End
        {
            get => _end;
            set => _end = Math.Max(Start, value);
        }
    }
}