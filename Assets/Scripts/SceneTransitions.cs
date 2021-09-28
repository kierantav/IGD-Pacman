using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public Animator anim;
    private int level;
    //public AudioSource intro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //intro.Play();
            FadeToLevel(1);
        }
    }

    public void FadeToLevel(int levelIndex) {
        level = levelIndex;
        anim.SetTrigger("FadeOut");
    }

    public void onFadeComplete() {
        SceneManager.LoadScene(level);
    }
}
