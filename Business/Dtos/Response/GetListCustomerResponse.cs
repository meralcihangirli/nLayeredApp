﻿namespace Business.Dtos.Response
{
    public class GetListCustomerResponse
    {
        public string Id { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
