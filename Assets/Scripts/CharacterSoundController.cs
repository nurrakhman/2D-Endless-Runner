using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{

    [Header("Audio")]
    public AudioClip jump;
    public AudioClip ScoreHighlight;
    private AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {

        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(ScoreHighlight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
