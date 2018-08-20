namespace ChickenCoop3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToCreatedTables : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Chickens (Name, Breed, isAdoptable, OwnerId) VALUES ('Henrietta', 'Orpington', 1, -1)");
            Sql("INSERT INTO ChickenBreeds (Name) VALUES ('Silkie')");
            Sql("INSERT INTO ChickenBreeds (Name) VALUES ('Rhode Island Red')");
            Sql("INSERT INTO ChickenBreeds (Name) VALUES ('Orpington')");
            Sql("INSERT INTO ChickenBreeds (Name) VALUES ('Other')");
            Sql("INSERT INTO Owners (Name) VALUES ('Fred')");
        }
        
        public override void Down()
        {
        }
    }
}
