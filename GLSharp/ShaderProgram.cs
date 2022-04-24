using System;
using System.Collections.Generic;
using System.Text;

namespace GLSharp
{
    public class ShaderProgram
    {
        public uint Program { get; private set; }

        public static ShaderProgram CreateStdShader(string vertex, string fragment)
        {
            uint prog = GLEXT.CreateProgram();

            // Vertex Shader
            uint vShader = GLEXT.CreateShader(GL.VERTEX_SHADER);
            GLEXT.ShaderSource(vShader, 1, new string[] { vertex }, IntPtr.Zero);
            GLEXT.CompileShader(vShader);
            GLEXT.GetShaderiv(vShader, GL.COMPILE_STATUS, out int vSuccess);
            if(vSuccess == 0)
            {
                StringBuilder infoLog = new StringBuilder(512);
                GLEXT.GetShaderInfoLog(vShader, infoLog.Capacity, IntPtr.Zero, infoLog);
                throw new GLProgramException(ProgramStep.Compile, infoLog.ToString());
            }
            GLEXT.AttachShader(prog, vShader);
            GLEXT.DeleteShader(vShader);

            // Fragment Shader
            uint fShader = GLEXT.CreateShader(GL.FRAGMENT_SHADER);
            GLEXT.ShaderSource(fShader, 1, new string[] { vertex }, IntPtr.Zero);
            GLEXT.CompileShader(fShader);
            GLEXT.GetShaderiv(fShader, GL.COMPILE_STATUS, out int fSuccess);
            if (vSuccess == 0)
            {
                StringBuilder infoLog = new StringBuilder(512);
                GLEXT.GetShaderInfoLog(fShader, infoLog.Capacity, IntPtr.Zero, infoLog);
                throw new GLProgramException(ProgramStep.Compile, infoLog.ToString());
            }
            GLEXT.AttachShader(prog, fShader);
            GLEXT.DeleteShader(fShader);

            // Link Program
            GLEXT.LinkProgram(prog);
            GLEXT.GetProgramiv(prog, GL.LINK_STATUS, out int pSuccess);
            if(pSuccess == 0)
            {
                StringBuilder infoLog = new StringBuilder(512);
                GLEXT.GetProgramInfoLog(prog, infoLog.Capacity, IntPtr.Zero, infoLog);
                throw new GLProgramException(ProgramStep.Link, infoLog.ToString());
            }

            return new ShaderProgram(prog);
        }

        public ShaderProgram(uint program)
        {
            this.Program = program;
        }

        public void Use()
        {
            GLEXT.UseProgram(Program);
        }

        public void Unuse()
        {
            GLEXT.UseProgram(0);
        }
    }
}
