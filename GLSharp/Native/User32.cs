using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GLSharp
{
    public class User32
    {
        public const string LIB = "user32.dll";

        [DllImport(LIB)]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport(LIB)]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);
        [DllImport(LIB)]
        public static extern bool GetClientRect(IntPtr hWnd, out Rect lpRect);
        [DllImport(LIB)]
        public static extern bool MessageBoxW(IntPtr hWnd,
            [MarshalAs(UnmanagedType.LPWStr)] string lpText,
            [MarshalAs(UnmanagedType.LPWStr)] string lpCaption,
            MessageBoxType type);
    }

    public enum MessageBoxType
    {
        ButtonAbortTryIgnore = 0x2,
        ButtonCancelTryContinue = 0x6,
        ButtonHelp = 0x4000,
        ButtonOk = 0x0,
        ButtonOkCancel = 0x1,
        ButtonRetryCancel = 0x5,
        ButtonYesNo = 0x4,
        ButtonYesNoCancel = 0x3,
        IconWarning = 0x30,
        IconInformation = 0x40,
        IconQuestion = 0x20,
        IconError = 0x10
    }
}
