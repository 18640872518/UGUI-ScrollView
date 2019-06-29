using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SkillItem : MonoBehaviour {
    public float clodTime = 2f;
    public Image filledImage;
    private float timer = 0;
    private bool isStartTimer = false;
    public KeyCode myKeyCode;
	// Use this for initialization
	void Start () {
        filledImage = transform.Find("FilledImage").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(myKeyCode))
        {
            isStartTimer = true;
        }
        if (isStartTimer)
        {
            timer += Time.deltaTime;
            filledImage.fillAmount = (clodTime - timer) / clodTime;
            if (timer >= clodTime)
            {
                filledImage.fillAmount = 0;
                timer = 0;
                isStartTimer = false;
            }
        }
	}
    public void OnClick()
    {
        isStartTimer = true;
    }
}
