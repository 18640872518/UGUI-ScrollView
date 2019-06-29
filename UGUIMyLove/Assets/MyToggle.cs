using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MyToggle : MonoBehaviour {
    public GameObject isOnGameObj;
    public GameObject isOffGameObj;

    private Toggle toggle; 
	// Use this for initialization
	void Start () {
        toggle = GetComponent<Toggle>();
        if (toggle.isOn)
        {
            OnValueChange(toggle.isOn);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnValueChange(bool isOn)
    {
        isOnGameObj.SetActive(isOn);
        isOffGameObj.SetActive(!isOn);
    }
}
