using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune
{
    public class Fortune
    {
        public string Text { get; }

        public Fortune(string text)
        {
            if (string.IsNullOrEmpty(text)) throw new ArgumentException("text cannot be null or empty");
            this.Text = text;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
