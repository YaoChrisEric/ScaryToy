﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace HalloweenSoundGenerator
{
    public class HalloweenSoundEffects
    {
        private readonly Dictionary<int, MediaPlayer> _soundDictionary = new Dictionary<int, MediaPlayer>();
        private readonly Random _random = new Random();
        private readonly Context _context;

        public HalloweenSoundEffects(Context context)
        {
            _context = context;
        }

        private static int[] soundEffects = new[]
        {
            Resource.Raw.OldDoorCreakingSoundBiblecom1197162460,
            Resource.Raw.chainsaw2,
            Resource.Raw.ghost01,
            Resource.Raw.ghost02,
            Resource.Raw.haunting,
            Resource.Raw.lab,
            Resource.Raw.laughhowl1,
            Resource.Raw.Monster_Footsteps,
            Resource.Raw.pig,
            Resource.Raw.SCREAM_4,
            Resource.Raw.sono_moo,
            Resource.Raw.wickedmalelaugh1,
            Resource.Raw.wickedwitchlaugh,
            Resource.Raw.Wolf_Howl
        };

        public void PlaySoundEffect()
        {
            var soundeffectKey = RandomSoundEffect();

            if(!_soundDictionary.ContainsKey(soundeffectKey))
            {
                _soundDictionary.Add(soundeffectKey, MediaPlayer.Create(_context, soundeffectKey));
            }

            _soundDictionary[soundeffectKey].Start();
        }

        private int RandomSoundEffect()
        {
            return soundEffects[_random.Next(0, soundEffects.Length - 1)];
        }
    }
}