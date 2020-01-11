using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteUIHandler : MonoBehaviour
{
    NoteHandler nh;

    public RectTransform noteRect;
    public GameObject noteUp;
    public GameObject noteDown;

    public Text noteText;

    public GameObject helperLineLowC;
    public GameObject helperLineLowA;
    public GameObject helperLineLowF;

    public GameObject helperLineHighA;
    public GameObject helperLineHighC;
    public GameObject helperLineHighE;
    public GameObject helperLineHighG;


    public GameObject tabNote1;
    public GameObject tabNote2;
    public GameObject tabNote3;
    public GameObject tabNote4;
    public GameObject tabNote5;
    public GameObject tabNote6;

    private List<BaseNote> NoteList;


    // Start is called before the first frame update
    void Start()
    {
        nh = this.GetComponent<NoteHandler>();

        NoteList = nh.NoteList;

        createNote();
        
    }

    public void createNote()
    {
        int noteNum = Random.Range(1, NoteList.Count - 1);

        BaseNote currentNote = NoteList[noteNum];

        noteText.text = currentNote.NoteName;

        float pos = currentNote.NotePos;

        helperLineLowC.SetActive(false);
        helperLineLowA.SetActive(false);
        helperLineLowF.SetActive(false);


        helperLineHighA.SetActive(false);
        helperLineHighC.SetActive(false);
        helperLineHighE.SetActive(false);
        helperLineHighG.SetActive(false);

        Debug.Log("NoteValue: " + currentNote.NoteValue + " Note: " + currentNote.NoteName);

        if (currentNote.NoteValue > 5)
        {
            noteUp.SetActive(false);
            noteDown.SetActive(true);
        }
        else
        {
            noteUp.SetActive(true);
            noteDown.SetActive(false);
        }

        if (currentNote.NoteValue > 11)
        {
            if (currentNote.HelpLine == 1)
            {
                helperLineHighA.SetActive(true);
            }
            else if (currentNote.HelpLine == 2)
            {
                helperLineHighA.SetActive(true);
                helperLineHighC.SetActive(true);
            }
            else if (currentNote.HelpLine == 3)
            {
                helperLineHighA.SetActive(true);
                helperLineHighC.SetActive(true);
                helperLineHighE.SetActive(true);
            }
            else if (currentNote.HelpLine == 4)
            {
                helperLineHighA.SetActive(true);
                helperLineHighC.SetActive(true);
                helperLineHighE.SetActive(true);
                helperLineHighG.SetActive(true);
            }
        }
        else if (currentNote.NoteValue < 1)
        {
            if (currentNote.HelpLine == 1)
            {
                helperLineLowC.SetActive(true);
            }
            else if (currentNote.HelpLine == 2)
            {
                helperLineLowC.SetActive(true);
                helperLineLowA.SetActive(true);
            }
            else if (currentNote.HelpLine == 3)
            {
                helperLineLowC.SetActive(true);
                helperLineLowA.SetActive(true);
                helperLineLowF.SetActive(true);
            }
        }

        noteRect.localPosition = new Vector3(0, pos, 0);

        tabNote1.SetActive(false);
        tabNote2.SetActive(false);
        tabNote3.SetActive(false);
        tabNote4.SetActive(false);
        tabNote5.SetActive(false);
        tabNote6.SetActive(false);



        Debug.Log("String 6 Pos: " + nh.tabTranslator(currentNote.NoteValue, 6));
        Debug.Log("String 5 Pos: " + nh.tabTranslator(currentNote.NoteValue, 5));
        Debug.Log("String 4 Pos: " + nh.tabTranslator(currentNote.NoteValue, 4));
        Debug.Log("String 3 Pos: " + nh.tabTranslator(currentNote.NoteValue, 3));
        Debug.Log("String 2 Pos: " + nh.tabTranslator(currentNote.NoteValue, 2));
        Debug.Log("String 1 Pos: " + nh.tabTranslator(currentNote.NoteValue, 1));

        int string6 = nh.tabTranslator(currentNote.NoteValue, 6);
        if (string6 != -1)
        {
            tabNote6.transform.GetChild(0).GetComponent<Text>().text = string6.ToString();
            tabNote6.SetActive(true);

        }
        int string5 = nh.tabTranslator(currentNote.NoteValue, 5);
        if (string5 != -1)
        {
            tabNote5.transform.GetChild(0).GetComponent<Text>().text = string5.ToString();
            tabNote5.SetActive(true);

        }
        int string4 = nh.tabTranslator(currentNote.NoteValue, 4);
        if (string4 != -1)
        {
            tabNote4.transform.GetChild(0).GetComponent<Text>().text = string4.ToString();
            tabNote4.SetActive(true);

        }
        int string3 = nh.tabTranslator(currentNote.NoteValue, 3);
        if (string3 != -1)
        {
            tabNote3.transform.GetChild(0).GetComponent<Text>().text = string3.ToString();
            tabNote3.SetActive(true);

        }
        int string2 = nh.tabTranslator(currentNote.NoteValue, 2);
        if (string2 != -1)
        {
            tabNote2.transform.GetChild(0).GetComponent<Text>().text = string2.ToString();
            tabNote2.SetActive(true);

        }
        int string1 = nh.tabTranslator(currentNote.NoteValue, 1);
        if (string1 != -1)
        {
            tabNote1.transform.GetChild(0).GetComponent<Text>().text = string1.ToString();
            tabNote1.SetActive(true);

        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
