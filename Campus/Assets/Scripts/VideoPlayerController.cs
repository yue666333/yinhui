using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public Button playButton;
    public Button pauseButton;
    public VideoPlayer videoPlayer; 
    private bool isPlaying = false; 

    void Start()
    {
        playButton.onClick.AddListener(ToggleVideoPlayback);
        pauseButton.onClick.AddListener(ToggleVideoPlayback2);
        pauseButton.gameObject.SetActive(false);
    }

    void ToggleVideoPlayback()
    {
        if (!isPlaying)
        {
            videoPlayer.Play();
            isPlaying = true;
    
            playButton.gameObject.SetActive(false);
            pauseButton.gameObject.SetActive(true);
        }
    }
    void ToggleVideoPlayback2()
    {
        if (isPlaying)
        {
            videoPlayer.Pause();
            isPlaying = false;
        }
        else
        {
            videoPlayer.Play();
            isPlaying = true;
        }
    }
}
