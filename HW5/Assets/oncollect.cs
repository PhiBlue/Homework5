using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class oncollect : MonoBehaviour
{
    [SerializeField] private GameObject particleobject;
    [SerializeField] private Animator dooranim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ParticleSystem ps = particleobject.GetComponent<ParticleSystem>();
        ps.Play();
        dooranim.SetBool("OpenDoor", true);
        Destroy(gameObject);
    }
}
