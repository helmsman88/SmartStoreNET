namespace SmartStore.Data.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using Setup;

	public sealed class MigrationsConfiguration : DbMigrationsConfiguration<SmartObjectContext>
	{
		public MigrationsConfiguration()
		{
			AutomaticMigrationsEnabled = false;
			AutomaticMigrationDataLossAllowed = true;
			ContextKey = "SmartStore.Core";
		}

		public void SeedDatabase(SmartObjectContext context)
		{
			Seed(context);
		}

		protected override void Seed(SmartObjectContext context)
		{
			context.MigrateLocaleResources(MigrateLocaleResources);
			MigrateSettings(context);
        }

		public void MigrateSettings(SmartObjectContext context)
		{
		}

		public void MigrateLocaleResources(LocaleResourcesBuilder builder)
		{
            builder.AddOrUpdate("Account.PasswordRecoveryConfirm.InvalidEmail",
                "No customer account matches this email address. Please click the link in your email anew.",
                "Diese Emailadresse konnte keinen Kundenkonto zugeordnet werden. Bitte rufen Sie den an Sie versendeten Link erneut auf.");

            builder.AddOrUpdate("Account.PasswordRecoveryConfirm.InvalidToken",
                "The used token is incorrect. Please click the link in your email anew.",
                "Das verwendete Token scheint nicht korrekt zu sein. Bitte rufen Sie den Link erneut auf.");

            builder.AddOrUpdate("Customer.UserAgreement.OrderItemNotFound",
                "The corresponding order item could not be found.",
                "Die entsprechende Auftragsposition konnte nicht gefunden werden.");

            builder.AddOrUpdate("Customer.UserAgreement.ProductNotFound",
                "The corresponding product could not be found.",
                "Das entsprechende Produkt konnte nicht gefunden werden.");

            builder.AddOrUpdate("ShoppingCart.RewardPoints", "Reward points", "Bonuspunkte");

            builder.AddOrUpdate("ShoppingCart.RewardPoints.Button", "Apply", "Anwenden");

			builder.AddOrUpdate("ShoppingCart.IsDisabled",
				"The shopping cart is disabled.",
				"Der Warenkorb ist deaktiviert.");

            builder.AddOrUpdate("Admin.Configuration.Settings.Catalog.AllowDifferingEmailAddressForEmailAFriend",
                "Allow differing email address for email e friend",
                "Abweichende Emailadresse f�r Tell A Friend zulassen",
                "Specifies whether customers are allowed to enter a email address different from the one they've registered their account with.", 
                "Bestimmt ob Kunden gestattet ist eine Emailadresse anzugeben, welche von der abweicht mit der sie sich im Shop registriert haben.");
        }
	}
}
