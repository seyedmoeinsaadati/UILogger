using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SMSPackages.UILogger
{
    public class ScreenSize : MonoBehaviour, ILogable
    {
        private void Start()
        {
        }
        public void CollectLogData()
        {
            UILogger.Add(string.Format("Screen Size: " + Screen.width + " x " + Screen.height));
        }
    }
}
