using RimWorld;
using Verse;

namespace PowerNetConsole.Utils
{
    [DefOf]
    public static class DefRefs
    {
        static DefRefs()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(DefRefs));
        }

        public static ResearchProjectDef InstantRemoteFlick;
    }
}
