using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNote
{
    private int _noteValue;
    private string _noteName;
    private float _notePos;
    private int _helpLine;

    public BaseNote(int noteValue, string noteName, float notePos, int helpline)
    {
        this._noteValue = noteValue;
        this._noteName = noteName;
        this._notePos = notePos;
        this._helpLine = helpline;
    }

    public int NoteValue { get { return _noteValue; } }

    public string NoteName { get { return _noteName; } }

    public float NotePos { get { return _notePos; } }

    public int HelpLine { get { return _helpLine; } }

}
