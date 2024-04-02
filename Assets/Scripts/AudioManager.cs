
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    [SerializeField]
    
    private AudioMixer audioMixer;

    [SerializeField]
    private Slider glissiereMusique;

    [SerializeField]private Slider glissiereFX;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //audioMixer.GetFloat("VolumeMusique");
        //audioMixer.SetFloat("VolumeMusique", -20f);
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", ConvertToLogarithmique(volume));
    }

    private float ConvertToLogarithmique(float volume){
        return Mathf.Log10(volume)*20;
    }
    
    public void AjusteVolumeEffet(float volume){
        audioMixer.SetFloat("VolumeEffet", ConvertToLogarithmique(volume));
        audioSource.Play();
    }
   
}
