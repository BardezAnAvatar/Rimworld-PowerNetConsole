using UnityEngine;
using Verse;

namespace PowerNetConsole
{
    [StaticConstructorOnStartup]
    public static class Content
    {
        public static Texture2D Expand, Collapse;
        public static Texture2D PowerNetGraph;

        static Content()
        {
            // Load content here.
            PowerNetGraph = ContentFinder<Texture2D>.Get("PowerNetConsole/UI/PowerNetConsole Graph");

            ModCore.Trace("Loaded content.");
        }
    }
}
