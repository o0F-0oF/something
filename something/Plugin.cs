using BepInEx.Configuration;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using BepInEx;

namespace something
{
    [BepInPlugin("amongus.sus.red.plugins", "something", "1.1.1.1")]
    public class Plugin : BasePlugin
    {
        internal static ManualLogSource log;
        internal static ConfigFile cfg;
        public override void Load()
        {
            log = Log;
            cfg = Config;
            log.LogMessage("BepInEx is very cool");
        }
    }
}
