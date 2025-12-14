using System;

namespace DesignPatterns.Models
{
    public class FordMustangFactory: CarFactory
    {
        public override Vehicle Create()
        {
            return new ModelBuilders.CarModelBuilder()
                .SetBrand("Ford")
                .SetModel("Mustang")
                .SetColor("Red")
                .Build();
        }
    
    }
}
