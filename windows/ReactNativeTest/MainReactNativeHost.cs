using ReactNative;
using ReactNative.Modules.Core;
using ReactNative.Shell;
using System.Collections.Generic;

namespace ReactNativeTest
{
    class MainReactNativeHost : ReactNativeHost
    {
        public override string MainComponentName => "ReactNativeTest";
        private CodePushReactPackage codePushReactPackage;

        public MainReactNativeHost()
        {
            codePushReactPackage = new CodePushReactPackage("", this);
        }

#if !BUNDLE || DEBUG
        public override bool UseDeveloperSupport => true;
#else
        public override bool UseDeveloperSupport => false;
#endif

        protected override string JavaScriptMainModuleName => "index";

#if BUNDLE
        protected override string JavaScriptBundleFile => "ms-appx:///ReactAssets/index.windows.bundle";
#endif

        protected override List<IReactPackage> Packages => new List<IReactPackage>
        {
            new MainReactPackage(),
        };
    }
}
