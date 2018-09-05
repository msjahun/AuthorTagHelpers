using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorTagHelpersAsp_dot_net_core.TagHelpers
{
    public class MusInputTagHelper : InputTagHelper
    {
        public MusInputTagHelper(IHtmlGenerator generator):base(generator)
        {
                    
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //tag details
            output.TagName = "input";
            output.TagMode = TagMode.StartTagOnly;

            output.Attributes.SetAttribute("class","form-control");
            output.Attributes.SetAttribute("type","text");
            output.Attributes.SetAttribute("musa","musa");
            base.Process(context, output);
        }
    }
}
