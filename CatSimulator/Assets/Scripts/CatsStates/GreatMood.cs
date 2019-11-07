using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatMood : MoodBase
{
    private CatStateController stateController;
    private MoodBase badMood;

    private void Start()
    {
        badMood = GetComponent<BadMood>();
        stateController = GetComponent<CatStateController>();
    }

    public override void Play()
    {
        stateController.UpdateCatReaction("Носится как угорелая.");
    }

    public override void Feed()
    {
        stateController.UpdateCatReaction("Быстро все съедает.");
    }

    public override void Pet()
    {
        stateController.UpdateCatReaction("Мурлычет и виляет хвостом.");
    }

    public override void Kick()
    {
        stateController.UpdateCatReaction("Убагет в другую комнату.");
        stateController.CurrentMood = badMood;
    }
}
