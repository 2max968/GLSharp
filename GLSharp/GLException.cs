using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public class GLException : Exception
    {
        public GLException(string message)
            : base(message) { }
    }

    public class GLProgramException : GLException
    {
        public ProgramStep Step { get; private set; }

        public GLProgramException(ProgramStep step, string message)
            : base("Program Exception:\n" + message)
        {
            Step = step;
        }
    }

    public enum ProgramStep
    {
        Compile,
        Link
    }
}
