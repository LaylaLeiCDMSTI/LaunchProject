using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClueClassmate : Clue
{

    public GameObject dialog;

    public TextMeshProUGUI text;


    //private Animator anim;
    //public AudioClip clip_ring;

    //public GameObject audio_kejian;

    protected override void Start()
    {
        base.Start();

        //anim = GetComponent<Animator>();
    }
    protected override void ClueInit()
    {
 

    }
    protected override void ClueStart()
    {

        StartCoroutine(TeacherDialog());

        clueUI.GetComponentInChildren<Button>().onClick.AddListener(() =>
        {
            clueUI.gameObject.SetActive(false);
            OnFinish();
        });
    }

    public GameObject tip_kejian;

    IEnumerator TeacherDialog()
    {
        yield return new WaitForSeconds(10);
        //AudioSource.PlayClipAtPoint(clip_ring, transform.position);
        yield return new WaitForSeconds(5);
        //anim.Play("talk1");
        dialog.SetActive(true);
        text.text = "Did you hear about that?";

        yield return new WaitForSeconds(4);
        //anim.Play("talk1");
        text.text = "About May?";

        yield return new WaitForSeconds(4);
        //anim.Play("talk1");
        text.text = "I heard she was\nsuspended from school. ";

        yield return new WaitForSeconds(4);
        //anim.Play("talk2");
        text.text = "Was it because of...";

        yield return new WaitForSeconds(4);
        dialog.SetActive(false);

        clueUI.SetActive(true);




        /*         AudioSource.PlayClipAtPoint(clip_ring, transform.position);
                yield return new WaitForSeconds(5);


                tip_kejian.SetActive(true);
                FindObjectOfType<PlayerMoveEnabler>().SetMoveEnable(true);


                clueUI.SetActive(true);
                audio_kejian.SetActive(true);

                yield return new WaitForSeconds(5);
                tip_kejian.SetActive(false); */
    }
}
