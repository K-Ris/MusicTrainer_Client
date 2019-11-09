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

        int note = Random.Range(1, 11);
        float pos = NoteList[note].NotePos;

        Debug.Log("NoteValue: " + NoteList[note].NoteValue + " Note: " + NoteList[note].NoteName);

        if(NoteList[note].NoteValue > 5)
        {
            noteUp.SetActive(false);
            noteDown.SetActive(true);
        }
        else
        {
            noteUp.SetActive(true);
            noteDown.SetActive(false);
        }

        noteRect.localPosition = new Vector3(0, pos, 0);

        tabNote1.SetActive(false);
        tabNote2.SetActive(false);
        tabNote3.SetActive(false);
        tabNote4.SetActive(false);
        tabNote5.SetActive(false);
        tabNote6.SetActive(false);

        

        Debug.Log("String 6 Pos: " + nh.tabTranslator(NoteList[note].NoteValue, 6));
        Debug.Log("String 5 Pos: " + nh.tabTranslator(NoteList[note].NoteValue, 5));
        Debug.Log("String 4 Pos: " + nh.tabTranslator(NoteList[note].NoteValue, 4));
        Debug.Log("String 3 Pos: " + nh.tabTranslator(NoteList[note].NoteValue, 3));
        Debug.Log("String 2 Pos: " + nh.tabTranslator(NoteList[note].NoteValue, 2));
        Debug.Log("String 1 Pos: " + nh.tabTranslator(NoteList[note].NoteValue, 1));

        int string6 = nh.tabTranslator(NoteList[note].NoteValue, 6);
        if(string6 != -1)
        {
            tabNote6.transform.GetChild(0).GetComponent<Text>().text = string6.ToString();
            tabNote6.SetActive(true);

        }
        int string5 = nh.tabTranslator(NoteList[note].NoteValue, 5);
        if (string5 != -1)
        {
            tabNote5.transform.GetChild(0).GetComponent<Text>().text = string5.ToString();
            tabNote5.SetActive(true);

        }
        int string4 = nh.tabTranslator(NoteList[note].NoteValue, 4);
        if (string4 != -1)
        {
            tabNote4.transform.GetChild(0).GetComponent<Text>().text = string4.ToString();
            tabNote4.SetActive(true);

        }
        int string3 = nh.tabTranslator(NoteList[note].NoteValue, 3);
        if (string3 != -1)
        {
            tabNote3.transform.GetChild(0).GetComponent<Text>().text = string3.ToString();
            tabNote3.SetActive(true);

        }
        int string2 = nh.tabTranslator(NoteList[note].NoteValue, 2);
        if (string2 != -1)
        {
            tabNote2.transform.GetChild(0).GetComponent<Text>().text = string2.ToString();
            tabNote2.SetActive(true);

        }
        int string1 = nh.tabTranslator(NoteList[note].NoteValue, 1);
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
