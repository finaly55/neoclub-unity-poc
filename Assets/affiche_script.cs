using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class affiche_script : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);

    public void openIt(string url)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
             OpenNewTab(url);
#endif
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            openIt("www.google.com");
        }
    }
}
        





