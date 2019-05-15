using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMangerScript : MonoBehaviour
{
    public static AudioClip ShootSound, RicochetSound, GlassSound, CountdownSound, MusicSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        ShootSound = Resources.Load<AudioClip>("Shoot");
        RicochetSound = Resources.Load<AudioClip>("Ricochet");
        GlassSound = Resources.Load<AudioClip>("Glass");
        CountdownSound = Resources.Load<AudioClip>("Countdown");
        MusicSound = Resources.Load<AudioClip>("Music");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Shoot":
                audioSrc.PlayOneShot(ShootSound);
                break;
            case "Ricochet":
                audioSrc.PlayOneShot(RicochetSound);
                break;
            case "Glass":
                audioSrc.PlayOneShot(GlassSound);
                break;
            case "Countdown":
                audioSrc.PlayOneShot(CountdownSound);
                break;
            case "Music":
                audioSrc.PlayOneShot(MusicSound);
                break;
        }
        // SoundManagerscript.PlaySound("...");
        // Use the code above to insert sound.
    }
}
