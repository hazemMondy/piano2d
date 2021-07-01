using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text texty;
    public  int scorep= 0;
    //   public int scorev;
    //int score
    public void scoret()
    {
       // texty.text = scorep.ToString("0");
        scorep++;
        texty.text = scorep.ToString("0");
    }

}
