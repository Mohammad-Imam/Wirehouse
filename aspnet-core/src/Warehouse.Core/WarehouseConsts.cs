using Warehouse.Debugging;

namespace Warehouse
{
    public class WarehouseConsts
    {
        public const string LocalizationSourceName = "Warehouse";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "676f9a6926094bbda70500b7bcb107a5";
    }
}
