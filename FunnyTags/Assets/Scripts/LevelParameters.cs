using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]public class LevelParameters 
{
    [SerializeField] private int m_fieldSize;
    [SerializeField] private int m_freeSpace;
    [SerializeField] private int m_TokenTypes;
    [SerializeField] private int m_turns;
   


    public int FieldSize { get { return m_fieldSize; } }
    public int FreeSpace { get { return m_freeSpace; } }
    public int TokenTypes { get { return m_TokenTypes; } }
    public int Turns 
    { get 
        { 
            return m_turns; 
        }
        set
        {
            m_turns = value;
            Hud.Instance.UpdateTurnsValue(m_turns);
        }
    }

    public LevelParameters(int currentLevel)
    {
        int fieldIncreaseStep = currentLevel / 4;
        float subStep = (currentLevel / 4f) - fieldIncreaseStep;
        m_fieldSize = 3 + fieldIncreaseStep;
        m_freeSpace = (int)(m_fieldSize * (1f - subStep));

        if(m_freeSpace<1)
        {
            m_freeSpace=1;
        }

        m_TokenTypes = 2 + (currentLevel / 3);

        if(m_TokenTypes>10)
        {
            m_TokenTypes = 10;
        }

        m_turns = (((m_fieldSize * m_fieldSize / 2) - m_freeSpace) * m_TokenTypes) + m_fieldSize;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
