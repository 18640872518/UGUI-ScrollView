using UnityEngine;
using System.Collections;

public class asdasd : MonoBehaviour {
    float x = 0;
    float y = 0;
    float speed = 100.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {//鼠标按着左键移动 
            y = Input.GetAxis("Mouse X") * Time.deltaTime * speed;
            x = Input.GetAxis("Mouse Y") * Time.deltaTime * speed;
        }
        else
        {
            x = y = 0;
        }

        //旋转角度（增加）
        transform.Rotate(new Vector3(-x, -y, 0));
        pinghuaxuanzhuan();
	}
    void OnGUI()
    {
       
            //自定义角度

            targetRotation = Quaternion.Euler(45.0f, 45.0f, 45.0f);
            // 直接设置旋转角度 
            //transform.rotation = targetRotation;

            // 平滑旋转至目标角度 
            iszhuan = true;
        
    }

    bool iszhuan = false;
    Quaternion targetRotation;

    void pinghuaxuanzhuan()
    {
        if (iszhuan)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 3);
        }
    }
}
