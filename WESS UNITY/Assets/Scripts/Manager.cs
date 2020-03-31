using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] Text testTextComp;
    [SerializeField] Test startTestText;

    Test currentText; 
    // Start is called before the first frame update
    void Start()
    {
        currentText = startTestText;
        testTextComp.text = currentText.GetText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
