using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatStateController : MonoBehaviour
{
    public MoodBase CurrentMood;
    private string catReaction = "";
    public string CatReaction => catReaction;

    private MoodBase goodMood;

    [HideInInspector] public UnityEvent ReactionUpdated;

    private void Start()
    {
        goodMood = GetComponent<GoodMood>();

        ResetMood();
    }

    public void Play()
    {
        CurrentMood.Play();
    }

    public void Feed()
    {
        CurrentMood.Feed();
    }

    public void Pet()
    {
        CurrentMood.Pet();
    }

    public void Kick()
    {
        CurrentMood.Kick();
    }

    public void ResetMood()
    {
        CurrentMood = goodMood;
    }

    public void UpdateCatReaction(string newCatReaction)
    {
        catReaction = newCatReaction;
        ReactionUpdated.Invoke();
    }

    private void OnDisable()
    {
        ReactionUpdated.RemoveAllListeners();
    }
}
