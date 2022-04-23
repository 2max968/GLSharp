using System;
using System.Runtime.InteropServices;

namespace GLSharp
{
	public partial class GL
	{
		[DllImport("Opengl32.dll", EntryPoint = "glAccum")]
		public static extern void Accum(uint op, float value);
		[DllImport("Opengl32.dll", EntryPoint = "glAlphaFunc")]
		public static extern void AlphaFunc(uint func, float @ref);
		[DllImport("Opengl32.dll", EntryPoint = "glAreTexturesResident")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AreTexturesResident(int n, uint[] textures, byte[] residences);
		[DllImport("Opengl32.dll", EntryPoint = "glAreTexturesResident")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AreTexturesResident(int n, uint[] textures, ref byte residences);
		[DllImport("Opengl32.dll", EntryPoint = "glAreTexturesResident")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AreTexturesResident(int n, uint[] textures, IntPtr residences);
		[DllImport("Opengl32.dll", EntryPoint = "glAreTexturesResident")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AreTexturesResident(int n, IntPtr textures, byte[] residences);
		[DllImport("Opengl32.dll", EntryPoint = "glAreTexturesResident")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AreTexturesResident(int n, IntPtr textures, ref byte residences);
		[DllImport("Opengl32.dll", EntryPoint = "glAreTexturesResident")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool AreTexturesResident(int n, IntPtr textures, IntPtr residences);
		[DllImport("Opengl32.dll", EntryPoint = "glArrayElement")]
		public static extern void ArrayElement(int i);
		[DllImport("Opengl32.dll", EntryPoint = "glBegin")]
		public static extern void Begin(uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glBindTexture")]
		public static extern void BindTexture(uint target, uint texture);
		[DllImport("Opengl32.dll", EntryPoint = "glBitmap")]
		public static extern void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);
		[DllImport("Opengl32.dll", EntryPoint = "glBitmap")]
		public static extern void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, IntPtr bitmap);
		[DllImport("Opengl32.dll", EntryPoint = "glBlendFunc")]
		public static extern void BlendFunc(uint sfactor, uint dfactor);
		[DllImport("Opengl32.dll", EntryPoint = "glCallList")]
		public static extern void CallList(uint list);
		[DllImport("Opengl32.dll", EntryPoint = "glCallLists")]
		public static extern void CallLists(int n, uint type, IntPtr lists);
		[DllImport("Opengl32.dll", EntryPoint = "glCallLists")]
		public static extern void CallLists(int n, uint type, byte[] lists);
		[DllImport("Opengl32.dll", EntryPoint = "glClear")]
		public static extern void Clear(uint mask);
		[DllImport("Opengl32.dll", EntryPoint = "glClearAccum")]
		public static extern void ClearAccum(float red, float green, float blue, float alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glClearColor")]
		public static extern void ClearColor(float red, float green, float blue, float alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glClearDepth")]
		public static extern void ClearDepth(double depth);
		[DllImport("Opengl32.dll", EntryPoint = "glClearIndex")]
		public static extern void ClearIndex(float c);
		[DllImport("Opengl32.dll", EntryPoint = "glClearStencil")]
		public static extern void ClearStencil(int s);
		[DllImport("Opengl32.dll", EntryPoint = "glClipPlane")]
		public static extern void ClipPlane(uint plane, double[] equation);
		[DllImport("Opengl32.dll", EntryPoint = "glClipPlane")]
		public static extern void ClipPlane(uint plane, IntPtr equation);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3b")]
		public static extern void Color3b(sbyte red, sbyte green, sbyte blue);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3bv")]
		public static extern void Color3bv(sbyte[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3bv")]
		public static extern void Color3bv(byte[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3bv")]
		public static extern void Color3bv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3d")]
		public static extern void Color3d(double red, double green, double blue);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3dv")]
		public static extern void Color3dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3dv")]
		public static extern void Color3dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3f")]
		public static extern void Color3f(float red, float green, float blue);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3fv")]
		public static extern void Color3fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3fv")]
		public static extern void Color3fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3i")]
		public static extern void Color3i(int red, int green, int blue);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3iv")]
		public static extern void Color3iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3iv")]
		public static extern void Color3iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3s")]
		public static extern void Color3s(short red, short green, short blue);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3sv")]
		public static extern void Color3sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3sv")]
		public static extern void Color3sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3ub")]
		public static extern void Color3ub(byte red, byte green, byte blue);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3ubv")]
		public static extern void Color3ubv(byte[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3ubv")]
		public static extern void Color3ubv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3ui")]
		public static extern void Color3ui(uint red, uint green, uint blue);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3uiv")]
		public static extern void Color3uiv(uint[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3uiv")]
		public static extern void Color3uiv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3us")]
		public static extern void Color3us(ushort red, ushort green, ushort blue);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3usv")]
		public static extern void Color3usv(ushort[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor3usv")]
		public static extern void Color3usv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4b")]
		public static extern void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4bv")]
		public static extern void Color4bv(sbyte[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4bv")]
		public static extern void Color4bv(byte[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4bv")]
		public static extern void Color4bv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4d")]
		public static extern void Color4d(double red, double green, double blue, double alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4dv")]
		public static extern void Color4dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4dv")]
		public static extern void Color4dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4f")]
		public static extern void Color4f(float red, float green, float blue, float alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4fv")]
		public static extern void Color4fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4fv")]
		public static extern void Color4fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4i")]
		public static extern void Color4i(int red, int green, int blue, int alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4iv")]
		public static extern void Color4iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4iv")]
		public static extern void Color4iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4s")]
		public static extern void Color4s(short red, short green, short blue, short alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4sv")]
		public static extern void Color4sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4sv")]
		public static extern void Color4sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4ub")]
		public static extern void Color4ub(byte red, byte green, byte blue, byte alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4ubv")]
		public static extern void Color4ubv(byte[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4ubv")]
		public static extern void Color4ubv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4ui")]
		public static extern void Color4ui(uint red, uint green, uint blue, uint alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4uiv")]
		public static extern void Color4uiv(uint[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4uiv")]
		public static extern void Color4uiv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4us")]
		public static extern void Color4us(ushort red, ushort green, ushort blue, ushort alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4usv")]
		public static extern void Color4usv(ushort[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glColor4usv")]
		public static extern void Color4usv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glColorMask")]
		public static extern void ColorMask([MarshalAs(UnmanagedType.I1)] bool red, [MarshalAs(UnmanagedType.I1)] bool green, [MarshalAs(UnmanagedType.I1)] bool blue, [MarshalAs(UnmanagedType.I1)] bool alpha);
		[DllImport("Opengl32.dll", EntryPoint = "glColorMaterial")]
		public static extern void ColorMaterial(uint face, uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glColorPointer")]
		public static extern void ColorPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glColorPointer")]
		public static extern void ColorPointer(int size, uint type, int stride, byte[] pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glCopyPixels")]
		public static extern void CopyPixels(int x, int y, int width, int height, uint type);
		[DllImport("Opengl32.dll", EntryPoint = "glCopyTexImage1D")]
		public static extern void CopyTexImage1D(uint target, int level, uint internalFormat, int x, int y, int width, int border);
		[DllImport("Opengl32.dll", EntryPoint = "glCopyTexImage2D")]
		public static extern void CopyTexImage2D(uint target, int level, uint internalFormat, int x, int y, int width, int height, int border);
		[DllImport("Opengl32.dll", EntryPoint = "glCopyTexSubImage1D")]
		public static extern void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
		[DllImport("Opengl32.dll", EntryPoint = "glCopyTexSubImage2D")]
		public static extern void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		[DllImport("Opengl32.dll", EntryPoint = "glCullFace")]
		public static extern void CullFace(uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glDeleteLists")]
		public static extern void DeleteLists(uint list, int range);
		[DllImport("Opengl32.dll", EntryPoint = "glDeleteTextures")]
		public static extern void DeleteTextures(int n, uint[] textures);
		[DllImport("Opengl32.dll", EntryPoint = "glDeleteTextures")]
		public static extern void DeleteTextures(int n, IntPtr textures);
		[DllImport("Opengl32.dll", EntryPoint = "glDepthFunc")]
		public static extern void DepthFunc(uint func);
		[DllImport("Opengl32.dll", EntryPoint = "glDepthMask")]
		public static extern void DepthMask([MarshalAs(UnmanagedType.I1)] bool flag);
		[DllImport("Opengl32.dll", EntryPoint = "glDepthRange")]
		public static extern void DepthRange(double zNear, double zFar);
		[DllImport("Opengl32.dll", EntryPoint = "glDisable")]
		public static extern void Disable(uint cap);
		[DllImport("Opengl32.dll", EntryPoint = "glDisableClientState")]
		public static extern void DisableClientState(uint array);
		[DllImport("Opengl32.dll", EntryPoint = "glDrawArrays")]
		public static extern void DrawArrays(uint mode, int first, int count);
		[DllImport("Opengl32.dll", EntryPoint = "glDrawBuffer")]
		public static extern void DrawBuffer(uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glDrawElements")]
		public static extern void DrawElements(uint mode, int count, uint type, IntPtr indices);
		[DllImport("Opengl32.dll", EntryPoint = "glDrawElements")]
		public static extern void DrawElements(uint mode, int count, uint type, byte[] indices);
		[DllImport("Opengl32.dll", EntryPoint = "glDrawPixels")]
		public static extern void DrawPixels(int width, int height, uint format, uint type, IntPtr pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glDrawPixels")]
		public static extern void DrawPixels(int width, int height, uint format, uint type, byte[] pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glEdgeFlag")]
		public static extern void EdgeFlag([MarshalAs(UnmanagedType.I1)] bool flag);
		[DllImport("Opengl32.dll", EntryPoint = "glEdgeFlagPointer")]
		public static extern void EdgeFlagPointer(int stride, IntPtr pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glEdgeFlagPointer")]
		public static extern void EdgeFlagPointer(int stride, byte[] pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glEdgeFlagv")]
		public static extern void EdgeFlagv(byte[] flag);
		[DllImport("Opengl32.dll", EntryPoint = "glEdgeFlagv")]
		public static extern void EdgeFlagv(IntPtr flag);
		[DllImport("Opengl32.dll", EntryPoint = "glEnable")]
		public static extern void Enable(uint cap);
		[DllImport("Opengl32.dll", EntryPoint = "glEnableClientState")]
		public static extern void EnableClientState(uint array);
		[DllImport("Opengl32.dll", EntryPoint = "glEnd")]
		public static extern void End();
		[DllImport("Opengl32.dll", EntryPoint = "glEndList")]
		public static extern void EndList();
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord1d")]
		public static extern void EvalCoord1d(double u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord1dv")]
		public static extern void EvalCoord1dv(double[] u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord1dv")]
		public static extern void EvalCoord1dv(IntPtr u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord1f")]
		public static extern void EvalCoord1f(float u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord1fv")]
		public static extern void EvalCoord1fv(float[] u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord1fv")]
		public static extern void EvalCoord1fv(IntPtr u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord2d")]
		public static extern void EvalCoord2d(double u, double v);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord2dv")]
		public static extern void EvalCoord2dv(double[] u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord2dv")]
		public static extern void EvalCoord2dv(IntPtr u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord2f")]
		public static extern void EvalCoord2f(float u, float v);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord2fv")]
		public static extern void EvalCoord2fv(float[] u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalCoord2fv")]
		public static extern void EvalCoord2fv(IntPtr u);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalMesh1")]
		public static extern void EvalMesh1(uint mode, int i1, int i2);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalMesh2")]
		public static extern void EvalMesh2(uint mode, int i1, int i2, int j1, int j2);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalPoint1")]
		public static extern void EvalPoint1(int i);
		[DllImport("Opengl32.dll", EntryPoint = "glEvalPoint2")]
		public static extern void EvalPoint2(int i, int j);
		[DllImport("Opengl32.dll", EntryPoint = "glFeedbackBuffer")]
		public static extern void FeedbackBuffer(int size, uint type, float[] buffer);
		[DllImport("Opengl32.dll", EntryPoint = "glFeedbackBuffer")]
		public static extern void FeedbackBuffer(int size, uint type, ref float buffer);
		[DllImport("Opengl32.dll", EntryPoint = "glFeedbackBuffer")]
		public static extern void FeedbackBuffer(int size, uint type, IntPtr buffer);
		[DllImport("Opengl32.dll", EntryPoint = "glFinish")]
		public static extern void Finish();
		[DllImport("Opengl32.dll", EntryPoint = "glFlush")]
		public static extern void Flush();
		[DllImport("Opengl32.dll", EntryPoint = "glFogf")]
		public static extern void Fogf(uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glFogfv")]
		public static extern void Fogfv(uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glFogfv")]
		public static extern void Fogfv(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glFogi")]
		public static extern void Fogi(uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glFogiv")]
		public static extern void Fogiv(uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glFogiv")]
		public static extern void Fogiv(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glFrontFace")]
		public static extern void FrontFace(uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glFrustum")]
		public static extern void Frustum(double left, double right, double bottom, double top, double zNear, double zFar);
		[DllImport("Opengl32.dll", EntryPoint = "glGenLists")]
		public static extern uint GenLists(int range);
		[DllImport("Opengl32.dll", EntryPoint = "glGenTextures")]
		public static extern void GenTextures(int n, uint[] textures);
		[DllImport("Opengl32.dll", EntryPoint = "glGenTextures")]
		public static extern void GenTextures(int n, ref uint textures);
		[DllImport("Opengl32.dll", EntryPoint = "glGenTextures")]
		public static extern void GenTextures(int n, IntPtr textures);
		[DllImport("Opengl32.dll", EntryPoint = "glGetBooleanv")]
		public static extern void GetBooleanv(uint pname, byte[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetBooleanv")]
		public static extern void GetBooleanv(uint pname, ref byte @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetBooleanv")]
		public static extern void GetBooleanv(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetClipPlane")]
		public static extern void GetClipPlane(uint plane, double[] equation);
		[DllImport("Opengl32.dll", EntryPoint = "glGetClipPlane")]
		public static extern void GetClipPlane(uint plane, ref double equation);
		[DllImport("Opengl32.dll", EntryPoint = "glGetClipPlane")]
		public static extern void GetClipPlane(uint plane, IntPtr equation);
		[DllImport("Opengl32.dll", EntryPoint = "glGetDoublev")]
		public static extern void GetDoublev(uint pname, double[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetDoublev")]
		public static extern void GetDoublev(uint pname, ref double @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetDoublev")]
		public static extern void GetDoublev(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetError")]
		public static extern uint GetError();
		[DllImport("Opengl32.dll", EntryPoint = "glGetFloatv")]
		public static extern void GetFloatv(uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetFloatv")]
		public static extern void GetFloatv(uint pname, ref float @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetFloatv")]
		public static extern void GetFloatv(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetIntegerv")]
		public static extern void GetIntegerv(uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetIntegerv")]
		public static extern void GetIntegerv(uint pname, ref int @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetIntegerv")]
		public static extern void GetIntegerv(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetLightfv")]
		public static extern void GetLightfv(uint light, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetLightfv")]
		public static extern void GetLightfv(uint light, uint pname, ref float @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetLightfv")]
		public static extern void GetLightfv(uint light, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetLightiv")]
		public static extern void GetLightiv(uint light, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetLightiv")]
		public static extern void GetLightiv(uint light, uint pname, ref int @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetLightiv")]
		public static extern void GetLightiv(uint light, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapdv")]
		public static extern void GetMapdv(uint target, uint query, double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapdv")]
		public static extern void GetMapdv(uint target, uint query, ref double v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapdv")]
		public static extern void GetMapdv(uint target, uint query, IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapfv")]
		public static extern void GetMapfv(uint target, uint query, float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapfv")]
		public static extern void GetMapfv(uint target, uint query, ref float v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapfv")]
		public static extern void GetMapfv(uint target, uint query, IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapiv")]
		public static extern void GetMapiv(uint target, uint query, int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapiv")]
		public static extern void GetMapiv(uint target, uint query, ref int v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMapiv")]
		public static extern void GetMapiv(uint target, uint query, IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMaterialfv")]
		public static extern void GetMaterialfv(uint face, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMaterialfv")]
		public static extern void GetMaterialfv(uint face, uint pname, ref float @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMaterialfv")]
		public static extern void GetMaterialfv(uint face, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMaterialiv")]
		public static extern void GetMaterialiv(uint face, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMaterialiv")]
		public static extern void GetMaterialiv(uint face, uint pname, ref int @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetMaterialiv")]
		public static extern void GetMaterialiv(uint face, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapfv")]
		public static extern void GetPixelMapfv(uint map, float[] values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapfv")]
		public static extern void GetPixelMapfv(uint map, ref float values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapfv")]
		public static extern void GetPixelMapfv(uint map, IntPtr values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapuiv")]
		public static extern void GetPixelMapuiv(uint map, uint[] values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapuiv")]
		public static extern void GetPixelMapuiv(uint map, ref uint values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapuiv")]
		public static extern void GetPixelMapuiv(uint map, IntPtr values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapusv")]
		public static extern void GetPixelMapusv(uint map, ushort[] values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapusv")]
		public static extern void GetPixelMapusv(uint map, ref ushort values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPixelMapusv")]
		public static extern void GetPixelMapusv(uint map, IntPtr values);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPointerv")]
		public static extern void GetPointerv(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPointerv")]
		public static extern void GetPointerv(uint pname, ref byte[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPolygonStipple")]
		public static extern void GetPolygonStipple(byte[] mask);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPolygonStipple")]
		public static extern void GetPolygonStipple(ref byte mask);
		[DllImport("Opengl32.dll", EntryPoint = "glGetPolygonStipple")]
		public static extern void GetPolygonStipple(IntPtr mask);
		[DllImport("Opengl32.dll", EntryPoint = "glGetString")]
		public static extern IntPtr GetString(uint name);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexEnvfv")]
		public static extern void GetTexEnvfv(uint target, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexEnvfv")]
		public static extern void GetTexEnvfv(uint target, uint pname, ref float @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexEnvfv")]
		public static extern void GetTexEnvfv(uint target, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexEnviv")]
		public static extern void GetTexEnviv(uint target, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexEnviv")]
		public static extern void GetTexEnviv(uint target, uint pname, ref int @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexEnviv")]
		public static extern void GetTexEnviv(uint target, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGendv")]
		public static extern void GetTexGendv(uint coord, uint pname, double[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGendv")]
		public static extern void GetTexGendv(uint coord, uint pname, ref double @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGendv")]
		public static extern void GetTexGendv(uint coord, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGenfv")]
		public static extern void GetTexGenfv(uint coord, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGenfv")]
		public static extern void GetTexGenfv(uint coord, uint pname, ref float @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGenfv")]
		public static extern void GetTexGenfv(uint coord, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGeniv")]
		public static extern void GetTexGeniv(uint coord, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGeniv")]
		public static extern void GetTexGeniv(uint coord, uint pname, ref int @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexGeniv")]
		public static extern void GetTexGeniv(uint coord, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexImage")]
		public static extern void GetTexImage(uint target, int level, uint format, uint type, IntPtr pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexImage")]
		public static extern void GetTexImage(uint target, int level, uint format, uint type, byte[] pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexLevelParameterfv")]
		public static extern void GetTexLevelParameterfv(uint target, int level, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexLevelParameterfv")]
		public static extern void GetTexLevelParameterfv(uint target, int level, uint pname, ref float @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexLevelParameterfv")]
		public static extern void GetTexLevelParameterfv(uint target, int level, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexLevelParameteriv")]
		public static extern void GetTexLevelParameteriv(uint target, int level, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexLevelParameteriv")]
		public static extern void GetTexLevelParameteriv(uint target, int level, uint pname, ref int @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexLevelParameteriv")]
		public static extern void GetTexLevelParameteriv(uint target, int level, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexParameterfv")]
		public static extern void GetTexParameterfv(uint target, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexParameterfv")]
		public static extern void GetTexParameterfv(uint target, uint pname, ref float @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexParameterfv")]
		public static extern void GetTexParameterfv(uint target, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexParameteriv")]
		public static extern void GetTexParameteriv(uint target, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexParameteriv")]
		public static extern void GetTexParameteriv(uint target, uint pname, ref int @params);
		[DllImport("Opengl32.dll", EntryPoint = "glGetTexParameteriv")]
		public static extern void GetTexParameteriv(uint target, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glHint")]
		public static extern void Hint(uint target, uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexMask")]
		public static extern void IndexMask(uint mask);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexPointer")]
		public static extern void IndexPointer(uint type, int stride, IntPtr pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexPointer")]
		public static extern void IndexPointer(uint type, int stride, byte[] pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexd")]
		public static extern void Indexd(double c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexdv")]
		public static extern void Indexdv(double[] c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexdv")]
		public static extern void Indexdv(IntPtr c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexf")]
		public static extern void Indexf(float c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexfv")]
		public static extern void Indexfv(float[] c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexfv")]
		public static extern void Indexfv(IntPtr c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexi")]
		public static extern void Indexi(int c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexiv")]
		public static extern void Indexiv(int[] c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexiv")]
		public static extern void Indexiv(IntPtr c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexs")]
		public static extern void Indexs(short c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexsv")]
		public static extern void Indexsv(short[] c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexsv")]
		public static extern void Indexsv(IntPtr c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexub")]
		public static extern void Indexub(byte c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexubv")]
		public static extern void Indexubv(byte[] c);
		[DllImport("Opengl32.dll", EntryPoint = "glIndexubv")]
		public static extern void Indexubv(IntPtr c);
		[DllImport("Opengl32.dll", EntryPoint = "glInitNames")]
		public static extern void InitNames();
		[DllImport("Opengl32.dll", EntryPoint = "glInterleavedArrays")]
		public static extern void InterleavedArrays(uint format, int stride, IntPtr pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glInterleavedArrays")]
		public static extern void InterleavedArrays(uint format, int stride, byte[] pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glIsEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IsEnabled(uint cap);
		[DllImport("Opengl32.dll", EntryPoint = "glIsList")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IsList(uint list);
		[DllImport("Opengl32.dll", EntryPoint = "glIsTexture")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IsTexture(uint texture);
		[DllImport("Opengl32.dll", EntryPoint = "glLightModelf")]
		public static extern void LightModelf(uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glLightModelfv")]
		public static extern void LightModelfv(uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glLightModelfv")]
		public static extern void LightModelfv(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glLightModeli")]
		public static extern void LightModeli(uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glLightModeliv")]
		public static extern void LightModeliv(uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glLightModeliv")]
		public static extern void LightModeliv(uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glLightf")]
		public static extern void Lightf(uint light, uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glLightfv")]
		public static extern void Lightfv(uint light, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glLightfv")]
		public static extern void Lightfv(uint light, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glLighti")]
		public static extern void Lighti(uint light, uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glLightiv")]
		public static extern void Lightiv(uint light, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glLightiv")]
		public static extern void Lightiv(uint light, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glLineStipple")]
		public static extern void LineStipple(int factor, ushort pattern);
		[DllImport("Opengl32.dll", EntryPoint = "glLineWidth")]
		public static extern void LineWidth(float width);
		[DllImport("Opengl32.dll", EntryPoint = "glListBase")]
		public static extern void ListBase(uint @base);
		[DllImport("Opengl32.dll", EntryPoint = "glLoadIdentity")]
		public static extern void LoadIdentity();
		[DllImport("Opengl32.dll", EntryPoint = "glLoadMatrixd")]
		public static extern void LoadMatrixd(double[] m);
		[DllImport("Opengl32.dll", EntryPoint = "glLoadMatrixd")]
		public static extern void LoadMatrixd(IntPtr m);
		[DllImport("Opengl32.dll", EntryPoint = "glLoadMatrixf")]
		public static extern void LoadMatrixf(float[] m);
		[DllImport("Opengl32.dll", EntryPoint = "glLoadMatrixf")]
		public static extern void LoadMatrixf(IntPtr m);
		[DllImport("Opengl32.dll", EntryPoint = "glLoadName")]
		public static extern void LoadName(uint name);
		[DllImport("Opengl32.dll", EntryPoint = "glLogicOp")]
		public static extern void LogicOp(uint opcode);
		[DllImport("Opengl32.dll", EntryPoint = "glMap1d")]
		public static extern void Map1d(uint target, double u1, double u2, int stride, int order, double[] points);
		[DllImport("Opengl32.dll", EntryPoint = "glMap1d")]
		public static extern void Map1d(uint target, double u1, double u2, int stride, int order, IntPtr points);
		[DllImport("Opengl32.dll", EntryPoint = "glMap1f")]
		public static extern void Map1f(uint target, float u1, float u2, int stride, int order, float[] points);
		[DllImport("Opengl32.dll", EntryPoint = "glMap1f")]
		public static extern void Map1f(uint target, float u1, float u2, int stride, int order, IntPtr points);
		[DllImport("Opengl32.dll", EntryPoint = "glMap2d")]
		public static extern void Map2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
		[DllImport("Opengl32.dll", EntryPoint = "glMap2d")]
		public static extern void Map2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, IntPtr points);
		[DllImport("Opengl32.dll", EntryPoint = "glMap2f")]
		public static extern void Map2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);
		[DllImport("Opengl32.dll", EntryPoint = "glMap2f")]
		public static extern void Map2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, IntPtr points);
		[DllImport("Opengl32.dll", EntryPoint = "glMapGrid1d")]
		public static extern void MapGrid1d(int un, double u1, double u2);
		[DllImport("Opengl32.dll", EntryPoint = "glMapGrid1f")]
		public static extern void MapGrid1f(int un, float u1, float u2);
		[DllImport("Opengl32.dll", EntryPoint = "glMapGrid2d")]
		public static extern void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
		[DllImport("Opengl32.dll", EntryPoint = "glMapGrid2f")]
		public static extern void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
		[DllImport("Opengl32.dll", EntryPoint = "glMaterialf")]
		public static extern void Materialf(uint face, uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glMaterialfv")]
		public static extern void Materialfv(uint face, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glMaterialfv")]
		public static extern void Materialfv(uint face, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glMateriali")]
		public static extern void Materiali(uint face, uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glMaterialiv")]
		public static extern void Materialiv(uint face, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glMaterialiv")]
		public static extern void Materialiv(uint face, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glMatrixMode")]
		public static extern void MatrixMode(uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glMultMatrixd")]
		public static extern void MultMatrixd(double[] m);
		[DllImport("Opengl32.dll", EntryPoint = "glMultMatrixd")]
		public static extern void MultMatrixd(IntPtr m);
		[DllImport("Opengl32.dll", EntryPoint = "glMultMatrixf")]
		public static extern void MultMatrixf(float[] m);
		[DllImport("Opengl32.dll", EntryPoint = "glMultMatrixf")]
		public static extern void MultMatrixf(IntPtr m);
		[DllImport("Opengl32.dll", EntryPoint = "glNewList")]
		public static extern void NewList(uint list, uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3b")]
		public static extern void Normal3b(sbyte nx, sbyte ny, sbyte nz);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3bv")]
		public static extern void Normal3bv(sbyte[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3bv")]
		public static extern void Normal3bv(byte[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3bv")]
		public static extern void Normal3bv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3d")]
		public static extern void Normal3d(double nx, double ny, double nz);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3dv")]
		public static extern void Normal3dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3dv")]
		public static extern void Normal3dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3f")]
		public static extern void Normal3f(float nx, float ny, float nz);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3fv")]
		public static extern void Normal3fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3fv")]
		public static extern void Normal3fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3i")]
		public static extern void Normal3i(int nx, int ny, int nz);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3iv")]
		public static extern void Normal3iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3iv")]
		public static extern void Normal3iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3s")]
		public static extern void Normal3s(short nx, short ny, short nz);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3sv")]
		public static extern void Normal3sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormal3sv")]
		public static extern void Normal3sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glNormalPointer")]
		public static extern void NormalPointer(uint type, int stride, IntPtr pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glNormalPointer")]
		public static extern void NormalPointer(uint type, int stride, byte[] pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glOrtho")]
		public static extern void Ortho(double left, double right, double bottom, double top, double zNear, double zFar);
		[DllImport("Opengl32.dll", EntryPoint = "glPassThrough")]
		public static extern void PassThrough(float token);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelMapfv")]
		public static extern void PixelMapfv(uint map, int mapsize, float[] values);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelMapfv")]
		public static extern void PixelMapfv(uint map, int mapsize, IntPtr values);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelMapuiv")]
		public static extern void PixelMapuiv(uint map, int mapsize, uint[] values);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelMapuiv")]
		public static extern void PixelMapuiv(uint map, int mapsize, IntPtr values);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelMapusv")]
		public static extern void PixelMapusv(uint map, int mapsize, ushort[] values);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelMapusv")]
		public static extern void PixelMapusv(uint map, int mapsize, IntPtr values);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelStoref")]
		public static extern void PixelStoref(uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelStorei")]
		public static extern void PixelStorei(uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelTransferf")]
		public static extern void PixelTransferf(uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelTransferi")]
		public static extern void PixelTransferi(uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glPixelZoom")]
		public static extern void PixelZoom(float xfactor, float yfactor);
		[DllImport("Opengl32.dll", EntryPoint = "glPointSize")]
		public static extern void PointSize(float size);
		[DllImport("Opengl32.dll", EntryPoint = "glPolygonMode")]
		public static extern void PolygonMode(uint face, uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glPolygonOffset")]
		public static extern void PolygonOffset(float factor, float units);
		[DllImport("Opengl32.dll", EntryPoint = "glPolygonStipple")]
		public static extern void PolygonStipple(byte[] mask);
		[DllImport("Opengl32.dll", EntryPoint = "glPolygonStipple")]
		public static extern void PolygonStipple(IntPtr mask);
		[DllImport("Opengl32.dll", EntryPoint = "glPopAttrib")]
		public static extern void PopAttrib();
		[DllImport("Opengl32.dll", EntryPoint = "glPopClientAttrib")]
		public static extern void PopClientAttrib();
		[DllImport("Opengl32.dll", EntryPoint = "glPopMatrix")]
		public static extern void PopMatrix();
		[DllImport("Opengl32.dll", EntryPoint = "glPopName")]
		public static extern void PopName();
		[DllImport("Opengl32.dll", EntryPoint = "glPrioritizeTextures")]
		public static extern void PrioritizeTextures(int n, uint[] textures, float[] priorities);
		[DllImport("Opengl32.dll", EntryPoint = "glPrioritizeTextures")]
		public static extern void PrioritizeTextures(int n, uint[] textures, IntPtr priorities);
		[DllImport("Opengl32.dll", EntryPoint = "glPrioritizeTextures")]
		public static extern void PrioritizeTextures(int n, IntPtr textures, float[] priorities);
		[DllImport("Opengl32.dll", EntryPoint = "glPrioritizeTextures")]
		public static extern void PrioritizeTextures(int n, IntPtr textures, IntPtr priorities);
		[DllImport("Opengl32.dll", EntryPoint = "glPushAttrib")]
		public static extern void PushAttrib(uint mask);
		[DllImport("Opengl32.dll", EntryPoint = "glPushClientAttrib")]
		public static extern void PushClientAttrib(uint mask);
		[DllImport("Opengl32.dll", EntryPoint = "glPushMatrix")]
		public static extern void PushMatrix();
		[DllImport("Opengl32.dll", EntryPoint = "glPushName")]
		public static extern void PushName(uint name);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2d")]
		public static extern void RasterPos2d(double x, double y);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2dv")]
		public static extern void RasterPos2dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2dv")]
		public static extern void RasterPos2dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2f")]
		public static extern void RasterPos2f(float x, float y);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2fv")]
		public static extern void RasterPos2fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2fv")]
		public static extern void RasterPos2fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2i")]
		public static extern void RasterPos2i(int x, int y);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2iv")]
		public static extern void RasterPos2iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2iv")]
		public static extern void RasterPos2iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2s")]
		public static extern void RasterPos2s(short x, short y);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2sv")]
		public static extern void RasterPos2sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos2sv")]
		public static extern void RasterPos2sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3d")]
		public static extern void RasterPos3d(double x, double y, double z);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3dv")]
		public static extern void RasterPos3dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3dv")]
		public static extern void RasterPos3dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3f")]
		public static extern void RasterPos3f(float x, float y, float z);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3fv")]
		public static extern void RasterPos3fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3fv")]
		public static extern void RasterPos3fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3i")]
		public static extern void RasterPos3i(int x, int y, int z);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3iv")]
		public static extern void RasterPos3iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3iv")]
		public static extern void RasterPos3iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3s")]
		public static extern void RasterPos3s(short x, short y, short z);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3sv")]
		public static extern void RasterPos3sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos3sv")]
		public static extern void RasterPos3sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4d")]
		public static extern void RasterPos4d(double x, double y, double z, double w);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4dv")]
		public static extern void RasterPos4dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4dv")]
		public static extern void RasterPos4dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4f")]
		public static extern void RasterPos4f(float x, float y, float z, float w);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4fv")]
		public static extern void RasterPos4fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4fv")]
		public static extern void RasterPos4fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4i")]
		public static extern void RasterPos4i(int x, int y, int z, int w);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4iv")]
		public static extern void RasterPos4iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4iv")]
		public static extern void RasterPos4iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4s")]
		public static extern void RasterPos4s(short x, short y, short z, short w);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4sv")]
		public static extern void RasterPos4sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glRasterPos4sv")]
		public static extern void RasterPos4sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glReadBuffer")]
		public static extern void ReadBuffer(uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, uint format, uint type, byte[] pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glRectd")]
		public static extern void Rectd(double x1, double y1, double x2, double y2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectdv")]
		public static extern void Rectdv(double[] v1, double[] v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectdv")]
		public static extern void Rectdv(double[] v1, IntPtr v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectdv")]
		public static extern void Rectdv(IntPtr v1, double[] v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectdv")]
		public static extern void Rectdv(IntPtr v1, IntPtr v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectf")]
		public static extern void Rectf(float x1, float y1, float x2, float y2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectfv")]
		public static extern void Rectfv(float[] v1, float[] v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectfv")]
		public static extern void Rectfv(float[] v1, IntPtr v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectfv")]
		public static extern void Rectfv(IntPtr v1, float[] v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectfv")]
		public static extern void Rectfv(IntPtr v1, IntPtr v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRecti")]
		public static extern void Recti(int x1, int y1, int x2, int y2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectiv")]
		public static extern void Rectiv(int[] v1, int[] v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectiv")]
		public static extern void Rectiv(int[] v1, IntPtr v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectiv")]
		public static extern void Rectiv(IntPtr v1, int[] v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectiv")]
		public static extern void Rectiv(IntPtr v1, IntPtr v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRects")]
		public static extern void Rects(short x1, short y1, short x2, short y2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectsv")]
		public static extern void Rectsv(short[] v1, short[] v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectsv")]
		public static extern void Rectsv(short[] v1, IntPtr v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectsv")]
		public static extern void Rectsv(IntPtr v1, short[] v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRectsv")]
		public static extern void Rectsv(IntPtr v1, IntPtr v2);
		[DllImport("Opengl32.dll", EntryPoint = "glRenderMode")]
		public static extern int RenderMode(uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glRotated")]
		public static extern void Rotated(double angle, double x, double y, double z);
		[DllImport("Opengl32.dll", EntryPoint = "glRotatef")]
		public static extern void Rotatef(float angle, float x, float y, float z);
		[DllImport("Opengl32.dll", EntryPoint = "glScaled")]
		public static extern void Scaled(double x, double y, double z);
		[DllImport("Opengl32.dll", EntryPoint = "glScalef")]
		public static extern void Scalef(float x, float y, float z);
		[DllImport("Opengl32.dll", EntryPoint = "glScissor")]
		public static extern void Scissor(int x, int y, int width, int height);
		[DllImport("Opengl32.dll", EntryPoint = "glSelectBuffer")]
		public static extern void SelectBuffer(int size, uint[] buffer);
		[DllImport("Opengl32.dll", EntryPoint = "glSelectBuffer")]
		public static extern void SelectBuffer(int size, ref uint buffer);
		[DllImport("Opengl32.dll", EntryPoint = "glSelectBuffer")]
		public static extern void SelectBuffer(int size, IntPtr buffer);
		[DllImport("Opengl32.dll", EntryPoint = "glShadeModel")]
		public static extern void ShadeModel(uint mode);
		[DllImport("Opengl32.dll", EntryPoint = "glStencilFunc")]
		public static extern void StencilFunc(uint func, int @ref, uint mask);
		[DllImport("Opengl32.dll", EntryPoint = "glStencilMask")]
		public static extern void StencilMask(uint mask);
		[DllImport("Opengl32.dll", EntryPoint = "glStencilOp")]
		public static extern void StencilOp(uint fail, uint zfail, uint zpass);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1d")]
		public static extern void TexCoord1d(double s);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1dv")]
		public static extern void TexCoord1dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1dv")]
		public static extern void TexCoord1dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1f")]
		public static extern void TexCoord1f(float s);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1fv")]
		public static extern void TexCoord1fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1fv")]
		public static extern void TexCoord1fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1i")]
		public static extern void TexCoord1i(int s);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1iv")]
		public static extern void TexCoord1iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1iv")]
		public static extern void TexCoord1iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1s")]
		public static extern void TexCoord1s(short s);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1sv")]
		public static extern void TexCoord1sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord1sv")]
		public static extern void TexCoord1sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2d")]
		public static extern void TexCoord2d(double s, double t);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2dv")]
		public static extern void TexCoord2dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2dv")]
		public static extern void TexCoord2dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2f")]
		public static extern void TexCoord2f(float s, float t);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2fv")]
		public static extern void TexCoord2fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2fv")]
		public static extern void TexCoord2fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2i")]
		public static extern void TexCoord2i(int s, int t);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2iv")]
		public static extern void TexCoord2iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2iv")]
		public static extern void TexCoord2iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2s")]
		public static extern void TexCoord2s(short s, short t);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2sv")]
		public static extern void TexCoord2sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord2sv")]
		public static extern void TexCoord2sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3d")]
		public static extern void TexCoord3d(double s, double t, double r);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3dv")]
		public static extern void TexCoord3dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3dv")]
		public static extern void TexCoord3dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3f")]
		public static extern void TexCoord3f(float s, float t, float r);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3fv")]
		public static extern void TexCoord3fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3fv")]
		public static extern void TexCoord3fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3i")]
		public static extern void TexCoord3i(int s, int t, int r);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3iv")]
		public static extern void TexCoord3iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3iv")]
		public static extern void TexCoord3iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3s")]
		public static extern void TexCoord3s(short s, short t, short r);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3sv")]
		public static extern void TexCoord3sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord3sv")]
		public static extern void TexCoord3sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4d")]
		public static extern void TexCoord4d(double s, double t, double r, double q);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4dv")]
		public static extern void TexCoord4dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4dv")]
		public static extern void TexCoord4dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4f")]
		public static extern void TexCoord4f(float s, float t, float r, float q);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4fv")]
		public static extern void TexCoord4fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4fv")]
		public static extern void TexCoord4fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4i")]
		public static extern void TexCoord4i(int s, int t, int r, int q);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4iv")]
		public static extern void TexCoord4iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4iv")]
		public static extern void TexCoord4iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4s")]
		public static extern void TexCoord4s(short s, short t, short r, short q);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4sv")]
		public static extern void TexCoord4sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoord4sv")]
		public static extern void TexCoord4sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoordPointer")]
		public static extern void TexCoordPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glTexCoordPointer")]
		public static extern void TexCoordPointer(int size, uint type, int stride, byte[] pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glTexEnvf")]
		public static extern void TexEnvf(uint target, uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glTexEnvfv")]
		public static extern void TexEnvfv(uint target, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexEnvfv")]
		public static extern void TexEnvfv(uint target, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexEnvi")]
		public static extern void TexEnvi(uint target, uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glTexEnviv")]
		public static extern void TexEnviv(uint target, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexEnviv")]
		public static extern void TexEnviv(uint target, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGend")]
		public static extern void TexGend(uint coord, uint pname, double param);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGendv")]
		public static extern void TexGendv(uint coord, uint pname, double[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGendv")]
		public static extern void TexGendv(uint coord, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGenf")]
		public static extern void TexGenf(uint coord, uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGenfv")]
		public static extern void TexGenfv(uint coord, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGenfv")]
		public static extern void TexGenfv(uint coord, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGeni")]
		public static extern void TexGeni(uint coord, uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGeniv")]
		public static extern void TexGeniv(uint coord, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexGeniv")]
		public static extern void TexGeniv(uint coord, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexImage1D")]
		public static extern void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glTexImage1D")]
		public static extern void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, byte[] pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glTexImage2D")]
		public static extern void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glTexImage2D")]
		public static extern void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, byte[] pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glTexParameterf")]
		public static extern void TexParameterf(uint target, uint pname, float param);
		[DllImport("Opengl32.dll", EntryPoint = "glTexParameterfv")]
		public static extern void TexParameterfv(uint target, uint pname, float[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexParameterfv")]
		public static extern void TexParameterfv(uint target, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexParameteri")]
		public static extern void TexParameteri(uint target, uint pname, int param);
		[DllImport("Opengl32.dll", EntryPoint = "glTexParameteriv")]
		public static extern void TexParameteriv(uint target, uint pname, int[] @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexParameteriv")]
		public static extern void TexParameteriv(uint target, uint pname, IntPtr @params);
		[DllImport("Opengl32.dll", EntryPoint = "glTexSubImage1D")]
		public static extern void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glTexSubImage1D")]
		public static extern void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, byte[] pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glTexSubImage2D")]
		public static extern void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glTexSubImage2D")]
		public static extern void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, byte[] pixels);
		[DllImport("Opengl32.dll", EntryPoint = "glTranslated")]
		public static extern void Translated(double x, double y, double z);
		[DllImport("Opengl32.dll", EntryPoint = "glTranslatef")]
		public static extern void Translatef(float x, float y, float z);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2d")]
		public static extern void Vertex2d(double x, double y);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2dv")]
		public static extern void Vertex2dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2dv")]
		public static extern void Vertex2dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2f")]
		public static extern void Vertex2f(float x, float y);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2fv")]
		public static extern void Vertex2fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2fv")]
		public static extern void Vertex2fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2i")]
		public static extern void Vertex2i(int x, int y);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2iv")]
		public static extern void Vertex2iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2iv")]
		public static extern void Vertex2iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2s")]
		public static extern void Vertex2s(short x, short y);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2sv")]
		public static extern void Vertex2sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex2sv")]
		public static extern void Vertex2sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3d")]
		public static extern void Vertex3d(double x, double y, double z);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3dv")]
		public static extern void Vertex3dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3dv")]
		public static extern void Vertex3dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3f")]
		public static extern void Vertex3f(float x, float y, float z);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3fv")]
		public static extern void Vertex3fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3fv")]
		public static extern void Vertex3fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3i")]
		public static extern void Vertex3i(int x, int y, int z);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3iv")]
		public static extern void Vertex3iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3iv")]
		public static extern void Vertex3iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3s")]
		public static extern void Vertex3s(short x, short y, short z);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3sv")]
		public static extern void Vertex3sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex3sv")]
		public static extern void Vertex3sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4d")]
		public static extern void Vertex4d(double x, double y, double z, double w);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4dv")]
		public static extern void Vertex4dv(double[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4dv")]
		public static extern void Vertex4dv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4f")]
		public static extern void Vertex4f(float x, float y, float z, float w);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4fv")]
		public static extern void Vertex4fv(float[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4fv")]
		public static extern void Vertex4fv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4i")]
		public static extern void Vertex4i(int x, int y, int z, int w);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4iv")]
		public static extern void Vertex4iv(int[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4iv")]
		public static extern void Vertex4iv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4s")]
		public static extern void Vertex4s(short x, short y, short z, short w);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4sv")]
		public static extern void Vertex4sv(short[] v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertex4sv")]
		public static extern void Vertex4sv(IntPtr v);
		[DllImport("Opengl32.dll", EntryPoint = "glVertexPointer")]
		public static extern void VertexPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glVertexPointer")]
		public static extern void VertexPointer(int size, uint type, int stride, byte[] pointer);
		[DllImport("Opengl32.dll", EntryPoint = "glViewport")]
		public static extern void Viewport(int x, int y, int width, int height);
	}
}
