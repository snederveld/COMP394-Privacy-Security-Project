using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionContinue : MonoBehaviour {
    public Button button;
    public bool correct;
    public GameObject thisScenario;
    public GameObject nextScenario;

    void Awake() {
        button.onClick.AddListener(SwitchScenario);
    }

    void SwitchScenario() {
        if (correct) {
            thisScenario.SetActive(false);
            nextScenario.SetActive(true);
        } else {
            //GameObject.Find("Failure").SetActive(true);  // TODO: FIND CORRECT PATH
        }
    }
}
