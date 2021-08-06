using SMSPackages.UILogger;
using UnityEngine;

public class ObjectPositionLogger : MonoBehaviour, ILogable
{
    public string title;
    void LogTransform()
    {
        UILogger.Add(title + " " + transform.position.ToString());
    }

    public void CollectLogData()
    {
        LogTransform();
    }
}