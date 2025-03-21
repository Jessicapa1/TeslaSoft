using TeslaSoft.Debugging;

namespace TeslaSoft
{
    public class TeslaSoftConsts
    {
        public const string LocalizationSourceName = "TeslaSoft";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "dd5368f21c9a4f1da836d28c57e4da37";
    }
}
