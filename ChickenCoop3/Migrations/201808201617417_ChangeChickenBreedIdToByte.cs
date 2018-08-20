namespace ChickenCoop3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeChickenBreedIdToByte : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from Chickens");
            DropForeignKey("dbo.Chickens", "ChickenBreed_Id", "dbo.ChickenBreeds");
            DropIndex("dbo.Chickens", new[] { "ChickenBreed_Id" });
            DropColumn("dbo.Chickens", "ChickenBreedId");
            RenameColumn(table: "dbo.Chickens", name: "ChickenBreed_Id", newName: "ChickenBreedId");
            DropPrimaryKey("dbo.ChickenBreeds");
            AlterColumn("dbo.ChickenBreeds", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Chickens", "ChickenBreedId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.ChickenBreeds", "Id");
            CreateIndex("dbo.Chickens", "ChickenBreedId");
            AddForeignKey("dbo.Chickens", "ChickenBreedId", "dbo.ChickenBreeds", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chickens", "ChickenBreedId", "dbo.ChickenBreeds");
            DropIndex("dbo.Chickens", new[] { "ChickenBreedId" });
            DropPrimaryKey("dbo.ChickenBreeds");
            AlterColumn("dbo.Chickens", "ChickenBreedId", c => c.Int());
            AlterColumn("dbo.ChickenBreeds", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ChickenBreeds", "Id");
            RenameColumn(table: "dbo.Chickens", name: "ChickenBreedId", newName: "ChickenBreed_Id");
            AddColumn("dbo.Chickens", "ChickenBreedId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Chickens", "ChickenBreed_Id");
            AddForeignKey("dbo.Chickens", "ChickenBreed_Id", "dbo.ChickenBreeds", "Id");
        }
    }
}
