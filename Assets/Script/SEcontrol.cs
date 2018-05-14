using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SEcontrol : MonoBehaviour {

    // multiple banks of sound effects, populated in editor
    public AudioClip FireSound;
    public AudioClip Tankmove;
    public AudioClip Tankidle;
    public AudioClip ImpactSounds;
    public AudioClip MissSound;
    public AudioClip music;
    public AudioSource asource;
    static SEcontrol This;

    public void PlayFireSoundInternal()
    {
        if (asource != null)
        {
            // set the clip on the source
            asource.clip = FireSound;
            asource.PlayOneShot(asource.clip);
        }
    }

    public static void PlayFireSound()
    {
        if (This != null)
        {
            This.PlayFireSoundInternal();
        }
    }
    // shot SE

    public void PlayTankmoveInternal()
    {
        if (asource != null)
        {
            // set the clip on the source
            asource.clip = Tankmove;
            asource.PlayOneShot(asource.clip);
        }
    }

    public static void PlayTankmove()
    {
        if (This != null)
        {
             This.PlayTankmoveInternal();
        }
           
    }
    //move SE

    public void PlayTankidleInternal()
    {
        if (asource != null)
        {
            // set the clip on the source
            asource.clip = Tankidle;
            asource.PlayOneShot(asource.clip);
        }
    }

    public static void PlayTankidle()
    {
        if (This != null)
        {
            This.PlayTankidleInternal();
        }
    }
    //move SE

    public void PlayImpactSoundInternal()
    {
        if (asource != null)
        {
            // set the clip on the source
            asource.clip = ImpactSounds;
            asource.PlayOneShot(asource.clip);
        }
    }
    public static void PlayImpactSound()
    {
        if (This != null)
        {
            This.PlayImpactSoundInternal();
        }   
    }
    //impact SE

    public void PlayMissSoundInternal()
    {
        if (asource != null)
        {
            // set the clip on the source
            asource.clip = MissSound;
            asource.PlayOneShot(asource.clip);
        }
    }
    public static void PlayMissSound()
    {
        if (This != null)
        {
            This.PlayMissSoundInternal();
        }
    }
    //miss SE

    public void PlayMusic()
    {
    }

    // Use this for initialization
    void Start()
    {

        asource = this.gameObject.GetComponent<AudioSource>();
        if (This != null)
            Debug.Log("SoundMgr:: error, more than one SoundMgr instance enoucntered, using previous verison");
        else
            This = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
