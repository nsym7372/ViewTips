namespace ValidationSample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using ValidationSample.Extentions;

    public partial class Person : IValidatableObject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Devices = new HashSet<Device>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }

        public string Memo { get; set; }

        [AgeOddEven]
        public int? Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //サービスを挿入する場合
            //https://miso-soup3.hateblo.jp/entry/20121030/1351588416

            if (string.IsNullOrEmpty(Memo) == false && Age == null)
            {
                yield return new ValidationResult("メモ書いたら年齢も必要");
            }
        }
    }
}
