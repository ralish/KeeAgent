// @formatter:off
// ReSharper disable InconsistentNaming

#pragma warning disable CS0649  // Field is never assigned to

using System;
using System.Runtime.InteropServices;

namespace KeeAgent
{
  internal static class NativeMethods
  {
    #region Windows and Messages

    [DllImport("User32", SetLastError = true)]
    internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, WINDOW_POS_FLAGS uFlags);

    [Flags]
    internal enum HWND
    {
      HWND_NOTOPMOST  = -2,
      HWND_TOPMOST    = -1,
      HWND_TOP        = 0,
      HWND_BOTTOM     = 1
    }


    [Flags]
    internal enum WINDOW_POS_FLAGS : uint
    {
      SWP_NOSIZE          = 0x1,
      SWP_NOMOVE          = 0x2,
      SWP_NOZORDER        = 0x4,
      SWP_NOREDRAW        = 0x8,
      SWP_NOACTIVATE      = 0x10,
      SWP_DRAWFRAME       = 0x20,
      SWP_FRAMECHANGED    = 0x20,
      SWP_SHOWWINDOW      = 0x40,
      SWP_HIDEWINDOW      = 0x80,
      SWP_NOCOPYBITS      = 0x100,
      SWP_NOOWNERZORDER   = 0x200,
      SWP_NOREPOSITION    = 0x200,
      SWP_NOSENDCHANGING  = 0x400,
      SWP_DEFERERASE      = 0x2000,
      SWP_ASYNCWINDOWPOS  = 0x4000
    }

    #endregion
  }
}
