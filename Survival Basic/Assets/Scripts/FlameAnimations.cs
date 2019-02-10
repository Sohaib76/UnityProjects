﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour {

    public int LightMode;
    public GameObject FlameLight;
	
	// Update is called once per frame
	void Update () {
        if (LightMode == 0) {
            StartCoroutine(AnimateLight ());
        }
        
	}
    //No Private
    private IEnumerator AnimateLight() {            
        LightMode = UnityEngine.Random.Range(1, 4);            //No UnityEngine.
            if(LightMode == 1)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim1");
        }

        if (LightMode == 2)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim2");
        }

        if (LightMode == 3)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim3");
        }

        yield return new WaitForSeconds(0.99f);
        LightMode = 0;

    }
}
