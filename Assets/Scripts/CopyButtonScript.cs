using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CopyButtonScript : MonoBehaviour
{
    public Text textToCopy;

    public void CopyTextToClipboard()
    {
        GUIUtility.systemCopyBuffer = textToCopy.text;
    }
}