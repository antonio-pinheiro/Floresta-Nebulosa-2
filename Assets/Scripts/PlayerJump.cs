using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {
    Animator anim;

    public float intervaloDePulo;
    private float proximoPulo;

    public AudioClip jumpSound;
    private AudioSource audioS;
	// Use this for initialization
	void Start () {

        anim = gameObject.GetComponent<Animator>();
        audioS = gameObject.GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown("space") && Time.time > proximoPulo)
        {
            Pulou();
        }

	}

    void Pulou()
    {
        audioS.clip = jumpSound;
        audioS.Play();
        anim.SetTrigger("Pulou");
        proximoPulo = Time.time + intervaloDePulo;
    }
}
