using UnityEngine;
using Verse;

namespace AntimatterAnnihilation
{
    [StaticConstructorOnStartup]
    public static class Content
    {
        public static GameObject EnergyBallPrefab;
        public static GameObject EnergyBeamInPrefab;
        public static GameObject EnergyBeamOutPrefab;
        public static GameObject UpBeamPrefab;
        public static GameObject MeguminChargePrefab;

        public static Texture2D Expand, Collapse;
        public static Texture2D PowerNetGraph;
        public static Texture2D PowerLevelLow, PowerLevelMedium, PowerLevelHigh;
        public static Texture2D AutoAttackIcon, CancelIcon, ArrowIcon, GlobalStrikeIcon;

        static Content()
        {
            // Load content here.
            PowerNetGraph = ContentFinder<Texture2D>.Get("AntimatterAnnihilation/UI/PowerNetConsole Graph");

            ModCore.Trace("Loaded content.");
        }
    }
}
