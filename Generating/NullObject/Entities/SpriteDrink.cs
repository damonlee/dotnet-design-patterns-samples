﻿using NullObject.Abstract;

namespace NullObject.Entities
{
	public class SpriteDrink : Drink
	{
		/// <summary>
		/// The drink name.
		/// </summary>
		public override string Name => string.Empty;

		/// <summary>
		/// The drink's cost in the US dollars.
		/// </summary>
		public override decimal Cost => default(decimal);
	}
}
