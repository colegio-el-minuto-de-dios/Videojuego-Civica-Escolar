using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonarPartituras : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip destroysound;
    public Animator pianista1;
    public Animator pianista2;
    public Animator pianista3;
    public Animator pianista4;
    public Animator violinista1;
    public Animator violinista2;
    public Animator violinista3;
    public Animator violinista4;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();        
    }

    void OnMouseDown(){
        audioSource.clip = destroysound;
        audioSource.Play();
        if ((gameObject.name == "P1") | (gameObject.name == "P2") | (gameObject.name == "P3")){
            pianista1.SetBool("estaTocando", true);
            pianista2.SetBool("estaTocando", true);
            pianista3.SetBool("estaTocando", true);
            pianista4.SetBool("estaTocando", true);
        }  
        if ((gameObject.name == "V1") | (gameObject.name == "V2") | (gameObject.name == "V3")){
            violinista1.SetBool("estaTocando", true);
            violinista2.SetBool("estaTocando", true);
            violinista3.SetBool("estaTocando", true);
            violinista4.SetBool("estaTocando", true);
        }          
    }
    void OnMouseUp(){
        audioSource.Stop();
        if ((gameObject.name == "P1") | (gameObject.name == "P2") | (gameObject.name == "P3")){
            pianista1.SetBool("estaTocando", false);
            pianista2.SetBool("estaTocando", false);
            pianista3.SetBool("estaTocando", false);
            pianista4.SetBool("estaTocando", false);
        } 
        if ((gameObject.name == "V1") | (gameObject.name == "V2") | (gameObject.name == "V3")){
            violinista1.SetBool("estaTocando", false);
            violinista2.SetBool("estaTocando", false);
            violinista3.SetBool("estaTocando", false);
            violinista4.SetBool("estaTocando", false);
        }   
    }
}
