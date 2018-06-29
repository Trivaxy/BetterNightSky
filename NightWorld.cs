using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BetterNightSky
{
	public class NightWorld : ModWorld
	{
		public override void PreUpdate()
		{
			foreach (KeyValuePair<CelestialObject, int> pair in BetterNightSky.CelestialIndex)
			{
				switch(pair.Key)
				{
					case CelestialObject.Mars:
						Main.star[pair.Value].position = new Vector2(340, 100);
						break;

					case CelestialObject.Saturn:
						Main.star[pair.Value].position = new Vector2(200, 300);
						break;

					case CelestialObject.Jupiter:
						Main.star[pair.Value].position = new Vector2(700, 178);
						break;

					case CelestialObject.Mercury:
						Main.star[pair.Value].position = new Vector2(90, 130);
						break;

					case CelestialObject.CrabNebula:
						Main.star[pair.Value].position = new Vector2(520, 370);
						break;

					case CelestialObject.Andromeda:
						Main.star[pair.Value].position = new Vector2(100, 50);
						break;

					case CelestialObject.CatsEyeNebula:
						Main.star[pair.Value].position = new Vector2(300, 330);
						break;

					case CelestialObject.CarinaNebula:
						Main.star[pair.Value].position = new Vector2(160, 430);
						break;

					case CelestialObject.Triangulum:
						Main.star[pair.Value].position = new Vector2(600, 40);
						break;

					case CelestialObject.Uranus:
						Main.star[pair.Value].position = new Vector2(70, 530);
						break;

					case CelestialObject.LargeMagellanicCloud:
						Main.star[pair.Value].position = new Vector2(400, 280);
						break;

					case CelestialObject.SmallMagellanicCloud:
						Main.star[pair.Value].position = new Vector2(550, 130);
						break;

					case CelestialObject.HelixNebula:
						Main.star[pair.Value].position = new Vector2(220, 450);
						break;
				}

				Main.star[pair.Value].rotation = 0;
				Main.star[pair.Value].scale = 1f;
				Main.star[pair.Value].twinkleSpeed = 0;
			}
		}
	}
}
