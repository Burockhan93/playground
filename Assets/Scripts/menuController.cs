using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
    public RectTransform MainMenu;
    public RectTransform Opt;
    public RectTransform Lead;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OptionPressed()
    {
        MainMenu.DOJumpAnchorPos(new Vector2(1500, 0), 50,10,3,false);
        Opt.DOAnchorPos(new Vector2(0, 0), 1);
    }
    public void LeaderPressed()
    {
        MainMenu.DOAnchorPos(new Vector2(800, 0), 1);
        Lead.DOAnchorPos(new Vector2(0, 0), 1);
    }

    public void BackPressed()
    {
        MainMenu.DOAnchorPos(new Vector2(0, 0), 1);
        Opt.DOAnchorPos(new Vector2(800, 0), 1);
        Lead.DOAnchorPos(new Vector2(800, 0), 1);
    }
}
