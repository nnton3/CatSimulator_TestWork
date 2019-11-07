using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodMood : MoodBase
{
    private CatStateController stateController;
    private MoodBase greatMood;
    private MoodBase badMood;

    private void Start()
    {
        greatMood = GetComponent<GreatMood>();
        badMood = GetComponent<BadMood>();
        stateController = GetComponent<CatStateController>();
    }

    public override void Play()
    {
        stateController.UpdateCatReaction("Медленно бегает за мячиком.");
        stateController.CurrentMood = greatMood;
    }

    public override void Feed()
    {
        stateController.UpdateCatReaction("Быстро все съедает.");
        stateController.CurrentMood = greatMood;
    }

    public override void Pet()
    {
        stateController.UpdateCatReaction("Мурлычет.");
        stateController.CurrentMood = greatMood;
    }

    public override void Kick()
    {
        stateController.UpdateCatReaction("Убегает на ковер и писает.");
        stateController.CurrentMood = badMood;
    }
}
