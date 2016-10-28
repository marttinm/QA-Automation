﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DeAutos.Automation.Model.Database
{
    public partial class DeAutosEntities : DbContext
    {
        public DeAutosEntities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BannerCampaign> BannerCampaigns { get; set; }
        public virtual DbSet<BannerInfo> BannerInfoes { get; set; }
        public virtual DbSet<Prelisting> Prelistings { get; set; }
        public virtual DbSet<PrelistingToVehicleBrand> PrelistingToVehicleBrands { get; set; }
        public virtual DbSet<PrelistingToVehicleModel> PrelistingToVehicleModels { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<AlertFeature> AlertFeatures { get; set; }
        public virtual DbSet<AlertInterval> AlertIntervals { get; set; }
        public virtual DbSet<AlertPublishableItem> AlertPublishableItems { get; set; }
        public virtual DbSet<AlertUser> AlertUsers { get; set; }
        public virtual DbSet<BackOfficeLog> BackOfficeLogs { get; set; }
        public virtual DbSet<SecurityRole> SecurityRoles { get; set; }
        public virtual DbSet<SecurityUser> SecurityUsers { get; set; }
        public virtual DbSet<Reporting> Reportings { get; set; }
        public virtual DbSet<ReportingScheduled> ReportingScheduleds { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PaymentMethodAvailability> PaymentMethodAvailabilities { get; set; }
        public virtual DbSet<PaymentTicket> PaymentTickets { get; set; }
        public virtual DbSet<PaymentTicketGatewayRequest> PaymentTicketGatewayRequests { get; set; }
        public virtual DbSet<PaymentTicketGatewayResponse> PaymentTicketGatewayResponses { get; set; }
        public virtual DbSet<PricingZone> PricingZones { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual DbSet<PurchaseOrderItemDiscount> PurchaseOrderItemDiscounts { get; set; }
        public virtual DbSet<SapBillingInfo> SapBillingInfoes { get; set; }
        public virtual DbSet<SapBlacklist> SapBlacklists { get; set; }
        public virtual DbSet<SapZone> SapZones { get; set; }
        public virtual DbSet<Suscription> Suscriptions { get; set; }
        public virtual DbSet<SuscriptionItem> SuscriptionItems { get; set; }
        public virtual DbSet<AgenciesContacted> AgenciesContacteds { get; set; }
        public virtual DbSet<AutoPublication> AutoPublications { get; set; }
        public virtual DbSet<AutoPublicationVehicleModelYear> AutoPublicationVehicleModelYears { get; set; }
        public virtual DbSet<CatalogLevel> CatalogLevels { get; set; }
        public virtual DbSet<CatalogMetadata> CatalogMetadatas { get; set; }
        public virtual DbSet<CatalogSponsor> CatalogSponsors { get; set; }
        public virtual DbSet<CatalogSponsorCompare> CatalogSponsorCompares { get; set; }
        public virtual DbSet<ContactData> ContactDatas { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<FeatureGroup> FeatureGroups { get; set; }
        public virtual DbSet<FeatureType> FeatureTypes { get; set; }
        public virtual DbSet<GeoLocationItemAutoPublication> GeoLocationItemAutoPublications { get; set; }
        public virtual DbSet<ListedVehicle> ListedVehicles { get; set; }
        public virtual DbSet<ListedVehicleFeature> ListedVehicleFeatures { get; set; }
        public virtual DbSet<ListedVehicleFeatureValue> ListedVehicleFeatureValues { get; set; }
        public virtual DbSet<ListingSponsor> ListingSponsors { get; set; }
        public virtual DbSet<ListingSponsorGeoLocationItem> ListingSponsorGeoLocationItems { get; set; }
        public virtual DbSet<ListingSponsorVehicleBrand> ListingSponsorVehicleBrands { get; set; }
        public virtual DbSet<ListingSponsorVehicleModelYear> ListingSponsorVehicleModelYears { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationType> LocationTypes { get; set; }
        public virtual DbSet<MetadataType> MetadataTypes { get; set; }
        public virtual DbSet<PeopleContacted> PeopleContacteds { get; set; }
        public virtual DbSet<PeopleToBeContacted> PeopleToBeContacteds { get; set; }
        public virtual DbSet<VehicleBrandAutoPublication> VehicleBrandAutoPublications { get; set; }
        public virtual DbSet<VehicleModelSellerClient> VehicleModelSellerClients { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<TaxCondition> TaxConditions { get; set; }
        public virtual DbSet<UserCustomerGroup> UserCustomerGroups { get; set; }
        public virtual DbSet<AuditRememberDay> AuditRememberDays { get; set; }
        public virtual DbSet<PhoneContact> PhoneContacts { get; set; }
        public virtual DbSet<Remember> Remembers { get; set; }
        public virtual DbSet<RememberDay> RememberDays { get; set; }
        public virtual DbSet<RememberDayItem> RememberDayItems { get; set; }
        public virtual DbSet<ContactButton> ContactButtons { get; set; }
        public virtual DbSet<ContactButtonConfiguration> ContactButtonConfigurations { get; set; }
        public virtual DbSet<Conversation> Conversations { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<AttributeDefinition> AttributeDefinitions { get; set; }
        public virtual DbSet<BrandSavingPlan> BrandSavingPlans { get; set; }
        public virtual DbSet<BusinessDomain> BusinessDomains { get; set; }
        public virtual DbSet<Colour> Colours { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Fuel> Fuels { get; set; }
        public virtual DbSet<GeoLocationItem> GeoLocationItems { get; set; }
        public virtual DbSet<GeoLocationItemType> GeoLocationItemTypes { get; set; }
        public virtual DbSet<GeoLocationRing> GeoLocationRings { get; set; }
        public virtual DbSet<ImageFormat> ImageFormats { get; set; }
        public virtual DbSet<SavingPlanType> SavingPlanTypes { get; set; }
        public virtual DbSet<SpecialAttributeDefinition> SpecialAttributeDefinitions { get; set; }
        public virtual DbSet<VehicleBrand> VehicleBrands { get; set; }
        public virtual DbSet<VehicleModel> VehicleModels { get; set; }
        public virtual DbSet<VehicleSegment> VehicleSegments { get; set; }
        public virtual DbSet<VehicleSpecsCategory> VehicleSpecsCategories { get; set; }
        public virtual DbSet<VehicleVersion> VehicleVersions { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<proofa2> proofa2 { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<BasicOperation> BasicOperations { get; set; }
        public virtual DbSet<ClientState> ClientStates { get; set; }
        public virtual DbSet<CreditPackState> CreditPackStates { get; set; }
        public virtual DbSet<MessageKeyBroker> MessageKeyBrokers { get; set; }
        public virtual DbSet<MessageSubType> MessageSubTypes { get; set; }
        public virtual DbSet<MessageType> MessageTypes { get; set; }
        public virtual DbSet<PublicationState> PublicationStates { get; set; }
        public virtual DbSet<PublicationType> PublicationTypes { get; set; }
        public virtual DbSet<SiteType> SiteTypes { get; set; }
        public virtual DbSet<SourceConversation> SourceConversations { get; set; }
        public virtual DbSet<SourceSection> SourceSections { get; set; }
        public virtual DbSet<AppliedDiscountCoupon> AppliedDiscountCoupons { get; set; }
        public virtual DbSet<AuditClarin365TrackOfTransaction> AuditClarin365TrackOfTransaction { get; set; }
        public virtual DbSet<Clarin365TrackOfTransaction> Clarin365TrackOfTransaction { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountCoupon> DiscountCoupons { get; set; }
        public virtual DbSet<ZonalSupplementArea> ZonalSupplementAreas { get; set; }
        public virtual DbSet<HubColourConversion> HubColourConversions { get; set; }
        public virtual DbSet<HubCurrencyConversion> HubCurrencyConversions { get; set; }
        public virtual DbSet<HubFuelConversion> HubFuelConversions { get; set; }
        public virtual DbSet<HubGeoLocationItemConversion> HubGeoLocationItemConversions { get; set; }
        public virtual DbSet<HubProcessPublication> HubProcessPublications { get; set; }
        public virtual DbSet<HubProductConversion> HubProductConversions { get; set; }
        public virtual DbSet<HubPublicationErrorDetail> HubPublicationErrorDetails { get; set; }
        public virtual DbSet<HubRubro> HubRubroes { get; set; }
        public virtual DbSet<HubVehicleModelConversion> HubVehicleModelConversions { get; set; }
        public virtual DbSet<HubVehicleSpecConversion> HubVehicleSpecConversions { get; set; }
        public virtual DbSet<ImporterProcessLog> ImporterProcessLogs { get; set; }
        public virtual DbSet<PaperBrandModelConversion> PaperBrandModelConversions { get; set; }
        public virtual DbSet<PublicationExternalAssociation> PublicationExternalAssociations { get; set; }
        public virtual DbSet<PublicationProvider> PublicationProviders { get; set; }
        public virtual DbSet<IndexAttributeEntity> IndexAttributeEntities { get; set; }
        public virtual DbSet<IndexEntity> IndexEntities { get; set; }
        public virtual DbSet<IndexFeatureEntity> IndexFeatureEntities { get; set; }
        public virtual DbSet<LocalizedMessage> LocalizedMessages { get; set; }
        public virtual DbSet<LocalizedMessageForm> LocalizedMessageForms { get; set; }
        public virtual DbSet<ContactServiceTemplate> ContactServiceTemplates { get; set; }
        public virtual DbSet<MailDepositBlacklist> MailDepositBlacklists { get; set; }
        public virtual DbSet<MessageActionAfterSent> MessageActionAfterSents { get; set; }
        public virtual DbSet<MessageBroker> MessageBrokers { get; set; }
        public virtual DbSet<MessageQueue> MessageQueues { get; set; }
        public virtual DbSet<MessageQueueParam> MessageQueueParams { get; set; }
        public virtual DbSet<MessageQueueResponseDetail> MessageQueueResponseDetails { get; set; }
        public virtual DbSet<MessageQueueStatu> MessageQueueStatus { get; set; }
        public virtual DbSet<MessageSendType> MessageSendTypes { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<PlanisysTemplate> PlanisysTemplates { get; set; }
        public virtual DbSet<SmtpTemplate> SmtpTemplates { get; set; }
        public virtual DbSet<DataCarConversionReport> DataCarConversionReports { get; set; }
        public virtual DbSet<DaxInfo> DaxInfoes { get; set; }
        public virtual DbSet<PublicationVisit> PublicationVisits { get; set; }
        public virtual DbSet<MobileAppInfo> MobileAppInfoes { get; set; }
        public virtual DbSet<ProcessScheduler> ProcessSchedulers { get; set; }
        public virtual DbSet<ProcessTask> ProcessTasks { get; set; }
        public virtual DbSet<CreditPack> CreditPacks { get; set; }
        public virtual DbSet<CreditPackItem> CreditPackItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductOffering> ProductOfferings { get; set; }
        public virtual DbSet<ProductOfferingPrice> ProductOfferingPrices { get; set; }
        public virtual DbSet<ProductPackItem> ProductPackItems { get; set; }
        public virtual DbSet<AuditPublicationPaperDate> AuditPublicationPaperDates { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<NewCar> NewCars { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<PublicationPaper> PublicationPapers { get; set; }
        public virtual DbSet<PublicationPaperDate> PublicationPaperDates { get; set; }
        public virtual DbSet<PublicationPaperDateProcess> PublicationPaperDateProcesses { get; set; }
        public virtual DbSet<PublishableItem> PublishableItems { get; set; }
        public virtual DbSet<PublishableItemImage> PublishableItemImages { get; set; }
        public virtual DbSet<PublishableItemPaymentMethod> PublishableItemPaymentMethods { get; set; }
        public virtual DbSet<PublishableItemType> PublishableItemTypes { get; set; }
        public virtual DbSet<SavingPlan> SavingPlans { get; set; }
        public virtual DbSet<SavingPlanTransferData> SavingPlanTransferDatas { get; set; }
        public virtual DbSet<UsedCar> UsedCars { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<EMailAudit> EMailAudits { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserClaim> UserClaims { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<PublicationSimilarConfiguration> PublicationSimilarConfigurations { get; set; }
        public virtual DbSet<PublicationSimilarConfigurationFunctionality> PublicationSimilarConfigurationFunctionalities { get; set; }
        public virtual DbSet<PublicationSimilarConfigurationOperationType> PublicationSimilarConfigurationOperationTypes { get; set; }
        public virtual DbSet<ClientUser> ClientUsers { get; set; }
        public virtual DbSet<EndUser> EndUsers { get; set; }
        public virtual DbSet<ImportUser> ImportUsers { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<AuditCatalog> AuditCatalogs { get; set; }
        public virtual DbSet<VehicleBrandSellerClient> VehicleBrandSellerClients { get; set; }
        public virtual DbSet<DbVersion> DbVersions { get; set; }
    }
}
