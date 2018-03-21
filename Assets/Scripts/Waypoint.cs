using System.Collections.Generic;
using UnityEngine;

public class Waypoint: MonoBehaviour {
	
	private static readonly Dictionary<Type, HashSet<Waypoint>> Waypoints =
		new Dictionary<Type, HashSet<Waypoint>>();
	
	public Type Category;
	
	private void OnEnable() {
		if (!Waypoints.ContainsKey(Category)) {
			Waypoints.Add(Category, new HashSet<Waypoint> {this});
		}
		else {
			var category = Waypoints[Category];
			category.Add(this);
		}
	}

	private void OnDisable() {
		Waypoints[Category].Remove(this);
	}

	public static HashSet<Waypoint> Get(Type type) {
		return Waypoints[type];
	}
	
	public enum Type {
		NPC
	}
}
