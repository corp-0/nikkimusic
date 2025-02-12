﻿using System;

namespace NikkiMusic.Utils
{
	public static class Extensions
	{
		/// <summary>
		/// Método genérico para obtener el siguiente valor de un Enum cualquiera.
		/// </summary>
		/// <param name="src">representa el tipo del Enum en cuestión</param>
		/// <typeparam name="T"></typeparam>
		/// <returns>Siguiente valor si existe, sino, el primero</returns>
		public static T Next<T>(this T src) where T : Enum
		{
			var array = (T[]) Enum.GetValues(src.GetType());
			int index = Array.IndexOf<T>(array, src) + 1;
			return array.Length == index ? array[0] : array[index];
		}
	}
}