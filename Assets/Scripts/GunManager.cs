using UnityEngine;

namespace RealisticGunshotSample
{
	public class GunManager : MonoBehaviour
	{
		[SerializeField] private GunSoundManager gunSoundManager;

		private GunFiringMode _gunFiringMode;
		private int _firingModeIndex;
		private UIManager uIManager;
		private bool _isFiring;

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

			if (Input.GetKeyDown(KeyCode.Mouse0))
			{
				_isFiring = true;
			}

			if (!Input.GetKey(KeyCode.Mouse0))
			{
				_isFiring = false;
			}

			HandleFiring();
		}

		private void HandleFiring()
		{
			switch (_gunFiringMode)
			{
				case GunFiringMode.Single:
					{
						if (_isFiring)
						{
							if (gunSoundManager)
							{
								gunSoundManager.PlayGunshotSounds(_gunFiringMode);
							}

							_isFiring = false;
						}

						break;
					}
			}
		}

		private void SwitchFiringMode()
		{
			_firingModeIndex++;
			_gunFiringMode = (GunFiringMode)_firingModeIndex;

			uIManager.ShowFiringMode();
		}
	}
}
