using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningFlash : MonoBehaviour
{
    public Light myLight;
    public float blinkAtThisTime;

    float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > blinkAtThisTime)
        {
            StartCoroutine("Blink");
            timer = 0;

        }
    }

    IEnumerator Blink()
    {
        myLight.enabled = true;
        yield return new WaitForSeconds(.4f);
        myLight.enabled = false;
    }

}
