using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace RoboDeApostas.Models.CasasDeAposta.SportingBetAPI.ListaDePartida
{
    public partial class ResponseListaDePartida
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public Template Template { get; set; }

        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public string Page { get; set; }

        [JsonProperty("widgets", NullValueHandling = NullValueHandling.Ignore)]
        public List<Widget> Widgets { get; set; }
    }

    public partial class Template
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("folder", NullValueHandling = NullValueHandling.Ignore)]
        public string Folder { get; set; }
    }

    public partial class Widget
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("refreshable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refreshable { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public WidgetPayload Payload { get; set; }

        [JsonProperty("trackingData", NullValueHandling = NullValueHandling.Ignore)]
        public TrackingData TrackingData { get; set; }
    }

    public partial class WidgetPayload
    {
        [JsonProperty("backgroundContainerConfig", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundContainerConfig BackgroundContainerConfig { get; set; }

        [JsonProperty("globalLink", NullValueHandling = NullValueHandling.Ignore)]
        public GlobalLink GlobalLink { get; set; }

        [JsonProperty("fixtures", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Fixtures { get; set; }

        [JsonProperty("tiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tile> Tiles { get; set; }

        [JsonProperty("isPersonalizedMarquee", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPersonalizedMarquee { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }

        [JsonProperty("headerWidgets", NullValueHandling = NullValueHandling.Ignore)]
        public List<HeaderWidget> HeaderWidgets { get; set; }

        [JsonProperty("allTabSettings", NullValueHandling = NullValueHandling.Ignore)]
        public AllTabSettings AllTabSettings { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class AllTabSettings
    {
        [JsonProperty("isVisible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVisible { get; set; }

        [JsonProperty("initialBatchCountOfEvents", NullValueHandling = NullValueHandling.Ignore)]
        public long? InitialBatchCountOfEvents { get; set; }

        [JsonProperty("isShowMoreEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShowMoreEnabled { get; set; }

        [JsonProperty("hideSecondaryNavigation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideSecondaryNavigation { get; set; }

        [JsonProperty("maxEventsPerAccordion", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxEventsPerAccordion { get; set; }
    }

    public partial class BackgroundContainerConfig
    {
        [JsonProperty("showTitle", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTitle { get; set; }

        [JsonProperty("titleIconDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleIconDisplay { get; set; }
    }

    public partial class GlobalLink
    {
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }
    }

    public partial class HeaderWidget
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        [JsonProperty("refreshable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refreshable { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public HeaderWidgetPayload Payload { get; set; }
    }

    public partial class HeaderWidgetPayload
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("mergeNavigation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MergeNavigation { get; set; }

        [JsonProperty("showCount", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCount { get; set; }

        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<Child> Children { get; set; }

        [JsonProperty("navigationOverrides", NullValueHandling = NullValueHandling.Ignore)]
        public NavigationOverrides NavigationOverrides { get; set; }

        [JsonProperty("activeChildren", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActiveChild> ActiveChildren { get; set; }
    }

    public partial class ActiveChild
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        [JsonProperty("refreshable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refreshable { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public ActiveChildPayload Payload { get; set; }
    }

    public partial class ActiveChildPayload
    {
        [JsonProperty("fixtures", NullValueHandling = NullValueHandling.Ignore)]
        public List<Fixture> Fixtures { get; set; }

        [JsonProperty("fixturesTransition", NullValueHandling = NullValueHandling.Ignore)]
        public string FixturesTransition { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("navigation", NullValueHandling = NullValueHandling.Ignore)]
        public List<Navigation> Navigation { get; set; }

        [JsonProperty("hideMarketSwitcher", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideMarketSwitcher { get; set; }

        [JsonProperty("gridType", NullValueHandling = NullValueHandling.Ignore)]
        public string GridType { get; set; }

        [JsonProperty("enablePaging", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePaging { get; set; }

        [JsonProperty("showNonGridable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNonGridable { get; set; }
    }

    public partial class Fixture
    {
        [JsonProperty("optionMarkets", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionMarket> OptionMarkets { get; set; }

        [JsonProperty("games", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Games { get; set; }

        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public List<Participant> Participants { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public CompetitionName Name { get; set; }

        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceId { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("fixtureType", NullValueHandling = NullValueHandling.Ignore)]
        public string FixtureType { get; set; }

        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public string Context { get; set; }

        [JsonProperty("addons", NullValueHandling = NullValueHandling.Ignore)]
        public Addons Addons { get; set; }

        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public string Stage { get; set; }

        [JsonProperty("liveAlert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiveAlert { get; set; }

        [JsonProperty("scoreboard", NullValueHandling = NullValueHandling.Ignore)]
        public Scoreboard Scoreboard { get; set; }

        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("cutOffDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CutOffDate { get; set; }

        [JsonProperty("sport", NullValueHandling = NullValueHandling.Ignore)]
        public Sport Sport { get; set; }

        [JsonProperty("competition", NullValueHandling = NullValueHandling.Ignore)]
        public Competition Competition { get; set; }

        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public Region Region { get; set; }

        [JsonProperty("virtualCompetition", NullValueHandling = NullValueHandling.Ignore)]
        public Competition VirtualCompetition { get; set; }

        [JsonProperty("viewType", NullValueHandling = NullValueHandling.Ignore)]
        public string ViewType { get; set; }

        [JsonProperty("isOpenForBetting", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpenForBetting { get; set; }

        [JsonProperty("isVirtual", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVirtual { get; set; }

        [JsonProperty("taggedLocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> TaggedLocations { get; set; }

        [JsonProperty("totalMarketsCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalMarketsCount { get; set; }

        [JsonProperty("conferences", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Conferences { get; set; }

        [JsonProperty("marketGroups", NullValueHandling = NullValueHandling.Ignore)]
        public MarketGroups MarketGroups { get; set; }

        [JsonProperty("priceBoostCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? PriceBoostCount { get; set; }
    }

    public partial class Addons
    {
        [JsonProperty("betBuilderFixture", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? BetBuilderFixture { get; set; }

        [JsonProperty("betRadar", NullValueHandling = NullValueHandling.Ignore)]
        public long? BetRadar { get; set; }

        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Statistics { get; set; }

        [JsonProperty("isResulted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsResulted { get; set; }

        [JsonProperty("participantDividend", NullValueHandling = NullValueHandling.Ignore)]
        public ParticipantDividend ParticipantDividend { get; set; }

        [JsonProperty("sportcastId", NullValueHandling = NullValueHandling.Ignore)]
        public long? SportcastId { get; set; }
    }

    public partial class ParticipantDividend
    {
    }

    public partial class Competition
    {
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Statistics { get; set; }

        [JsonProperty("sportId", NullValueHandling = NullValueHandling.Ignore)]
        public long? SportId { get; set; }

        [JsonProperty("compoundId", NullValueHandling = NullValueHandling.Ignore)]
        public string CompoundId { get; set; }

        [JsonProperty("virtualCompetitionId", NullValueHandling = NullValueHandling.Ignore)]
        public long? VirtualCompetitionId { get; set; }

        [JsonProperty("displayMode", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayMode { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public CompetitionName Name { get; set; }

        [JsonProperty("imageType", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        [JsonProperty("competitionIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> CompetitionIds { get; set; }
    }

    public partial class CompetitionName
    {
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("sign", NullValueHandling = NullValueHandling.Ignore)]
        public string Sign { get; set; }
    }

    public partial class MarketGroups
    {
        [JsonProperty("outrightMarketGroupIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> OutrightMarketGroupIds { get; set; }

        [JsonProperty("specialMarketGroupIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> SpecialMarketGroupIds { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }
    }

    public partial class OptionMarket
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public CompetitionName Name { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status? Status { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public List<Option> Options { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Parameter> Parameters { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public ParticipantDividend Properties { get; set; }

        [JsonProperty("grouping", NullValueHandling = NullValueHandling.Ignore)]
        public Grouping Grouping { get; set; }

        [JsonProperty("isMain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMain { get; set; }

        [JsonProperty("templateCategory", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateCategory TemplateCategory { get; set; }

        [JsonProperty("comboPrevention", NullValueHandling = NullValueHandling.Ignore)]
        public ComboPrevention? ComboPrevention { get; set; }

        [JsonProperty("minCombo", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinCombo { get; set; }

        [JsonProperty("attr", NullValueHandling = NullValueHandling.Ignore)]
        public string Attr { get; set; }

        [JsonProperty("spread", NullValueHandling = NullValueHandling.Ignore)]
        public double? Spread { get; set; }

        [JsonProperty("balanced", NullValueHandling = NullValueHandling.Ignore)]
        public long? Balanced { get; set; }
    }

    public partial class Grouping
    {
        [JsonProperty("gridGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Grid> GridGroups { get; set; }

        [JsonProperty("grid", NullValueHandling = NullValueHandling.Ignore)]
        public Grid? Grid { get; set; }

        [JsonProperty("detailed", NullValueHandling = NullValueHandling.Ignore)]
        public List<Detailed> Detailed { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public GroupingParameters Parameters { get; set; }
    }

    public partial class Detailed
    {
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public long? Group { get; set; }

        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public long? Index { get; set; }

        [JsonProperty("marketTabId", NullValueHandling = NullValueHandling.Ignore)]
        public long? MarketTabId { get; set; }

        [JsonProperty("marketHelpPath", NullValueHandling = NullValueHandling.Ignore)]
        public MarketHelpPath? MarketHelpPath { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum? Name { get; set; }

        [JsonProperty("displayType", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayType? DisplayType { get; set; }

        [JsonProperty("marketGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MarketGroupId { get; set; }

        [JsonProperty("marketGroupItemId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MarketGroupItemId { get; set; }

        [JsonProperty("subIndex", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubIndex { get; set; }
    }

    public partial class GroupingParameters
    {
        [JsonProperty("happening", NullValueHandling = NullValueHandling.Ignore)]
        public Happening? Happening { get; set; }

        [JsonProperty("marketType", NullValueHandling = NullValueHandling.Ignore)]
        public MarketType? MarketType { get; set; }

        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public Period? Period { get; set; }

        [JsonProperty("attr", NullValueHandling = NullValueHandling.Ignore)]
        public string Attr { get; set; }

        [JsonProperty("attrType", NullValueHandling = NullValueHandling.Ignore)]
        public AttrTypeEnum? AttrType { get; set; }
    }

    public partial class Option
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status? Status { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public CompetitionName Name { get; set; }

        [JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
        public SourceName SourceName { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public Price Price { get; set; }

        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public OptionParameters Parameters { get; set; }
    }

    public partial class OptionParameters
    {
        [JsonProperty("optionType", NullValueHandling = NullValueHandling.Ignore)]
        public OptionType? OptionType { get; set; }

        [JsonProperty("optionTypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionType> OptionTypes { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("numerator", NullValueHandling = NullValueHandling.Ignore)]
        public long? Numerator { get; set; }

        [JsonProperty("denominator", NullValueHandling = NullValueHandling.Ignore)]
        public long? Denominator { get; set; }

        [JsonProperty("odds", NullValueHandling = NullValueHandling.Ignore)]
        public double? Odds { get; set; }

        [JsonProperty("americanOdds", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmericanOdds { get; set; }
    }

    public partial class SourceName
    {
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Value { get; set; }
    }

    public partial class Parameter
    {
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public Key? Key { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public AttrTypeEnum? Type { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class TemplateCategory
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public Category? Category { get; set; }
    }

    public partial class Participant
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("participantId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParticipantId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public ParticipantName Name { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Properties Properties { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Options { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("jersey", NullValueHandling = NullValueHandling.Ignore)]
        public string Jersey { get; set; }

        [JsonProperty("rotateJersey", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RotateJersey { get; set; }
    }

    public partial class ParticipantName
    {
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("sign", NullValueHandling = NullValueHandling.Ignore)]
        public string Sign { get; set; }

        [JsonProperty("short", NullValueHandling = NullValueHandling.Ignore)]
        public string Short { get; set; }

        [JsonProperty("shortSign", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortSign { get; set; }
    }

    public partial class Properties
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class Region
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("sportId", NullValueHandling = NullValueHandling.Ignore)]
        public long? SportId { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("parentId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public CompetitionName Name { get; set; }
    }

    public partial class Scoreboard
    {
        [JsonProperty("corners", NullValueHandling = NullValueHandling.Ignore)]
        public Corners Corners { get; set; }

        [JsonProperty("redCards", NullValueHandling = NullValueHandling.Ignore)]
        public Corners RedCards { get; set; }

        [JsonProperty("yellowCards", NullValueHandling = NullValueHandling.Ignore)]
        public Corners YellowCards { get; set; }

        [JsonProperty("offsides", NullValueHandling = NullValueHandling.Ignore)]
        public Corners Offsides { get; set; }

        [JsonProperty("throwIns", NullValueHandling = NullValueHandling.Ignore)]
        public Corners ThrowIns { get; set; }

        [JsonProperty("penalties", NullValueHandling = NullValueHandling.Ignore)]
        public Corners Penalties { get; set; }

        [JsonProperty("substitutions", NullValueHandling = NullValueHandling.Ignore)]
        public Corners Substitutions { get; set; }

        [JsonProperty("goalKicks", NullValueHandling = NullValueHandling.Ignore)]
        public Corners GoalKicks { get; set; }

        [JsonProperty("freeKicks", NullValueHandling = NullValueHandling.Ignore)]
        public Corners FreeKicks { get; set; }

        [JsonProperty("scoreDetailed", NullValueHandling = NullValueHandling.Ignore)]
        public Corners ScoreDetailed { get; set; }

        [JsonProperty("sportId", NullValueHandling = NullValueHandling.Ignore)]
        public long? SportId { get; set; }

        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        [JsonProperty("periodId", NullValueHandling = NullValueHandling.Ignore)]
        public long? PeriodId { get; set; }

        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Points { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public string Score { get; set; }

        [JsonProperty("timer", NullValueHandling = NullValueHandling.Ignore)]
        public Timer Timer { get; set; }

        [JsonProperty("started", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Started { get; set; }
    }

    public partial class Corners
    {
        [JsonProperty("player1", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> Player1 { get; set; }

        [JsonProperty("player2", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> Player2 { get; set; }
    }

    public partial class Timer
    {
        [JsonProperty("running", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Running { get; set; }

        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Base { get; set; }

        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        [JsonProperty("seconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? Seconds { get; set; }
    }

    public partial class Sport
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public CompetitionName Name { get; set; }
    }

    public partial class Navigation
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class Child
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("navigation", NullValueHandling = NullValueHandling.Ignore)]
        public List<Navigation> Navigation { get; set; }

        [JsonProperty("navigationContext", NullValueHandling = NullValueHandling.Ignore)]
        public NavigationContext NavigationContext { get; set; }
    }

    public partial class NavigationContext
    {
        [JsonProperty("competitionId", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompetitionId { get; set; }

        [JsonProperty("showCompetitionLogo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCompetitionLogo { get; set; }
    }

    public partial class NavigationOverrides
    {
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public string Matches { get; set; }

        [JsonProperty("outrights", NullValueHandling = NullValueHandling.Ignore)]
        public string Outrights { get; set; }

        [JsonProperty("specials", NullValueHandling = NullValueHandling.Ignore)]
        public string Specials { get; set; }

        [JsonProperty("teams", NullValueHandling = NullValueHandling.Ignore)]
        public string Teams { get; set; }

        [JsonProperty("standings", NullValueHandling = NullValueHandling.Ignore)]
        public string Standings { get; set; }
    }

    public partial class Tile
    {
        [JsonProperty("marqueeType", NullValueHandling = NullValueHandling.Ignore)]
        public string MarqueeType { get; set; }

        [JsonProperty("sportId", NullValueHandling = NullValueHandling.Ignore)]
        public long? SportId { get; set; }

        [JsonProperty("competitionId", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompetitionId { get; set; }

        [JsonProperty("regionId", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegionId { get; set; }

        [JsonProperty("showOnHomeLobby", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnHomeLobby { get; set; }

        [JsonProperty("showOnSportsLobby", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnSportsLobby { get; set; }

        [JsonProperty("showOnEventPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnEventPage { get; set; }

        [JsonProperty("eventIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> EventIds { get; set; }

        [JsonProperty("eventNameVisibility", NullValueHandling = NullValueHandling.Ignore)]
        public string EventNameVisibility { get; set; }

        [JsonProperty("marketAndOptionNameVisibility", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketAndOptionNameVisibility { get; set; }

        [JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageUrl { get; set; }

        [JsonProperty("badgeAndRibbonVisibilityOption", NullValueHandling = NullValueHandling.Ignore)]
        public string BadgeAndRibbonVisibilityOption { get; set; }

        [JsonProperty("noEventSportIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> NoEventSportIds { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public Link Link { get; set; }

        [JsonProperty("showOnCompetitionPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnCompetitionPage { get; set; }

        [JsonProperty("competitionIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> CompetitionIds { get; set; }

        [JsonProperty("regionIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> RegionIds { get; set; }

        [JsonProperty("regionSportId", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegionSportId { get; set; }

        [JsonProperty("crmPromotionVisibility", NullValueHandling = NullValueHandling.Ignore)]
        public string CrmPromotionVisibility { get; set; }

        [JsonProperty("geoLocationStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string GeoLocationStatus { get; set; }

        [JsonProperty("showOnTeamsPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnTeamsPage { get; set; }

        [JsonProperty("textColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TextColor { get; set; }

        [JsonProperty("hideBuildABetBadge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideBuildABetBadge { get; set; }

        [JsonProperty("leftAlignOddsButton", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LeftAlignOddsButton { get; set; }

        [JsonProperty("trackingDetail", NullValueHandling = NullValueHandling.Ignore)]
        public TrackingDetail TrackingDetail { get; set; }

        [JsonProperty("isPriceBoostMarquee", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPriceBoostMarquee { get; set; }

        [JsonProperty("isAutomatedMarquee", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutomatedMarquee { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        [JsonProperty("popup", NullValueHandling = NullValueHandling.Ignore)]
        public string Popup { get; set; }
    }

    public partial class TrackingDetail
    {
        [JsonProperty("modulePosition", NullValueHandling = NullValueHandling.Ignore)]
        public string ModulePosition { get; set; }

        [JsonProperty("pageLayout", NullValueHandling = NullValueHandling.Ignore)]
        public string PageLayout { get; set; }

        [JsonProperty("moduleCustomName", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleCustomName { get; set; }

        [JsonProperty("sitecoreTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string SitecoreTemplateId { get; set; }

        [JsonProperty("marqueeName", NullValueHandling = NullValueHandling.Ignore)]
        public string MarqueeName { get; set; }

        [JsonProperty("marqueeRecommendationType", NullValueHandling = NullValueHandling.Ignore)]
        public string MarqueeRecommendationType { get; set; }
    }

    public partial class TrackingData
    {
        [JsonProperty("component.recommendationtype", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentRecommendationtype { get; set; }
    }

    public enum ComboPrevention { NoFixtureCombo };

    public enum DisplayType { OverUnder, Regular };

    public enum MarketHelpPath { FootballDoubleChance, FootballMatchResultAndBothTeamsToScore, FootballMatchResultRegularTime };

    public enum NameEnum { AmbasMarcam, ChanceDupla, ResultadoDaPartida, ResultadoEAmbasMarcam, The1ªEquipeAMarcar, TotalDeGolsMaisMenos };

    public enum Grid { E8Vi2Hdwz, Ls8O6Ll2V, Ntyfdsehn, T9R0Doqex, Tabpo1C9N, The6Xg0Qprzl, The7Wijdvvko };

    public enum AttrTypeEnum { Decimal, Integer, String };

    public enum Happening { Goal };

    public enum MarketType { DoubleChance, OverUnder, ThreeWay, XthHappening };

    public enum Period { RegularTime };

    public enum OptionType { Draw, Equals, Max, NotExists, NotToHappen, Over, ToHappen, Under };

    public enum Status { Suspended, Visible };

    public enum Key { DecimalValue, Happening, IntegerValue, MarketType, Period };

    public enum Category { Gridable };

    public partial class ResponseListaDePartida
    {
        public static ResponseListaDePartida FromJson(string json) => JsonConvert.DeserializeObject<ResponseListaDePartida>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ResponseListaDePartida self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ComboPreventionConverter.Singleton,
                DisplayTypeConverter.Singleton,
                MarketHelpPathConverter.Singleton,
                NameEnumConverter.Singleton,
                GridConverter.Singleton,
                AttrTypeEnumConverter.Singleton,
                HappeningConverter.Singleton,
                MarketTypeConverter.Singleton,
                PeriodConverter.Singleton,
                OptionTypeConverter.Singleton,
                StatusConverter.Singleton,
                KeyConverter.Singleton,
                CategoryConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class ComboPreventionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ComboPrevention) || t == typeof(ComboPrevention?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "NoFixtureCombo")
            {
                return ComboPrevention.NoFixtureCombo;
            }
            throw new Exception("Cannot unmarshal type ComboPrevention");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ComboPrevention)untypedValue;
            if (value == ComboPrevention.NoFixtureCombo)
            {
                serializer.Serialize(writer, "NoFixtureCombo");
                return;
            }
            throw new Exception("Cannot marshal type ComboPrevention");
        }

        public static readonly ComboPreventionConverter Singleton = new ComboPreventionConverter();
    }

    internal class DisplayTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DisplayType) || t == typeof(DisplayType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "OverUnder":
                    return DisplayType.OverUnder;
                case "Regular":
                    return DisplayType.Regular;
            }
            throw new Exception("Cannot unmarshal type DisplayType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DisplayType)untypedValue;
            switch (value)
            {
                case DisplayType.OverUnder:
                    serializer.Serialize(writer, "OverUnder");
                    return;
                case DisplayType.Regular:
                    serializer.Serialize(writer, "Regular");
                    return;
            }
            throw new Exception("Cannot marshal type DisplayType");
        }

        public static readonly DisplayTypeConverter Singleton = new DisplayTypeConverter();
    }

    internal class MarketHelpPathConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MarketHelpPath) || t == typeof(MarketHelpPath?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Football/Double Chance":
                    return MarketHelpPath.FootballDoubleChance;
                case "Football/Match Result (Regular Time)":
                    return MarketHelpPath.FootballMatchResultRegularTime;
                case "Football/Match Result and Both Teams to Score":
                    return MarketHelpPath.FootballMatchResultAndBothTeamsToScore;
            }
            throw new Exception("Cannot unmarshal type MarketHelpPath");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MarketHelpPath)untypedValue;
            switch (value)
            {
                case MarketHelpPath.FootballDoubleChance:
                    serializer.Serialize(writer, "Football/Double Chance");
                    return;
                case MarketHelpPath.FootballMatchResultRegularTime:
                    serializer.Serialize(writer, "Football/Match Result (Regular Time)");
                    return;
                case MarketHelpPath.FootballMatchResultAndBothTeamsToScore:
                    serializer.Serialize(writer, "Football/Match Result and Both Teams to Score");
                    return;
            }
            throw new Exception("Cannot marshal type MarketHelpPath");
        }

        public static readonly MarketHelpPathConverter Singleton = new MarketHelpPathConverter();
    }

    internal class NameEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NameEnum) || t == typeof(NameEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1ª equipe a marcar":
                    return NameEnum.The1ªEquipeAMarcar;
                case "Ambas Marcam":
                    return NameEnum.AmbasMarcam;
                case "Chance Dupla":
                    return NameEnum.ChanceDupla;
                case "Resultado da Partida":
                    return NameEnum.ResultadoDaPartida;
                case "Resultado e Ambas Marcam":
                    return NameEnum.ResultadoEAmbasMarcam;
                case "Total de Gols: Mais/Menos":
                    return NameEnum.TotalDeGolsMaisMenos;
            }
            throw new Exception("Cannot unmarshal type NameEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NameEnum)untypedValue;
            switch (value)
            {
                case NameEnum.The1ªEquipeAMarcar:
                    serializer.Serialize(writer, "1ª equipe a marcar");
                    return;
                case NameEnum.AmbasMarcam:
                    serializer.Serialize(writer, "Ambas Marcam");
                    return;
                case NameEnum.ChanceDupla:
                    serializer.Serialize(writer, "Chance Dupla");
                    return;
                case NameEnum.ResultadoDaPartida:
                    serializer.Serialize(writer, "Resultado da Partida");
                    return;
                case NameEnum.ResultadoEAmbasMarcam:
                    serializer.Serialize(writer, "Resultado e Ambas Marcam");
                    return;
                case NameEnum.TotalDeGolsMaisMenos:
                    serializer.Serialize(writer, "Total de Gols: Mais/Menos");
                    return;
            }
            throw new Exception("Cannot marshal type NameEnum");
        }

        public static readonly NameEnumConverter Singleton = new NameEnumConverter();
    }

    internal class GridConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Grid) || t == typeof(Grid?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "6xg0qprzl":
                    return Grid.The6Xg0Qprzl;
                case "7wijdvvko":
                    return Grid.The7Wijdvvko;
                case "e8vi2hdwz":
                    return Grid.E8Vi2Hdwz;
                case "ls8o6ll2v":
                    return Grid.Ls8O6Ll2V;
                case "ntyfdsehn":
                    return Grid.Ntyfdsehn;
                case "t9r0doqex":
                    return Grid.T9R0Doqex;
                case "tabpo1c9n":
                    return Grid.Tabpo1C9N;
            }
            throw new Exception("Cannot unmarshal type Grid");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Grid)untypedValue;
            switch (value)
            {
                case Grid.The6Xg0Qprzl:
                    serializer.Serialize(writer, "6xg0qprzl");
                    return;
                case Grid.The7Wijdvvko:
                    serializer.Serialize(writer, "7wijdvvko");
                    return;
                case Grid.E8Vi2Hdwz:
                    serializer.Serialize(writer, "e8vi2hdwz");
                    return;
                case Grid.Ls8O6Ll2V:
                    serializer.Serialize(writer, "ls8o6ll2v");
                    return;
                case Grid.Ntyfdsehn:
                    serializer.Serialize(writer, "ntyfdsehn");
                    return;
                case Grid.T9R0Doqex:
                    serializer.Serialize(writer, "t9r0doqex");
                    return;
                case Grid.Tabpo1C9N:
                    serializer.Serialize(writer, "tabpo1c9n");
                    return;
            }
            throw new Exception("Cannot marshal type Grid");
        }

        public static readonly GridConverter Singleton = new GridConverter();
    }

    internal class AttrTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AttrTypeEnum) || t == typeof(AttrTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Decimal":
                    return AttrTypeEnum.Decimal;
                case "Integer":
                    return AttrTypeEnum.Integer;
                case "String":
                    return AttrTypeEnum.String;
            }
            throw new Exception("Cannot unmarshal type AttrTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AttrTypeEnum)untypedValue;
            switch (value)
            {
                case AttrTypeEnum.Decimal:
                    serializer.Serialize(writer, "Decimal");
                    return;
                case AttrTypeEnum.Integer:
                    serializer.Serialize(writer, "Integer");
                    return;
                case AttrTypeEnum.String:
                    serializer.Serialize(writer, "String");
                    return;
            }
            throw new Exception("Cannot marshal type AttrTypeEnum");
        }

        public static readonly AttrTypeEnumConverter Singleton = new AttrTypeEnumConverter();
    }

    internal class HappeningConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Happening) || t == typeof(Happening?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Goal")
            {
                return Happening.Goal;
            }
            throw new Exception("Cannot unmarshal type Happening");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Happening)untypedValue;
            if (value == Happening.Goal)
            {
                serializer.Serialize(writer, "Goal");
                return;
            }
            throw new Exception("Cannot marshal type Happening");
        }

        public static readonly HappeningConverter Singleton = new HappeningConverter();
    }

    internal class MarketTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MarketType) || t == typeof(MarketType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DoubleChance":
                    return MarketType.DoubleChance;
                case "OverUnder":
                    return MarketType.OverUnder;
                case "ThreeWay":
                    return MarketType.ThreeWay;
                case "XthHappening":
                    return MarketType.XthHappening;
            }
            throw new Exception("Cannot unmarshal type MarketType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MarketType)untypedValue;
            switch (value)
            {
                case MarketType.DoubleChance:
                    serializer.Serialize(writer, "DoubleChance");
                    return;
                case MarketType.OverUnder:
                    serializer.Serialize(writer, "OverUnder");
                    return;
                case MarketType.ThreeWay:
                    serializer.Serialize(writer, "ThreeWay");
                    return;
                case MarketType.XthHappening:
                    serializer.Serialize(writer, "XthHappening");
                    return;
            }
            throw new Exception("Cannot marshal type MarketType");
        }

        public static readonly MarketTypeConverter Singleton = new MarketTypeConverter();
    }

    internal class PeriodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Period) || t == typeof(Period?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "RegularTime")
            {
                return Period.RegularTime;
            }
            throw new Exception("Cannot unmarshal type Period");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Period)untypedValue;
            if (value == Period.RegularTime)
            {
                serializer.Serialize(writer, "RegularTime");
                return;
            }
            throw new Exception("Cannot marshal type Period");
        }

        public static readonly PeriodConverter Singleton = new PeriodConverter();
    }

    internal class OptionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OptionType) || t == typeof(OptionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Draw":
                    return OptionType.Draw;
                case "Equals":
                    return OptionType.Equals;
                case "Max":
                    return OptionType.Max;
                case "NotExists":
                    return OptionType.NotExists;
                case "NotToHappen":
                    return OptionType.NotToHappen;
                case "Over":
                    return OptionType.Over;
                case "ToHappen":
                    return OptionType.ToHappen;
                case "Under":
                    return OptionType.Under;
            }
            throw new Exception("Cannot unmarshal type OptionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OptionType)untypedValue;
            switch (value)
            {
                case OptionType.Draw:
                    serializer.Serialize(writer, "Draw");
                    return;
                case OptionType.Equals:
                    serializer.Serialize(writer, "Equals");
                    return;
                case OptionType.Max:
                    serializer.Serialize(writer, "Max");
                    return;
                case OptionType.NotExists:
                    serializer.Serialize(writer, "NotExists");
                    return;
                case OptionType.NotToHappen:
                    serializer.Serialize(writer, "NotToHappen");
                    return;
                case OptionType.Over:
                    serializer.Serialize(writer, "Over");
                    return;
                case OptionType.ToHappen:
                    serializer.Serialize(writer, "ToHappen");
                    return;
                case OptionType.Under:
                    serializer.Serialize(writer, "Under");
                    return;
            }
            throw new Exception("Cannot marshal type OptionType");
        }

        public static readonly OptionTypeConverter Singleton = new OptionTypeConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Suspended":
                    return Status.Suspended;
                case "Visible":
                    return Status.Visible;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.Suspended:
                    serializer.Serialize(writer, "Suspended");
                    return;
                case Status.Visible:
                    serializer.Serialize(writer, "Visible");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    internal class KeyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Key) || t == typeof(Key?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DecimalValue":
                    return Key.DecimalValue;
                case "Happening":
                    return Key.Happening;
                case "IntegerValue":
                    return Key.IntegerValue;
                case "MarketType":
                    return Key.MarketType;
                case "Period":
                    return Key.Period;
            }
            throw new Exception("Cannot unmarshal type Key");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Key)untypedValue;
            switch (value)
            {
                case Key.DecimalValue:
                    serializer.Serialize(writer, "DecimalValue");
                    return;
                case Key.Happening:
                    serializer.Serialize(writer, "Happening");
                    return;
                case Key.IntegerValue:
                    serializer.Serialize(writer, "IntegerValue");
                    return;
                case Key.MarketType:
                    serializer.Serialize(writer, "MarketType");
                    return;
                case Key.Period:
                    serializer.Serialize(writer, "Period");
                    return;
            }
            throw new Exception("Cannot marshal type Key");
        }

        public static readonly KeyConverter Singleton = new KeyConverter();
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Gridable")
            {
                return Category.Gridable;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            if (value == Category.Gridable)
            {
                serializer.Serialize(writer, "Gridable");
                return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }
}
