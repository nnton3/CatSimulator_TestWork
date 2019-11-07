using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadMood : MoodBase
{
    private CatStateController stateController;
    private MoodBase goodMood;

    private void Start()
    {
        goodMood = GetComponent<GoodMood>();
        stateController = GetComponent<CatStateController>();
    }

    public override void Play()
    {
        stateController.UpdateCatReaction
            ("Сидит на месте.");
    }

    public override void Feed()
    {
        stateController.UpdateCatReaction("Все съедает, но если в это время подойти - поцарапает.");
        stateController.CurrentMood = goodMood;
    }

    public override void Pet()
    {
        stateController.UpdateCatReaction("Царапает.");
    }

    public override void Kick()
    {
        stateController.UpdateCatReaction("Прыгает и кусает за правое ухо.");
    }
}
