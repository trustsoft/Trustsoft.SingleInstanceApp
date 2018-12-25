//------------------------Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ISingleInstanceApp.cs" company="Trustsoft Ltd.">
//     Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>19.11.2015</date>
//------------------------Copyright © 2010-2015 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.SingleInstanceApp
{
    #region " Using Directives "

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     Define method that should be called when second instance of app is launched.
    /// </summary>
    public interface ISingleInstanceApp
    {
        /// <summary>
        ///     Called when second app`s instance is activated.
        /// </summary>
        /// <param name="args"> The arguments. </param>
        /// <returns> <c> true </c> if processed, <c> false </c> otherwise. </returns>
        bool OnActivate(IList<string> args);
    }
}