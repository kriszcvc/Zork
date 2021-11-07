﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
	public class Room : IEquatable<Room>
	{
		[JsonProperty(Order = 1)]
		public string Name { get; set; }

		[JsonProperty(Order = 2)]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "Neighbors", Order = 3)]
		private Dictionary<Directions, string> NeighborNames { get; set; }

		[JsonIgnore]
		public Dictionary<Directions, Room> Neighbors { get; private set; }

		public static bool operator ==(Room lhs, Room rhs)
		{
			if (ReferenceEquals(lhs, rhs))
			{
				return true;
			}

			if (lhs is null || rhs is null)
			{
				return false;
			}

			return lhs.Name == rhs.Name;
		}

		public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

		public override bool Equals(object obj) => obj is Room room ? this == room : false;

		public bool Equals(Room other) => this == other;

		public override string ToString() => Name;

		public override int GetHashCode() => Name.GetHashCode();

		public void UpdateNeighbors(World world)
		{
			Neighbors = new Dictionary<Directions, Room>();
			foreach (var pair in NeighborNames)
			{
				(Directions direction, string name) = (pair.Key, pair.Value);
				Neighbors.Add(direction, world.RoomsByName[name]);
			}
		}
	}
}