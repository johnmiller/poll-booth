namespace PollBooth.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPollBoothEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ballots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BallotId = c.Int(nullable: false),
                        Order = c.Int(nullable: false),
                        Text = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ballots", t => t.BallotId, cascadeDelete: true)
                .Index(t => t.BallotId);
            
            CreateTable(
                "dbo.IssueChoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueId = c.Int(nullable: false),
                        Text = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Issues", t => t.IssueId, cascadeDelete: true)
                .Index(t => t.IssueId);
            
            CreateTable(
                "dbo.CastBallots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BallotId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ballots", t => t.BallotId, cascadeDelete: true)
                .Index(t => t.BallotId);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CastBallotId = c.Int(nullable: false),
                        IssueId = c.Int(nullable: false),
                        IssueChoiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Issues", t => t.IssueId, cascadeDelete: true)
                .ForeignKey("dbo.IssueChoices", t => t.IssueChoiceId, cascadeDelete: true)
                .ForeignKey("dbo.CastBallots", t => t.CastBallotId, cascadeDelete: true)
                .Index(t => t.IssueId)
                .Index(t => t.IssueChoiceId)
                .Index(t => t.CastBallotId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "CastBallotId", "dbo.CastBallots");
            DropForeignKey("dbo.Votes", "IssueChoiceId", "dbo.IssueChoices");
            DropForeignKey("dbo.Votes", "IssueId", "dbo.Issues");
            DropForeignKey("dbo.CastBallots", "BallotId", "dbo.Ballots");
            DropForeignKey("dbo.Issues", "BallotId", "dbo.Ballots");
            DropForeignKey("dbo.IssueChoices", "IssueId", "dbo.Issues");
            DropIndex("dbo.Votes", new[] { "CastBallotId" });
            DropIndex("dbo.Votes", new[] { "IssueChoiceId" });
            DropIndex("dbo.Votes", new[] { "IssueId" });
            DropIndex("dbo.CastBallots", new[] { "BallotId" });
            DropIndex("dbo.Issues", new[] { "BallotId" });
            DropIndex("dbo.IssueChoices", new[] { "IssueId" });
            DropTable("dbo.Votes");
            DropTable("dbo.CastBallots");
            DropTable("dbo.IssueChoices");
            DropTable("dbo.Issues");
            DropTable("dbo.Ballots");
        }
    }
}
