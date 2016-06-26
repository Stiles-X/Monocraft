﻿#region License

// Copyright (c) 2016, Vira
// All rights reserved.
// Solution: Monocraft
// Project: Monocraft
// Filename: Delegates.cs
// Date - created: 2016.06.22 - 10:16
// Date - current: 2016.06.26 - 11:08

#endregion

#region Usings

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Monocraft.World;
using Monocraft.World.Frames;

#endregion

namespace Monocraft.Basics
{
    // Here should be stored all delegates!
    public delegate void GenerateD(
        Vector3 position, VisFrame[,,] frames, WorldTile[] neighbours, GraphicsDevice device, SpriteBatch sp);
}