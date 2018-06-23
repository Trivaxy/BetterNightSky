using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace BetterNightSky
{
	class BetterNightSky : Mod
	{
		public BetterNightSky()
		{
		}

		public override void Load()
		{
			//Attempting to increase the array size that holds all the star Texture2Ds to override it with mine
			//since I have a larger amount of textures

			if (!Main.dedServ)
			{
				Array.Resize<Texture2D>(ref Main.starTexture, 8); //resize the array to 7, original was 5

				for (int i = 0; i < Main.starTexture.Length; i++)
				{
					Main.starTexture[i] = this.GetTexture("Textures/Star_" + i);
					//load my textures into each index
				}

				for (int i = 0; i < Main.moonTexture.Length; i++)
				{
					Main.moonTexture[i] = this.GetTexture("Textures/Moon1");
				}
			}

			//we use a new random object because Main.rand isn't initialized yet
			Random temp_Rand = new Random();
			for(int i = 0; i < Main.star.Length; i++)
			{
				if(temp_Rand.Next(17) == 0)
				{
					Main.star[i].type = 5;
				}

				if(temp_Rand.Next(13) == 0)
				{
					Main.star[i].type = 7;
				}
			}
		}

		public override void Unload()
		{
			Array.Resize<Texture2D>(ref Main.starTexture, 5);
			
			for(int i = 0; i < Main.star.Length; i++)
			{
				if(Main.star[i].type > 4)
				{
					Main.star[i].type = Main.rand.Next(5);
				}
			}

			for(int i = 0; i < 5; i++)
			{
				Main.starTexture[i] = ModLoader.GetTexture("Terraria/Star_" + i);
			}

			for(int i = 0; i < Main.moonTexture.Length; i++)
			{
				Main.moonTexture[i] = ModLoader.GetTexture("Terraria/Moon_" + i);
			}
		}
	}
}
