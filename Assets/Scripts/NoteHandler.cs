﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHandler : MonoBehaviour
{

    //Note Positions
    //Notes over and under main lines
    //flat and sharp notes
    //Generate random Note
    //Generate Tab for note depending on hand position
    //Set Sound

    //public float not_pos_c;
    //public float not_pos_d;
    public float not_pos_e = -325f;
    public float not_pos_f = -285f;
    public float not_pos_g = -245f;
    public float not_pos_a = -209f;
    public float not_pos_b = -169f;
    public float not_pos_c1 = -134f;
    public float not_pos_d1 = -97f;
    public float not_pos_e1 = -52f;
    public float not_pos_f1 = -15f;
    public float not_pos_g1 = 20f;
    public float not_pos_a1 = 57f;
    public float not_pos_b1 = -68f;
    public float not_pos_c2 = -42f;
    public float not_pos_d2 = -3f;
    public float not_pos_e2 = 38f;
    public float not_pos_f2 = 73f;
    public float not_pos_g2 = 112f;
    public float not_pos_a2 = 145f;
    public float not_pos_b2 = 185f;
    public float not_pos_c3 = 219f;
    public float not_pos_d3 = 260f;
    public float not_pos_e3 = 294f;
    public float not_pos_f3 = 338f;
    public float not_pos_g3 = 378f;

    private List<BaseNote> noteList;

    private int[] string_base_all = { -5, -4, -99, -3, -99, -2, -99, -1, 0, -99};

    private int[] string_base_6 = { -5, -4, -99, -3 ,-99, -2, -99, -1, 0, -99, 1, -99, 2, 3, -99, 4, -99, 5};
    private int[] string_base_5 = { -2, -99, -1, 0, -99, 1, -99, 2, 3, -99, 4, -99, 5, -99, 6, 7, -99, 8};
    private int[] string_base_4 = { 1, -99, 2, 3, -99, 4, -99, 5, -99, 6, 7, -99, 8, -99, 9, 10, -99, 11};
    private int[] string_base_3 = { 4, -99, 5, 5, 6, 7, -99, 8, -99, 9, 10, -99, 11, -99, 12, -99, 13, 14};
    private int[] string_base_2 = { 6, 7, -99, 8, -99, 9, 10, -99, 11, -99, 12, -99, 13, 14, -99, 15, -99, 16};
    private int[] string_base_1 = { 9, 10, -99, 11, -99, 12, -99, 13, 14, -99, 15, -99, 16, 17, -99, 18};

    void Awake()
    {
        noteList = new List<BaseNote>
        {
            new BaseNote(-5, "e", not_pos_e, 3),
            new BaseNote(-4, "f", not_pos_f, 3),
            new BaseNote(-3, "g", not_pos_g, 2),
            new BaseNote(-2, "a", not_pos_a, 2),
            new BaseNote(-1, "b", not_pos_b, 1),
            new BaseNote(0, "c1", not_pos_c1, 1),
            new BaseNote(1, "d1", not_pos_d1, 0),
            new BaseNote(2, "e1", not_pos_e1, 0),
            new BaseNote(3, "f1", not_pos_f1, 0),
            new BaseNote(4, "g1", not_pos_g1, 0),
            new BaseNote(5, "a1", not_pos_a1, 0),
            new BaseNote(6, "b1", not_pos_b1, 0),
            new BaseNote(7, "c2", not_pos_c2, 0),
            new BaseNote(8, "d2", not_pos_d2, 0),
            new BaseNote(9, "e2", not_pos_e2, 0),
            new BaseNote(10, "f2", not_pos_f2, 0),
            new BaseNote(11, "g2", not_pos_g2, 0),
            new BaseNote(12, "a2", not_pos_a2, 1),
            new BaseNote(13, "b2", not_pos_b2, 1),
            new BaseNote(14, "c3", not_pos_c3, 2),
            new BaseNote(15, "d3", not_pos_d3, 2),
            new BaseNote(16, "e3", not_pos_e3, 3),
            new BaseNote(17, "f3", not_pos_f3, 3),
            new BaseNote(18, "g3", not_pos_g3, 4)
        };

    }

    public int tabTranslator(int noteValue, int stringNr)
    {

        int pos = -1;

        if(stringNr == 6)
        {
            pos = Array.IndexOf(string_base_6, noteValue);
        }
        else if (stringNr == 5)
        {
            pos = Array.IndexOf(string_base_5, noteValue);
        }
        else if (stringNr == 4)
        {
            pos = Array.IndexOf(string_base_4, noteValue);
        }
        else if (stringNr == 3)
        {
            pos = Array.IndexOf(string_base_3, noteValue);
        }
        else if (stringNr == 2)
        {
            pos = Array.IndexOf(string_base_2, noteValue);
        }
        else if (stringNr == 1)
        {
            pos = Array.IndexOf(string_base_1, noteValue);
        }

        return pos;
    }

    public List<BaseNote> NoteList { get { return noteList; } }
}
