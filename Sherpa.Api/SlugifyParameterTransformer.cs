using System.Text.RegularExpressions;

namespace Sherpa;

public partial class SlugifyParameterTransformer : IOutboundParameterTransformer
{
    [GeneratedRegex("([a-z])([A-Z])")]
    private static partial Regex MyRegex();
    
    public string? TransformOutbound(object? value)
    {
        if (value == null) return null; 
        var str = value.ToString();
        return string.IsNullOrEmpty(str) ? null : MyRegex().Replace(str, "$1-$2").ToLower();
    }
}