using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UILoggerEditor : EditorWindow
{
    [MenuItem("Tools/Create UILogger", false)]
    public static void CreateUILogger()
    {
        GameObject uilogger = (GameObject)Instantiate(Resources.Load("UILogger"), Vector3.zero, Quaternion.identity);
        uilogger.name = "UILogger";
    }
}
