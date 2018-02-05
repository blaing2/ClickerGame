using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resource_Manager : MonoBehaviour {
  // link to other mangers
  public GameObject workerManager;

  // link to display boxes
  public Text woodDisplay;
  public Text stoneDisplay;

  public Text boneDisplay;
  public Text teethDisplay;
  public Text furDisplay;
  public Text meatDisplay;
  public Text fishDisplay;
  public Text herbDispaly;

  public Text ironOreDisplay;
  public Text ironDispaly;
  public Text coalDisplay;
  public Text steelDisplay;

  public Text leatherDisplay;

  public Text mBoneDisplay;
  public Text mTeethDisplay;
  public Text mPeltDisplay;
  public Text mScalesDisplay;
  public Text mMeatDisplay;

  // set up variables
  public int wood = 0;
  public int stone = 0;

  public int bone = 0;
  public int teeth = 0;
  public int fur = 0;
  public int meat = 0;
  public int fish = 0;
  public int herb = 0;

  public int ironOre = 0;
  public int iron = 0;
  public int coal = 0;
  public int steel = 0;

  public int leather = 0;

  public int mBone = 0;
  public int mTeeth = 0;
  public int mPelt = 0;
  public int mMeat = 0;
  public int mScale = 0;

  // set cool downs
  private float autoCooldownTimer = 0.0F;
  private int autoClickTimeInterval = 10;

  // set click increase
  public int woodClickIncrease = 1;
  public int stoneClickIncrease = 1;

  public int boneClickIncrease = 1;
  public int teethClickIncrease = 1;
  public int furClickIncrease = 1;
  public int meatClickIncrease = 1;
  public int fishClickIncrease = 1;
  public int herClickIncrease = 1;

  public int ironOreClickIncrease = 1;
  public int coalClickIncrease = 1;

  public int mBoneClickIncrease = 1;
  public int mTeethClickIncrease = 1;
  public int mPeltClickIncrease = 1;
  public int mMeatClickIncrease = 1;
  public int mScaleClickIncrease = 1;

  // temp set click upgrade --> move this to upgradeManager
  public int woodClickUpgradeMultiplier = 1;
  public int stoneClickUpgradeMultiplier = 1;

  public int boneClickUpgradeMultiplier = 1;
  public int teethClickUpgradeMultiplier = 1;
  public int furClickUpgradeMultiplier = 1;
  public int meatClickUpgradeMultiplier = 1;
  public int fishClickUpgradeMultiplier = 1;
  public int herbClickUpgradeMultiplier = 1;

  public int ironOreClickUpgradeMultiplier = 1;
  public int coalClickUpgradeMultiplier = 1;

  public int mBoneClickUpgradeMultiplier = 1;
  public int mTeethClickUpgradeMultiplier = 1;
  public int mPeltClickUpgradeMultiplier = 1;
  public int mMeatClickUpgradeMultiplier = 1;
  public int mScaleClickUpgradeMultiplier = 1;
	
	// Update is called once per frame
	void Update ()
  {

    // set displays for all of the 
    woodDisplay.text = "Wood: " + wood;
    stoneDisplay.text = "Stone: " + stone;

    boneDisplay.text = "Bone: " + bone;
    teethDisplay.text = "Teeth: " + teeth;
    furDisplay.text = "Fur: " + fur;
    meatDisplay.text = "Meat: " + meat;
    fishDisplay.text = "Fish: " + fish;
    herbDispaly.text = "Herb: " + herb;

    ironOreDisplay.text = "Iron Ore: " + ironOre;
    ironDispaly.text = "Iron: " + iron;
    coalDisplay.text = "Coal: " + coal;
    steelDisplay.text = "Steel: " + steel;

    leatherDisplay.text = "Leather: " + leather;
    
    mBoneDisplay.text = "Monster Bone: " + mBone;
    mTeethDisplay.text = "Monster Teeth: " + mTeeth;
    mPeltDisplay.text = "Monster Pelt: " + mPelt;
    mMeatDisplay.text = "Monster Meat: " + mMeat;
    mScalesDisplay.text = "Monster Scales: " + mScale;

    // set up call to other managers
    Worker_Manager workerManagerScript = workerManager.GetComponent<Worker_Manager>();
     
    // run auto click ever ten seconds
    if (autoCooldownTimer <= Time.time)
    {
      // set new timer to current time + the auto time - reduction time while keeping it in between 0 and 10
      autoCooldownTimer = Time.time + autoClickTimeInterval;

      // add (click increase * click upgrade) * number of workers to each resource variable
      wood += (woodClickIncrease * woodClickUpgradeMultiplier) * (workerManagerScript.workersWood);
      stone += (stoneClickIncrease * stoneClickUpgradeMultiplier) * (workerManagerScript.workersStone);

      bone += (boneClickIncrease * boneClickUpgradeMultiplier) * (workerManagerScript.workersRegularHunt);
      teeth += (teethClickIncrease * boneClickUpgradeMultiplier) * (workerManagerScript.workersRegularHunt);
      fur += (furClickIncrease * furClickUpgradeMultiplier) * (workerManagerScript.workersRegularHunt);
      meat += (meatClickIncrease * meatClickUpgradeMultiplier) * (workerManagerScript.workersRegularHunt);
      fish += (fishClickIncrease * fishClickUpgradeMultiplier) * (workerManagerScript.workersFisher);
      herb += (herClickIncrease * herbClickUpgradeMultiplier) * (workerManagerScript.workersHerb);

      ironOre += (ironOreClickIncrease * ironOreClickUpgradeMultiplier) * (workerManagerScript.workersMine);
      coal += (coalClickIncrease * coalClickUpgradeMultiplier) * (workerManagerScript.workersMine);


      mBone += (mBoneClickIncrease * mBoneClickUpgradeMultiplier) * (workerManagerScript.workersMonsterHunt);
      mTeeth += (mTeethClickIncrease * mBoneClickUpgradeMultiplier) * (workerManagerScript.workersMonsterHunt);
      mPelt += (mPeltClickIncrease * mPeltClickUpgradeMultiplier) * (workerManagerScript.workersMonsterHunt);
      mMeat += (mMeatClickIncrease * mMeatClickUpgradeMultiplier) * (workerManagerScript.workersMonsterHunt);
      mScale += (mScaleClickIncrease * mScaleClickUpgradeMultiplier) * (workerManagerScript.workersMonsterHunt);

    }

	} // end UPDATE

} // end CLASS
