namespace ChickenCoop3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChickens : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Chickens (Name, isAdoptable, ChickenBreedId, ChickenBreed_Id) VALUES ('Henrietta', 1, 1, 1)");
            Sql("INSERT INTO Chickens (Name, isAdoptable, OwnerId, ChickenBreedId, ChickenBreed_Id) VALUES ('Redi', 0, 1, 2, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
