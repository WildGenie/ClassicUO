﻿#region license
//  Copyright (C) 2018 ClassicUO Development Community on Github
//
//	This project is an alternative client for the game Ultima Online.
//	The goal of this is to develop a lightweight client considering 
//	new technologies.  
//  (Copyright (c) 2018 ClassicUO Development Team)
//    
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.
#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicUO.Game.GameObjects
{
    public class Container : Item
    {
        private readonly Dictionary<Serial, Item> _items = new Dictionary<Serial, Item>();

        public Container(Serial serial) : base(serial)
        {

        }

        public virtual void Add(Item item)
        {

        }

        public virtual void Remove(Serial serial)
        {

        }

        public bool Exists(Serial serial) => _items.ContainsKey(serial);

        public int Count => _items.Count;
    }
}