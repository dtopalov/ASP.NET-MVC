namespace MvcEssentialsHw.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class CalculatorFormViewModel
    {
        public CalculatorFormViewModel()
        {
            this.Units = new List<StorageUnit>
                             {
                                 new StorageUnit
                                     {
                                         Name = "Bit",
                                         IntrinsicValue = 1.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Byte",
                                         IntrinsicValue = 8.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Kilobit",
                                         IntrinsicValue = 1000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Kilobyte",
                                         IntrinsicValue = 8000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Megabit",
                                         IntrinsicValue = 1000000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Megabyte",
                                         IntrinsicValue = 8000000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Gigabit",
                                         IntrinsicValue = 1000000000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Gigabyte",
                                         IntrinsicValue = 8000000000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Terabit",
                                         IntrinsicValue = 1000000000000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Terabyte",
                                         IntrinsicValue = 8000000000000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Petabit",
                                         IntrinsicValue = 1000000000000000.0m
                                     },
                                 new StorageUnit
                                     {
                                         Name = "Petabyte",
                                         IntrinsicValue = 8000000000000000.0m
                                     }
                             };
        }
        public int Quantity { get; set; }

        public string Type { get; set; }

        public string Kilo { get; set; }

        public IList Units { get; set; }
    }
}