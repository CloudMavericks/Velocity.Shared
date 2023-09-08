using Velocity.Shared.Enums;

namespace Velocity.Shared.Requests.CustomerVendorDetails;

public class CreateCustomerVendorDetailRequest
{
    public string Name { get; set; }
    public string FullName { get; set; }
    public CustomerVendorType Type { get; set; }
}