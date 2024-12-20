﻿using UwaziTech.Core.Models.response;

namespace UwaziTech.Core.Models.request
{
    public class InsuranceDetails
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string Reference { get; set; } = Guid.NewGuid().ToString("N");

        public static implicit operator InsuranceModel(InsuranceDetails insuranceDetails)
        {
            return new InsuranceModel
            {
                Name = insuranceDetails.Name,
                Address = insuranceDetails.Address,
                Reference = insuranceDetails.Reference,
                PhoneNumber = insuranceDetails.PhoneNumber,
            };
        }
    }
}
