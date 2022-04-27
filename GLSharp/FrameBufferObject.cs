using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GLSharp
{
    public class FrameBufferObject : IDisposable
    {
        public uint Texture { get; private set; }
        public uint DepthTexture { get; private set; }
        public uint FBO { get; private set; }
        //public uint WRITE_FBO { get; private set; } = 0;
        public bool Disposed { get; private set; } = false;
        bool msaa = false;
        int width, height;
        public int Width { get => width; }
        public int Height { get => height; }
        //uint msaaTex = 0;
        int samples;

        public FrameBufferObject(int width, int height, int samples = 0, bool depthBuffer = false)
        {
            Console.WriteLine("Create FBO {0}", Thread.CurrentThread.ManagedThreadId);
            this.width = width;
            this.height = height;
            this.msaa = samples > 0;
            this.samples = samples;
            /*if (!this.msaa)
            {
                Texture = GLSharp.Texture.LoadTexture(IntPtr.Zero, width, height);
                FBO = createFBO(Texture, width, height);
            }
            else
            {
                Texture = GLSharp.Texture.LoadTexture(IntPtr.Zero, width, height);
                FBO = createFBOMultisampling(ref msaaTex, width, height, samples);
                WRITE_FBO = createFBO(Texture, width, height);
            }*/
            if(depthBuffer)
            {
                uint tex = 0;
                GL.GenTextures(1, ref tex);
                GL.BindTexture(GL.TEXTURE_2D, tex);
                GL.TexImage2D(GL.TEXTURE_2D, 0, GL.RED, width, height, 0, GL.RED, GL.BYTE, IntPtr.Zero);
                DepthTexture = tex;
            }

            if(!msaa)
            {
                Texture = GLSharp.Texture.LoadTexture(IntPtr.Zero, width, height);
                FBO = createFBO(Texture, DepthTexture, width, height);
            }
            else
            {
                uint tex = 0;
                FBO = createFBOMultisampling(ref tex, DepthTexture, width, height, samples);
                Texture = tex;
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
            //uint fbo2 = WRITE_FBO;
            GLEXT.DeleteFramebuffers(1, ref fbo);
            //GLEXT.glDeleteFramebuffers(1, ref fbo2);
            GL.DeleteTexture(Texture);
            if (DepthTexture != 0)
                GL.DeleteTexture(DepthTexture);
            //GL.DeleteTexture(msaaTex);
        }

        public void Bind()
        {
            GLEXT.BindFramebuffer(GL.FRAMEBUFFER, FBO);
        }

        public void Unbind()
        {
            GLEXT.BindFramebuffer(GL.FRAMEBUFFER, 0);
        }

        public void BindTexture()
        {
            GL.BindTexture(GL.TEXTURE_2D, Texture);
        }

        /*public void Blit()
        {
            if (msaa)
            {
                blitFBO(FBO, WRITE_FBO, width, height);
            }
        }*/

        public void BlitTo(uint write_fbo, int width, int height)
        {
            blitFBO(FBO, write_fbo, this.width, this.height, width, height);
        }

        public void BlitTo(FrameBufferObject write_fbo)
        {
            blitFBO(this.FBO, write_fbo.FBO, this.width, this.height, write_fbo.width, write_fbo.height);
        }

        public void BlitToScreen()
        {
            blitFBO(FBO, 0, width, height, Width, height);
        }

        public void Resize(int width, int height)
        {
            if(msaa)
            {
                GL.BindTexture(GL.TEXTURE_2D_MULTISAMPLE, Texture);
                GLEXT.TexImage2DMultisample(GL.TEXTURE_2D_MULTISAMPLE, samples, GL.RGBA, width, height, false);
            }
            else
            {
                GL.BindTexture(GL.TEXTURE_2D, Texture);
                GL.TexImage2D(GL.TEXTURE_2D, 0, GL.RGBA, width, height,
                    0, GL.RGBA, GL.UNSIGNED_BYTE, IntPtr.Zero);
                GL.BindTexture(GL.TEXTURE_2D, 0);
            }

            if(DepthTexture != 0)
            {
                GL.BindTexture(GL.TEXTURE_2D, DepthTexture);
                GL.TexImage2D(GL.TEXTURE_2D, 0, GL.RED, width, height,
                    0, GL.RED, GL.BYTE, IntPtr.Zero);
                GL.BindTexture(GL.TEXTURE_2D, 0);
            }

            GL.BindTexture(GL.TEXTURE_2D, 0);
            this.width = width;
            this.height = height;
        }

        static uint createFBO(uint texture, uint depthTexture, int w, int h)
        {
            uint fbo = 0;
            GLEXT.GenFramebuffers(1, ref fbo);
            GLEXT.BindFramebuffer(GL.FRAMEBUFFER, fbo);
            GLEXT.FramebufferTexture(GL.FRAMEBUFFER, GL.COLOR_ATTACHMENT0, texture, 0);
            if(depthTexture != 0)
                GLEXT.FramebufferTexture(GL.FRAMEBUFFER, GL.DEPTH_ATTACHMENT, depthTexture, 0);
            uint[] drawBuffers = new uint[] { GL.COLOR_ATTACHMENT0 };
            GLEXT.DrawBuffers(1, ref fbo);
            GLEXT.BindFramebuffer(GL.FRAMEBUFFER, fbo);
            GL.Viewport(0, 0, w, h);
            GL.MatrixMode(GL.PROJECTION);
            GL.Ortho(0, w, h, 0, 1, -1);
            GL.MatrixMode(GL.MODELVIEW);
            if(GLEXT.CheckFramebufferStatus(GL.FRAMEBUFFER) != GL.FRAMEBUFFER_COMPLETE)
            {
                return 0;
            }
            return fbo;
        }

        static uint createFBOMultisampling(ref uint tex, uint depthTexture, int w, int h, int samples)
        {
            tex = 0;
            GL.GenTextures(1, ref tex);
            GL.BindTexture(GL.TEXTURE_2D_MULTISAMPLE, tex);
            GLEXT.TexImage2DMultisample(GL.TEXTURE_2D_MULTISAMPLE, samples, GL.RGBA, w, h, false);

            uint fbo = 0;
            GLEXT.GenFramebuffers(1, ref fbo);
            GLEXT.BindFramebuffer(GL.FRAMEBUFFER, fbo);
            GLEXT.FramebufferTexture(GL.FRAMEBUFFER, GL.COLOR_ATTACHMENT0, (uint)tex, 0);
            if (depthTexture != 0)
                GLEXT.FramebufferTexture(GL.FRAMEBUFFER, GL.DEPTH_ATTACHMENT, depthTexture, 0);
            uint[] drawBuffers = new uint[] { GL.COLOR_ATTACHMENT0 };
            GLEXT.DrawBuffers(1, ref fbo);
            GLEXT.BindFramebuffer(GL.FRAMEBUFFER, fbo);
            GL.Viewport(0, 0, w, h);
            GL.MatrixMode(GL.PROJECTION);
            GL.Ortho(0, w, h, 0, 1, -1);
            GL.MatrixMode(GL.MODELVIEW);
            if (GLEXT.CheckFramebufferStatus(GL.FRAMEBUFFER) != GL.FRAMEBUFFER_COMPLETE)
            {
                GL.DeleteTexture(tex);
                return 0;
            }
            return fbo;
        }

        static void blitFBO(uint fbo_read, uint fbo_write, int srcWidth, int srcHeight, int dstWidth, int dstHeight)
        {
            GL.BindTexture(GL.TEXTURE_2D, 0);
            GLEXT.BindFramebufferEXT(GL.READ_FRAMEBUFFER, fbo_read);
            GLEXT.BindFramebufferEXT(GL.DRAW_FRAMEBUFFER, fbo_write);
            GLEXT.BlitFramebufferEXT(0, 0, srcWidth, srcHeight,
                                        0, 0, dstWidth, dstHeight,
                                        GL.COLOR_BUFFER_BIT,
                                        GL.NEAREST);
            GLEXT.BindFramebufferEXT(GL.READ_FRAMEBUFFER, 0);
            GLEXT.BindFramebufferEXT(GL.DRAW_FRAMEBUFFER, 0);
        }
    }
}
