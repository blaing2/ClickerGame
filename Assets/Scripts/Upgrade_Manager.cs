using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* TODO:
 * Update upgrade level text
 * when upgrade level is at max block out the text
 * when upgrade buttons are pressed update info to variables
 * set upgrade cost
 */

public class Upgrade_Manager : MonoBehaviour
{
  public GameObject resourceManager;

  public Button housingButton;
  public Button mineStabilityButton;
  public Button axesButton;
  public Button pickaxesButton;
  public Button butcherKnifeButton;
  public Button bowButton;
  public Button skinningKnifeButton;
  public Button fishingPoleButton;

  public Text housingDisplay;
  public Text mineStablityDisplay;
  public Text axeDisplay;
  public Text pickaxeDisplay;
  public Text butcherDisplay;
  public Text bowDisplay;
  public Text skinningDisplay;
  public Text fishingPoleDisplay;

  public Text housingCostDisplay;
  public Text mineStabilityCostDisplay;
  public Text axeCostDisplay;
  public Text pickaseCostDisplay;
  public Text butcherCostDisplay;
  public Text bowCostDisplay;
  public Text skinningKnifeCostDisplay;
  public Text fishingPoleCostDisplay;

  public float upgradeCostMultiplier = 1.5F;
  
  private int housingCostWood = 250;
  private int housingCostStone = 50;

  private int mineStabilityCostStone = 300;
  private int mineStabilityCostWood = 150;

  private int axeCostWood = 50;
  private int axeCostStone = 20;

  private int pickaxeCostWood = 50;
  private int pickaxeCostStone = 20;

  private int butcherCostWood = 50;
  private int butcherCostStone = 20;

  private int bowCostTeeth = 30;
  private int bowCostWood = 100;

  private int skinningCostTeeth = 30;
  private int skinningCostStone = 50;

  private int fishingCostWood = 100;
  private int fishingCostStone = 5;

  public int housingLevel = 0;
  public int mineStablityLevel = 0;
  public int axeLevel = 0;
  public int pickaxeLevel = 0;
  public int butcherLevel = 0;
  public int bowLevel = 0;
  public int skinningLevel = 0;
  public int fishingLevel = 0;
	
	// Update is called once per frame
	void Update ()
  {
		// set displays for all levels
    housingDisplay.text = "Upgrade Housing [" + housingLevel + "]";
    mineStablityDisplay.text = "Upgrade Mine Stablity [" + mineStablityLevel + "]";
    axeDisplay.text = "Upgrade Axes [" + axeLevel + "]";
    pickaxeDisplay.text = "Upgrade Pickaxe [" + pickaxeLevel + "]";
    butcherDisplay.text = "Upgrade Butcher Knife [" + butcherLevel + "]";
    bowDisplay.text = "Upgrade Bow [" + bowLevel + "]";
    skinningDisplay.text = "Upgrade Skinning Knife [" + skinningLevel + "]";
    fishingPoleDisplay.text = "Upgrade Fishing Pole [" + fishingLevel + "]";

    // set display for all upgrade cost
    housingCostDisplay.text = "Wood: " + housingCostWood + " Stone: " + housingCostStone;
    housingCostDisplay.text = "Wood: " + housingCostWood + " Stone: " + housingCostStone;



  }

}
