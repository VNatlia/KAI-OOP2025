using System;

namespace Lab3._4;

public class OverflowEventArgs : EventArgs
    {
        public string Message { get; }

        public OverflowEventArgs(string message)
        {
            Message = message;
        }
    }

