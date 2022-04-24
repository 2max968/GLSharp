using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GLSharp
{
    public class GLEXT
    {
        public delegate void glGenFramebuffers_del(int n, ref uint framebuffers);
        public delegate void glBindFramebuffer_del(uint target, uint framebuffer);
        public delegate void glFramebufferTexture_del(uint target, uint attachment, uint texture, int level);
        public delegate void glDrawBuffers_del(int n, ref uint drawbuffers);
        public delegate uint glCheckFramebufferStatus_del(uint target);
        public delegate void glDeleteFramebuffers_del(int n, ref uint framebuffers);
        public delegate void glBindFramebufferEXT_del(uint target, uint farmebuffer);
        public delegate void glBlitFramebufferEXT_del(int srcX0,
                                                        int srcY0,
                                                        int srcX1,
                                                        int srcY1,
                                                        int dstX0,
                                                        int dstY0,
                                                        int dstX1,
                                                        int dstY1,
                                                        uint mask,
                                                        uint filter);
        public delegate void glTexImage2DMultisample_del(uint target, int samples, uint internalformat,
                                                        int width, int height, 
                                                        [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocation);

        public delegate uint glCreateProgram();
        public delegate uint glCreateShader(uint shaderType);
        public delegate void glShaderSource(uint shader, uint count, string[] @string, IntPtr length);
        public delegate void glCompileShader(uint shader);
        public delegate void glGetShaderiv(uint shader, uint pname, out int @params);
        public delegate void glGetShaderInfoLog(uint shader, int maxLength, IntPtr length, StringBuilder infoLog);
        public delegate void glAttachShader(uint program, uint shader);
        public delegate void glDeleteShader(uint shader);
        public delegate void glLinkProgram(uint program);
        public delegate void glGetProgramiv(uint program, uint pname, out int @params);
        public delegate void glGetProgramInfoLog(uint program, int maxLength, IntPtr length, StringBuilder infoLog);
        public delegate void glUseProgram(uint program);

        public static glGenFramebuffers_del GenFramebuffers = null;
        public static glBindFramebuffer_del BindFramebuffer = null;
        public static glFramebufferTexture_del FramebufferTexture = null;
        public static glDrawBuffers_del DrawBuffers = null;
        public static glCheckFramebufferStatus_del CheckFramebufferStatus = null;
        public static glDeleteFramebuffers_del DeleteFramebuffers = null;
        public static glBindFramebufferEXT_del BindFramebufferEXT = null;
        public static glBlitFramebufferEXT_del BlitFramebufferEXT = null;
        public static glTexImage2DMultisample_del TexImage2DMultisample = null;

        public static glCreateProgram CreateProgram = null;
        public static glCreateShader CreateShader = null;
        public static glShaderSource ShaderSource = null;
        public static glCompileShader CompileShader = null;
        public static glGetShaderiv GetShaderiv = null;
        public static glGetShaderInfoLog GetShaderInfoLog = null;
        public static glAttachShader AttachShader = null;
        public static glDeleteShader DeleteShader = null;
        public static glLinkProgram LinkProgram = null;
        public static glGetProgramiv GetProgramiv = null;
        public static glGetProgramInfoLog GetProgramInfoLog = null;
        public static glUseProgram UseProgram = null;

        public static void Init()
        {
            setPtr("glGenFramebuffers", ref GenFramebuffers);
            setPtr("glBindFramebuffer", ref BindFramebuffer);
            setPtr("glFramebufferTexture", ref FramebufferTexture);
            setPtr("glDrawBuffers", ref DrawBuffers);
            setPtr("glCheckFramebufferStatus", ref CheckFramebufferStatus);
            setPtr("glDeleteFramebuffers", ref DeleteFramebuffers);
            setPtr("glBindFramebufferEXT", ref BindFramebufferEXT);
            setPtr("glBlitFramebufferEXT", ref BlitFramebufferEXT);
            setPtr("glTexImage2DMultisample", ref TexImage2DMultisample);
            setPtr("glCreateprogram", ref CreateProgram);

            setPtr(ref CreateProgram);
            setPtr(ref CreateShader);
            setPtr(ref ShaderSource);
            setPtr(ref CompileShader);
            setPtr(ref GetShaderiv);
            setPtr(ref GetShaderInfoLog);
            setPtr(ref AttachShader);
            setPtr(ref DeleteShader);
            setPtr(ref LinkProgram);
            setPtr(ref GetProgramiv);
            setPtr(ref GetProgramInfoLog);
            setPtr(ref UseProgram);
        }

        internal static void setPtr<T>(ref T del) where T : Delegate
        {
            string name = typeof(T).Name;
            setPtr(name, ref del);
        }

        internal static void setPtr<T>(string name, ref T del) where T : Delegate
        {
            if (del != null)
                return;
            IntPtr procAddres = WGL.GetProcAddress(name);
            if (procAddres != IntPtr.Zero)
                del = Marshal.GetDelegateForFunctionPointer<T>(procAddres);
            else
                del = null;
        }
    }
}
