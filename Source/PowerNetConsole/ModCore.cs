using System;
using HarmonyLib;
using InGameWiki;
using System.Linq;
using UnityEngine;
using Verse;
using Object = UnityEngine.Object;

namespace PowerNetConsole
{
    internal class HotSwapAllAttribute : Attribute { }
    
    [HotSwapAll]
    public class ModCore : Mod
    {
        public static ModCore Instance { get; private set; }

        public ModWiki Wiki { get; internal set; }

        public Harmony HarmonyInstance { get; private set; }

        public ModCore(ModContentPack content) : base(content)
        {
            Instance = this;
            Log("Hello, world!");

            AddHook();
            Trace("Added hook.");

            PatchAll();
            Log($"Patched {HarmonyInstance.GetPatchedMethods().Count()} methods.");
        }

        private void AddHook()
        {
            var go = new GameObject("PowerNetConsole Hook");
            go.hideFlags = HideFlags.HideAndDontSave;
            Object.DontDestroyOnLoad(go);

            go.AddComponent<Hook>();
        }

        private void PatchAll()
        {
            HarmonyInstance = new Harmony("bardez.PowerNetConsole");
            HarmonyInstance.PatchAll();
        }

        public static void Log(string msg)
        {
            Verse.Log.Message(msg ?? "<null>");
        }

        public static void Trace(string msg)
        {
            Verse.Log.Message(msg ?? "<null>");
        }
    }
}
