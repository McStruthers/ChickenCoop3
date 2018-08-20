namespace ChickenCoop3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewChickens : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Chickens (Name, isAdoptable, ChickenBreedId) VALUES ('Henrietta', 1, 1)");
            Sql("INSERT INTO Chickens (Name, isAdoptable, OwnerId, ChickenBreedId) VALUES ('Redi', 0, 1, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
