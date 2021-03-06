﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrafficManager.TrafficLight {
	public enum StepChangeMetric {
		/// <summary>
		/// Step is changed based on flow/wait comparison
		/// </summary>
		Default,
		/// <summary>
		/// Step is changed on first flow detection
		/// </summary>
		FirstFlow,
		/// <summary>
		/// Step is changed on first wait detection
		/// </summary>
		FirstWait,
		/// <summary>
		/// Step is changed if no vehicle is moving
		/// </summary>
		NoFlow,
		/// <summary>
		/// Step is changed if no vehicle is waiting
		/// </summary>
		NoWait,
	}
}
