using UnityEngine;
using System.Collections;

public static class Log
{
    public static void Trace(string message)
    {
        UnityEngine.Debug.Log(string.Format("[TRACE] {0}", message));
    }

    public static void Debug(string message)
    {
        UnityEngine.Debug.Log(string.Format("[DEBUG] {0}", message));
    }

    public static void Error(string message)
    {
        UnityEngine.Debug.LogError(string.Format("[ERROR] {0}", message));
    }
}
