using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionContinue : MonoBehaviour {
    public Button button;
    public bool correct;
    public Text failText;
    public Text correctText;
    //public GameObject thisScenario;
    //public GameObject nextScenario;

    void Awake() {
        //button.onClick.AddListener(SwitchScenario);
        button.onClick.AddListener(ChangeText);
        failText.enabled = false;
        correctText.enabled = false;
    }

    void ChangeText()
    {
        if (correct)
        {
            correctText.enabled = true;
        }
        else
        {
            failText.enabled = true;
        }
    }

    //void SwitchScenario() {
    //    if (correct) {    // switch scenario
    //        thisScenario.SetActive(false);
    //        nextScenario.SetActive(true);
    //    } else {    // show Failure GO
    //        GameObject failureGO = GameObject.Find("Failure");
    //        failureGO.transform.GetChild(0).gameObject.SetActive(true);
    //    }
    //}
}