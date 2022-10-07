using UnityEngine;

namespace RealisticGunshotSample
{
	public class GunSoundManager : MonoBehaviour
	{
		[SerializeField] private GunSound[] gunSounds;

		private GunFiringMode _gunFiringMode;

		private void Start()
		{
			gunSounds = GetComponentsInChildren<GunSound>();
		}

		internal void PlayGunshotSounds(GunFiringMode gunFiringMode)
		{
			for (int i = 0; i < gunSounds.Length; i++)
			{
				gunSounds[i].PlayGunshotSound(gunFiringMode);
			}
		}

		internal void StopGunshotSounds()
		{
			for (int i = 0; i < gunSounds.Length; i++)
			{
				gunSounds[i].StopGunshotSound(_gunFiringMode);
			}
		}
	}
}
