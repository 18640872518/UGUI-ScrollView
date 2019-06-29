using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class LevelButtonScrollRect : MonoBehaviour,IBeginDragHandler,IEndDragHandler {

    private ScrollRect scrollRect;
    private float[] myArray = new float[]{0, 0.3333f, 0.6666f, 1f};
    private float TargetHorizontalPosition =0;
    public float smoothing = 4;
    private bool isDrang = false;
    public Toggle[] toggleArray;
	void Start () {
        scrollRect = GetComponent<ScrollRect>();
	}
	
	void Update () {
        if (isDrang == false)
        {
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(scrollRect.horizontalNormalizedPosition, TargetHorizontalPosition, Time.deltaTime * smoothing);
        }
       
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDrang = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDrang = false;
        float pos = scrollRect.horizontalNormalizedPosition;
        int index = 0;
        float offset = Mathf.Abs(myArray[index] - pos);
        for (int i = 1; i < myArray.Length; i++)
        {
            float offsetTemp = Mathf.Abs(myArray[i] - pos);
            if (offsetTemp < offset)
            {
                index = i;
                offset = offsetTemp;
            }
        }
        TargetHorizontalPosition = myArray[index];
        toggleArray[index].isOn = true;
        //scrollRect.horizontalNormalizedPosition = myArray[index];
    }
    public void MoveToPage1(bool isOn)
    {
        if (isOn)
        {
            TargetHorizontalPosition = myArray[0];
        }
    }
    public void MoveToPage2(bool isOn)
    {
        if (isOn)
        {
            TargetHorizontalPosition = myArray[1];
        }
    }
    public void MoveToPage3(bool isOn)
    {
        if (isOn)
        {
            TargetHorizontalPosition = myArray[2];
        }
    }
    public void MoveToPage4(bool isOn)
    {
        if (isOn)
        {
            TargetHorizontalPosition = myArray[3];
        }
    }
}
