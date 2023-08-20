using UnityEngine;
using UnityEngine.UI;

public class MusicToggleScript : MonoBehaviour
{
    public Toggle toggle;
    public AudioSource audioSource;

    private void Awake()
    {
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
    }
}
