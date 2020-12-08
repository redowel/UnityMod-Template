using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;

namespace UnityModTemplate
{
    public class Main
    {
        static void Init()
        {
            Main.Load = new GameObject();
            Main.Load.AddComponent<Mod>();
            UnityEngine.Object.DontDestroyOnLoad(Main.Load);
        }

        static void Unload()
        {
            GameObject.Destroy(Main.Load);
        }


        private static GameObject Load;
    }
}