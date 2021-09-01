using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public FadeController fader;

    public AudioClip playersound;
    public string scenename;
    public int maxRandom;

    private bool IsTriggerZone = false;
    // Start is called before the first frame update
    void Start()
    {
        fader.FadeOut(5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsTriggerZone)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 3))
            {
                if(hit.collider.tag == "Door")
                {
                    if(Input.GetKey(KeyCode.E))
                    {
                        hit.collider.gameObject.GetComponent<Animator>().SetBool("IsOpen", true);
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerZone")
            IsTriggerZone = true;
        if (other.gameObject.tag == "NextSceneCollider")
        {
            if(Random.Range(1, maxRandom) == 1)
            {
                AudioSource.PlayClipAtPoint(playersound, transform.position);
                fader.FadeIn(2.0f, () => { SceneManager.LoadScene("Dead"); });
            }
            else
            {
                AudioSource.PlayClipAtPoint(playersound, transform.position);
                fader.FadeIn(2.0f, () => { SceneManager.LoadScene(scenename); });
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TriggerZone")
            IsTriggerZone = false;
    }
}
