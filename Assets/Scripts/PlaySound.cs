using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour
{
    public AudioClip sound;
    public GameObject theSound;
    private AudioSource audioSource;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = this.GetComponent<Button>();
        audioSource = theSound.GetComponent<AudioSource>();
        button.onClick.AddListener(SoundPlay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SoundPlay()
    {
        audioSource.PlayOneShot(sound);
    }
}
