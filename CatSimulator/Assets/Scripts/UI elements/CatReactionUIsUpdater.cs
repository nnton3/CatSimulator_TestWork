using UnityEngine;
using UnityEngine.UI;

public class CatReactionUIsUpdater : MonoBehaviour
{
    private Text reactionText;
    private CatStateController catController;

    private void Start()
    {
        reactionText = GetComponent<Text>();
        catController = FindObjectOfType<CatStateController>();

        catController.ReactionUpdated.AddListener(UpdateReactionText);
    }

    public void UpdateReactionText()
    {
        reactionText.text = catController.CatReaction;
    }
}
