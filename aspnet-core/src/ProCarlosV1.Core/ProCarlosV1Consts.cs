using ProCarlosV1.Debugging;

namespace ProCarlosV1
{
    public class ProCarlosV1Consts
    {
        public const string LocalizationSourceName = "ProCarlosV1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "11cf509a87fd411482f0cb8ce576f300";
    }
}
