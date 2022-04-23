using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GLSharp.OpenGL
{
    public class FrameBufferObject : IDisposable
    {
        public uint Texture { get; private set; }
        public uint FBO { get; private set; }
        public uint WRITE_FBO { get; private set; } = 0;
        public bool Disposed { get; private set; } = false;
        bool msaa = false;
        int width, height;
        public int Width { get => width; }
        public int Height { get => height; }
        uint msaaTex = 0;

        public FrameBufferObject(int width, int height, int samples = 0)
        {
            Console.WriteLine("Create FBO {0}", Thread.CurrentThread.ManagedThreadId);
            this.width = width;
            this.height = height;
            this.msaa = samples > 0;
            if (!this.msaa)
            {
                Texture = GLSharp.Texture.LoadTexture(IntPtr.Zero, width, height);
                FBO = createFBO(Texture, width, height);
            }
            else
            {
                Texture = GLSharp.Texture.LoadTexture(IntPtr.Zero, width, height);
                FBO = createFBOMultisampling(ref msaaTex, width, height, samples);
                WRITE_FBO = createFBO(Texture, width, height);
            }
        }

        ~FrameBufferObject()
        {
            if (!Disposed)
                Util.Leackage(this);
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            uint fbo = FBO;
            uint fbo2 = WRITE_FBO;
            GLEXT.glDeleteFramebuffers(1, ref fbo);
            GLEXT.glDeleteFramebuffers(1, ref fbo2);
            GL.DeleteTextures(1, new uint[] { Texture });
            GL.DeleteTextures(1, new uint[] { msaaTex });
        }

        public void Bind()
        {
            GLEXT.glBindFramebuffer(GL.FRAMEBUFFER, FBO);
        }

        public void Unbind()
        {
            GLEXT.glBindFramebuffer(GL.FRAMEBUFFER, 0);
        }

        public void BindTexture()
        {
            GL.BindTexture(GL.TEXTURE_2D, Texture);
        }

        public void Blit()
        {
            if (msaa)
            {
                blitFBO(FBO, WRITE_FBO, width, height);
            }
        }

        static uint createFBO(uint texture, int w, int h)
        {
            uint fbo = 0;
            GLEXT.glGenFramebuffers(1, ref fbo);
            GLEXT.glBindFramebuffer(GL.FRAMEBUFFER, fbo);
            GLEXT.glFramebufferTexture(GL.FRAMEBUFFER, GL.COLOR_ATTACHMENT0, texture, 0);
            uint[] drawBuffers = new uint[] { GL.COLOR_ATTACHMENT0 };
            GLEXT.glDrawBuffers(1, ref fbo);
            GLEXT.glBindFramebuffer(GL.FRAMEBUFFER, fbo);
            GL.Viewport(0, 0, w, h);
            GL.MatrixMode(GL.PROJECTION);
            GL.Ortho(0, w, 0, h, 1, -1);
            GL.MatrixMode(GL.MODELVIEW);
            if(GLEXT.glCheckFramebufferStatus(GL.FRAMEBUFFER) != GL.FRAMEBUFFER_COMPLETE)
            {
                return 0;
            }
            return fbo;
        }

        static uint createFBOMultisampling(ref uint tex, int w, int h, int samples)
        {
            tex = 0;
            GL.GenTextures(1, ref tex);
            GL.BindTexture(GL.TEXTURE_2D_MULTISAMPLE, tex);
            GLEXT.glTexImage2DMultisample(GL.TEXTURE_2D_MULTISAMPLE, samples, GL.RGBA, w, h, false);

            uint fbo = 0;
            GLEXT.glGenFramebuffers(1, ref fbo);
            GLEXT.glBindFramebuffer(GL.FRAMEBUFFER, fbo);
            GLEXT.glFramebufferTexture(GL.FRAMEBUFFER, GL.COLOR_ATTACHMENT0, (uint)tex, 0);
            uint[] drawBuffers = new uint[] { GL.COLOR_ATTACHMENT0 };
            GLEXT.glDrawBuffers(1, ref fbo);
            GLEXT.glBindFramebuffer(GL.FRAMEBUFFER, fbo);
            GL.Viewport(0, 0, w, h);
            if (GLEXT.glCheckFramebufferStatus(GL.FRAMEBUFFER) != GL.FRAMEBUFFER_COMPLETE)
            {
                GL.DeleteTextures(1, new uint[] { tex });
                return 0;
            }
            return fbo;
        }

        static void blitFBO(uint fbo_read, uint fbo_write, int width, int height)
        {
            GL.BindTexture(GL.TEXTURE_2D, 0);
            GLEXT.glBindFramebufferEXT(GL.READ_FRAMEBUFFER, fbo_read);
            GLEXT.glBindFramebufferEXT(GL.DRAW_FRAMEBUFFER, fbo_write);
            GLEXT.glBlitFramebufferEXT(0, 0, width, height,
                                        0, 0, width, height,
                                        GL.COLOR_BUFFER_BIT,
                                        GL.NEAREST);
            GLEXT.glBindFramebufferEXT(GL.READ_FRAMEBUFFER, 0);
            GLEXT.glBindFramebufferEXT(GL.DRAW_FRAMEBUFFER, 0);
        }
    }
}
