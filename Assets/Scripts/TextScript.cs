using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextScript : MonoBehaviour {
    public Button button;
    public GameObject thisScenario;
    public GameObject nextScenario;

    void Awake() {
        button.onClick.AddListener(ChangeScenario);
    }

    void ChangeScenario() {
        if (thisScenario.name != nextScenario.name) {
            thisScenario.SetActive(false);
            nextScenario.SetActive(true);
        }
        else {
            Scene loadedLevel = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadedLevel.buildIndex);
        }

    }
}
