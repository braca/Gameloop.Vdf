﻿namespace Gameloop.Vdf
{
    public class VValue : VToken
    {
        public object Value { get; set; }

        public VValue(object value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
