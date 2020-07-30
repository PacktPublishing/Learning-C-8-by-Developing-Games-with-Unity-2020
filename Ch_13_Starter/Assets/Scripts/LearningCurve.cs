using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Integer variables
    private int currentAge = 30;
    public int addedAge = 1;
    public int currentGold = 32;
    public int playerLives = 3;
    public int diceRoll = 7;

    // Float variables
    public float pi = 3.14f;

    // String variables
    public string firstName = "Harrison";
    public string rareItem = "Relic Stone";
    public string characterAction = "Attack";

    // Boolean variables
    public bool isAuthor = true;
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;

    // Unity components
    private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();

        Debug.Log($"A string can have variables like {firstName} inserted directly!");

        //Debug.Log(firstName * pi);

        // Testing methods
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        Debug.LogFormat("Next skill at level {0}", nextSkillLevel);

        // Testing conditinal statements
        PocketChange();
        OpenTreasureChamber();
        SwitchingAround();

        // Working with lists
        List<string> questPartyMembers = new List<string>() 
        { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight" };

        questPartyMembers.Add("Craven the Necromancer");
        questPartyMembers.Insert(1, "Tanis the Thief");
        //questPartyMembers.RemoveAt(0);
        questPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        // Working with dictionaries
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5},
            { "Antidote", 7},
            { "Aspirin", 1}
        };

        itemInventory["Potion"] = 10;
        itemInventory.Add("Throwing Knife", 3);
        itemInventory["Bandages"] = 5;

        if(itemInventory.ContainsKey("Aspirin"))
        {
            itemInventory["Aspirin"] = 3;
        }

        itemInventory.Remove("Antidote");
        Debug.LogFormat("Items: {0}", itemInventory.Count);

        // Working with loops
        for (int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);

            if(questPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }

        foreach (string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }

        foreach (KeyValuePair<string, int> kvp in itemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }

        while(playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }

        Debug.Log("Player KO'd...");

        // Creating class instances
        Character hero = new Character();
        //Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        
        // Reference types
        Character hero2 = hero;
        hero2.name = "Sir Krane the Brave";
        hero2.PrintStatsInfo();
        //hero2.Reset();
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        // Creating structs
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        // Inheritance
        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        // Unity components
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    /// <summary>
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }

    // Generates and returns a character with a name and level
    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level + 5;
    }

    // Uses branching if-else statements
    public void PocketChange()
    {
        if (currentGold > 50)
        {
            Debug.Log("You're rolling in it - beware of pickpockets.");
        }
        else if (currentGold < 15)
        {
            Debug.Log("Not much there to steal.");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }
    }

    // Uses branching and nested if-else statements
    public void OpenTreasureChamber()
    {
        if(pureOfHeart && rareItem == "Relic Stone")
        {
            if(!hasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }

    // Uses switch statements
    public void SwitchingAround()
    {
        switch (characterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }

        // Uses fall-through cases
        switch (diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }
    }
}






