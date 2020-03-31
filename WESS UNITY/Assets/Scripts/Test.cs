using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Test")]
public class Test : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string testText;

    public string GetText()
    {
        return testText;
    }
}


