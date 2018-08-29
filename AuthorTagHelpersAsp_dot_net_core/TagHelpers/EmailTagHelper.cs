using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AuthorTagHelpersAsp_dot_net_core.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public const string EmailDomain = "kibrisorder.com";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        { 

            output.TagName = "a"; //Replaces <email> tag with <a> anchor tag
            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            output.Attributes.Add(new TagHelperAttribute("class", "btn btn-danger"));
            output.Content.SetContent(address);
        }
    }
}
