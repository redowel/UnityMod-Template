using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityModTemplate
{
    class Mod : MonoBehaviour
    {
        public void OnGUI()
        {
            GUI.Box(new Rect(10, 10, 200, 20), "UNITY TEMPLATE BOX!");
         
        }



    }
}