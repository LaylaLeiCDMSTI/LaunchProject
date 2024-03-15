using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClueTeacher : Clue
{

    public GameObject dialog;
    public TextMeshProUGUI text;

    private Animator anim;
    public AudioClip clip_ring;

    public GameObject audio_kejian;
    public GameObject teacher;
    public GameObject classmates;
    public GameObject girl1;
    public GameObject girl2;
    public GameObject classend;
    protected override void Start()
    {
        base.Start();

        anim = GetComponent<Animator>();

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
        yield return new WaitForSeconds(5);
        AudioSource.PlayClipAtPoint(clip_ring, transform.position);
        yield return new WaitForSeconds(5);
        anim.Play("talk1");
        dialog.SetActive(true);
        text.text = "Jack";

        yield return new WaitForSeconds(4);
        anim.Play("talk1");
        text.text = "Mary";

        yield return new WaitForSeconds(4);
        anim.Play("talk1");
        text.text = "May";

        yield return new WaitForSeconds(4);
        anim.Play("talk2");
        text.text = "May?";

        yield return new WaitForSeconds(4);
        dialog.SetActive(false);


        clueUI.SetActive(true);
        

        yield return new WaitForSeconds(5);
        AudioSource.PlayClipAtPoint(clip_ring, transform.position);
        yield return new WaitForSeconds(5);

        yield return new WaitForSeconds(5);
        audio_kejian.SetActive(true);
        teacher.SetActive(false);
        classmates.SetActive(false);


        tip_kejian.SetActive(true);
        girl1.SetActive(true);
        girl2.SetActive(true);
        FindObjectOfType<PlayerMoveEnabler>().SetMoveEnable(true);
        yield return new WaitForSeconds(5);
        //FindObjectOfType<PlayerMoveEnabler>().SetMoveEnable(false);
        classend.SetActive(false);
    }
}
                 