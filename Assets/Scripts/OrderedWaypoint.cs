using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderedWaypoint: Waypoint, IComparable<OrderedWaypoint> {
	public int Order = 1;
	
	private static readonly Dictionary<Type, List<OrderedWaypoint>> Waypoints =
		new Dictionary<Type, List<OrderedWaypoint>>();
	
	private void OnEnable() {
		if (!Waypoints.ContainsKey(Category)) {
			Waypoints.Add(Category, new List<OrderedWaypoint> {this});
		}
		else {
			var category = Waypoints[Category];
			var index = category.BinarySearch(this);
			if (index < 0)
			{
				category.Insert(~index, this);
			}
		}
	}

	private void OnDisable() {
		Waypoints[Category].Remove(this);
	}
	
	public new static List<OrderedWaypoint> Get(Type type) {
		return Waypoints[type];
	}


	public int CompareTo(OrderedWaypoint other) {
		return Order.CompareTo(other.Order);
	}
}