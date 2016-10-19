using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] songs;
    public List<AudioClip> songList;

    private AudioSource audioSource;

    public int songNumber;

    private float currentSongToFinish;
	

	void Awake ()
    {
        audioSource = GetComponent<AudioSource>();

        songList = new List<AudioClip>();

        for (int i=0; i<= songs.Length-1; i++)
            songList.Add(songs[i]);

        Debug.Log(songList.Count);
    }
	
    void Start()
    {
        ChooseSong();
    }

    void ChooseSong()
    {
        songNumber = Random.Range(0, songList.Count);

        Play(songList[songNumber]);
    }

    void Play(AudioClip song)
    {
        audioSource.clip = song;

        currentSongToFinish = song.length;

        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }

        StartCoroutine(TimeToPlayNextSong());
    }

    IEnumerator TimeToPlayNextSong()
    {
        yield return new WaitForSeconds(currentSongToFinish);

        songList.RemoveAt(songNumber);

        Debug.Log(songList.Count);

        ChooseSong();
    }
}
