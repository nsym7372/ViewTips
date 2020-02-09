using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidationSample.Extentions
{
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.Property)]
    public class AgeOddEvenAttribute : ValidationAttribute
    {
        //https://www.atmarkit.co.jp/fdotnet/aspnetmvc3/aspnetmvc3_05/aspnetmvc3_05_01.html

        public AgeOddEvenAttribute()
        {
            this.ErrorMessage = "{0}には偶数が必要です";
        }
        // 検証の実処理（値リストに入力値が含まれているかをチェック）
        public override bool IsValid(object value)
        {
            // 入力値が空の場合は検証をスキップ
            if (value == null) { return true; }

            var age = (int)value;
            return age % 2 == 0;
        }
    }
}