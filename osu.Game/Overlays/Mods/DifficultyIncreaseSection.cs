﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using OpenTK.Input;
using osu.Framework.Allocation;
using osu.Game.Graphics;

namespace osu.Game.Overlays.Mods
{
    public class DifficultyIncreaseSection : ModSection
    {
        protected override Key[] ToggleKeys => new Key[] { Key.A, Key.S, Key.D, Key.F, Key.G, Key.H, Key.J, Key.K, Key.L };

        [BackgroundDependencyLoader]
        private void load(OsuColour colours)
        {
            Colour = colours.Yellow;
            SelectedColour = colours.YellowLight;
        }

        public DifficultyIncreaseSection()
        {
            Header = @"Gameplay Difficulty Increase";
        }
    }
}
