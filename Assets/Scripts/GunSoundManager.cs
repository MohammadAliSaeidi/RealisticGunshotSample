using UnityEngine;

namespace RealisticGunshotSample
{
	public class GunSoundManager : MonoBehaviour
	{
		[SerializeField] private GunSound[] gunSounds;

		private GunFiringMode _gunFiringMode;

		internal void PlayGunshotSounds()
		{
			for (int i = 0; i < gunSounds.Length; i++)
			{
				gunSounds[i].PlayGunshotSound(_gunFiringMode);
			}
		}

		internal void StopGunshotSounds()
		{
			for (int i = 0; i < gunSounds.Length; i++)
			{
				gunSounds[i].StopGunshotSound(_gunFiringMode);
			}
		}

		internal void SetGunFiringMode(GunFiringMode gunFiringMode)
		{
			_gunFiringMode = gunFiringMode;
		}
	}
}
