//------------------------Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ExternDll.cs" company="Trustsoft Ltd.">
//     Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>19.11.2015</date>
//------------------------Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.SingleInstanceApp.Interop
{
    #region " Using Directives "

    using System.Runtime.InteropServices;

    #endregion

    /// <summary>
    ///     Helper class for <see cref="DllImportAttribute"/> to simplify the dll name definition.
    /// </summary>
    internal static class ExternDll
    {
        #region " Constants "

        internal const string Kernel32 = "kernel32.dll";
        internal const string Shell32 = "shell32.dll";

        #endregion
    }
}