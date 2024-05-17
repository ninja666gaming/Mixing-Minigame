using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jukebox : MonoBehaviour
{
    [SerializeField] AudioSource audiosource;
    [SerializeField] AudioClip sceneSong;
    [SerializeField] AudioClip mixingSong;
    private AudioClip playing;
    public float FadeTime = 100f;

    // Start is called before the first frame update
    void Start()
    {
        playing = sceneSong;
        audiosource.clip = playing;
        audiosource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        EndMixing();
    }

    private void OnDisable()
    {
        StartMixing();
    }

    public void StartMixing()
    {
        StartCoroutine(FadeOut(audiosource, FadeTime));
        playing = mixingSong;
        audiosource.clip = playing;
        audiosource.Play();
        StartCoroutine(FadeIn(audiosource, FadeTime));
        Debug.Log("Mixing Song");
    }
    public void EndMixing()
    {
        StartCoroutine(FadeOut(audiosource, FadeTime));
        playing = sceneSong;
        audiosource.clip = playing;
        audiosource.Play();
        StartCoroutine(FadeIn(audiosource, FadeTime));
        Debug.Log("Scene Song");
    }


    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
        audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

        yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }
    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume < 0.4)
        {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }
}
