//------------------------Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="NativeMethods.cs" company="Trustsoft Ltd.">
//     Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>19.11.2015</date>
//------------------------Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.SingleInstanceApp.Interop
{
    #region " Using Directives "

    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Security;

    #endregion

    [SuppressUnmanagedCodeSecurity]
    internal static class NativeMethods
    {
        #region " Static Methods "

        public static string[] CommandLineToArgs(string cmdLine)
        {
            IntPtr arguments = IntPtr.Zero;
            try
            {
                int numArgs;

                arguments = CommandLineToArguments(cmdLine, out numArgs);
                if (arguments == IntPtr.Zero)
                {
                    throw new Win32Exception();
                }
                var result = new string[numArgs];

                for (int i = 0; i < numArgs; i++)
                {
                    IntPtr currArg = Marshal.ReadIntPtr(arguments, i * Marshal.SizeOf(typeof(IntPtr)));
                    result[i] = Marshal.PtrToStringUni(currArg);
                }

                return result;
            }
            finally
            {
                LocalFree(arguments);
            }
        }

        [DllImport(ExternDll.Shell32, EntryPoint = "CommandLineToArgvW", CharSet = CharSet.Unicode)]
        private static extern IntPtr CommandLineToArguments([MarshalAs(UnmanagedType.LPWStr)] string cmdLine,
                                                            out int numArgs);

        [DllImport(ExternDll.Kernel32, EntryPoint = "LocalFree", SetLastError = true)]
        private static extern IntPtr LocalFree(IntPtr hMem);

        #endregion
    }
}