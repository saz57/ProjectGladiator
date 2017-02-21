using UnityEngine;
using System.Collections;

public struct Stats {

	public int maxStats;
	private int streigth,
	agility,
	endurance,
	vitality;
	public void getStreigth(int _streigth)
	{
		if (_streigth + agility + endurance + vitality < maxStats) {
			streigth = _streigth;
		}
	}
	public void getAgility(int _agility)
	{
		if (streigth + _agility + endurance + vitality < maxStats) {
			agility = _agility;
		}
	}
	public void getEndurance(int _endurance)
	{
		if (streigth + agility + _endurance + vitality < maxStats) {
			endurance = _endurance;
		}
	}
	public void getVitality(int _vitality)
	{
		if (streigth + agility + endurance + _vitality < maxStats) {
			vitality = _vitality;
		}
	}

}
