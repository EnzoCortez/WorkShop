using System;

namespace DesignPatterns.Models
{
    public class FordExplorerFactory: CarFactory
    {
        public override Vehicle Create()
        {
            return new ModelBuilders.CarModelBuilder()
                .SetBrand("Ford")
                .SetModel("Explorer")
                .SetColor("Black")
                .SetYear(2024)
                .Build();
        }
    
    }
}
