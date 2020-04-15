using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionContinue : MonoBehaviour {
    public Button button;
    public GameObject thisScenario;
    public GameObject nextScenario;

    void Awake() {
        button.onClick.AddListener(SwitchScenario);
    }

    void SwitchScenario() {
        thisScenario.SetActive(false);
        nextScenario.SetActive(true);
    }
}
