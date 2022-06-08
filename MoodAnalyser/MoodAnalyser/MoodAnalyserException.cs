﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_METHOD, NO_SUCH_CLASS,
        }
        public ExceptionType Type;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}