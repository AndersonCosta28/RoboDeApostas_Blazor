namespace RoboDeApostas.Models.CasasDeAposta.SportsbetioAPI.ListaDePartida;

using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
public partial class ResponseListaDePartida
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Data Data { get; set; }
}

public partial class Data
{
    [JsonProperty("sportsbetNewGraphql", NullValueHandling = NullValueHandling.Ignore)]
    public SportsbetNewGraphql SportsbetNewGraphql { get; set; }
}

public partial class SportsbetNewGraphql
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("getTournamentById", NullValueHandling = NullValueHandling.Ignore)]
    public GetTournamentById GetTournamentById { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }
}

public partial class GetTournamentById
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
    public Event[] Events { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public GetTournamentByIdTypename? Typename { get; set; }
}

public partial class Event
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }

    [JsonProperty("asian", NullValueHandling = NullValueHandling.Ignore)]
    public Asian Asian { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? Type { get; set; }

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? Status { get; set; }

    [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
    public long? StartTime { get; set; }

    [JsonProperty("market_count", NullValueHandling = NullValueHandling.Ignore)]
    public long? MarketCount { get; set; }

    [JsonProperty("live_odds", NullValueHandling = NullValueHandling.Ignore)]
    public bool? LiveOdds { get; set; }

    [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
    public string Slug { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("enName", NullValueHandling = NullValueHandling.Ignore)]
    public string EnName { get; set; }

    [JsonProperty("maxBetAvailable", NullValueHandling = NullValueHandling.Ignore)]
    public bool? MaxBetAvailable { get; set; }

    [JsonProperty("videoStream", NullValueHandling = NullValueHandling.Ignore)]
    public VideoStream VideoStream { get; set; }

    [JsonProperty("sport", NullValueHandling = NullValueHandling.Ignore)]
    public League Sport { get; set; }

    [JsonProperty("league", NullValueHandling = NullValueHandling.Ignore)]
    public League League { get; set; }

    [JsonProperty("tournament", NullValueHandling = NullValueHandling.Ignore)]
    public League Tournament { get; set; }

    [JsonProperty("competitors", NullValueHandling = NullValueHandling.Ignore)]
    public Competitor[] Competitors { get; set; }

    [JsonProperty("information", NullValueHandling = NullValueHandling.Ignore)]
    public Information Information { get; set; }

    [JsonProperty("isSportcastFixtureActive", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSportcastFixtureActive { get; set; }

    [JsonProperty("sportcastFixtureId")]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? SportcastFixtureId { get; set; }
}

public partial class Asian
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }

    [JsonProperty("ftMatchWinner", NullValueHandling = NullValueHandling.Ignore)]
    public Ft[] FtMatchWinner { get; set; }

    [JsonProperty("ftTotal", NullValueHandling = NullValueHandling.Ignore)]
    public Ft[] FtTotal { get; set; }

    [JsonProperty("ftHandicap", NullValueHandling = NullValueHandling.Ignore)]
    public Ft[] FtHandicap { get; set; }
}

public partial class Ft
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public FtHandicapTypename? Typename { get; set; }

    [JsonProperty("enName", NullValueHandling = NullValueHandling.Ignore)]
    public EnNameEnum? EnName { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public EnNameEnum? Name { get; set; }

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? Status { get; set; }

    [JsonProperty("selections", NullValueHandling = NullValueHandling.Ignore)]
    public Selection[] Selections { get; set; }

    [JsonProperty("market_type", NullValueHandling = NullValueHandling.Ignore)]
    public MarketType MarketType { get; set; }
}

public partial class MarketType
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public MarketTypeTypename? Typename { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public Description? Name { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public Description? Description { get; set; }

    [JsonProperty("translation_key", NullValueHandling = NullValueHandling.Ignore)]
    public Description? TranslationKey { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? Type { get; set; }

    [JsonProperty("settings")]
    public object Settings { get; set; }
}

public partial class Selection
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public SelectionTypename? Typename { get; set; }

    [JsonProperty("enName", NullValueHandling = NullValueHandling.Ignore)]
    public string EnName { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; }

    [JsonProperty("odds", NullValueHandling = NullValueHandling.Ignore)]
    public double? Odds { get; set; }

    [JsonProperty("providerProductId")]
    public object ProviderProductId { get; set; }
}

public partial class Competitor
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("betradarId", NullValueHandling = NullValueHandling.Ignore)]
    public string BetradarId { get; set; }
}

public partial class Information
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }

    [JsonProperty("match_time")]
    public object MatchTime { get; set; }

    [JsonProperty("provider_prefix", NullValueHandling = NullValueHandling.Ignore)]
    public string ProviderPrefix { get; set; }

    [JsonProperty("period_scores", NullValueHandling = NullValueHandling.Ignore)]
    public object[] PeriodScores { get; set; }

    [JsonProperty("match_status_translations", NullValueHandling = NullValueHandling.Ignore)]
    public string MatchStatusTranslations { get; set; }

    [JsonProperty("home_score")]
    public object HomeScore { get; set; }

    [JsonProperty("away_score")]
    public object AwayScore { get; set; }

    [JsonProperty("home_gamescore")]
    public object HomeGamescore { get; set; }

    [JsonProperty("away_gamescore")]
    public object AwayGamescore { get; set; }

    [JsonProperty("provider_product_id", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? ProviderProductId { get; set; }
}

public partial class League
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
    public string? Slug { get; set; }

    [JsonProperty("betBoostMultiplier", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? BetBoostMultiplier { get; set; }

    [JsonProperty("iconCode", NullValueHandling = NullValueHandling.Ignore)]
    public string IconCode { get; set; }
}

public partial class VideoStream
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }

    [JsonProperty("streamAvailable", NullValueHandling = NullValueHandling.Ignore)]
    public bool? StreamAvailable { get; set; }
}

public enum EnNameEnum { AsianHandicap00, AsianTotal, The1X2 };

public enum Description { Handicap, The1X2, Total };

public enum MarketTypeTypename { SportsbetNewGraphqlMarketType };

public enum SelectionTypename { SportsbetNewGraphqlMarketSelection };

public enum FtHandicapTypename { SportsbetNewGraphqlMarket };

public enum GetTournamentByIdTypename { SportsbetNewGraphqlLeague, SportsbetNewGraphqlSport, SportsbetNewGraphqlTournament };

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
                GetTournamentByIdTypenameConverter.Singleton,
                FtHandicapTypenameConverter.Singleton,
                EnNameEnumConverter.Singleton,
                MarketTypeTypenameConverter.Singleton,
                DescriptionConverter.Singleton,
                SelectionTypenameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
}

internal class GetTournamentByIdTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(GetTournamentByIdTypename) || t == typeof(GetTournamentByIdTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "SportsbetNewGraphqlLeague":
                return GetTournamentByIdTypename.SportsbetNewGraphqlLeague;
            case "SportsbetNewGraphqlSport":
                return GetTournamentByIdTypename.SportsbetNewGraphqlSport;
            case "SportsbetNewGraphqlTournament":
                return GetTournamentByIdTypename.SportsbetNewGraphqlTournament;
        }
        throw new Exception("Cannot unmarshal type GetTournamentByIdTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (GetTournamentByIdTypename)untypedValue;
        switch (value)
        {
            case GetTournamentByIdTypename.SportsbetNewGraphqlLeague:
                serializer.Serialize(writer, "SportsbetNewGraphqlLeague");
                return;
            case GetTournamentByIdTypename.SportsbetNewGraphqlSport:
                serializer.Serialize(writer, "SportsbetNewGraphqlSport");
                return;
            case GetTournamentByIdTypename.SportsbetNewGraphqlTournament:
                serializer.Serialize(writer, "SportsbetNewGraphqlTournament");
                return;
        }
        throw new Exception("Cannot marshal type GetTournamentByIdTypename");
    }

    public static readonly GetTournamentByIdTypenameConverter Singleton = new GetTournamentByIdTypenameConverter();
}

internal class FtHandicapTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(FtHandicapTypename) || t == typeof(FtHandicapTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "SportsbetNewGraphqlMarket")
        {
            return FtHandicapTypename.SportsbetNewGraphqlMarket;
        }
        throw new Exception("Cannot unmarshal type FtHandicapTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (FtHandicapTypename)untypedValue;
        if (value == FtHandicapTypename.SportsbetNewGraphqlMarket)
        {
            serializer.Serialize(writer, "SportsbetNewGraphqlMarket");
            return;
        }
        throw new Exception("Cannot marshal type FtHandicapTypename");
    }

    public static readonly FtHandicapTypenameConverter Singleton = new FtHandicapTypenameConverter();
}

internal class EnNameEnumConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(EnNameEnum) || t == typeof(EnNameEnum?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "1x2":
                return EnNameEnum.The1X2;
            case "Asian Handicap 0-0":
                return EnNameEnum.AsianHandicap00;
            case "Asian Total":
                return EnNameEnum.AsianTotal;
        }
        throw new Exception("Cannot unmarshal type EnNameEnum");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (EnNameEnum)untypedValue;
        switch (value)
        {
            case EnNameEnum.The1X2:
                serializer.Serialize(writer, "1x2");
                return;
            case EnNameEnum.AsianHandicap00:
                serializer.Serialize(writer, "Asian Handicap 0-0");
                return;
            case EnNameEnum.AsianTotal:
                serializer.Serialize(writer, "Asian Total");
                return;
        }
        throw new Exception("Cannot marshal type EnNameEnum");
    }

    public static readonly EnNameEnumConverter Singleton = new EnNameEnumConverter();
}

internal class MarketTypeTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(MarketTypeTypename) || t == typeof(MarketTypeTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "SportsbetNewGraphqlMarketType")
        {
            return MarketTypeTypename.SportsbetNewGraphqlMarketType;
        }
        throw new Exception("Cannot unmarshal type MarketTypeTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (MarketTypeTypename)untypedValue;
        if (value == MarketTypeTypename.SportsbetNewGraphqlMarketType)
        {
            serializer.Serialize(writer, "SportsbetNewGraphqlMarketType");
            return;
        }
        throw new Exception("Cannot marshal type MarketTypeTypename");
    }

    public static readonly MarketTypeTypenameConverter Singleton = new MarketTypeTypenameConverter();
}

internal class DescriptionConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "1x2":
                return Description.The1X2;
            case "Handicap":
                return Description.Handicap;
            case "Total":
                return Description.Total;
        }
        throw new Exception("Cannot unmarshal type Description");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (Description)untypedValue;
        switch (value)
        {
            case Description.The1X2:
                serializer.Serialize(writer, "1x2");
                return;
            case Description.Handicap:
                serializer.Serialize(writer, "Handicap");
                return;
            case Description.Total:
                serializer.Serialize(writer, "Total");
                return;
        }
        throw new Exception("Cannot marshal type Description");
    }

    public static readonly DescriptionConverter Singleton = new DescriptionConverter();
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

internal class SelectionTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(SelectionTypename) || t == typeof(SelectionTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "SportsbetNewGraphqlMarketSelection")
        {
            return SelectionTypename.SportsbetNewGraphqlMarketSelection;
        }
        throw new Exception("Cannot unmarshal type SelectionTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (SelectionTypename)untypedValue;
        if (value == SelectionTypename.SportsbetNewGraphqlMarketSelection)
        {
            serializer.Serialize(writer, "SportsbetNewGraphqlMarketSelection");
            return;
        }
        throw new Exception("Cannot marshal type SelectionTypename");
    }

    public static readonly SelectionTypenameConverter Singleton = new SelectionTypenameConverter();
}