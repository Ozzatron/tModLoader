using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

namespace Terraria.ModLoader
{
	public class GlobalNPC
	{
		public Mod mod
		{
			get;
			internal set;
		}

		public string Name
		{
			get;
			internal set;
		}

		public virtual bool Autoload(ref string name)
		{
			return mod.Properties.Autoload;
		}

		public virtual void SetDefaults(NPC npc)
		{
		}

		public virtual void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale)
		{
		}

		public virtual bool PreAI(NPC npc)
		{
			return true;
		}

		public virtual void AI(NPC npc)
		{
		}

		public virtual void PostAI(NPC npc)
		{
		}

		public virtual void FindFrame(NPC npc, int frameHeight)
		{
		}

		public virtual void HitEffect(NPC npc, int hitDirection, double damage)
		{
		}

		public virtual bool PreNPCLoot(NPC npc)
		{
			return true;
		}

		public virtual void NPCLoot(NPC npc)
		{
		}

		public virtual bool CanHitPlayer(NPC npc, Player target, ref int cooldownSlot)
		{
			return true;
		}

		public virtual void ModifyHitPlayer(NPC npc, Player target, ref int damage, ref bool crit)
		{
		}

		public virtual void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
		{
		}

		public virtual bool? CanHitNPC(NPC npc, NPC target)
		{
			return null;
		}

		public virtual void ModifyHitNPC(NPC npc, NPC target, ref int damage, ref float knockback, ref bool crit)
		{
		}

		public virtual void OnHitNPC(NPC npc, NPC target, int damage, float knockback, bool crit)
		{
		}

		public virtual bool? CanBeHitByItem(NPC npc, Player player, Item item)
		{
			return null;
		}

		public virtual void ModifyHitByItem(NPC npc, Player player, Item item, ref int damage, ref float knockback, ref bool crit)
		{
		}

		public virtual void OnHitByItem(NPC npc, Player player, Item item, int damage, float knockback, bool crit)
		{
		}

		public virtual bool? CanBeHitByProjectile(NPC npc, Projectile projectile)
		{
			return null;
		}

		public virtual void ModifyHitByProjectile(NPC npc, Projectile projectile, ref int damage, ref float knockback, ref bool crit)
		{
		}

		public virtual void OnHitByProjectile(NPC npc, Projectile projectile, int damage, float knockback, bool crit)
		{
		}

		public virtual bool StrikeNPC(NPC npc, ref double damage, int defense, ref float knockback, int hitDirection, ref bool crit)
		{
			return true;
		}

		public virtual void BossHeadSlot(NPC npc, ref int index)
		{
		}

		public virtual void BossHeadRotation(NPC npc, ref float rotation)
		{
		}

		public virtual void BossHeadSpriteEffects(NPC npc, ref SpriteEffects spriteEffects)
		{
		}

		public virtual Color? GetAlpha(NPC npc, Color drawColor)
		{
			return null;
		}

		public virtual bool PreDraw(NPC npc, SpriteBatch spriteBatch, Color drawColor)
		{
			return true;
		}

		public virtual void PostDraw(NPC npc, SpriteBatch spriteBatch, Color drawColor)
		{
		}

		public virtual void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
		{
		}

		public virtual void EditSpawnRange(Player player, ref int spawnRangeX, ref int spawnRangeY,
			ref int safeRangeX, ref int safeRangeY)
		{
		}

		public virtual void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
		{
		}

		public virtual void SpawnNPC(int npc, int tileX, int tileY)
		{
		}
	}
}
