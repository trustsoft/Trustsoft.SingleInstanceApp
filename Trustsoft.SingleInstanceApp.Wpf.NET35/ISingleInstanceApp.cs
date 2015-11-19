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

    public interface ISingleInstanceApp
    {
        #region " Public Methods "

        bool OnActivate(IList<string> args);

        #endregion
    }
}