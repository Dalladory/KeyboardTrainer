using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_trainer
{
    class InputStatistic
    {
        public float Seconds { get; set; }

        public float WordsCount { get; set; }
        public float SymbolCount { get; set; }
        public float ErrorInputs { get; set; }

        private float symbolsPerMinute;

        public float SymbolsPerMinute
        {
            get 
            {
                symbolsPerMinute = SymbolCount / Seconds * 60;
                if (Double.IsNaN(symbolsPerMinute)) { return 0; }
                return symbolsPerMinute;
            }
        }

        private float accuracy;

        public float Accuracy
        {
            get 
            {
                accuracy = SymbolCount / (SymbolCount + ErrorInputs) * 100;
                if (Double.IsNaN(accuracy)) { return 100; }
                return accuracy;
            }
        }

        public override string ToString()
        {
            return $"Time: {TimeFormat()}\nWords count: {WordsCount}\nSymbol count: {SymbolCount}\nError inputs: {ErrorInputs}\nSymbols per minute: {SymbolsPerMinute}\nAccuracy: {Accuracy}%";
        }

        public string TimeFormat()
        {
            if (Seconds < 60) return $"0 min. {Seconds} sec.";

            return $"{(int)(Seconds / 60)} min. {Seconds % 60} sec.";
        }
    }
}