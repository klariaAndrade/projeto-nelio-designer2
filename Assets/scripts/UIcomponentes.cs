using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class UIcomponentes
{
    [Serializable]

    public class Hud{
       
       [Header("Text")]
        
        public Text txtCoinCount;

        [Header ("Other")]

        public GameObject panelHud;

    }

        [Serializable]

    public class LevelCompletePanel{
       
       [Header("Text")]
        
        public Text txtScore;

        [Header ("Other")]

        public GameObject Panel;

    }
       [Serializable]

    public class GameOverPanel{
       
       [Header("Text")]
        
        public Text txtScore;

        [Header ("Other")]

        public GameObject Panel;

    }

    public Hud hud;
    public LevelCompletePanel LCPanel;
    public GameOverPanel GOPanel;


}
