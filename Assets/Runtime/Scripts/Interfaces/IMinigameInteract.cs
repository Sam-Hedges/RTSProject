using UnityEngine;

public interface IMinigameInteract

{
    void Minigame(bool active, GameObject heldItem);
    void GameUI(bool active);
}