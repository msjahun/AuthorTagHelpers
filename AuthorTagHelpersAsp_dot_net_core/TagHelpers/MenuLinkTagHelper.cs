using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AuthorTagHelpersAsp_dot_net_core.TagHelpers
{
    public class MenuLinkTagHelper : TagHelper
    {
        
            public string Controller { get; set; }
        public string Action { get; set; }
        public string DisplayName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "li";
            var content = $"<a href=\"/{Controller}/{Action }\"><i class=\"fa fa-circle-o\"></i> {DisplayName}</a>";
            output.Content.SetHtmlContent(content);
        }
    }
}
