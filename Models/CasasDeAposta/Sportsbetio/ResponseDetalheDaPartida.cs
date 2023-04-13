using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace RoboDeApostas.Models.CasasDeAposta.SportsbetioAPI.DetalheDaPartida;

public partial class ResponseDetalheDaPartida
{
    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
    public Data Data { get; set; }

    public static ResponseDetalheDaPartida FromJson(string json) => JsonConvert.DeserializeObject<ResponseDetalheDaPartida>(json, Converter.Settings);

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

    [JsonProperty("getEventById", NullValueHandling = NullValueHandling.Ignore)]
    public GetEventById GetEventById { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }
}

public partial class GetEventById
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    //[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(ParseStringConverter))]
    //public long? Type { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("sport", NullValueHandling = NullValueHandling.Ignore)]
    public Sport Sport { get; set; }

    [JsonProperty("tournament", NullValueHandling = NullValueHandling.Ignore)]
    public Sport Tournament { get; set; }

    [JsonProperty("competitors", NullValueHandling = NullValueHandling.Ignore)]
    public Sport[] Competitors { get; set; }

    [JsonProperty("mainMarkets", NullValueHandling = NullValueHandling.Ignore)]
    public MainMarket[] MainMarkets { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }
}

public partial class Sport
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public string Typename { get; set; }
}

public partial class MainMarket
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public MainMarketTypename? Typename { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("englishName", NullValueHandling = NullValueHandling.Ignore)]
    public string EnglishName { get; set; }

    [JsonProperty("enName", NullValueHandling = NullValueHandling.Ignore)]
    public string EnName { get; set; }

    //[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(ParseStringConverter))]
    //public long? Status { get; set; }

    [JsonProperty("selections", NullValueHandling = NullValueHandling.Ignore)]
    public Selection[] Selections { get; set; }

    [JsonProperty("market_type", NullValueHandling = NullValueHandling.Ignore)]
    public MarketType MarketType { get; set; }

    [JsonProperty("specifiers", NullValueHandling = NullValueHandling.Ignore)]
    public Specifiers Specifiers { get; set; }
}

public partial class MarketType
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public MarketTypeTypename? Typename { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("translation_key", NullValueHandling = NullValueHandling.Ignore)]
    public string TranslationKey { get; set; }

    //[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(ParseStringConverter))]
    //public long? Type { get; set; }

    [JsonProperty("settings")]
    public object Settings { get; set; }
}

public partial class Selection
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("__typename", NullValueHandling = NullValueHandling.Ignore)]
    public SelectionTypename? Typename { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("enName", NullValueHandling = NullValueHandling.Ignore)]
    public string EnName { get; set; }

    [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; }

    [JsonProperty("odds", NullValueHandling = NullValueHandling.Ignore)]
    public double? Odds { get; set; }

    [JsonProperty("probabilities")]
    public object Probabilities { get; set; }

    [JsonProperty("providerProductId")]
    public object ProviderProductId { get; set; }
}

public partial class Specifiers
{
    //[JsonProperty("hcp", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(ParseStringConverter))]
    //public long? Hcp { get; set; }

    //[JsonProperty("hcp_for_the_rest", NullValueHandling = NullValueHandling.Ignore)]
    //[JsonConverter(typeof(ParseStringConverter))]
    //public long? HcpForTheRest { get; set; }

    [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
    public string Total { get; set; }
}

public enum MarketTypeTypename { SportsbetNewGraphqlMarketType };

public enum SelectionTypename { SportsbetNewGraphqlMarketSelection };

public enum MainMarketTypename { SportsbetNewGraphqlMarket };


public static class Serialize
{
    public static string ToJson(this ResponseDetalheDaPartida self) => JsonConvert.SerializeObject(self, Converter.Settings);
}

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
            {
                MainMarketTypenameConverter.Singleton,
                MarketTypeTypenameConverter.Singleton,
                SelectionTypenameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
}

internal class MainMarketTypenameConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(MainMarketTypename) || t == typeof(MainMarketTypename?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "SportsbetNewGraphqlMarket")
        {
            return MainMarketTypename.SportsbetNewGraphqlMarket;
        }
        throw new Exception("Cannot unmarshal type MainMarketTypename");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (MainMarketTypename)untypedValue;
        if (value == MainMarketTypename.SportsbetNewGraphqlMarket)
        {
            serializer.Serialize(writer, "SportsbetNewGraphqlMarket");
            return;
        }
        throw new Exception("Cannot marshal type MainMarketTypename");
    }

    public static readonly MainMarketTypenameConverter Singleton = new MainMarketTypenameConverter();
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