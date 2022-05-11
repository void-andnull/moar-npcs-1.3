using Terraria.ID;
using Terraria.ModLoader;

namespace MoarNPCs.Items
{
	public class NPCSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("NPC Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This sword is ridiculously overpowered");
		}

		public override void SetDefaults() 
		{
			item.damage = 500;
			item.melee = true;
			item.width = 100;
			item.height = 400;
			item.useTime = 20;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}