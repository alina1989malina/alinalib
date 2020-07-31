using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Alinalib.RNAlinalib
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAlinalibModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAlinalibModule"/>.
        /// </summary>
        internal RNAlinalibModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAlinalib";
            }
        }
    }
}
