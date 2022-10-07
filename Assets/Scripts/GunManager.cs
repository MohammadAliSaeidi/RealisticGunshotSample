using UnityEngine;

namespace RealisticGunshotSample
{
	public class GunManager : MonoBehaviour
	{
		private GunFiringMode _gunFiringMode;
		private int _firingModeIndex;

		private void Start()
		{
			_gunFiringMode = GunFiringMode.Single;
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.B))
			{
				SwitchFiringMode();
			}
		}

		private void SwitchFiringMode()
		{
			_firingModeIndex++;
			_gunFiringMode = (GunFiringMode)_firingModeIndex;
			UIManager.ShowFiringMode();
		}
	}
}
