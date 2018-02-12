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
  public Text housingDisplay;
  public Text mineStablityDisplay;

  public Text axeDisplay;
  public Text butcherDisplay;
  public Text bowDisplay;
  public Text skinningDisplay;
  public Text fishingPoleDisplay;

  public Text mineStabilityDisplay;
  public Text pickAxeDisplay;

  public float upgradeCostMultiplier = 1.5F;

  private int housingCostWood = 250;
  private int housingCostStone = 50;

  private int axeCostWood = 50;
  private int axeCostStone = 20;

  private int butcherCostWood = 50;
  private int butcherCostStone = 20;

  private int bowCostTeeth = 30;
  private int bowCostWood = 100;

  private int skinningCostTeeth = 30;
  private int skinningCostStone = 50;

  private int fishingCostWood = 100;
  private int fishingCostStone = 5;

  public int housingLevel = 0;
  public int axeLevel = 0;
  public int butcherLevel = 0;
  public int bowLevel = 0;
  public int skinningLevel = 0;
  public int fishingLevel = 0;
	
	// Update is called once per frame
	void Update ()
  {
		// set displays for all upgrades
	}

}
