namespace TailwindTraders.Mobile.Features.Settings
{
    public static class DefaultSettings
    {
        public const string ApiAuthorizationHeader = "Authorization";

        public static string AccessToken = string.Empty;

        public const string AppCenterAndroidSecret = "__ENTER_YOUR_ANDROID_APPCENTER_SECRET_HERE__";

        public const string AppCenteriOSSecret = "__ENTER_YOUR_IOS_APPCENTER_SECRET_HERE__";

        public const bool UseFakeAPIs = false;

        public const bool UseFakeAuthentication = DebugMode;

        public const bool ForceAutomaticLogin = DebugMode;

        public const bool BreakNetworkRandomly = false;

        public const bool AndroidDebuggable = DebugMode;

        public const bool UseDebugLogging = DebugMode;

        public const bool EnableARDiagnostics = DebugMode;

        public const bool DebugMode =
#if DEBUG 
            true;
#else
            false;
#endif


        //public static string RootApiUrl { get; set; } = "https://bemaproduct.azurewebsites.net/api";
        public static string RootApiUrl { get; set; } = "http://localhost:8000/api";

        public static string RootProductsWebApiUrl { get; set; } = "https://bemaproduct.azurewebsites.net/api";
    }
}
