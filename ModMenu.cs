using System;
using UnityEngine;

namespace ModMenuSpace
{
	public class ModMenu : MonoBehaviour
	{
		// Variables needed for menu
		public static string MenuLabel = "MOD MENU TITLE";
		public static bool MenuVisible = false;

		public static bool Cheat1Active = false;
		public static string Cheat1Label = "Cheat 1 OFF";

		public static void DrawMenu()
		{

			// Toggle Menu button (always visible)
			if (GUI.Button(new Rect(0f,0f,100f,30f),"Toggle Menu"))
			{
				MenuVisible = !MenuVisible;
			}


			// This will only be drawn when menu is toggled on
			if (MenuVisible)
			{
    			// Cheat Header and Canvas
				GUI.Box(new Rect(100f,0f,500f,400f),MenuLabel);

                // Cheat 1 Button
                if (GUI.Button(new Rect(100f,30f,180f,30f),Cheat1Label))
			    {
				    Cheat1Active = !Cheat1Active;

                    if (Cheat1Active) 
                    { 
                        Cheat1Label = "Cheat 1 ON"; 
                    } else { 
                        Cheat1Label = "Cheat 1 OFF"; 
                    }
			    }

			}
		}
	}
}
