using System.Diagnostics;

namespace AuthServiceIn6BM.Api.Models;

public class ErrorResponse
{
    public int StatusCode { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Detial { get; set; } = string.Empty;
    public string? ErrorCode { get; set; }
    public string TraceId { get; set; } = Activity.Current?.Id ?? string.Empty;
    public DateTime Timestamps { get; set; } = DateTime.UtcNow;
}