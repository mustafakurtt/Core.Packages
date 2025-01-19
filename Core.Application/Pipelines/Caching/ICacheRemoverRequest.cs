using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;

namespace Core.Application.Pipelines.Caching;

public interface ICacheRemoverRequest
{
    string? CacheKey { get; }
    bool BypassCache { get; }
    string? CacheGroupKey { get; }
}