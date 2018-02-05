using System;
using System.Runtime.InteropServices;
using System.Text;

namespace TellMeYourSecrets
{
    internal class kernel32
    {
        ////////////////////////////////////////////////////////////////////////////////
        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetCurrentThread();

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll")]
        internal static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Boolean bInheritHandle, UInt32 dwProcessId);

        [DllImport("kernel32.dll")]
        internal static extern Boolean OpenProcessToken(IntPtr hProcess, UInt32 dwDesiredAccess, out IntPtr hToken);

        [DllImport("kernel32.dll")]
        internal static extern Boolean OpenThreadToken(IntPtr ThreadHandle, UInt32 DesiredAccess, Boolean OpenAsSelf, ref IntPtr TokenHandle);

        [DllImport("kernel32.dll")]
        internal static extern Boolean CloseHandle(IntPtr hProcess);
    }
}