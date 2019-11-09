using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNote
{
    private int _noteValue;
    private string _noteName;
    private float _notePos;

    public BaseNote(int noteValue, string noteName, float notePos)
    {
        this._noteValue = noteValue;
        this._noteName = noteName;
        this._notePos = notePos;
    }

    public int NoteValue { get { return _noteValue; } }

    public string NoteName { get { return _noteName; } }

    public float NotePos { get { return _notePos; } }

}
