using StardewModdingAPI;
using StardewValley;
using StardewValley.Network;
using StardewValley.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTest
{
    public class EventPatched
    {
        public static IMonitor Monitor;

        public static void Initialize(IMonitor monitor)
        {
            Monitor = monitor;
        }

        public static void setUpPlayerControlSequence_Kelly(Event __instance, string id) // Code originally written by Goldenrevolver: https://github.com/kenny2892/StardewValleyMods/pull/1
        {
            try
            {
                Monitor.Log("Successfully loaded setUpPlayerControlSequence_Kelly", LogLevel.Alert);
            }
            catch (Exception e)
            {
                Monitor.Log("Failed to load setUpPlayerControlSequence_Kelly", LogLevel.Alert);
            }
        }

        public static void setUpFestivalMainEvent_Kelly(StardewValley.Event __instance)
        {
            try
            {
                Monitor.Log("Successfully loaded setUpFesticalMainEvent_Kelly", LogLevel.Alert);
            }

            catch (Exception e)
            {
                Monitor.Log("Failed to load setUpFesticalMainEvent_Kelly", LogLevel.Alert);
            }
        }
    }
}
