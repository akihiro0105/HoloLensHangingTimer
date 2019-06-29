using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
    [SerializeField] private Text text;

    private float initheight = 0.0f;

    private float time = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        initheight = Camera.main.transform.position.y;
        
        //0.26
        if (initheight>0.25f)
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0.0f;
        }
        text.text = "Time : " + time.ToString();

        if (time>10.0f)
        {
            text.text = "お疲れさまでした．";
        }
    }
}
