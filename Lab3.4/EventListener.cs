using System;

namespace Lab3._4;

public class EventListener
{

        private Arithmetic _arithmetic;

        public EventListener(Arithmetic arithmetic)
        {
            _arithmetic = arithmetic;
            _arithmetic.OverflowOccurred += HandleOverflow;
        }

        private void HandleOverflow(object sender, OverflowEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n Подія: {e.Message}");
            Console.ResetColor();
        }
    }

