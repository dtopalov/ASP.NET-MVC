namespace MvcEssentialsHw.Models
{
    using System.ComponentModel.DataAnnotations;

    public class StorageUnit
    {
        public string Name { get; set; }

        public decimal IntrinsicValue { get; set; }

        [DisplayFormat(DataFormatString = "{0:G5}", ApplyFormatInEditMode = true)]
        public decimal RelativeValue { get; set; }
    }
}