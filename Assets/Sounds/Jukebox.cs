using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jukebox : MonoBehaviour
{
    [SerializeField] AudioSource audiosource;
    [SerializeField] AudioClip sceneSong;
    [SerializeField] AudioClip mixingSong;
    private AudioClip playing;
    public float FadeTime = 0.5f;
    private float mixingVolume = 0.09f;
    private float sceneVolume = 0.04f;
    private bool isInitialEnable = true;

    // Start is called before the first frame update
    void Start()
    {

        playing = sceneSong;
        audiosource.volume = sceneVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if (isInitialEnable)
        {
            isInitialEnable = false;
        }
        else
        {
            EndMixing();
        }
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
        StartCoroutine(FadeIn(audiosource, FadeTime, mixingVolume));
        Debug.Log("Mixing Song");
    }
    public void EndMixing()
    {
        StartCoroutine(FadeOut(audiosource, FadeTime));
        playing = sceneSong;
        audiosource.clip = playing;
        audiosource.Play();
        StartCoroutine(FadeIn(audiosource, FadeTime, sceneVolume));
        Debug.Log("Scene Song");
    }


    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            //Debug.Log(audioSource.volume);
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
    }
    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime, float targetVolume)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume < targetVolume)
        {
            //Debug.Log(audioSource.volume);
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }
    }
}
