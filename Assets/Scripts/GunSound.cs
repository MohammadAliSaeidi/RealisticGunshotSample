using UnityEngine;

namespace RealisticGunshotSample
{
	[RequireComponent(typeof(AudioSource))]
	public class GunSound : MonoBehaviour
	{
		[SerializeField] private AudioClip[] SingleShotSounds;
		[SerializeField] private AudioClip AutoFiringSound;

		private AudioSource _audioSource;

		private void Awake()
		{
			_audioSource = GetComponent<AudioSource>();
		}

		internal void PlayGunshotSound(GunFiringMode gunFiringMode)
		{
			switch (gunFiringMode)
			{
				case GunFiringMode.Single:
					{
						int rndIndex = SingleShotSounds.Length > 1 ? UnityEngine.Random.Range(0, SingleShotSounds.Length) : 0;

						_audioSource.clip = SingleShotSounds[rndIndex];
						_audioSource.Play();

						break;
					}

				case GunFiringMode.Auto:
					{
						_audioSource.clip = AutoFiringSound;
						_audioSource.Play();

						break;
					}
			}
		}

		internal void StopGunshotSound(GunFiringMode gunFiringMode)
		{
			if (gunFiringMode == GunFiringMode.Auto)
			{
				_audioSource.Stop();
			}
		}
	}
}
