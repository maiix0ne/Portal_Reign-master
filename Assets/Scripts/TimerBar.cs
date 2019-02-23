using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerBar : MonoBehaviour {
    Image fillImg;
    float timeAmt = 2f;
    float time;
	// Use this for initialization
	void Start () {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
	}
	
	// Update is called once per frame
	void Update () {
		if(time > 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
        }
	}
}
