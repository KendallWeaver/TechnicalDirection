// This script was made by following a "QUESTING SYTEM" tutorial by Brackeys
// This is was a default "player" script that he made. 
using System.Collections;
using System.Collections.Generic;
using Unity Engine;

public class PlayerQuestTut : MonoBehaviour {

  public int health = 5;
  public int experience = 40;
  public int gold = 1000;
  
  //This was added later; it's a way to make sure a quest can be given to a player. 
  public Quest quest;
  //Go back to the QuestGiver script and look at AcceptQuest()
  
  // This next function would occure whenever he pressed the "Fight" button on the UI.
  public void GoBattle()
  {
    heath -= 1;
    experience +=2;
    gold += 5;
    
    //The following will 
    if (quest.isActive)
    {
      quest.goal.EnemyKilled(); // This refers to the function made in the 'QuestGoal' script
      if (quest.goal.IsReached())
      {
        experience += quest.experienceReward;
        gold += quest.goldReward;
        quest.Complete(); // This refers to the "Complete" function made in the 'Quest' script
      }
    }
  }

}