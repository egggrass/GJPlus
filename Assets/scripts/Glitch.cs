using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kino;
public class Glitch : Singleton<Glitch>
{
    
    public AnalogGlitch analogGlitch;
    public DigitalGlitch digitalGlitch;
    public float glitchDegree1 = 0.1f;
    public float glitchDegree2 = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ShowGlitch()
    {
       
        analogGlitch.scanLineJitter = glitchDegree1;
        analogGlitch.horizontalShake = glitchDegree1;
        analogGlitch.colorDrift = glitchDegree1;

        digitalGlitch.intensity = glitchDegree2;
    }

    public void StopGlitch()
    {

        analogGlitch.scanLineJitter = 0;
        analogGlitch.horizontalShake = 0;
        analogGlitch.colorDrift = 0;

        digitalGlitch.intensity = 0;
    }
    
    

}
