using Velocity.Shared.Enums;

namespace Velocity.Shared.Responses.CustomerVendorDetails;

public record CustomerVendorResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string FullName { get; init; }
    public CustomerVendorType Type { get; init; }
}