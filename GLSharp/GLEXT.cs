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

        public static glGenFramebuffers_del glGenFramebuffers = null;
        public static glBindFramebuffer_del glBindFramebuffer = null;
        public static glFramebufferTexture_del glFramebufferTexture = null;
        public static glDrawBuffers_del glDrawBuffers = null;
        public static glCheckFramebufferStatus_del glCheckFramebufferStatus = null;
        public static glDeleteFramebuffers_del glDeleteFramebuffers = null;
        public static glBindFramebufferEXT_del glBindFramebufferEXT = null;
        public static glBlitFramebufferEXT_del glBlitFramebufferEXT = null;
        public static glTexImage2DMultisample_del glTexImage2DMultisample = null;

        public static void Init()
        {
            setPtr("glGenFramebuffers", ref glGenFramebuffers);
            setPtr("glBindFramebuffer", ref glBindFramebuffer);
            setPtr("glFramebufferTexture", ref glFramebufferTexture);
            setPtr("glDrawBuffers", ref glDrawBuffers);
            setPtr("glCheckFramebufferStatus", ref glCheckFramebufferStatus);
            setPtr("glDeleteFramebuffers", ref glDeleteFramebuffers);
            setPtr("glBindFramebufferEXT", ref glBindFramebufferEXT);
            setPtr("glBlitFramebufferEXT", ref glBlitFramebufferEXT);
            setPtr("glTexImage2DMultisample", ref glTexImage2DMultisample);
        }

        static void setPtr<T>(string name, ref T del) where T : Delegate
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
