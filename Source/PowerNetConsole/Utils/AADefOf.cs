using RimWorld;
using Verse;

namespace PowerNetConsole.Utils
{
    [DefOf]
    public static class AADefOf
    {
        static AADefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(AADefOf));
        }

        public static ResearchProjectDef InstantFlick_AA;
    }
}
